using System.Threading.Tasks;
using Abp.Application.Services;
using LibraryManagementSystem.Sessions.Dto;

namespace LibraryManagementSystem.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
