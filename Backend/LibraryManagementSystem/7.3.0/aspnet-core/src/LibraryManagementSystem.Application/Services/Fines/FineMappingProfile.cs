﻿using Abp.AutoMapper;
using AutoMapper;
using LibraryManagementSystem.Domain;
using LibraryManagementSystem.Services.Fines.Dto;
using LibraryManagementSystem.Services.Utils;
using System;

namespace LibraryManagementSystem.Services.Fines
{
    public class FineMappingProfile : Profile
    {
        //
        public FineMappingProfile()
        {
            CreateMap<Fine, FineDto>()
                .ForMember(e => e.PersonId, m => m.MapFrom(e => e.Person != null ? e.Person.Id : (Guid?)null))
                .ForMember(e => e.TransactionId, m => m.MapFrom(e => e.Transaction != null ? e.Transaction.Id : (Guid?)null))
                .ForMember(x => x.StatusType, m => m.MapFrom(x => x.Status != null ? x.Status.GetEnumDescription() : null));

            CreateMap<FineDto, Fine>()
                .ForMember(e => e.Id, d => d.Ignore())
                .ForMember(e => e.Person, d => d.Ignore())
                .ForMember(e => e.Transaction, d => d.Ignore());
        }


    }
}
