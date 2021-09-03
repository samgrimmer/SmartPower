using System.Collections.Generic;
using System.Threading.Tasks;
using SmartPower.Common;

namespace SmartPower.Client.Blazor.Pages
{
    partial class BulkReversals
    {
        public List<Dto.Response.BulkReversal> BulkReversalList { get; set; }

        public bool DirtyPendingReversals { get; set; }

        public string BatchProcessedMessage { get; set; }

        protected override async Task OnInitializedAsync()
        {
            var bulkReversals = await BulkReversalService.GetReversalList(Constant.CurrentUser);

            BulkReversalList = Mapper.Map<List<Dto.Response.BulkReversal>>(bulkReversals);
        }

        protected async Task ClearList()
        {
            await BulkReversalService.ClearReversals(Constant.CurrentUser);
            
            Reset();

            await OnInitializedAsync();
        }

        protected void CloseDialog()
        {
            DirtyPendingReversals = false;
        }

        protected async Task BulkReversal(bool dirtyPendingReversalsConfirmation)
        {
            if (dirtyPendingReversalsConfirmation)
            {
                var batchNumber = await BulkReversalService.CreateReversals(Constant.CurrentUser);

                BatchProcessedMessage = $"{Constant.BulkReversal.Message.BatchCreatedAction} {batchNumber}";
                
                Reset();

                await OnInitializedAsync();
            }
            else
            {
                DirtyPendingReversals = await BulkReversalService.ValidatePendingReversals(Constant.CurrentUser);
            }
        }

        protected void NavigateToBulkReversalInput()
        {
            NavigationManager.NavigateTo("bulk-reversal-input");
        }

        private void Reset()
        {
            DirtyPendingReversals = false;
        }
    }
}
