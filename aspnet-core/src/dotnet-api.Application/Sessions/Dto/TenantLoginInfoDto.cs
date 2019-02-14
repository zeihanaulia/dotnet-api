using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using dotnet-api.MultiTenancy;

namespace dotnet-api.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
