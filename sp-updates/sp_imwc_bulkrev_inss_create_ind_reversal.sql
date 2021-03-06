USE [Master_DB_DEMO]
GO
/****** Object:  StoredProcedure [dbo].[sp_imwc_bulkrev_inss_create_ind_reversal]    Script Date: 3/09/2021 2:32:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		David Gibb
-- Create date: 14/03/2021
-- Description:	Bulk Reversals - Create individual reversal
-- =============================================
ALTER PROCEDURE [dbo].[sp_imwc_bulkrev_inss_create_ind_reversal] 
	@UserName NVARCHAR(200),
	@Org_SPIN INT,
	@New_BatchNo INT
AS
BEGIN
	
	SET NOCOUNT ON;
	DECLARE @OB AS MONEY;
	DECLARE @New_SPIN AS INT;

	SELECT @OB = InvOpeningBalance FROM tInvoices WHERE SPInvNumber = @Org_SPIN;

    --Create header
    If @OB = 0 
		begin
            INSERT INTO tInvoices (  SPInvNumberOrig, BatchNo, SiteNo, RetailerCode, StatementNumber, Parent_Acc_Num, AccountNo, ReadTypeCode, InvDate, InvEnteredDate, InvNumber, InvOpeningBalance, 
                            InvStartDate, InvEndDate, InvDueDate, InvNoOfDays, CostsUsage, CostsFees, CostsNetwork, SpotRate, Losses, InvSubTotal, InvTotal, InvGST, InvDiscount, 
                            InvAmount, InvAmountToPay, InvAmountSOA, CreditInv, NtwkVariable, NtwkFixed, FixedKVA, NoOfStaff, SqMetresOccupied, SqMetresTotal, ACAdjFactor, Unit_Total, 
                            OpeningBalanceExGST, OpeningBalanceGST, InvDiscountExGST, InvDiscountGST, InvAmountExGST, InvAmountGST, InvAmountToPayExGST, InvAmountToPayGST, EDI_ID)
				SELECT  tInvoices.SPInvNumberOrig, @New_BatchNo As BatchNo, tInvoices.SiteNo, tInvoices.RetailerCode, tInvoices.StatementNumber, tInvoices.Parent_Acc_Num, tInvoices.AccountNo, 
							'RV' as Read_Type, tInvoices.InvDate AS U_InvDate, GetDate() AS U_InvEnteredDate, 'Reversal_' + tInvoices.InvNumber AS U_InvNumber, 0 AS U_InvOpeningBalance, 
                            tInvoices.InvStartDate, tInvoices.InvEndDate, tInvoices.InvDueDate AS U_DueDate, [InvNoOfDays]*-1 As InvNoDays, 0 AS U_CostsUsage, 0 AS U_CostsFees, 0 AS U_CostsNetwork, 
							tInvoices.SpotRate, tInvoices.Losses, [InvSubTotal]*-1 AS U_InvSubTotal, [InvTotal]*-1 AS U_InvTotal, [InvGST]*-1 AS U_InvGST, [InvDiscount]*-1 AS U_InvDiscount, 
							[InvAmount]*-1 AS U_InvAmount, [InvAmountToPay]*-1 AS U_InvAmountToPay,[InvAmountSOA]*-1 AS U_InvAmountSOA, 
                            0 AS U_CreditInv, tInvoices.NtwkVariable, tInvoices.NtwkFixed, tInvoices.FixedKVA, tInvoices.NoOfStaff, tInvoices.SqMetresOccupied, tInvoices.SqMetresTotal, 
							tInvoices.ACAdjFactor, [Unit_Total] *-1 as U_Unit_Total, 0 AS U_OpeningBalanceExGST, 0 AS U_OpeningBalanceGST, [InvDiscountExGST]*-1 AS U_InvDiscountExGST, 
							[InvDiscountGST]*-1 AS U_InvDiscountGST, [InvAmountExGST]*-1 AS U_InvAmountExGST, [InvAmountGST]*-1 AS U_InvAmountGST, [InvAmountToPayExGST]*-1 AS U_InvAmountToPayExGST, 
							[InvAmountToPayGST]*-1 AS U_InvAmountToPayGST , EDI_ID 
				FROM tInvoices 
                WHERE tInvoices.SPInvNumber = @Org_SPIN;

				Set @New_SPIN = SCOPE_IDENTITY();
        end
	Else
		begin
            INSERT INTO tInvoices (  SPInvNumberOrig, BatchNo, SiteNo, RetailerCode, StatementNumber, Parent_Acc_Num, AccountNo, ReadTypeCode, InvDate, InvEnteredDate, InvNumber, InvOpeningBalance, 
                            InvStartDate, InvEndDate, InvDueDate, InvNoOfDays, CostsUsage, CostsFees, CostsNetwork, SpotRate, Losses, InvSubTotal, InvTotal, InvGST, InvDiscount, 
                            InvAmount, InvAmountToPay, InvAmountSOA, CreditInv, NtwkVariable, NtwkFixed, FixedKVA, NoOfStaff, SqMetresOccupied, SqMetresTotal, ACAdjFactor, Unit_Total, 
                            OpeningBalanceExGST, OpeningBalanceGST, InvDiscountExGST, InvDiscountGST, InvAmountExGST, InvAmountGST, InvAmountToPayExGST, InvAmountToPayGST, EDI_ID )
				SELECT  tInvoices.SPInvNumberOrig, @New_BatchNo As BatchNo, tInvoices.SiteNo, tInvoices.RetailerCode, tInvoices.StatementNumber, tInvoices.Parent_Acc_Num, tInvoices.AccountNo, 
							'RV' as Read_Type, tInvoices.InvDate AS U_InvDate, GetDate() AS U_InvEnteredDate, 'Reversal_' + tInvoices.InvNumber AS U_InvNumber, [InvOpeningBalance] AS U_InvOpeningBalance, 
                            tInvoices.InvStartDate, tInvoices.InvEndDate, tInvoices.InvDueDate, [InvNoOfDays]*-1 As InvNoDays, 0 AS U_CostsUsage, 0 AS U_CostsFees, 0 AS U_CostsNetwork, 
							tInvoices.SpotRate, tInvoices.Losses, [InvSubTotal]*-1 AS U_InvSubTotal, [InvTotal]*-1 AS U_InvTotal, [InvGST]*-1 AS U_InvGST, [InvDiscount]*-1 AS U_InvDiscount,
							[InvAmount]*-1 AS U_InvAmount, [InvAmount]*-1 AS U_InvAmountToPay, [InvAmountSOA]*-1 AS U_InvAmountSOA, 
                            0 AS U_CreditInv, tInvoices.NtwkVariable, tInvoices.NtwkFixed, tInvoices.FixedKVA, tInvoices.NoOfStaff, tInvoices.SqMetresOccupied, tInvoices.SqMetresTotal, 
							tInvoices.ACAdjFactor, [Unit_Total] *-1 as U_Unit_Total, 0 AS U_OpeningBalanceExGST, 0 AS U_OpeningBalanceGST, [InvDiscountExGST]*-1 AS U_InvDiscountExGST, 
							[InvDiscountGST]*-1 AS U_InvDiscountGST, [InvAmountExGST]*-1 AS U_InvAmountExGST, [InvAmountGST]*-1 AS U_InvAmountGST, [InvAmountExGST]*-1 AS U_InvAmountToPayExGST, 
							[InvAmountGST]*-1 AS U_InvAmountToPayGST , EDI_ID 
				FROM tInvoices 
				WHERE tInvoices.SPInvNumber = @Org_SPIN;

				Set @New_SPIN = SCOPE_IDENTITY();
                    
         end
            
    --Create Lines
     INSERT INTO tInvoiceLines ( SPInvNumber, SPInvNumberOrig, Description, PrevReading, CurrReading, UnitsUsed, UnitsUsedCheck, UnitCost, Multiplier, InvLineTotal, ProductID, 
				UnitType, RateID, PriceType, LinesReference, Metered, TariffID, utility_Code, Cost_Centre_ID,PPD ,GST, UnitMultiplier, InvLineTotal_Incl_GST, InvLineTotal_GST)
		SELECT  @New_SPIN AS U_SPInvNumber, tInvoiceLines.SPInvNumberOrig, tInvoiceLines.Description, tInvoiceLines.PrevReading, tInvoiceLines.CurrReading, [UnitsUsed]*-1 AS U_UnitsUsed, 
				tInvoiceLines.UnitsUsedCheck, tInvoiceLines.UnitCost, tInvoiceLines.Multiplier, [InvLineTotal]*-1 AS U_InvLineTotal, tInvoiceLines.ProductID, tInvoiceLines.UnitType, 
				tInvoiceLines.RateID, tInvoiceLines.PriceType, tInvoiceLines.LinesReference, tInvoiceLines.Metered, tInvoiceLines.TariffID, tInvoiceLines.utility_Code, tInvoiceLines.Cost_Centre_ID,
				tInvoiceLines.PPD, tInvoiceLines.GST, tInvoiceLines.UnitMultiplier, (ISNULL(tInvoiceLines.InvLineTotal_Incl_GST,0) * -1) AS Line_Incl_GST, 
				(ISNULL(tInvoiceLines.InvLineTotal_GST,0) *-1) AS Line_GST  
		FROM tInvoiceLines 
		WHERE tInvoiceLines.SPInvNumber = @Org_SPIN;
 
	

    --Adjust Originl invoice with flag
    UPDATE tInvoices SET tInvoices.InvNumber = 'Org_Rev_' + [InvNumber] 
		WHERE tInvoices.SPInvNumber = @Org_SPIN AND InvNumber NOT LIKE 'Org_Rev_%'; 
   
	UPDATE tInvoices SET tInvoices.ReadTypeCode = 'ORV' 
		WHERE tInvoices.SPInvNumber = @Org_SPIN;

	--Update 
	UPDATE tReversals_Bulk_List SET Rev_Results = 'Reversal Created' , New_SpInvNumber = @New_SPIN 
			WHERE tReversals_Bulk_List.Org_SPInvNumber = @Org_SPIN AND UserName = @UserName;

	RETURN @New_SPIN;
    
END