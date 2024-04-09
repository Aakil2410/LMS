using Abp.Application.Services.Dto;
using Abp.Application.Services;
using LibraryManagementSystem.Domain;
using LibraryManagementSystem.Services.Categories.Dto;
using System;
using Abp.Domain.Repositories;

namespace LibraryManagementSystem.Services.Categories
{
    public class CategoryAppService : AsyncCrudAppService<Book, CategoryDto, Guid, PagedAndSortedResultRequestDto>, ICategoryAppService
    {
        private readonly IRepository<Book, Guid> _repository;

        public CategoryAppService(IRepository<Book, Guid> repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
