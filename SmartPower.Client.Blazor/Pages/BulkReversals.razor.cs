using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Components;
using SmartPower.Common;

namespace SmartPower.Client.Blazor.Pages
{
    partial class BulkReversals
    {
        [Inject] 
        public NavigationManager NavigationManager { get; set; }

        [Inject] 
        public IMapper Mapper { get; set; }

        [Inject] 
        public Domain.Service.IBulkReversal BulkReversalService { get; set; }

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

        protected async Task BulkReversal()
        {
            var batchNumber = await BulkReversalService.CreateReversals(Constant.CurrentUser);

            BatchProcessedMessage = $"{Constant.BulkReversal.Message.BatchCreatedAction} {batchNumber}";
            
            Reset();

            await OnInitializedAsync();
        }

        protected async Task ValidatedBulkReversal()
        {
            DirtyPendingReversals = await BulkReversalService.ValidatePendingReversals(Constant.CurrentUser);

            if (!DirtyPendingReversals)
            {
                await BulkReversal();
            }
        }

        protected void NavigateToBulkReversalInput()
        {
            NavigationManager.NavigateTo("bulk-reversal-input");
        }

        protected void CloseDialog()
        {
            DirtyPendingReversals = false;
        }

        private void Reset()
        {
            DirtyPendingReversals = false;
        }
    }
}
