
using System.ComponentModel;

namespace LibraryManagementSystem.Domain.Enums
{
    public enum Gender
    {
        [Description("Male")]
        Male = 1,
        [Description("Female")]
        Female = 2,
        [Description("Other")]
        NotDisclosed = 3
    }
}
