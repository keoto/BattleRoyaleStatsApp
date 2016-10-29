using System;
using System.Net;
using BattleRoyaleStatsApp.Models;
using Newtonsoft.Json;

namespace BattleRoyaleStatsApp.Data
{
    public static class StatsService
    {
        public static Stats RetreiveStats(string apiUrl, string steamId)
        {
            using (var client = new WebClient())
            {
                var text = client.DownloadString(string.Format(apiUrl, steamId));
                var stats = JsonConvert.DeserializeObject<Stats>(text);

                if (stats == null)
                {
                    throw new Exception("The requested Steam ID did not return a valid request for the hardcore api.{0}");
                }

                return stats;
            }
        }

        public static string Top5Guns(Stats stats)
        {
            var results = "";
            if (stats.top_guns.Count > 0)
            {
                stats.top_guns.ForEach(x => results += $"{x.name} : {x.kills}  -  ");
            }
            return results;
        }

        public static string Top5LongestKills(Stats stats)
        {
            var results = "";
            if (stats.longest_kills.Count > 0)
            {
                stats.longest_kills.ForEach(x => results += $"{x.weapon} : {x.distance}m  -  ");
            }
            return results;
        }
    }
}
