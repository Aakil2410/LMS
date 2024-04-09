using Abp.Domain.Entities.Auditing;
using LibraryManagementSystem.Authorization.Users;
using LibraryManagementSystem.Domain.Enums;
using System;

namespace LibraryManagementSystem.Domain
{
    public class Fine : FullAuditedEntity<Guid>
    {
        public virtual decimal? Amount { get; set; }
        public virtual string Reason { get; set; }
        public virtual DateTime? DateIssued { get; set; }
        public virtual FinePaymentStatus? Status { get; set; }
        public virtual DateTime? PaymentDate { get; set; }
               
        public virtual Person Person { get; set; }
                
        public virtual Transaction Transaction { get; set; }

    }
}
