using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleRoyaleStatsApp
{
    class StatsClass
    {
        public StatsClass()
        {
            TopGuns = new List<KeyValuePair<string, string>>();
            TopDistances = new List<KeyValuePair<string, string>>();
        }

        public string PlayerName { get; set; }
        public bool IsHardcore { get; set; }
        public int Kills { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public decimal KillsPerRound { get; set; }
        public decimal WinPercentage { get; set; }
        public decimal WinPoints { get; set; }
        public decimal KillPoints { get; set; }
        public decimal TotalPoints { get; set; }
        public string RankName { get; set; }
        public int GlobalRank { get; set; }
        public List<KeyValuePair<string, string>> TopGuns { get; set; }
        public List<KeyValuePair<string, string>> TopDistances { get; set; }
    }   

}
