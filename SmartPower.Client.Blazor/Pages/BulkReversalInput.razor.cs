using System.Threading.Tasks;

namespace SmartPower.Client.Blazor.Pages
{
    partial class BulkReversalInput
    {
        public BulkReversalInput()
        {
            BulkReversal = new Dto.Request.BulkReversal { BatchNumber = 2, UserName = Common.Constant.CurrentUser };
        }

        public string OrgSpinText { get; set; }

        public Dto.Request.BulkReversal BulkReversal { get; set; }

        private async Task HandleValidSubmit()
        {
            await BulkReversalService.CreateReversal(Common.Constant.CurrentUser, BulkReversal.OrgSpin);

            NavigationManager.NavigateTo("bulk-reversals");
        }
    }
}
