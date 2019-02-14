using System.Threading.Tasks;
using Abp.Application.Services;
using dotnet-api.Authorization.Accounts.Dto;

namespace dotnet-api.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
