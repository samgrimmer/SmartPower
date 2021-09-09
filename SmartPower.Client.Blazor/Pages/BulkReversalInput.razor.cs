using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Components;

namespace SmartPower.Client.Blazor.Pages
{
    partial class BulkReversalInput
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }

        [Inject]
        public IMapper Mapper { get; set; }

        [Inject]
        public Application.Entity.Repository.IBulkReversal BulkReversalRepository { get; set; }

        public BulkReversalInput()
        {
            BulkReversal = new Dto.Request.BulkReversal { BatchNumber = 2, UserName = Common.Constant.CurrentUser };
        }

        public Dto.Request.BulkReversal BulkReversal { get; set; }

        private async Task HandleValidSubmit()
        {
            await BulkReversalRepository.CreateReversalListItem(Common.Constant.CurrentUser, BulkReversal.OrgSpin);

            await BulkReversalRepository.UpdateReversalStatus(Common.Constant.CurrentUser);

            NavigationManager.NavigateTo("bulk-reversals");
        }
    }
}
