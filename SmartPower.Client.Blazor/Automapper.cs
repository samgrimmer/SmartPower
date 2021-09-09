using AutoMapper;

namespace SmartPower.Client.Blazor
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<Application.Entity.Model.Projection.BulkReversalSummary, Dto.Response.BulkReversalSummary>();
            CreateMap<Application.Entity.Model.Projection.InvoiceSummary, Dto.Response.InvoiceSummary>();
        }
    }
}
