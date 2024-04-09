using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Domain.Enums
{
    public enum TransactionStatus:int
    {
        [Description("Paid")]
        Paid = 1,
        [Description("Waived")]
        Waived = 2,
        [Description("Returned")]
        Returned = 3,
        [Description("Borrowed")]
        Borrowed = 4,
        [Description("Lost")]
        Lost = 5,
        [Description("Pending")]
        Pending = 6
    }
}
