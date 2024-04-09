using Abp.Authorization;
using LibraryManagementSystem.Authorization.Roles;
using LibraryManagementSystem.Authorization.Users;

namespace LibraryManagementSystem.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
