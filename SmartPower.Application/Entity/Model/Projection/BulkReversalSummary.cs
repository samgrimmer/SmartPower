namespace SmartPower.Application.Entity.Model.Projection
{
    public class BulkReversalSummary
    {
        public int? NewSpInvNumber { get; set; }
        public int? OrgSpinvNumber { get; set; }
        public string RevStatus { get; set; }
        public string RevResults { get; set; }
    }
}
