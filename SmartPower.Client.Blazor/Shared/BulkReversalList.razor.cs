using System.Collections.Generic;
using Microsoft.AspNetCore.Components;

namespace SmartPower.Client.Blazor.Shared
{
    partial class BulkReversalList
    {
        [Parameter]
        public List<Dto.Response.BulkReversal> BulkReversals { get; set; }
    }
}