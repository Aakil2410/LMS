using Abp.Application.Services.Dto;
using Abp.Application.Services;
using LibraryManagementSystem.Services.Fines.Dto;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace LibraryManagementSystem.Services.Fines
{
    public interface IFineAppService : IApplicationService
    {
        Task<FineDto> CreateAsync(FineDto input);

        Task<FineDto> GetAsync(Guid id);

        Task<List<FineDto>> GetAllAsync();

        Task<FineDto> UpdaetAsync(FineDto input); 

        Task DeleteAsync(Guid id);
    }



}
