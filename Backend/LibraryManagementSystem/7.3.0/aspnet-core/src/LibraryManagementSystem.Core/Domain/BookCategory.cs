using Abp.Domain.Entities.Auditing;
using System;

namespace LibraryManagementSystem.Domain
{
    public class BookCategory : FullAuditedEntity<Guid>
    {
        public virtual Book Book { get; set; }

        public virtual Category Category { get; set; }

    }
}
