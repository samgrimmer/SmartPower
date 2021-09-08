namespace SmartPower.Common
{
    public static class Constant
    {
        public const string CurrentUser = "samg";
        public const int ItemCount = 10;
        public const string DateStringFormat = "dd/MM/yyyy h:mmtt";

        public static class BulkReversal
        {
            public const string ExportStringHeaders = "Results,Status,NewSpInvNumber,OrgSpinvNumber";

            public class CsvExport
            {
                public class File
                {
                    public const string FileName = "bulk-reversals.csv";
                    public const string FileContentType = "text/csv";
                }
            }

            public static class Message
            {
                public const string DirtyPendingReversals = "Some invoices are not suited to reverse; either a SPIN that does not exist or SPIN has already been reversed";
                public const string DirtyPendingReversalsContinue = "Do you want to continue and only process those items in status 'Found'";
                public const string BatchCreatedAction = "Action Completed: Reversals have been created and put in Batch";
            }
        }

        public static class Invoice
        {
            public static class Message
            {
                public const string NotFound = "Invoice was not found";
            }
        }
    }
}
