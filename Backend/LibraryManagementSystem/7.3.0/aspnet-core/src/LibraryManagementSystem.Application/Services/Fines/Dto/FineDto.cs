﻿using Abp.Application.Services.Dto;
using LibraryManagementSystem.Domain.Enums;
using LibraryManagementSystem.Domain;
using System;
using AutoMapper;

namespace LibraryManagementSystem.Services.Fines.Dto
{
    public class FineDto : EntityDto<Guid>
    {
        public double Amount { get; set; }
        public string Reason { get; set; }
        public DateTime? DateIssued { get; set; }
        public FinePaymentStatus? Status { get; set; }
       
        public string StatusType { get; set; }
        public DateTime? PaymentDate { get; set; }

        // nav virtual prop
        public Guid? PersonId { get; set; }

        public Guid? TransactionId { get; set; }
    }
}
