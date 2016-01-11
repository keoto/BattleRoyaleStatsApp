using System;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;
using System.IO;
using System.Xml;
using Newtonsoft.Json.Linq;
using System.Drawing;
using System.Collections.Generic;


namespace BattleRoyaleStatsApp
{
    public partial class Form1 : Form
    {
        private string HardcoreAPIUrl = "http://battleroyalegames.com/leaderboard/api.php?steamid={0}";
        private string RegularAPIUrl = "http://battleroyalegames.com/leaderboard/api.php?steamid={0}&reg=1";
        private string statsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/BattleRoyaleStatFiles";
        private List<StatsClass> lstStats = new List<StatsClass>();

        public Form1()
        {           
            InitializeComponent();
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {
            
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/BattleRoyaleStats/settings.xml"))
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/BattleRoyaleStats/settings.xml");

                if (xmlDoc.SelectSingleNode("xml/steamid") != null)
                    txtSteamID.Text = xmlDoc.SelectSingleNode("xml/steamid").InnerText;
                if (xmlDoc.SelectSingleNode("xml/refreshrate") != null)
                    txtRefreshRate.Text = xmlDoc.SelectSingleNode("xml/refreshrate").InnerText;
                if (xmlDoc.SelectSingleNode("xml/labels") != null)
                    chkIncludeLabels.Checked = Convert.ToBoolean(xmlDoc.SelectSingleNode("xml/labels").InnerText);
                
            }
            InitTimer();
            
            var pos = this.PointToScreen(chkIncludeLabels.Location);
            pos = pbLogo.PointToClient(pos);
            chkIncludeLabels.Parent = pbLogo;
            chkIncludeLabels.Location = pos;
            chkIncludeLabels.BackColor = Color.Transparent;
            
        }

        private Timer timer;
        private void InitTimer()
        {
            timer = new Timer();
            timer.Tick += new EventHandler(btnUpdateAPI_Click);
            timer.Interval = Convert.ToInt32(txtRefreshRate.Text) * 60000;
            timer.Start();
        }

