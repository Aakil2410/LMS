using System.ComponentModel;

namespace LibraryManagementSystem.Domain.Enums
{
    public enum AvailabilityStatus : int
    {
        //[Description("1. Available")]
        [Description("Available")]
        Available= 1,

        [Description("Borrowed")]
        Borrowed = 2,

        [Description("Lost")]
        Lost = 3,

        [Description("OnHold")]
        OnHold = 4,

        [Description("Reserved")]
        Reserved = 5,

        [Description("Damaged")]
        Damaged = 6,

        [Description("Unavailable")]
        Unavailable = 7
    }
}
