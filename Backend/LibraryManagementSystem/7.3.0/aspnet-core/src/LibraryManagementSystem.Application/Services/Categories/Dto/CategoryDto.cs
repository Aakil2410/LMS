using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using LibraryManagementSystem.Domain;
using System;

namespace LibraryManagementSystem.Services.Categories.Dto
{
    [AutoMap(typeof(Category))]
    public class CategoryDto : EntityDto<Guid>
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }
    }
}
