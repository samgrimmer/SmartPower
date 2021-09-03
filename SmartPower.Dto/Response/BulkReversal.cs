namespace SmartPower.Dto.Response
{
    public class BulkReversal
    {
        public int RevId { get; set; }
        public int? OrgSpinvNumber { get; set; }
        public string RevStatus { get; set; }
        public int? NewSpInvNumber { get; set; }
        public string RevResults { get; set; }
        public string UserName { get; set; }
    }
}
