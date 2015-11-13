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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlStats = new System.Windows.Forms.Panel();
            this.txtKillsPerDistance = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtWinPercentage = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtKillsPerGame = new System.Windows.Forms.TextBox();
            this.btnToggleStats = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.chkIncludeLabels = new System.Windows.Forms.CheckBox();
            this.txtRankName = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRefreshRate
            // 
            this.txtRefreshRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRefreshRate.Location = new System.Drawing.Point(202, 292);
            this.txtRefreshRate.Name = "txtRefreshRate";
            this.txtRefreshRate.Size = new System.Drawing.Size(29, 22);
            this.txtRefreshRate.TabIndex = 0;
            this.txtRefreshRate.Text = "60";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Steam ID Below";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(237, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "(minutes)";
            // 
            // btnUpdateAPI
            // 
            this.btnUpdateAPI.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdateAPI.Location = new System.Drawing.Point(84, 334);
            this.btnUpdateAPI.Name = "btnUpdateAPI";
            this.btnUpdateAPI.Size = new System.Drawing.Size(123, 30);
            this.btnUpdateAPI.TabIndex = 3;
            this.btnUpdateAPI.Text = "Get Data";
            this.btnUpdateAPI.UseVisualStyleBackColor = false;
            this.btnUpdateAPI.Click += new System.EventHandler(this.btnUpdateAPI_Click);
            // 
            // txtSteamID
            // 
            this.txtSteamID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSteamID.Location = new System.Drawing.Point(12, 293);
            this.txtSteamID.Name = "txtSteamID";
            this.txtSteamID.Size = new System.Drawing.Size(180, 22);
            this.txtSteamID.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Control;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(122, 12);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(88, 22);
            this.txtName.TabIndex = 6;
            // 
            // txtWins
            // 
            this.txtWins.BackColor = System.Drawing.SystemColors.Control;
            this.txtWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWins.Location = new System.Drawing.Point(122, 40);
            this.txtWins.Name = "txtWins";
            this.txtWins.ReadOnly = true;
            this.txtWins.Size = new System.Drawing.Size(88, 22);
            this.txtWins.TabIndex = 7;
            // 
            // txtLoses
            // 
            this.txtLoses.BackColor = System.Drawing.SystemColors.Control;
            this.txtLoses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoses.Location = new System.Drawing.Point(122, 68);
            this.txtLoses.Name = "txtLoses";
            this.txtLoses.ReadOnly = true;
            this.txtLoses.Size = new System.Drawing.Size(88, 22);
            this.txtLoses.TabIndex = 8;
            // 
            // txtKills
            // 
            this.txtKills.BackColor = System.Drawing.SystemColors.Control;
            this.txtKills.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKills.Location = new System.Drawing.Point(122, 124);
            this.txtKills.Name = "txtKills";
            this.txtKills.ReadOnly = true;
            this.txtKills.Size = new System.Drawing.Size(88, 22);
            this.txtKills.TabIndex = 9;
            // 
            // txtKillPoints
            // 
            this.txtKillPoints.BackColor = System.Drawing.SystemColors.Control;
            this.txtKillPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKillPoints.Location = new System.Drawing.Point(368, 40);
            this.txtKillPoints.Name = "txtKillPoints";
            this.txtKillPoints.ReadOnly = true;
            this.txtKillPoints.Size = new System.Drawing.Size(88, 22);
            this.txtKillPoints.TabIndex = 10;
            // 
            // txtWinPoints
            // 
            this.txtWinPoints.BackColor = System.Drawing.SystemColors.Control;
            this.txtWinPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWinPoints.Location = new System.Drawing.Point(368, 12);
            this.txtWinPoints.Name = "txtWinPoints";
            this.txtWinPoints.ReadOnly = true;
            this.txtWinPoints.Size = new System.Drawing.Size(88, 22);
            this.txtWinPoints.TabIndex = 11;
            // 
            // txtTotalPoints
            // 
            this.txtTotalPoints.BackColor = System.Drawing.SystemColors.Control;
            this.txtTotalPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPoints.Location = new System.Drawing.Point(368, 68);
            this.txtTotalPoints.Name = "txtTotalPoints";
            this.txtTotalPoints.ReadOnly = true;
            this.txtTotalPoints.Size = new System.Drawing.Size(88, 22);
            this.txtTotalPoints.TabIndex = 12;
            // 
            // txtGlobalRank
            // 
            this.txtGlobalRank.BackColor = System.Drawing.SystemColors.Control;
            this.txtGlobalRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGlobalRank.Location = new System.Drawing.Point(368, 96);
            this.txtGlobalRank.Name = "txtGlobalRank";
            this.txtGlobalRank.ReadOnly = true;
            this.txtGlobalRank.Size = new System.Drawing.Size(88, 22);
            this.txtGlobalRank.TabIndex = 13;
            // 
            // txtKillsPerGun
            // 
            this.txtKillsPerGun.BackColor = System.Drawing.SystemColors.Control;
            this.txtKillsPerGun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKillsPerGun.Location = new System.Drawing.Point(122, 180);
            this.txtKillsPerGun.Multiline = true;
            this.txtKillsPerGun.Name = "txtKillsPerGun";
            this.txtKillsPerGun.ReadOnly = true;
            this.txtKillsPerGun.Size = new System.Drawing.Size(343, 46);
            this.txtKillsPerGun.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Wins";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Losses";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Kills";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(243, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Win Points";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(243, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Kill Points";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(243, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Total Points";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(243, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "Global Rank";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 210);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "Kills Per Gun";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(199, 273);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(125, 16);
            this.label13.TabIndex = 25;
            this.label13.Text = "Repeat Call Interval";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // pnlStats
            // 
            this.pnlStats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStats.Controls.Add(this.txtRankName);
            this.pnlStats.Controls.Add(this.label17);
            this.pnlStats.Controls.Add(this.txtKillsPerDistance);
            this.pnlStats.Controls.Add(this.label16);
            this.pnlStats.Controls.Add(this.label15);
            this.pnlStats.Controls.Add(this.txtWinPercentage);
            this.pnlStats.Controls.Add(this.label14);
            this.pnlStats.Controls.Add(this.txtKillsPerGame);
            this.pnlStats.Controls.Add(this.label3);
            this.pnlStats.Controls.Add(this.txtWinPoints);
            this.pnlStats.Controls.Add(this.label6);
            this.pnlStats.Controls.Add(this.label4);
            this.pnlStats.Controls.Add(this.txtGlobalRank);
            this.pnlStats.Controls.Add(this.txtName);
            this.pnlStats.Controls.Add(this.txtKillsPerGun);
            this.pnlStats.Controls.Add(this.txtTotalPoints);
            this.pnlStats.Controls.Add(this.label5);
            this.pnlStats.Controls.Add(this.txtWins);
            this.pnlStats.Controls.Add(this.label7);
            this.pnlStats.Controls.Add(this.label11);
            this.pnlStats.Controls.Add(this.label8);
            this.pnlStats.Controls.Add(this.txtKillPoints);
            this.pnlStats.Controls.Add(this.txtLoses);
            this.pnlStats.Controls.Add(this.label9);
            this.pnlStats.Controls.Add(this.txtKills);
            this.pnlStats.Controls.Add(this.label10);
            this.pnlStats.Location = new System.Drawing.Point(428, 11);
            this.pnlStats.Name = "pnlStats";
            this.pnlStats.Size = new System.Drawing.Size(475, 303);
            this.pnlStats.TabIndex = 26;
            // 
            // txtKillsPerDistance
            // 
            this.txtKillsPerDistance.BackColor = System.Drawing.SystemColors.Control;
            this.txtKillsPerDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKillsPerDistance.Location = new System.Drawing.Point(122, 233);
            this.txtKillsPerDistance.Multiline = true;
            this.txtKillsPerDistance.Name = "txtKillsPerDistance";
            this.txtKillsPerDistance.ReadOnly = true;
            this.txtKillsPerDistance.Size = new System.Drawing.Size(343, 45);
            this.txtKillsPerDistance.TabIndex = 27;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(10, 262);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(112, 16);
            this.label16.TabIndex = 28;
            this.label16.Text = "Kills Per Distance";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(10, 96);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 16);
            this.label15.TabIndex = 26;
            this.label15.Text = "Win %";
            // 
            // txtWinPercentage
            // 
            this.txtWinPercentage.BackColor = System.Drawing.SystemColors.Control;
            this.txtWinPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWinPercentage.Location = new System.Drawing.Point(122, 96);
            this.txtWinPercentage.Name = "txtWinPercentage";
            this.txtWinPercentage.ReadOnly = true;
            this.txtWinPercentage.Size = new System.Drawing.Size(88, 22);
            this.txtWinPercentage.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(10, 155);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 16);
            this.label14.TabIndex = 24;
            this.label14.Text = "Kills Per Round";
            // 
            // txtKillsPerGame
            // 
            this.txtKillsPerGame.BackColor = System.Drawing.SystemColors.Control;
            this.txtKillsPerGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKillsPerGame.Location = new System.Drawing.Point(122, 152);
            this.txtKillsPerGame.Name = "txtKillsPerGame";
            this.txtKillsPerGame.ReadOnly = true;
            this.txtKillsPerGame.Size = new System.Drawing.Size(88, 22);
            this.txtKillsPerGame.TabIndex = 23;
            // 
            // btnToggleStats
            // 
            this.btnToggleStats.BackColor = System.Drawing.SystemColors.Control;
            this.btnToggleStats.Location = new System.Drawing.Point(213, 334);
            this.btnToggleStats.Name = "btnToggleStats";
            this.btnToggleStats.Size = new System.Drawing.Size(123, 30);
            this.btnToggleStats.TabIndex = 27;
            this.btnToggleStats.Text = "Hide Stats";
            this.btnToggleStats.UseVisualStyleBackColor = false;
            this.btnToggleStats.Click += new System.EventHandler(this.btnToggleStats_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(54, 219);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(307, 31);
            this.label12.TabIndex = 28;
            this.label12.Text = "API Statistics to txt Files";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblError.Location = new System.Drawing.Point(12, 371);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 16);
            this.lblError.TabIndex = 29;
            // 
            // chkIncludeLabels
            // 
            this.chkIncludeLabels.AutoSize = true;
            this.chkIncludeLabels.Location = new System.Drawing.Point(317, 298);
            this.chkIncludeLabels.Name = "chkIncludeLabels";
            this.chkIncludeLabels.Size = new System.Drawing.Size(95, 17);
            this.chkIncludeLabels.TabIndex = 30;
            this.chkIncludeLabels.Text = "Include Labels";
            this.chkIncludeLabels.UseVisualStyleBackColor = true;
            // 
            // txtRankName
            // 
            this.txtRankName.BackColor = System.Drawing.SystemColors.Control;
            this.txtRankName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRankName.Location = new System.Drawing.Point(368, 124);
            this.txtRankName.Name = "txtRankName";
            this.txtRankName.ReadOnly = true;
            this.txtRankName.Size = new System.Drawing.Size(88, 22);
            this.txtRankName.TabIndex = 29;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(243, 127);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 16);
            this.label17.TabIndex = 30;
            this.label17.Text = "Rank Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(925, 374);
            this.Controls.Add(this.chkIncludeLabels);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnToggleStats);
            this.Controls.Add(this.pnlStats);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtSteamID);
            this.Controls.Add(this.btnUpdateAPI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRefreshRate);
            this.Name = "Form1";
            this.Text = "Battle Royale Stats By Keoto";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlStats.ResumeLayout(false);
            this.pnlStats.PerformLayout();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel pnlStats;
        private System.Windows.Forms.Button btnToggleStats;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtWinPercentage;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtKillsPerGame;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.CheckBox chkIncludeLabels;
        private System.Windows.Forms.TextBox txtKillsPerDistance;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtRankName;
        private System.Windows.Forms.Label label17;
    }
}

