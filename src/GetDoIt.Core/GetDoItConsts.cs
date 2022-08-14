using GetDoIt.Debugging;

namespace GetDoIt
{
    public class GetDoItConsts
    {
        public const string LocalizationSourceName = "GetDoIt";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "3294b6d5121443f196091884ae84fcdf";
    }
}
