﻿using Abp.Domain.Entities.Auditing;
using LibraryManagementSystem.Authorization.Users;
using LibraryManagementSystem.Domain.Enums;
using System;

namespace LibraryManagementSystem.Domain
{
    public class Person : FullAuditedEntity<Guid>
    {
        public virtual string Name { get; set; }
        public virtual string Surname { get; set; }
        public virtual string FullName { get; protected set; }
        public virtual Gender? Gender { get; set; }
        public virtual string Email { get; set; }
        public virtual string ContactNumber { get; set; }
        public virtual string Address { get; set; }
        public virtual  DateTime? RegistrationDate { get; set; }
        public virtual int? BooksBorrowed { get; set; }
        public virtual double? FinesDue { get; set; }

        public virtual User User { get; set; }

        public override string ToString()
        {
            return FullName;
        }
    }
}
