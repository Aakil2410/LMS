using Abp.Application.Services.Dto;
using Abp.Application.Services;
using System;
using LibraryManagementSystem.Services.OrderItems.Dto;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace LibraryManagementSystem.Services.OrderItems
{
    public interface IOrderItemAppService : IApplicationService
    {
        Task<OrderItemDto> CreateAsync(OrderItemDto input);

        Task<OrderItemDto> GetAsync(Guid id);

        Task<List<OrderItemDto>> GetAllAsync();

        Task<OrderItemDto> UpdateAsync(OrderItemDto input);

        Task DeleteAsync(Guid id); 
         
         
    }
}

