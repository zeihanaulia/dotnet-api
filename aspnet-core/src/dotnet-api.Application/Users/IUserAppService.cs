using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using dotnet-api.Roles.Dto;
using dotnet-api.Users.Dto;

namespace dotnet-api.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
