using System.Threading.Tasks;
using Abp.Application.Services;
using dotnet-api.Sessions.Dto;

namespace dotnet-api.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
