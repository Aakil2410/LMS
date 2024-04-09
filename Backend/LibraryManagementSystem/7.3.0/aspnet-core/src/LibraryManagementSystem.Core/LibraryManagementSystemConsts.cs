using LibraryManagementSystem.Debugging;

namespace LibraryManagementSystem
{
    public class LibraryManagementSystemConsts
    {
        public const string LocalizationSourceName = "LibraryManagementSystem";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "3ace081614f44294867c107fe95708b6";
    }
}
