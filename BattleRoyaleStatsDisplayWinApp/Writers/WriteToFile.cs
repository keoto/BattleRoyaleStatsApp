using System.Globalization;
using System.IO;
using BattleRoyaleStatsApp.Data;
using BattleRoyaleStatsApp.Models;

namespace BattleRoyaleStatsApp.Writers
{
    public static class WriteToFile
    {
        private static string _statsFolder;
        private static bool _includeLabelsChecked;

        private static string _globalRank;
        private static string _winPoints;
        private static string _killPoints;
        private static string _totalPoints;
        private static string _rankName;
        private static string _wins;
        private static string _kills;
        private static string _losses;
        private static string _killsPerRound;
        private static string _winPercentage;
        private static string _top5Guns;
        private static string _top5LongestKills;

        public static void WriteRegularAndHardcoreDataToFile(Stats stats, string statsFolder, bool chkIncludeLabelsChecked)
        {
            _statsFolder = statsFolder;
            _includeLabelsChecked = chkIncludeLabelsChecked;

            WriteRegularDataToFile(stats);
            WriteHardcoreDataToFile(stats);
        }

        private static void WriteRegularDataToFile(Stats stats)
        {
            const string gameMode = "reg_";
            var regularStats = stats.regular_summary;

            AssignRegularStats(stats, regularStats);
            var allData = AllDataToString();

            if (_includeLabelsChecked)
            {
                IncludeLabelsOnFields();
            }

            WriteAllText(gameMode, allData);
        }

        private static void WriteHardcoreDataToFile(Stats stats)
        {
            const string gameMode = "hc_";
            var hardcoreStats = stats.hardcore_summary;

            AssignHardcoreStats(stats, hardcoreStats);
            var allData = AllDataToString();

            if (_includeLabelsChecked)
            {
                IncludeLabelsOnFields();
            }

            WriteAllText(gameMode, allData);
        }

        private static string AllDataToString()
        {
            var allData =
                string.Format(
                    "Wins: {0} | Losses: {1} | Win %: {2} | Kills: {3} | Kills Per Round: {4} | Kills By Gun: {11} | Kills By Distance: {5} | Win Points: {6} | Kill Points: {7} | Total Points {8} | Rank Name: {10} | Global Rank: {9} | ",
                    _winPoints, _killPoints, _winPercentage, _kills, _killsPerRound, _top5Guns, _winPoints,
                    _killPoints, _totalPoints, _globalRank, _rankName, _top5LongestKills);
            return allData;
        }

        private static void IncludeLabelsOnFields()
        {
            _top5Guns = "Top 5 Guns by Kill: " + _top5Guns;
            _top5LongestKills = "Top 5 Kills by Distance: " + _top5LongestKills;
            _kills = "Kills: " + _kills;
            _wins = "Wins: " + _wins;
            _losses = "Losses: " + _losses;
            _killsPerRound = "KPR: " + _killsPerRound;
            _winPercentage = "Win %: " + _winPercentage;
            _globalRank = "Global Rank: " + _globalRank;
            _winPoints = "Win Points: " + _winPoints;
            _killPoints = "Kill Points: " + _killPoints;
            _totalPoints = "Total Points: " + _totalPoints;
            _rankName = "Rank Name: " + _rankName;
        }

        private static void AssignRegularStats(Stats stats, RegularSummary regularStats)
        {
            _globalRank = regularStats.global_rank.ToString();
            _winPoints = regularStats.win_points.ToString(CultureInfo.InvariantCulture);
            _killPoints = regularStats.kill_points.ToString(CultureInfo.InvariantCulture);
            _totalPoints = regularStats.total_points.ToString(CultureInfo.InvariantCulture);
            _rankName = regularStats.rank.rank;
            _wins = regularStats.wins.ToString();
            _kills = regularStats.kills.ToString();
            _losses = regularStats.losses.ToString();
            _killsPerRound = "";
            _winPercentage = ((decimal)regularStats.wins / (decimal)regularStats.losses * 100).ToString("0.0");
            _top5Guns = StatsService.Top5Guns(stats);
            _top5LongestKills = StatsService.Top5LongestKills(stats);
        }

        private static void AssignHardcoreStats(Stats stats, HardcoreSummary hardcoreStats)
        {
            _globalRank = hardcoreStats.global_rank.ToString();
            _winPoints = hardcoreStats.win_points.ToString(CultureInfo.InvariantCulture);
            _killPoints = hardcoreStats.kill_points.ToString(CultureInfo.InvariantCulture);
            _totalPoints = hardcoreStats.total_points.ToString(CultureInfo.InvariantCulture);
            _rankName = hardcoreStats.rank.rank;
            _wins = hardcoreStats.wins.ToString();
            _kills = hardcoreStats.kills.ToString();
            _losses = hardcoreStats.losses.ToString();
            _killsPerRound = "";
            _winPercentage = ((decimal)hardcoreStats.wins / (decimal)hardcoreStats.losses * 100).ToString("0.0");
            _top5Guns = StatsService.Top5Guns(stats);
            _top5LongestKills = StatsService.Top5LongestKills(stats);
        }

        private static void WriteAllText(string gameMode, string allData)
        {
            File.WriteAllText(_statsFolder + "/" + gameMode + "global_rank.txt", _globalRank);
            File.WriteAllText(_statsFolder + "/" + gameMode + "kills.txt", _kills);
            File.WriteAllText(_statsFolder + "/" + gameMode + "win_points.txt", _winPoints);
            File.WriteAllText(_statsFolder + "/" + gameMode + "kill_points.txt", _killPoints);
            File.WriteAllText(_statsFolder + "/" + gameMode + "total_points.txt", _totalPoints);
            File.WriteAllText(_statsFolder + "/" + gameMode + "rank_name.txt", _rankName);
            File.WriteAllText(_statsFolder + "/" + gameMode + "wins.txt", _wins);
            File.WriteAllText(_statsFolder + "/" + gameMode + "losses.txt", _losses);
            File.WriteAllText(_statsFolder + "/" + gameMode + "kills_per_round.txt", _killsPerRound);
            File.WriteAllText(_statsFolder + "/" + gameMode + "win_percentage.txt", _winPercentage);
            File.WriteAllText(_statsFolder + "/" + gameMode + "top_5_kills_by_guns.txt", _top5Guns);
            File.WriteAllText(_statsFolder + "/" + gameMode + "top_5_kills_by_distance.txt", _top5LongestKills);
            File.WriteAllText(_statsFolder + "/" + gameMode + "all_data.txt", allData);
        }
    }
}
