using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace LibraryManagementSystem.Controllers
{
    public abstract class LibraryManagementSystemControllerBase: AbpController
    {
        protected LibraryManagementSystemControllerBase()
        {
            LocalizationSourceName = LibraryManagementSystemConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
