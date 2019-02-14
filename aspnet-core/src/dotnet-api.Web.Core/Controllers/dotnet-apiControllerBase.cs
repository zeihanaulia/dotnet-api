using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace dotnet-api.Controllers
{
    public abstract class dotnet-apiControllerBase: AbpController
    {
        protected dotnet-apiControllerBase()
        {
            LocalizationSourceName = dotnet-apiConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
