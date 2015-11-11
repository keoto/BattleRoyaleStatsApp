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
            this.txtRankName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRefreshRate
            // 
            this.txtRefreshRate.Location = new System.Drawing.Point(267, 281);
            this.txtRefreshRate.Name = "txtRefreshRate";
            this.txtRefreshRate.Size = new System.Drawing.Size(29, 20);
            this.txtRefreshRate.TabIndex = 0;
            this.txtRefreshRate.Text = "60";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(31, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Steam ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "(minutes)";
            // 
            // btnUpdateAPI
            // 
            this.btnUpdateAPI.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdateAPI.Location = new System.Drawing.Point(486, 281);
            this.btnUpdateAPI.Name = "btnUpdateAPI";
            this.btnUpdateAPI.Size = new System.Drawing.Size(123, 40);
            this.btnUpdateAPI.TabIndex = 3;
            this.btnUpdateAPI.Text = "Get Data";
            this.btnUpdateAPI.UseVisualStyleBackColor = false;
            this.btnUpdateAPI.Click += new System.EventHandler(this.btnUpdateAPI_Click);
            // 
            // txtSteamID
            // 
            this.txtSteamID.Location = new System.Drawing.Point(34, 281);
            this.txtSteamID.Name = "txtSteamID";
            this.txtSteamID.Size = new System.Drawing.Size(180, 20);
            this.txtSteamID.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(457, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Control;
            this.txtName.Location = new System.Drawing.Point(533, 20);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 6;
            // 
            // txtWins
            // 
            this.txtWins.BackColor = System.Drawing.SystemColors.Control;
            this.txtWins.Location = new System.Drawing.Point(533, 46);
            this.txtWins.Name = "txtWins";
            this.txtWins.ReadOnly = true;
            this.txtWins.Size = new System.Drawing.Size(100, 20);
            this.txtWins.TabIndex = 7;
            // 
            // txtLoses
            // 
            this.txtLoses.BackColor = System.Drawing.SystemColors.Control;
            this.txtLoses.Location = new System.Drawing.Point(533, 72);
            this.txtLoses.Name = "txtLoses";
            this.txtLoses.ReadOnly = true;
            this.txtLoses.Size = new System.Drawing.Size(100, 20);
            this.txtLoses.TabIndex = 8;
            // 
            // txtKills
            // 
            this.txtKills.BackColor = System.Drawing.SystemColors.Control;
            this.txtKills.Location = new System.Drawing.Point(533, 98);
            this.txtKills.Name = "txtKills";
            this.txtKills.ReadOnly = true;
            this.txtKills.Size = new System.Drawing.Size(100, 20);
            this.txtKills.TabIndex = 9;
            // 
            // txtKillPoints
            // 
            this.txtKillPoints.BackColor = System.Drawing.SystemColors.Control;
            this.txtKillPoints.Location = new System.Drawing.Point(533, 150);
            this.txtKillPoints.Name = "txtKillPoints";
            this.txtKillPoints.ReadOnly = true;
            this.txtKillPoints.Size = new System.Drawing.Size(100, 20);
            this.txtKillPoints.TabIndex = 10;
            // 
            // txtWinPoints
            // 
            this.txtWinPoints.BackColor = System.Drawing.SystemColors.Control;
            this.txtWinPoints.Location = new System.Drawing.Point(533, 124);
            this.txtWinPoints.Name = "txtWinPoints";
            this.txtWinPoints.ReadOnly = true;
            this.txtWinPoints.Size = new System.Drawing.Size(100, 20);
            this.txtWinPoints.TabIndex = 11;
            // 
            // txtTotalPoints
            // 
            this.txtTotalPoints.BackColor = System.Drawing.SystemColors.Control;
            this.txtTotalPoints.Location = new System.Drawing.Point(533, 176);
            this.txtTotalPoints.Name = "txtTotalPoints";
            this.txtTotalPoints.ReadOnly = true;
            this.txtTotalPoints.Size = new System.Drawing.Size(100, 20);
            this.txtTotalPoints.TabIndex = 12;
            // 
            // txtGlobalRank
            // 
            this.txtGlobalRank.BackColor = System.Drawing.SystemColors.Control;
            this.txtGlobalRank.Location = new System.Drawing.Point(533, 202);
            this.txtGlobalRank.Name = "txtGlobalRank";
            this.txtGlobalRank.ReadOnly = true;
            this.txtGlobalRank.Size = new System.Drawing.Size(100, 20);
            this.txtGlobalRank.TabIndex = 13;
            // 
            // txtRankName
            // 
            this.txtRankName.BackColor = System.Drawing.SystemColors.Control;
            this.txtRankName.Location = new System.Drawing.Point(533, 228);
            this.txtRankName.Name = "txtRankName";
            this.txtRankName.ReadOnly = true;
            this.txtRankName.Size = new System.Drawing.Size(100, 20);
            this.txtRankName.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(457, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Wins";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(457, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Losses";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(457, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Kills";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(457, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Win Points";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(457, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Kill Points";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(457, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Total Points";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(457, 209);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Global Rank";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(457, 235);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Rank Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 361);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(358, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Application Developed by Keoto.  Contact information keoto@outlook.com";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label13.Location = new System.Drawing.Point(264, 265);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Repeat Call Interval";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 336);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(317, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "txt files are stored in My Documents / BattleRoyaleStatFiles folder.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(698, 383);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRankName);
            this.Controls.Add(this.txtGlobalRank);
            this.Controls.Add(this.txtTotalPoints);
            this.Controls.Add(this.txtWinPoints);
            this.Controls.Add(this.txtKillPoints);
            this.Controls.Add(this.txtKills);
            this.Controls.Add(this.txtLoses);
            this.Controls.Add(this.txtWins);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSteamID);
            this.Controls.Add(this.btnUpdateAPI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRefreshRate);
            this.Name = "Form1";
            this.Text = "Battle Royale Stats By Keoto";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.TextBox txtRankName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}

