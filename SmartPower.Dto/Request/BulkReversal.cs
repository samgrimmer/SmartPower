using System.ComponentModel.DataAnnotations;

namespace SmartPower.Dto.Request
{
    public class BulkReversal
    {
        public string UserName { get; set; }

        [Required(ErrorMessage = "OrgSpin is required")]
        public int OrgSpin { get; set; }

        public int BatchNumber { get; set; }
    }
}
