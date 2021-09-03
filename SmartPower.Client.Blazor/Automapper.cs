using AutoMapper;

namespace SmartPower.Client.Blazor
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<SmartPower.Data.Entity.Model.TReversalsBulkList, Dto.Response.BulkReversal>();
        }
    }
}
