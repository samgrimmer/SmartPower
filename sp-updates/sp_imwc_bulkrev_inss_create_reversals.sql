USE [Master_DB_DEMO]
GO
/****** Object:  StoredProcedure [dbo].[sp_imwc_bulkrev_inss_create_reversals]    Script Date: 3/09/2021 2:34:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		David Gibb
-- Create date: 13/03/2021
-- Description:	Bulk reversals - Create Reversals
-- =============================================
ALTER PROCEDURE [dbo].[sp_imwc_bulkrev_inss_create_reversals]
	@UserName NVARCHAR(200)
AS
BEGIN

	SET NOCOUNT ON;

	DECLARE @Org_SPIN AS INT;
	DECLARE @Status AS NVARCHAR(100);
	DECLARE @New_SPIN AS INT;
	DECLARE @New_BatchNo AS INT;
	DECLARE @SPID AS INT;
	DECLARE @Can_Proceed AS BIT;

	EXECUTE @New_BatchNo = sp_imwc_bulkrev_inss_create_new_reversals_batch;

	PRINT 'BatchNo';
	PRINT @New_BatchNo;

	DECLARE rev_cursor CURSOR FOR 
			SELECT Org_SPInvNumber
            From tReversals_Bulk_List 
            WHERE tReversals_Bulk_List.Rev_Status = 'Found Invoice' AND UserName = @UserName

	OPEN rev_cursor  
	FETCH NEXT FROM rev_cursor INTO @Org_SPIN  

	WHILE @@FETCH_STATUS = 0  
	BEGIN  
		  --Loop
			--Test original invoice exists
			IF EXISTS (SELECT SPInvNumber From tInvoices WHERE SPInvNumber = @Org_SPIN) 
				BEGIN
					SET @Can_Proceed = 1; 
				END
			ELSE
				BEGIN
					SET @Can_Proceed = 0;
					SET @Status = 'Invoice does not exist.';
				END
			
			--Test original invoice is not already a reversal
			IF EXISTS (SELECT ReadTypeCode From tInvoices WHERE SPInvNumber = @Org_SPIN and (ReadTypeCode = 'ORV' or ReadTypeCode = 'RV')) 
				BEGIN
					SET @Can_Proceed = 0; 
					SET @Status = 'Invoice is already a reversal.';
				END
			ELSE
				BEGIN
					SET @Can_Proceed = 1;
				END

			--Create Reversal
			If @Can_Proceed = 1
				begin
					EXECUTE sp_imwc_bulkrev_inss_create_ind_reversal @UserName, @Org_SPIN, @New_BatchNo;
					
				end
			ELSE
				begin
					UPDATE tReversals_Bulk_List SET Rev_Results = @Status 
						WHERE tReversals_Bulk_List.Org_SPInvNumber = @Org_SPIN AND UserName = @UserName;
				end

		  FETCH NEXT FROM rev_cursor INTO @Org_SPIN 
	END 

	CLOSE rev_cursor  
	DEALLOCATE rev_cursor 

	RETURN @New_BatchNo

END
