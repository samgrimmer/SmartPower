USE [Master_DB_DEMO]
GO
/****** Object:  StoredProcedure [dbo].[sp_imwc_bulkrev_sels_test_supplied_invoices]    Script Date: 3/09/2021 2:33:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		David Gibb
-- Create date: 13/03/2021
-- Description:	Bulk reversals - Test if supplied invoices are suitable to continue
-- =============================================
ALTER PROCEDURE [dbo].[sp_imwc_bulkrev_sels_test_supplied_invoices]
	@UserName NVARCHAR(20)
AS
BEGIN

	SET NOCOUNT ON;

	DECLARE @Test_Status_Pass AS BIT;
	
	IF EXISTS (SELECT tReversals_Bulk_List.Rev_Status From tReversals_Bulk_List WHERE tReversals_Bulk_List.Rev_Status <> 'Found Invoice' AND UserName = @UserName) 
		BEGIN
			SET @Test_Status_Pass = 1;
		END
	ELSE
		BEGIN
			SET @Test_Status_Pass = 0;
		END

	RETURN @Test_Status_Pass;
  

END
