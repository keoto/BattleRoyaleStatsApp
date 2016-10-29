using System;
using System.Globalization;
using System.Windows.Forms;
using BattleRoyaleStatsApp.Data;
using BattleRoyaleStatsApp.Models;

namespace BattleRoyaleStatsApp.Writers
{
    public static class WriteToScreen
    {
        public static void WriteDataToScreen(Form1 form, Stats stats, GameMode gameMode)
        {
            if (stats == null)
            {
                MessageBox.Show(@"No stats to show!");
                return;
            }

            form.WriteDataToTextField("txtName", stats.name);

            switch (gameMode)
            {
                case GameMode.Regular:
                    var regularSummary = stats.regular_summary;
                    form.WriteDataToTextField("txtWins", regularSummary.wins.ToString());
                    form.WriteDataToTextField("txtLoses", regularSummary.losses.ToString());
                    form.WriteDataToTextField("txtKills", regularSummary.kills.ToString());
                    form.WriteDataToTextField("txtWinPoints", regularSummary.win_points.ToString(CultureInfo.InvariantCulture));
                    form.WriteDataToTextField("txtKillPoints", regularSummary.kill_points.ToString(CultureInfo.InvariantCulture));
                    form.WriteDataToTextField("txtTotalPoints", regularSummary.total_points.ToString(CultureInfo.InvariantCulture));
                    form.WriteDataToTextField("txtGlobalRank", regularSummary.global_rank.ToString());
                    form.WriteDataToTextField("txtRankName", regularSummary.rank.rank);
                    form.WriteDataToTextField("txtWinPercentage", ((decimal)regularSummary.wins / (decimal)regularSummary.losses * 100).ToString("0.0"));

                    break;
                case GameMode.Hardcore:
                    var hardcoreSummary = stats.hardcore_summary;
                    form.WriteDataToTextField("txtWins", hardcoreSummary.wins.ToString());
                    form.WriteDataToTextField("txtLoses", hardcoreSummary.losses.ToString());
                    form.WriteDataToTextField("txtKills", hardcoreSummary.kills.ToString());
                    form.WriteDataToTextField("txtWinPoints", hardcoreSummary.win_points.ToString(CultureInfo.InvariantCulture));
                    form.WriteDataToTextField("txtKillPoints", hardcoreSummary.kill_points.ToString(CultureInfo.InvariantCulture));
                    form.WriteDataToTextField("txtTotalPoints", hardcoreSummary.total_points.ToString(CultureInfo.InvariantCulture));
                    form.WriteDataToTextField("txtGlobalRank", hardcoreSummary.global_rank.ToString());
                    form.WriteDataToTextField("txtRankName", hardcoreSummary.rank.rank);
                    form.WriteDataToTextField("txtWinPercentage", ((decimal)hardcoreSummary.wins / (decimal)hardcoreSummary.losses * 100).ToString("0.0"));
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(gameMode), gameMode, null);
            }

            //form.WriteDataToTextField("txtKillsPerGame", data.KillsPerRound.ToString());
            form.WriteDataToTextField("txtKillsPerGun", StatsService.Top5Guns(stats).Replace("  -  ", Environment.NewLine));
            form.WriteDataToTextField("txtKillsPerDistance", StatsService.Top5LongestKills(stats).Replace("  -  ", Environment.NewLine));
        }
    }
}
