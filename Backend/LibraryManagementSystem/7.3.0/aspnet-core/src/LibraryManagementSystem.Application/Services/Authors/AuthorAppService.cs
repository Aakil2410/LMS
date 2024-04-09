
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using LibraryManagementSystem.Domain;
using LibraryManagementSystem.Services.Authors.Dto;
using System;

namespace LibraryManagementSystem.Services.Authors
{
    public class AuthorAppService : AsyncCrudAppService<Author, AuthorDto, Guid, PagedAndSortedResultRequestDto>, IAuthorAppService
    {
        private readonly IRepository<Author, Guid> _repository;

        public AuthorAppService(IRepository<Author, Guid> repository) : base(repository)
        {
            _repository = repository;
        }

    }
}
