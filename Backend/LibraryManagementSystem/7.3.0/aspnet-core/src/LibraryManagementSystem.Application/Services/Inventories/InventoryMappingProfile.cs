using AutoMapper;
using LibraryManagementSystem.Domain;
using LibraryManagementSystem.Services.Inventories.Dto;
using System;



namespace LibraryManagementSystem.Services.Inventories
{
    public class InventoryMappingProfile : Profile
    {
        public InventoryMappingProfile()
        {
            CreateMap<Inventory, InventoryDto>()
                .ForMember(e => e.BookId, m => m.MapFrom(e => e.Book != null ? e.Book.Id : (Guid?)null));

            CreateMap<InventoryDto, Inventory>()
                .ForMember(e => e.Id, d => d.Ignore())
                .ForMember(e => e.Book, d => d.Ignore());

        }
    }
}
