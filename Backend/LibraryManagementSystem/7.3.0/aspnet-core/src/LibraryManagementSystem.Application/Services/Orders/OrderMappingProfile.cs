using AutoMapper;
using LibraryManagementSystem.Domain;
using LibraryManagementSystem.Services.Orders.Dto;
using LibraryManagementSystem.Services.Utils;

namespace LibraryManagementSystem.Services.Orders
{
    public class OrderMappingProfile : Profile
    {
        public OrderMappingProfile()
        {
            CreateMap<Order, OrderDto>()
                .ForMember(x => x.StatusType, m => m.MapFrom(x => x.Status != null ? x.Status.GetEnumDescription() : null));

            CreateMap<OrderDto, Order>()
                .ForMember(e => e.Id, d => d.Ignore());
        }
    }
}
