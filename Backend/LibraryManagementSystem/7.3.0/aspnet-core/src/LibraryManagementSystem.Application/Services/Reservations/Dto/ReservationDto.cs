using Abp.Application.Services.Dto;
using LibraryManagementSystem.Domain.Enums;
using System;
using AutoMapper;

namespace LibraryManagementSystem.Services.Reservations.Dto
{
    public class ReservationDto : EntityDto<Guid>
    {
        public DateTime? ReservationDate { get; set; }
        public ReservationStatus? Status { get; set; }
        //
        public string StatusType { get; set; }
        // nav props
        public Guid? PersonId { get; set; }
        public Guid? BookId { get; set; }
    }
}
