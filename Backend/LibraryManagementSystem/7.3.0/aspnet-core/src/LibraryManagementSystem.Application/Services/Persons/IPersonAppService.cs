﻿using Abp.Application.Services;
using Abp.Application.Services.Dto;
using LibraryManagementSystem.Services.Persons.Dto;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace LibraryManagementSystem.Services.Persons
{
    public interface IPersonAppService : IApplicationService
    {
        Task<PersonDto> CreateAsync(CreatePersonDto input);

        Task<PersonDto> GetAsync(Guid id);

        Task<List<PersonDto>> GetAllAsync();

        Task<PersonDto> UpdateAsync(PersonDto input);

        Task DeleteAsync(Guid id);


    }
}
