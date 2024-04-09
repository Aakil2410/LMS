using Abp.Application.Services;
using Abp.Application.Services.Dto;
using LibraryManagementSystem.Services.Orders.Dto;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Services.Orders
{
    public interface IOrderAppService : IAsyncCrudAppService<OrderDto, Guid, PagedAndSortedResultRequestDto>
    {
        /*-
        Task<OrderDto> CreateAsync(OrderDto input);

        Task<OrderDto> GetAsync(Guid id);

        Task<List<OrderDto>> GetAllAsync();

        Task<OrderDto> UpdateAsync(OrderDto input);

        Task DeleteAsync(Guid id);*/
    }
}
