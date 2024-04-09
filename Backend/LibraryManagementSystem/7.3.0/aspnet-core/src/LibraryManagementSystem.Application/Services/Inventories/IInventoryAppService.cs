using Abp.Application.Services;
using Abp.Application.Services.Dto;
using LibraryManagementSystem.Services.Inventories.Dto;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Services.Inventories
{
    public interface IInventoryAppService : IApplicationService
    {
        Task<InventoryDto> CreateAsync(InventoryDto input);

        Task<InventoryDto> GetAsync(Guid id);

        Task<List<InventoryDto>> GetAllAsync();

        Task<InventoryDto> UpdateAsync(InventoryDto input);

        Task DeleteAsync(Guid id);

    }


}
