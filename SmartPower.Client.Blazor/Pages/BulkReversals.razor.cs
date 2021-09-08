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
        public Application.Entity.Repository.IBulkReversal BulkReversalRepository { get; set; }

        public List<Dto.Response.BulkReversalSummary> BulkReversalSummaryList { get; set; }

        public bool DirtyPendingReversals { get; set; }

        public string BatchProcessedMessage { get; set; }

        protected override async Task OnInitializedAsync()
        {
            var bulkReversals = await BulkReversalRepository.GetBulkReversals(Constant.CurrentUser);

            BulkReversalSummaryList = Mapper.Map<List<Dto.Response.BulkReversalSummary>>(bulkReversals);
        }

        protected async Task ClearList()
        {
            await BulkReversalRepository.ClearReversals(Constant.CurrentUser);
            
            Reset();

            await OnInitializedAsync();
        }

        protected async Task BulkReversal()
        {
            var batchNumber = await BulkReversalRepository.CreateReversals(Constant.CurrentUser);

            BatchProcessedMessage = $"{Constant.BulkReversal.Message.BatchCreatedAction} {batchNumber}";
            
            Reset();

            await OnInitializedAsync();
        }

        protected async Task TestSuppliedInvoices()
        {
            DirtyPendingReversals = await BulkReversalRepository.TestSuppliedInvoices(Constant.CurrentUser);

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
