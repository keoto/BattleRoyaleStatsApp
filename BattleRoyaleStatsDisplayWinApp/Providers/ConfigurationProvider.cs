using System.Configuration;

namespace BattleRoyaleStatsApp.Providers
{
    public class ConfigurationProvider
    {
        public string ApiUrl { get; set; }

        public ConfigurationProvider()
        {
            ApiUrl = ConfigurationManager.AppSettings["ApiUrl"];
        }
    }
}
