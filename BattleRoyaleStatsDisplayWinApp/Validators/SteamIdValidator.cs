namespace BattleRoyaleStatsApp.Validators
{
    public static class SteamIdValidator
    {
        public static bool ValidSteamId(string steamId)
        {
            if (string.IsNullOrEmpty(steamId))
            {
                return false;
            }

            if (System.Text.RegularExpressions.Regex.IsMatch(steamId, "[^0-9]"))
            {
                return false;
            }

            return true;
        }
    }
}
