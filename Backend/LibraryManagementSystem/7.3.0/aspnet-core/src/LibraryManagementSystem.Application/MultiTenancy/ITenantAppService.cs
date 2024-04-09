using Abp.Application.Services;
using LibraryManagementSystem.MultiTenancy.Dto;

namespace LibraryManagementSystem.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