        private void ProcessResponse(dynamic response, string strTextlabel, bool IsHardcore)
        {
            StatsClass data = new StatsClass();

            data.PlayerName = response.name;
            data.IsHardcore = IsHardcore;
            data.Kills = response.kills;
            data.Wins = response.wins;
            data.Losses = response.losses;
            if (data.Kills > 0) data.KillsPerRound = Math.Round(decimal.Divide(data.Kills, (data.Wins + data.Losses)), 2);
            if (data.Wins > 0) data.WinPercentage = Math.Round(decimal.Divide(data.Wins, (data.Wins + data.Losses)) * 100, 2);
            data.GlobalRank = response.global_rank;
            data.WinPoints = response.win_points;
            data.KillPoints = response.kill_points;
            data.TotalPoints = response.total_points;
            data.RankName = response.rank_name;

            // Kills Per Gun
            JArray jarrGuns = JArray.Parse(response.top_5_guns.ToString());
            foreach (var item in jarrGuns.Children())
            {
                data.TopGuns.Add(new KeyValuePair<string, string>(item.SelectToken("gun").ToString(), item.SelectToken("count").ToString()));
            }
            // Kills Per Distance
            JArray jarrKills = JArray.Parse(response.top_5_kills.ToString());
            foreach (var item in jarrKills.Children())
            {
                data.TopDistances.Add(new KeyValuePair<string, string>(item.SelectToken("gun").ToString(), item.SelectToken("distance").ToString()));
            }

            lstStats.Add(data);
            
            string strGlobalRank = data.GlobalRank.ToString();
            string strWinPoints = data.WinPoints.ToString();
            string strKillPoints = data.KillPoints.ToString();
            string strTotalPoints = data.TotalPoints.ToString();
            string strRankName = data.RankName;
            string strWins = data.Wins.ToString();
            string strKills = data.Kills.ToString();
            string strLosses =data.Losses.ToString();
            string strKillsPerRound= data.KillsPerRound.ToString();
            string strWinPercentage = data.WinPercentage.ToString();
            string strAllData;
            string strTop5Guns = Top5Guns(data);
            string strTop5Distance = Top5Distances(data);

            strAllData = string.Format("Wins: {0} | Losses: {1} | Win %: {2} | Kills: {3} | Kills Per Round: {4} | Kills By Gun: {11} | Kills By Distance: {5} | Win Points: {6} | Kill Points: {7} | Total Points {8} | Rank Name: {10} | Global Rank: {9} | ", data.Wins, data.Losses, data.WinPercentage, data.Kills, data.KillsPerRound, strTop5Guns, data.WinPoints, data.KillPoints, data.TotalPoints, data.GlobalRank, data.RankName, strTop5Distance);

            if (chkIncludeLabels.Checked)
            {
                strTop5Guns = "Top 5 Guns by Kill: " + strTop5Guns;
                strTop5Distance = "Top 5 Kills by Distance: " + strTop5Distance;
                strKills = "Kills: " + data.Kills;
                strWins = "Wins: " + data.Wins;
                strLosses = "Losses: " + data.Losses;
                strKillsPerRound = "KPR: " + data.KillsPerRound;
                strWinPercentage = "Win %: " + data.WinPercentage;
                strGlobalRank = "Global Rank: " + data.GlobalRank;
                strWinPoints = "Win Points: " + data.WinPoints;
                strKillPoints = "Kill Points: " + data.KillPoints;
                strTotalPoints = "Total Points: " + data.TotalPoints;
                strRankName = "Rank Name: " + data.RankName;
            }

            File.WriteAllText(statsFolder + "/" + strTextlabel + "global_rank.txt", strGlobalRank);
            File.WriteAllText(statsFolder + "/" + strTextlabel + "kills.txt", strKills);
            File.WriteAllText(statsFolder + "/" + strTextlabel + "win_points.txt", strWinPoints);
            File.WriteAllText(statsFolder + "/" + strTextlabel + "kill_points.txt", strKillPoints);
            File.WriteAllText(statsFolder + "/" + strTextlabel + "total_points.txt", strTotalPoints);
            File.WriteAllText(statsFolder + "/" + strTextlabel + "rank_name.txt", strRankName);
            File.WriteAllText(statsFolder + "/" + strTextlabel + "wins.txt", strWins);
            File.WriteAllText(statsFolder + "/" + strTextlabel + "losses.txt", strLosses);
            File.WriteAllText(statsFolder + "/" + strTextlabel + "kills_per_round.txt", strKillsPerRound);
            File.WriteAllText(statsFolder + "/" + strTextlabel + "win_percentage.txt", strWinPercentage);
            File.WriteAllText(statsFolder + "/" + strTextlabel + "top_5_kills_by_guns.txt", strTop5Guns);
            File.WriteAllText(statsFolder + "/" + strTextlabel + "top_5_kills_by_distance.txt", strTop5Distance);
            File.WriteAllText(statsFolder + "/" + strTextlabel + "all_data.txt", strAllData);
        }

        private void WriteDataToScreen(StatsClass data)
        {
            if (data != null){
                txtName.Text = data.PlayerName;
                txtWins.Text = data.Wins.ToString();
                txtLoses.Text = data.Losses.ToString();
                txtKills.Text = data.Kills.ToString();
                txtWinPoints.Text = data.WinPoints.ToString();
                txtKillPoints.Text = data.KillPoints.ToString();
                txtTotalPoints.Text = data.TotalPoints.ToString();
                txtGlobalRank.Text = data.GlobalRank.ToString();
                txtRankName.Text = data.RankName.ToString();
                txtWinPercentage.Text = data.WinPercentage.ToString();
                txtKillsPerGame.Text = data.KillsPerRound.ToString();
                txtKillsPerGun.Text = Top5Guns(data).Replace("  -  ", Environment.NewLine);
                txtKillsPerDistance.Text = Top5Distances(data).Replace("  -  ", Environment.NewLine);
            }

            
        }

        private string Top5Guns(StatsClass data)
        {
            string results = "";
            if (data.TopGuns.Count > 0)
            {
                data.TopGuns.ForEach(x => results += String.Format("{0} : {1}  -  ", x.Key, x.Value));
            }
            return results;
        }

        private string Top5Distances(StatsClass data)
        {
            string results = "";
            if (data.TopDistances.Count > 0)
            {
                data.TopDistances.ForEach(x => results += String.Format("{0} : {1}m  -  ", x.Key, x.Value));
            }
            return results;
        }

