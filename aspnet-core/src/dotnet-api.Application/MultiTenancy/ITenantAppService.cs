using Abp.Application.Services;
using Abp.Application.Services.Dto;
using dotnet-api.MultiTenancy.Dto;

namespace dotnet-api.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

