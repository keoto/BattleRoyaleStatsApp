using System;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Drawing;
using System.Linq;
using BattleRoyaleStatsApp.Data;
using BattleRoyaleStatsApp.Models;
using BattleRoyaleStatsApp.Providers;
using BattleRoyaleStatsApp.Validators;
using BattleRoyaleStatsApp.Writers;


namespace BattleRoyaleStatsApp
{
    public partial class Form1 : Form
    {
        private string _apiUrl;
        private Timer _timer;
        private Stats _stats;
        private readonly string _statsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/BattleRoyaleStatFiles";

        public Form1()
        {
            InitializeComponent();
            GetConfiguration();
            DirectoryValidator.ValidateDirectoryExists(_statsFolder);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (
                File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                            "/BattleRoyaleStats/settings.xml"))
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) +
                            "/BattleRoyaleStats/settings.xml");

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

        private void InitTimer()
        {
            _timer = new Timer();
            _timer.Tick += new EventHandler(btnUpdateAPI_Click);
            _timer.Interval = Convert.ToInt32(txtRefreshRate.Text) * 60000;
            _timer.Start();
        }

        public void WriteDataToTextField(string fieldName, string data)
        {
            var tBox = Controls.Find(fieldName, true).FirstOrDefault();
            if (tBox != null)
            {
                tBox.Text = data;
            }
        }

        private void GetConfiguration()
        {
            _apiUrl = new ConfigurationProvider().ApiUrl;
        }

        private void btnUpdateAPI_Click(object sender, EventArgs e)
        {
            var steamId = txtSteamID.Text;
            if (!SteamIdValidator.ValidSteamId(steamId))
            {
                MessageBox.Show(@"You Steam ID should only contain numbers.");
                txtSteamID.Focus();
            }

            try
            {
                _stats = StatsService.RetreiveStats(_apiUrl, txtSteamID.Text);
                XmlData.CreateXml(steamId, txtRefreshRate.Text, chkIncludeLabels.Checked);
                WriteToFile.WriteRegularAndHardcoreDataToFile(_stats, _statsFolder, chkIncludeLabels.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtSteamID.Focus();
            }

            btnRegular_Click(_stats, null);
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
            if (!SteamIdValidator.ValidSteamId(txtSteamID.Text))
            {
                MessageBox.Show(@"You Steam ID should only contain numbers.");
                //txtSteamID.Text.Remove(txtSteamID.Text.Length - 1);
            }
        }

        private void btnRegular_Click(object sender, EventArgs e)
        {
            ButtonHover(btnRegular);
            ButtonLeave(btnHardcore);
            WriteToScreen.WriteDataToScreen(this, _stats, GameMode.Regular);
        }

        private void btnHardcore_Click(object sender, EventArgs e)
        {
            ButtonHover(btnHardcore);
            ButtonLeave(btnRegular);
            WriteToScreen.WriteDataToScreen(this, _stats, GameMode.Hardcore);
        }

        private void btnOpenFiles_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(_statsFolder.Replace("/", "\\"));
        }
    }
}
