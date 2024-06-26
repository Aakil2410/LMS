﻿
using System.ComponentModel;

namespace LibraryManagementSystem.Domain.Enums
{
    public enum TransactionType : int
    {
        [Description("Borrow Book")]
        Borrow = 1,

        [Description("Return Book")]
        Return = 2,

        [Description("Lost Book")]
        LostBook = 3,

        [Description("Fine Payment")]
        FinePayment = 4,

        [Description("Refund")]
        Refund = 5
    }
}
