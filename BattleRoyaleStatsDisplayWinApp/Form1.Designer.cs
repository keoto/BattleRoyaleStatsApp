namespace BattleRoyaleStatsDisplayWinApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtRefreshRate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdateAPI = new System.Windows.Forms.Button();
            this.txtSteamID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtWins = new System.Windows.Forms.TextBox();
            this.txtLoses = new System.Windows.Forms.TextBox();
            this.txtKills = new System.Windows.Forms.TextBox();
            this.txtKillPoints = new System.Windows.Forms.TextBox();
            this.txtWinPoints = new System.Windows.Forms.TextBox();
            this.txtTotalPoints = new System.Windows.Forms.TextBox();
            this.txtGlobalRank = new System.Windows.Forms.TextBox();
            this.txtKillsPerGun = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pnlStats = new System.Windows.Forms.Panel();
            this.txtRankName = new System.Windows.Forms.TextBox();
            this.txtKillsPerDistance = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtWinPercentage = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtKillsPerGame = new System.Windows.Forms.TextBox();
            this.btnToggleStats = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.chkIncludeLabels = new System.Windows.Forms.CheckBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pnlStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRefreshRate
            // 
            this.txtRefreshRate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRefreshRate.Location = new System.Drawing.Point(280, 360);
            this.txtRefreshRate.Name = "txtRefreshRate";
            this.txtRefreshRate.Size = new System.Drawing.Size(29, 27);
            this.txtRefreshRate.TabIndex = 0;
            this.txtRefreshRate.Text = "60";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.label1.Location = new System.Drawing.Point(24, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "STEAM ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.label2.Location = new System.Drawing.Point(198, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "(MINUTES)";
            // 
            // btnUpdateAPI
            // 
            this.btnUpdateAPI.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdateAPI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateAPI.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateAPI.Location = new System.Drawing.Point(400, 321);
            this.btnUpdateAPI.Name = "btnUpdateAPI";
            this.btnUpdateAPI.Size = new System.Drawing.Size(123, 30);
            this.btnUpdateAPI.TabIndex = 3;
            this.btnUpdateAPI.Text = "GET DATA";
            this.btnUpdateAPI.UseVisualStyleBackColor = false;
            this.btnUpdateAPI.Click += new System.EventHandler(this.btnUpdateAPI_Click);
            this.btnUpdateAPI.MouseEnter += new System.EventHandler(this.btnUpdateAPI_MouseEnter);
            this.btnUpdateAPI.MouseLeave += new System.EventHandler(this.btnUpdateAPI_MouseLeave);
            // 
            // txtSteamID
            // 
            this.txtSteamID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSteamID.Location = new System.Drawing.Point(99, 324);
            this.txtSteamID.Name = "txtSteamID";
            this.txtSteamID.Size = new System.Drawing.Size(210, 27);
            this.txtSteamID.TabIndex = 4;
            this.txtSteamID.TextChanged += new System.EventHandler(this.txtSteamID_TextChanged);
            this.txtSteamID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSteamID_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.label3.Location = new System.Drawing.Point(26, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "NAME";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Control;
            this.txtName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(101, 14);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(161, 27);
            this.txtName.TabIndex = 6;
            // 
            // txtWins
            // 
            this.txtWins.BackColor = System.Drawing.SystemColors.Control;
            this.txtWins.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWins.Location = new System.Drawing.Point(101, 46);
            this.txtWins.Name = "txtWins";
            this.txtWins.ReadOnly = true;
            this.txtWins.Size = new System.Drawing.Size(161, 27);
            this.txtWins.TabIndex = 7;
            // 
            // txtLoses
            // 
            this.txtLoses.BackColor = System.Drawing.SystemColors.Control;
            this.txtLoses.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoses.Location = new System.Drawing.Point(101, 78);
            this.txtLoses.Name = "txtLoses";
            this.txtLoses.ReadOnly = true;
            this.txtLoses.Size = new System.Drawing.Size(161, 27);
            this.txtLoses.TabIndex = 8;
            // 
            // txtKills
            // 
            this.txtKills.BackColor = System.Drawing.SystemColors.Control;
            this.txtKills.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKills.Location = new System.Drawing.Point(101, 143);
            this.txtKills.Name = "txtKills";
            this.txtKills.ReadOnly = true;
            this.txtKills.Size = new System.Drawing.Size(161, 27);
            this.txtKills.TabIndex = 9;
            // 
            // txtKillPoints
            // 
            this.txtKillPoints.BackColor = System.Drawing.SystemColors.Control;
            this.txtKillPoints.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKillPoints.Location = new System.Drawing.Point(401, 46);
            this.txtKillPoints.Name = "txtKillPoints";
            this.txtKillPoints.ReadOnly = true;
            this.txtKillPoints.Size = new System.Drawing.Size(124, 27);
            this.txtKillPoints.TabIndex = 10;
            // 
            // txtWinPoints
            // 
            this.txtWinPoints.BackColor = System.Drawing.SystemColors.Control;
            this.txtWinPoints.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWinPoints.Location = new System.Drawing.Point(401, 14);
            this.txtWinPoints.Name = "txtWinPoints";
            this.txtWinPoints.ReadOnly = true;
            this.txtWinPoints.Size = new System.Drawing.Size(124, 27);
            this.txtWinPoints.TabIndex = 11;
            // 
            // txtTotalPoints
            // 
            this.txtTotalPoints.BackColor = System.Drawing.SystemColors.Control;
            this.txtTotalPoints.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPoints.Location = new System.Drawing.Point(402, 78);
            this.txtTotalPoints.Name = "txtTotalPoints";
            this.txtTotalPoints.ReadOnly = true;
            this.txtTotalPoints.Size = new System.Drawing.Size(123, 27);
            this.txtTotalPoints.TabIndex = 12;
            // 
            // txtGlobalRank
            // 
            this.txtGlobalRank.BackColor = System.Drawing.SystemColors.Control;
            this.txtGlobalRank.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGlobalRank.Location = new System.Drawing.Point(402, 112);
            this.txtGlobalRank.Name = "txtGlobalRank";
            this.txtGlobalRank.ReadOnly = true;
            this.txtGlobalRank.Size = new System.Drawing.Size(123, 27);
            this.txtGlobalRank.TabIndex = 13;
            // 
            // txtKillsPerGun
            // 
            this.txtKillsPerGun.BackColor = System.Drawing.SystemColors.Control;
            this.txtKillsPerGun.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKillsPerGun.Location = new System.Drawing.Point(30, 233);
            this.txtKillsPerGun.Multiline = true;
            this.txtKillsPerGun.Name = "txtKillsPerGun";
            this.txtKillsPerGun.ReadOnly = true;
            this.txtKillsPerGun.Size = new System.Drawing.Size(232, 150);
            this.txtKillsPerGun.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.label4.Location = new System.Drawing.Point(26, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "WIINS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.label5.Location = new System.Drawing.Point(26, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "LOSSES";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.label6.Location = new System.Drawing.Point(26, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 19);
            this.label6.TabIndex = 17;
            this.label6.Text = "KILLS";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.label7.Location = new System.Drawing.Point(289, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "WIN POINTS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.label8.Location = new System.Drawing.Point(289, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 19);
            this.label8.TabIndex = 19;
            this.label8.Text = "KILL POINTS";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.label9.Location = new System.Drawing.Point(289, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 19);
            this.label9.TabIndex = 20;
            this.label9.Text = "TOTAL POINTS";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.label10.Location = new System.Drawing.Point(289, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 19);
            this.label10.TabIndex = 21;
            this.label10.Text = "GLOBAL RANK";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.label11.Location = new System.Drawing.Point(26, 211);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 19);
            this.label11.TabIndex = 22;
            this.label11.Text = "KILLS BY GUN";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.label13.Location = new System.Drawing.Point(24, 363);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(169, 19);
            this.label13.TabIndex = 25;
            this.label13.Text = "REPEAT DATA INTERVAL";
            // 
            // pnlStats
            // 
            this.pnlStats.Controls.Add(this.txtRankName);
            this.pnlStats.Controls.Add(this.txtKillsPerDistance);
            this.pnlStats.Controls.Add(this.label15);
            this.pnlStats.Controls.Add(this.label17);
            this.pnlStats.Controls.Add(this.txtWinPercentage);
            this.pnlStats.Controls.Add(this.label16);
            this.pnlStats.Controls.Add(this.label14);
            this.pnlStats.Controls.Add(this.txtKillsPerGame);
            this.pnlStats.Controls.Add(this.label3);
            this.pnlStats.Controls.Add(this.label6);
            this.pnlStats.Controls.Add(this.label4);
            this.pnlStats.Controls.Add(this.txtName);
            this.pnlStats.Controls.Add(this.label5);
            this.pnlStats.Controls.Add(this.txtWinPoints);
            this.pnlStats.Controls.Add(this.txtWins);
            this.pnlStats.Controls.Add(this.txtKillsPerGun);
            this.pnlStats.Controls.Add(this.txtLoses);
            this.pnlStats.Controls.Add(this.label7);
            this.pnlStats.Controls.Add(this.txtGlobalRank);
            this.pnlStats.Controls.Add(this.txtKills);
            this.pnlStats.Controls.Add(this.label10);
            this.pnlStats.Controls.Add(this.label11);
            this.pnlStats.Controls.Add(this.label9);
            this.pnlStats.Controls.Add(this.label8);
            this.pnlStats.Controls.Add(this.txtKillPoints);
            this.pnlStats.Controls.Add(this.txtTotalPoints);
            this.pnlStats.Location = new System.Drawing.Point(-2, 402);
            this.pnlStats.Name = "pnlStats";
            this.pnlStats.Size = new System.Drawing.Size(560, 388);
            this.pnlStats.TabIndex = 26;
            // 
            // txtRankName
            // 
            this.txtRankName.BackColor = System.Drawing.SystemColors.Control;
            this.txtRankName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRankName.Location = new System.Drawing.Point(402, 144);
            this.txtRankName.Name = "txtRankName";
            this.txtRankName.ReadOnly = true;
            this.txtRankName.Size = new System.Drawing.Size(123, 27);
            this.txtRankName.TabIndex = 29;
            // 
            // txtKillsPerDistance
            // 
            this.txtKillsPerDistance.BackColor = System.Drawing.SystemColors.Control;
            this.txtKillsPerDistance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKillsPerDistance.Location = new System.Drawing.Point(293, 233);
            this.txtKillsPerDistance.Multiline = true;
            this.txtKillsPerDistance.Name = "txtKillsPerDistance";
            this.txtKillsPerDistance.ReadOnly = true;
            this.txtKillsPerDistance.Size = new System.Drawing.Size(232, 150);
            this.txtKillsPerDistance.TabIndex = 27;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.label15.Location = new System.Drawing.Point(26, 115);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 19);
            this.label15.TabIndex = 26;
            this.label15.Text = "WIN %";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.label17.Location = new System.Drawing.Point(289, 147);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(95, 19);
            this.label17.TabIndex = 30;
            this.label17.Text = "RANK NAME";
            // 
            // txtWinPercentage
            // 
            this.txtWinPercentage.BackColor = System.Drawing.SystemColors.Control;
            this.txtWinPercentage.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWinPercentage.Location = new System.Drawing.Point(101, 111);
            this.txtWinPercentage.Name = "txtWinPercentage";
            this.txtWinPercentage.ReadOnly = true;
            this.txtWinPercentage.Size = new System.Drawing.Size(161, 27);
            this.txtWinPercentage.TabIndex = 25;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.label16.Location = new System.Drawing.Point(289, 211);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(134, 19);
            this.label16.TabIndex = 28;
            this.label16.Text = "KILLS BY DISTANCE";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.label14.Location = new System.Drawing.Point(26, 178);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 19);
            this.label14.TabIndex = 24;
            this.label14.Text = "KPR";
            // 
            // txtKillsPerGame
            // 
            this.txtKillsPerGame.BackColor = System.Drawing.SystemColors.Control;
            this.txtKillsPerGame.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKillsPerGame.Location = new System.Drawing.Point(101, 175);
            this.txtKillsPerGame.Name = "txtKillsPerGame";
            this.txtKillsPerGame.ReadOnly = true;
            this.txtKillsPerGame.Size = new System.Drawing.Size(161, 27);
            this.txtKillsPerGame.TabIndex = 23;
            // 
            // btnToggleStats
            // 
            this.btnToggleStats.BackColor = System.Drawing.SystemColors.Control;
            this.btnToggleStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleStats.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToggleStats.Location = new System.Drawing.Point(400, 806);
            this.btnToggleStats.Name = "btnToggleStats";
            this.btnToggleStats.Size = new System.Drawing.Size(123, 30);
            this.btnToggleStats.TabIndex = 27;
            this.btnToggleStats.Text = "HIDE STATS";
            this.btnToggleStats.UseVisualStyleBackColor = false;
            this.btnToggleStats.Click += new System.EventHandler(this.btnToggleStats_Click);
            this.btnToggleStats.MouseEnter += new System.EventHandler(this.btnToggleStats_MouseEnter);
            this.btnToggleStats.MouseLeave += new System.EventHandler(this.btnToggleStats_MouseLeave);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblError.Location = new System.Drawing.Point(12, 428);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 16);
            this.lblError.TabIndex = 29;
            // 
            // chkIncludeLabels
            // 
            this.chkIncludeLabels.AutoSize = true;
            this.chkIncludeLabels.BackColor = System.Drawing.Color.Transparent;
            this.chkIncludeLabels.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkIncludeLabels.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIncludeLabels.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.chkIncludeLabels.Location = new System.Drawing.Point(384, 362);
            this.chkIncludeLabels.Name = "chkIncludeLabels";
            this.chkIncludeLabels.Size = new System.Drawing.Size(139, 23);
            this.chkIncludeLabels.TabIndex = 30;
            this.chkIncludeLabels.Text = "INCLUDE LABELS";
            this.chkIncludeLabels.UseVisualStyleBackColor = false;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.ImageLocation = "";
            this.pbLogo.Location = new System.Drawing.Point(-2, -49);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(560, 462);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbLogo.TabIndex = 31;
            this.pbLogo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(562, 838);
            this.Controls.Add(this.txtRefreshRate);
            this.Controls.Add(this.chkIncludeLabels);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnToggleStats);
            this.Controls.Add(this.pnlStats);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtSteamID);
            this.Controls.Add(this.btnUpdateAPI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbLogo);
            this.Font = new System.Drawing.Font("Bebas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(1)))), ((int)(((byte)(1)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.Text = "Battle Royale Stats By Keoto";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlStats.ResumeLayout(false);
            this.pnlStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRefreshRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpdateAPI;
        private System.Windows.Forms.TextBox txtSteamID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtWins;
        private System.Windows.Forms.TextBox txtLoses;
        private System.Windows.Forms.TextBox txtKills;
        private System.Windows.Forms.TextBox txtKillPoints;
        private System.Windows.Forms.TextBox txtWinPoints;
        private System.Windows.Forms.TextBox txtTotalPoints;
        private System.Windows.Forms.TextBox txtGlobalRank;
        private System.Windows.Forms.TextBox txtKillsPerGun;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel pnlStats;
        private System.Windows.Forms.Button btnToggleStats;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtWinPercentage;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtKillsPerGame;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.CheckBox chkIncludeLabels;
        private System.Windows.Forms.TextBox txtKillsPerDistance;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtRankName;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

