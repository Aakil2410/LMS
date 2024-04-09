using Abp.Application.Services.Dto;
using AutoMapper;
using LibraryManagementSystem.Domain;
using System;

namespace LibraryManagementSystem.Services.OrderItems.Dto
{
    public class OrderItemDto : EntityDto<Guid>
    {
        public int Quantity { get; set; }

        public Guid? BookId { get; set; }

        public string ISBN { get; set; }

        public Guid? OrderId { get; set; }
    }
}
