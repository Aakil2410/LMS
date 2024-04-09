using AutoMapper;
using LibraryManagementSystem.Domain;
using LibraryManagementSystem.Services.Reservations.Dto;
using LibraryManagementSystem.Services.Transactions.Dto;
using LibraryManagementSystem.Services.Utils;
using System;

namespace LibraryManagementSystem.Services.Transactions
{
    public class TransactionMappingProfile : Profile
    {
        public TransactionMappingProfile()
        {
            CreateMap<Transaction, TransactionDto>()
                .ForMember(e => e.PersonId, m => m.MapFrom(e => e.Person != null ? e.Person.Id : (Guid?)null))
                .ForMember(e => e.BookId, m => m.MapFrom(e => e.Book != null ? e.Book.Id : (Guid?)null))
                .ForMember(x => x.StatusType, m => m.MapFrom(x => x.Status != null ? x.Status.GetEnumDescription() : null))
                .ForMember(x => x.TransactionType, m => m.MapFrom(x => x.Type != null ? x.Type.GetEnumDescription() : null));

            CreateMap<TransactionDto, Transaction>()
                .ForMember(e => e.Id, d => d.Ignore())
                .ForMember(e => e.Person, d => d.Ignore())
                .ForMember(e => e.Book, d => d.Ignore());
        }
    }
}
