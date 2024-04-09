using AutoMapper;
using LibraryManagementSystem.Domain;
using LibraryManagementSystem.Services.Books.Dto;
using LibraryManagementSystem.Services.Utils;
using System;

namespace LibraryManagementSystem.Services.Books
{
    public class BookMappingProfile : Profile
    {
        public BookMappingProfile()
        {

            CreateMap<Book, BookDto>()
                .ForMember(e => e.ParentId, m => m.MapFrom(e => e.Parent != null ? e.Parent.Id : (Guid?)null))
                .ForMember(x => x.StatusType, m => m.MapFrom(x => x.Status != null ? x.Status.GetEnumDescription() : null));
                
            CreateMap<BookDto, Book>()
                .ForMember(e => e.Id, d => d.Ignore());
        }
    }   
}
