using Abp.Application.Services.Dto;
using AutoMapper;
using LibraryManagementSystem.Domain;
using System;

namespace LibraryManagementSystem.Services.Authors.Dto
{
    [AutoMap(typeof(Author))]
    public class AuthorDto : EntityDto<Guid>
    {
        public string Name { get; set; }
        public string Biography { get; set; }


    }
}
