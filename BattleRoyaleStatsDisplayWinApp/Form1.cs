using System;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;
using System.IO;
using Microsoft.VisualBasic;
using System.Xml;
using Newtonsoft.Json.Linq;


namespace BattleRoyaleStatsDisplayWinApp
{
    public partial class Form1 : Form
    {
        private string APIUrl = "http://battleroyalegames.com/leaderboard/api.php?steamid={0}";

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

        }

        private Timer timer;
        private void InitTimer()
        {
            timer = new Timer();
            timer.Tick += new EventHandler(btnUpdateAPI_Click);
            timer.Interval = Convert.ToInt32(txtRefreshRate.Text) * 60000;
            timer.Start();
        }

        private void RetreiveData()
        {
            try
            {

                using (WebClient client = new WebClient())
                {
                    dynamic response = JsonConvert.DeserializeObject(client.DownloadString(string.Format(APIUrl, txtSteamID.Text)));

                    BattleRoyaleStats.XMLData.CreateXML(txtSteamID.Text, txtRefreshRate.Text, chkIncludeLabels.Checked);

                    // write txt files out
                    string statsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/BattleRoyaleStatFiles";

                    if (!Directory.Exists(statsFolder))
                        Directory.CreateDirectory(statsFolder);

                    int iKills;
                    int iWins;
                    int iLosses;
                    decimal dKillsPerRound;
                    decimal dWinPercentage;
                    string strTop5Guns = "";
                    string strTop5Distance = "";
                    string strGlobalRank;
                    string strWinPoints;
                    string strKillPoints;
                    string strTotalPoints;
                    string strRankName;

                    string strWins;
                    string strKills;
                    string strLosses;
                    string strKillsPerRound;
                    string strWinPercentage;
                    string strAllData;

                    iKills = response.kills;
                    iWins = response.wins;
                    iLosses = response.losses;
                    dKillsPerRound = Math.Round(decimal.Divide(iKills, (iWins + iLosses)), 2);
                    dWinPercentage = Math.Round(decimal.Divide(iWins, (iWins + iLosses)) * 100, 2);

                    strKills = iKills.ToString();
                    strWins = iWins.ToString();
                    strLosses = iLosses.ToString();
                    strKillsPerRound = Math.Round(decimal.Divide(iKills, (iWins + iLosses)), 2).ToString();
                    strWinPercentage = dWinPercentage.ToString();
                    strGlobalRank = response.global_rank;
                    strWinPoints = response.win_points;
                    strKillPoints = response.kill_points;
                    strTotalPoints = response.total_points;
                    strRankName = response.rank_name;

                    // Kills Per Gun
                    JArray jarrGuns = JArray.Parse(response.top_5_guns.ToString());
                    foreach (var item in jarrGuns.Children())
                    {
                        strTop5Guns += String.Format("{0} : {1} -  ", item.SelectToken("gun").ToString(), item.SelectToken("count").ToString());
                    }
                    strTop5Guns = strTop5Guns.Substring(0, strTop5Guns.Length - 3);
                    // Kills Per Distance
                    JArray jarrKills = JArray.Parse(response.top_5_kills.ToString());
                    foreach (var item in jarrKills.Children())
                    {
                        strTop5Distance += String.Format("{0} : {1}m  -  ", item.SelectToken("gun").ToString(), item.SelectToken("distance").ToString());
                    }
                    strTop5Distance = strTop5Distance.Substring(0, strTop5Distance.Length - 3);

                    strAllData = string.Format("Wins: {0} | Losses: {1} | Win %: {2} | Kills: {3} | Kills Per Round: {4} | Kills By Gun: {11} | Kills By Distance: {5} | Win Points: {6} | Kill Points: {7} | Total Points {8} | Rank Name: {10} | Global Rank: {9} | ",
                        strWins, strLosses, strWinPercentage, strKills, strKillsPerRound, strTop5Distance, strWinPoints, strKillPoints, strTotalPoints, strGlobalRank, strRankName,strTop5Guns);

                    if (chkIncludeLabels.Checked)
                    {
                        strTop5Guns = "Top 5 Guns by Kill: " + strTop5Guns;
                        strTop5Distance = "Top 5 Kills by Distance: " + strTop5Distance;

                        strKills = "Kills: " + strKills;
                        strWins = "Wins: " + strWins;
                        strLosses = "Losses: " + strLosses;
                        strKillsPerRound = "KPR: " + strKillsPerRound;
                        strWinPercentage = "Win %: " + strWinPercentage;
                        strGlobalRank = "Global Rank: " + strGlobalRank;
                        strWinPoints = "Win Points: " + strWinPoints;
                        strKillPoints = "Kill Points: " + strKillPoints;
                        strTotalPoints = "Total Points: " + strTotalPoints;
                        strRankName = "Rank Name: " + strRankName;
                    }

                    

                    File.WriteAllText(statsFolder + "/global_rank.txt", strGlobalRank);
                    File.WriteAllText(statsFolder + "/kills.txt", strKills);
                    File.WriteAllText(statsFolder + "/win_points.txt", strWinPoints);
                    File.WriteAllText(statsFolder + "/kill_points.txt", strKillPoints);
                    File.WriteAllText(statsFolder + "/total_points.txt", strTotalPoints);
                    File.WriteAllText(statsFolder + "/rank_name.txt", strRankName);
                    File.WriteAllText(statsFolder + "/wins.txt", strWins);
                    File.WriteAllText(statsFolder + "/losses.txt", strLosses);
                    File.WriteAllText(statsFolder + "/kills_per_round.txt", strKillsPerRound);
                    File.WriteAllText(statsFolder + "/win_percentage.txt", strWinPercentage);
                    File.WriteAllText(statsFolder + "/top_5_kills_by_guns.txt", strTop5Guns);
                    File.WriteAllText(statsFolder + "/top_5_kills_by_distance.txt", strTop5Distance);
                    File.WriteAllText(statsFolder + "/all_data.txt", strAllData);                    

                    //write data out to show on app
                    txtName.Text = response.name;
                    txtWins.Text = response.wins;
                    txtLoses.Text = response.losses;
                    txtKills.Text = response.kills;
                    txtWinPoints.Text = response.win_points;
                    txtKillPoints.Text = response.kill_points;
                    txtTotalPoints.Text = response.total_points;
                    txtGlobalRank.Text = response.global_rank;
                    txtRankName.Text = response.rank_name;
                    txtWinPercentage.Text = dWinPercentage.ToString();
                    txtKillsPerGame.Text = dKillsPerRound.ToString();
                    txtKillsPerGun.Text = strTop5Guns;
                    txtKillsPerDistance.Text = strTop5Distance;

                    timer.Interval = Convert.ToInt32(txtRefreshRate.Text) * 60000;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("{0} {1}", ex.Message, ex.StackTrace));
            }
        }

        private void btnUpdateAPI_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSteamID.Text))
            {
                RetreiveData();                
            }

        }

        private void btnToggleStats_Click(object sender, EventArgs e)
        {
            if (pnlStats.Visible)
            {
                btnToggleStats.Text = "SHOW STATS";
                pnlStats.Visible = false;
            }
            else
            {
                btnToggleStats.Text = "HIDE STATS";
                pnlStats.Visible = true;
            }
        }
    }
}
