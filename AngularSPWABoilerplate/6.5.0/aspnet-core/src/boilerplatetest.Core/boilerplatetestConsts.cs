using boilerplatetest.Debugging;

namespace boilerplatetest
{
    public class boilerplatetestConsts
    {
        public const string LocalizationSourceName = "boilerplatetest";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "68e2116bf3884dd6a6b93aebfd5ee77f";
    }
}
