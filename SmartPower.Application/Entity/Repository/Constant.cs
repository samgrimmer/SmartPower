namespace SmartPower.Application.Entity.Repository
{
    public static class Constant
    {
        public static class StoredProcedures
        {
            public static class BulkReversal
            {
                public const string ClearReversals = "sp_imwc_bulkrev_del_clear_list_current_user";
                public const string UpdateReversalStatus = "sp_imwc_bulkrev_upts_update_status_current_user";
                public const string TestSuppliedInvoices = "sp_imwc_bulkrev_sels_test_supplied_invoices";
                public const string CreateReversal = "sp_imwc_bulkrev_inss_create_ind_reversal";
                public const string CreateReversals = "sp_imwc_bulkrev_inss_create_reversals";
                public const string CreateReversalsBatch = "sp_imwc_bulkrev_inss_create_new_reversals_batch";
            }
        }
    }
}