        private void RetreiveData()
        {
            lstStats.Clear();
            string strError = "";
            try
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtSteamID.Text, "[^0-9]"))
                {
                    using (WebClient client = new WebClient())
                    {
                        if (!Directory.Exists(statsFolder))
                            Directory.CreateDirectory(statsFolder);

                        BattleRoyaleStats.XMLData.CreateXML(txtSteamID.Text, txtRefreshRate.Text, chkIncludeLabels.Checked);

                        dynamic response1 = JsonConvert.DeserializeObject(client.DownloadString(string.Format(HardcoreAPIUrl, txtSteamID.Text)));
                        if (response1.name != null)
                        {   
                            ProcessResponse(response1, "hc_", true);
                            timer.Interval = Convert.ToInt32(txtRefreshRate.Text) * 60000;
                        }
                        else
                        {
                            strError = "The requested Steam ID did not return a valid request for the hardcore api.{0}";
                            txtSteamID.Focus();
                        }

                        dynamic response2 = JsonConvert.DeserializeObject(client.DownloadString(string.Format(RegularAPIUrl, txtSteamID.Text)));
                        if (response2.name != null)
                        {                           
                            ProcessResponse(response2, "reg_", false);
                            timer.Interval = Convert.ToInt32(txtRefreshRate.Text) * 60000;
                        }
                        else
                        {
                            strError += "The requested Steam ID did not return a valid request for the regular api.{0}";
                            txtSteamID.Focus();
                        }                    
                    }
                }
                else
                {
                    strError += "You Steam ID should only contain numbers.";
                    txtSteamID.Focus();
                }

                if (!string.IsNullOrEmpty(strError)) MessageBox.Show(string.Format(strError, Environment.NewLine));
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("{0} {1}", ex.Message, ex.StackTrace));
            }
        }

        private void btnUpdateAPI_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSteamID.Text)) RetreiveData();
            btnRegular_Click(null,null);
        }

        private void btnToggleStats_Click(object sender, EventArgs e)
        {
            if (pnlStats.Visible)
            {
                btnToggleStats.Text = "SHOW STATS";
                pnlStats.Visible = false;
                btnRegular.Visible = false;
                btnHardcore.Visible = false;
                btnToggleStats.Location = new Point(btnToggleStats.Location.X, chkIncludeLabels.Location.Y - 15);
            }
            else
            {
                btnToggleStats.Text = "HIDE STATS";
                pnlStats.Visible = true;
                btnRegular.Visible = true;
                btnHardcore.Visible = true;
                btnToggleStats.Location = new Point(btnToggleStats.Location.X, pnlStats.Location.Y + 410);
            }
        }

        private void ButtonHover(Button btn)
        {
            btn.BackColor = ColorTranslator.FromHtml("#5d0101");
            btn.ForeColor = Color.White;            
        }

        private void ButtonLeave(Button btn)
        {
            btn.BackColor = SystemColors.Control;
            btn.ForeColor = ColorTranslator.FromHtml("#5d0101");
        }

        private void btnToggleStats_MouseLeave(object sender, EventArgs e)
        {
            ButtonLeave(btnToggleStats);
        }

        private void btnToggleStats_MouseEnter(object sender, EventArgs e)
        {
            ButtonHover(btnToggleStats);
        }

        private void btnUpdateAPI_MouseLeave(object sender, EventArgs e)
        {
            ButtonLeave(btnUpdateAPI);
        }

        private void btnUpdateAPI_MouseEnter(object sender, EventArgs e)
        {
            ButtonHover(btnUpdateAPI);
        }

        private void txtSteamID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtSteamID_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtSteamID.Text, "[^0-9]"))
            {
                MessageBox.Show("You Steam ID should only contain numbers.");
                txtSteamID.Text.Remove(txtSteamID.Text.Length - 1);
            }
        }

        private void btnRegular_Click(object sender, EventArgs e)
        {
            ButtonHover(btnRegular);
            ButtonLeave(btnHardcore);
            WriteDataToScreen(lstStats.Find(x => !x.IsHardcore));
        }

        private void btnHardcore_Click(object sender, EventArgs e)
        {
            ButtonHover(btnHardcore);
            ButtonLeave(btnRegular);
            WriteDataToScreen(lstStats.Find(x => x.IsHardcore));
        }

        private void btnOpenFiles_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@statsFolder.Replace("/", "\\"));
        }
    }
}
