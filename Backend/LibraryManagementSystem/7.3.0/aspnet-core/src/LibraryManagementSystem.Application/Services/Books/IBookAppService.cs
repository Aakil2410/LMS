using Abp.Application.Services;
using LibraryManagementSystem.Services.Books.Dto;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Services.Books
{
    public interface IBookAppService : IApplicationService 
    {

        Task<BookDto> CreateAsync(BookDto input);

        Task<BookDto> GetAsync(Guid id);

        Task<List<BookDto>> GetAllAsync();

        Task<BookDto> UpdateAsync(BookDto input);

        Task DeleteAsync(Guid id);

    }
}
