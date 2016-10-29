using System.Collections.Generic;

namespace BattleRoyaleStatsApp.Models
{
    // Allthough tempting, don't change names of any of these properties. We map them against JSON from the leaderboard api.
    public class Stats
    {
        public string name { get; set; }
        public string uid { get; set; }
        public string profile_url { get; set; }
        public HardcoreSummary hardcore_summary { get; set; }
        public RegularSummary regular_summary { get; set; }
        public List<LongestKill> longest_kills { get; set; }
        public List<Victim> victims { get; set; }
        public List<Nemes> nemeses { get; set; }
        public List<TopGun> top_guns { get; set; }
        public List<Map> maps { get; set; }
    }

    public class Rank
    {
        public string rank { get; set; }
        public string color { get; set; }
    }

    public class HardcoreSummary
    {
        public int kills { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public string time_played { get; set; }
        public double win_points { get; set; }
        public double kill_points { get; set; }
        public string distance_moved { get; set; }
        public int global_rank { get; set; }
        public double total_points { get; set; }
        public Rank rank { get; set; }
        public int average_placement { get; set; }
    }

    public class Rank2
    {
        public string rank { get; set; }
        public string color { get; set; }
    }

    public class RegularSummary
    {
        public int kills { get; set; }
        public int wins { get; set; }
        public int losses { get; set; }
        public string time_played { get; set; }
        public double win_points { get; set; }
        public double kill_points { get; set; }
        public string distance_moved { get; set; }
        public int global_rank { get; set; }
        public double total_points { get; set; }
        public Rank2 rank { get; set; }
        public int average_placement { get; set; }
    }

    public class LongestKill
    {
        public string name { get; set; }
        public string profile_url { get; set; }
        public double distance { get; set; }
        public string weapon { get; set; }
        public string match_id { get; set; }
        public string match_url { get; set; }
    }

    public class Victim
    {
        public string id { get; set; }
        public string name { get; set; }
        public string profile_url { get; set; }
        public int times_killed { get; set; }
    }

    public class Nemes
    {
        public string id { get; set; }
        public string name { get; set; }
        public string profile_url { get; set; }
        public int times_died { get; set; }
    }

    public class TopGun
    {
        public string name { get; set; }
        public int kills { get; set; }
    }

    public class Map
    {
        public string map { get; set; }
        public int times_played { get; set; }
        public double percentage { get; set; }
    }
}
