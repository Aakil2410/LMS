using Abp.Application.Services.Dto;
using AutoMapper;
using LibraryManagementSystem.Domain;
using LibraryManagementSystem.Domain.Enums;
using System;

namespace LibraryManagementSystem.Services.Orders.Dto
{
    [AutoMap(typeof(Order))]
    public class OrderDto : EntityDto<Guid>
    {
        public int ItemsOrdered { get; set; }
        public DateTime? OrderDate { get; set; }
        public OrderStatus? Status { get; set; }
        public string StatusType { get; set; }
    }
}
