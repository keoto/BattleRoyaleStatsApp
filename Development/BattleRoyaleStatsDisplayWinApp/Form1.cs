using System;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;
using System.IO;
using Microsoft.VisualBasic;
using System.Xml;


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

                txtSteamID.Text = xmlDoc.SelectSingleNode("xml/steamid").InnerText;
                txtRefreshRate.Text = xmlDoc.SelectSingleNode("xml/refreshrate").InnerText;
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


        private void btnUpdateAPI_Click(object sender, EventArgs e)
        {
            using (WebClient client = new WebClient())
            {
                dynamic response = JsonConvert.DeserializeObject(client.DownloadString(string.Format(APIUrl, txtSteamID.Text)));

                BattleRoyaleStats.XMLData.CreateXML(txtSteamID.Text, txtRefreshRate.Text);

                // write txt files out
                string statsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/BattleRoyaleStatFiles";

                if (!Directory.Exists(statsFolder))
                    Directory.CreateDirectory(statsFolder);

                File.WriteAllText(statsFolder + "/global_rank.txt", response.global_rank.ToString());
                File.WriteAllText(statsFolder + "/kills.txt", response.kills.ToString());
                File.WriteAllText(statsFolder + "/win_points.txt", response.win_points.ToString());
                File.WriteAllText(statsFolder + "/kill_points.txt", response.kill_points.ToString());
                File.WriteAllText(statsFolder + "/total_points.txt", response.total_points.ToString());
                File.WriteAllText(statsFolder + "/rank_name.txt", response.rank_name.ToString());
                File.WriteAllText(statsFolder + "/wins.txt", response.wins.ToString());
                File.WriteAllText(statsFolder + "/losses.txt", response.losses.ToString());

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

                timer.Interval = Convert.ToInt32(txtRefreshRate.Text) * 60000;

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
