using System.Collections.Generic;
using Microsoft.AspNetCore.Components;

namespace SmartPower.Client.Blazor.Shared.BulkReversal
{
    partial class BulkReversalList
    {
        [Parameter]
        public List<Dto.Response.BulkReversalSummary> BulkReversals { get; set; }
    }
}