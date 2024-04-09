using System.Threading.Tasks;
using Abp.Application.Services;
using LibraryManagementSystem.Authorization.Accounts.Dto;

namespace LibraryManagementSystem.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
