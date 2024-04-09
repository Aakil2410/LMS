using Abp.Domain.Entities.Auditing;
using LibraryManagementSystem.Domain.Enums;
using System;

namespace LibraryManagementSystem.Domain
{
    public  class Inventory : FullAuditedEntity<Guid>
    {
        public virtual string Location { get; set; }
        public virtual AvailabilityStatus? Status { get; set; }
        public virtual DateTime? LastLoanedDate { get; set; }
        public virtual DateTime? LastReturnedDate { get; set; }

        public virtual Book Book { get; set; }
    }
}
