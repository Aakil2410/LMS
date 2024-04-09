using Abp.Application.Services.Dto;
using Abp.Application.Services;
using LibraryManagementSystem.Services.Categories.Dto;
using System;

namespace LibraryManagementSystem.Services.Categories
{
    public interface ICategoryAppService : IAsyncCrudAppService<CategoryDto, Guid, PagedAndSortedResultRequestDto>
    {
    }
}
