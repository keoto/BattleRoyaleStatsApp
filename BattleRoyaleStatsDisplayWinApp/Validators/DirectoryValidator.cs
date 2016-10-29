using System.IO;

namespace BattleRoyaleStatsApp.Validators
{
    public static class DirectoryValidator
    {
        public static void ValidateDirectoryExists(string directory)
        {
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
        }
    }
}
