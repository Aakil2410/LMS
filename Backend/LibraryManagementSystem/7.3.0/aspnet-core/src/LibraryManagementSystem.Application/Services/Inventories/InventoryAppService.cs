using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using LibraryManagementSystem.Domain;
using LibraryManagementSystem.Services.Inventories.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Services.Inventories
{
    public class InventoryAppService : ApplicationService, IInventoryAppService
    {
        private readonly IRepository<Book, Guid> _bookReppository;

        public InventoryAppService(IRepository<Book, Guid> bookReppository)
        {
            _bookReppository = bookReppository;
        }

        [HttpPost]
        public async Task<InventoryDto> CreateAsync(InventoryDto input)
        {
            var inventory = ObjectMapper.Map<Inventory>(input);
            inventory.Book = await _bookReppository.GetAsync((Guid)input.BookId.Value);
            var response = await _repository.InsertAsync(inventory);
            CurrentUnitOfWork.SaveChanges();
            return ObjectMapper.Map<InventoryDto>(response);
        }

        [HttpGet]
        public async Task<InventoryDto> GetAsync(Guid id)
        {
            var query = await _repository.GetAllIncluding(m => m.Book).FirstOrDefaultAsync();
            var response = ObjectMapper.Map<InventoryDto>(query);
            return response;
        }

        [HttpGet]
        public async Task<List<InventoryDto>> GetAllAsync()
        {
            var item = _repository.GetAllIncluding(m => m.Book);
            var response = ObjectMapper.Map<List<InventoryDto>>(item);
            return response;
        }

        [HttpPut]
        public async Task<InventoryDto> UpdateAsync(InventoryDto input)
        {
            var inventory = await _repository.GetAllIncluding(x => x.Book).FirstOrDefaultAsync();
            ObjectMapper.Map(input, inventory);
            inventory.Book = input?.BookId != null ? await _bookReppository.GetAsync((Guid)input.BookId):inventory.Book;
            var response = await _repository.UpdateAsync(inventory);
            CurrentUnitOfWork.SaveChanges();
            return ObjectMapper.Map<InventoryDto>(response);
        }

        [HttpDelete]
        public async Task DeleteAsync(Guid id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}

