using Abp.Application.Services.Dto;
using AutoMapper;
using LibraryManagementSystem.Domain;
using LibraryManagementSystem.Domain.Enums;
using System;

namespace LibraryManagementSystem.Services.Inventories.Dto
{
    public class InventoryDto : EntityDto<Guid>
    {
        public string Location { get; set; }
        public AvailabilityStatus? Status { get; set; }
        public DateTime? LastLoanedDate { get; set; }
        public DateTime? LastReturnedDate { get; set; }

        public Guid? BookId { get; set; }
    }
}
