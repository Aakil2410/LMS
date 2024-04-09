using Abp.Application.Services.Dto;
using Abp.Application.Services;
using System;
using LibraryManagementSystem.Services.Authors.Dto;

namespace LibraryManagementSystem.Services.Authors
{
    public interface IAuthorAppService : IAsyncCrudAppService<AuthorDto, Guid, PagedAndSortedResultRequestDto>
    {
    }
}
