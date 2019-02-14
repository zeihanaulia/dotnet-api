using Abp.Authorization;
using dotnet-api.Authorization.Roles;
using dotnet-api.Authorization.Users;

namespace dotnet-api.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
