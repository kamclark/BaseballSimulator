namespace BaseballGUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.textBoxCommentary = new System.Windows.Forms.TextBox();
            this.labelHits = new System.Windows.Forms.Label();
            this.labelSingles = new System.Windows.Forms.Label();
            this.labelDoubles = new System.Windows.Forms.Label();
            this.labelTriples = new System.Windows.Forms.Label();
            this.labelHomeruns = new System.Windows.Forms.Label();
            this.labelTotalBases = new System.Windows.Forms.Label();
            this.textBoxHits = new System.Windows.Forms.TextBox();
            this.groupBoxStats = new System.Windows.Forms.GroupBox();
            this.textBoxSluggingPercentage = new System.Windows.Forms.TextBox();
            this.textBoxOnBasePercentage = new System.Windows.Forms.TextBox();
            this.textBoxBattingAverage = new System.Windows.Forms.TextBox();
            this.labelSluggingPercentage = new System.Windows.Forms.Label();
            this.labelOnBasePercentage = new System.Windows.Forms.Label();
            this.labelBattingAverage = new System.Windows.Forms.Label();
            this.textBoxOPS = new System.Windows.Forms.TextBox();
            this.textBoxHitByPitch = new System.Windows.Forms.TextBox();
            this.textBoxOuts = new System.Windows.Forms.TextBox();
            this.textBoxStrikeouts = new System.Windows.Forms.TextBox();
            this.textBoxWalks = new System.Windows.Forms.TextBox();
            this.textBoxPlateApperances = new System.Windows.Forms.TextBox();
            this.labelPlateApperances = new System.Windows.Forms.Label();
            this.labelOPS = new System.Windows.Forms.Label();
            this.labelWalks = new System.Windows.Forms.Label();
            this.labelHitByPitch = new System.Windows.Forms.Label();
            this.labelStrikeouts = new System.Windows.Forms.Label();
            this.labelOuts = new System.Windows.Forms.Label();
            this.textBoxTotalBases = new System.Windows.Forms.TextBox();
            this.textBoxHomeruns = new System.Windows.Forms.TextBox();
            this.textBoxTriples = new System.Windows.Forms.TextBox();
            this.textBoxDoubles = new System.Windows.Forms.TextBox();
            this.textBoxSingles = new System.Windows.Forms.TextBox();
            this.groupBoxBatterInfo = new System.Windows.Forms.GroupBox();
            this.buttonAddPlayer = new System.Windows.Forms.Button();
            this.textBoxNickname = new System.Windows.Forms.TextBox();
            this.labelNickname = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.buttonSwing = new System.Windows.Forms.Button();
            this.groupBoxStats.SuspendLayout();
            this.groupBoxBatterInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxCommentary
            // 
            this.textBoxCommentary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCommentary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBoxCommentary.Location = new System.Drawing.Point(16, 12);
            this.textBoxCommentary.Multiline = true;
            this.textBoxCommentary.Name = "textBoxCommentary";
            this.textBoxCommentary.ReadOnly = true;
            this.textBoxCommentary.Size = new System.Drawing.Size(733, 48);
            this.textBoxCommentary.TabIndex = 0;
            // 
            // labelHits
            // 
            this.labelHits.AutoSize = true;
            this.labelHits.Location = new System.Drawing.Point(7, 22);
            this.labelHits.Name = "labelHits";
            this.labelHits.Size = new System.Drawing.Size(36, 17);
            this.labelHits.TabIndex = 1;
            this.labelHits.Text = "Hits:";
            // 
            // labelSingles
            // 
            this.labelSingles.AutoSize = true;
            this.labelSingles.Location = new System.Drawing.Point(7, 50);
            this.labelSingles.Name = "labelSingles";
            this.labelSingles.Size = new System.Drawing.Size(58, 17);
            this.labelSingles.TabIndex = 2;
            this.labelSingles.Text = "Singles:";
            // 
            // labelDoubles
            // 
            this.labelDoubles.AutoSize = true;
            this.labelDoubles.Location = new System.Drawing.Point(7, 78);
            this.labelDoubles.Name = "labelDoubles";
            this.labelDoubles.Size = new System.Drawing.Size(64, 17);
            this.labelDoubles.TabIndex = 3;
            this.labelDoubles.Text = "Doubles:";
            // 
            // labelTriples
            // 
            this.labelTriples.AutoSize = true;
            this.labelTriples.Location = new System.Drawing.Point(7, 106);
            this.labelTriples.Name = "labelTriples";
            this.labelTriples.Size = new System.Drawing.Size(55, 17);
            this.labelTriples.TabIndex = 4;
            this.labelTriples.Text = "Triples:";
            // 
            // labelHomeruns
            // 
            this.labelHomeruns.AutoSize = true;
            this.labelHomeruns.Location = new System.Drawing.Point(7, 134);
            this.labelHomeruns.Name = "labelHomeruns";
            this.labelHomeruns.Size = new System.Drawing.Size(77, 17);
            this.labelHomeruns.TabIndex = 5;
            this.labelHomeruns.Text = "Homeruns:";
            // 
            // labelTotalBases
            // 
            this.labelTotalBases.AutoSize = true;
            this.labelTotalBases.Location = new System.Drawing.Point(7, 162);
            this.labelTotalBases.Name = "labelTotalBases";
            this.labelTotalBases.Size = new System.Drawing.Size(87, 17);
            this.labelTotalBases.TabIndex = 6;
            this.labelTotalBases.Text = "Total Bases:";
            // 
            // textBoxHits
            // 
            this.textBoxHits.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxHits.Location = new System.Drawing.Point(96, 24);
            this.textBoxHits.Name = "textBoxHits";
            this.textBoxHits.ReadOnly = true;
            this.textBoxHits.Size = new System.Drawing.Size(56, 15);
            this.textBoxHits.TabIndex = 7;
            // 
            // groupBoxStats
            // 
            this.groupBoxStats.Controls.Add(this.textBoxSluggingPercentage);
            this.groupBoxStats.Controls.Add(this.textBoxOnBasePercentage);
            this.groupBoxStats.Controls.Add(this.textBoxBattingAverage);
            this.groupBoxStats.Controls.Add(this.labelSluggingPercentage);
            this.groupBoxStats.Controls.Add(this.labelOnBasePercentage);
            this.groupBoxStats.Controls.Add(this.labelBattingAverage);
            this.groupBoxStats.Controls.Add(this.textBoxOPS);
            this.groupBoxStats.Controls.Add(this.textBoxHitByPitch);
            this.groupBoxStats.Controls.Add(this.textBoxOuts);
            this.groupBoxStats.Controls.Add(this.textBoxStrikeouts);
            this.groupBoxStats.Controls.Add(this.textBoxWalks);
            this.groupBoxStats.Controls.Add(this.textBoxPlateApperances);
            this.groupBoxStats.Controls.Add(this.labelPlateApperances);
            this.groupBoxStats.Controls.Add(this.labelOPS);
            this.groupBoxStats.Controls.Add(this.labelWalks);
            this.groupBoxStats.Controls.Add(this.labelHitByPitch);
            this.groupBoxStats.Controls.Add(this.labelStrikeouts);
            this.groupBoxStats.Controls.Add(this.labelOuts);
            this.groupBoxStats.Controls.Add(this.textBoxTotalBases);
            this.groupBoxStats.Controls.Add(this.textBoxHomeruns);
            this.groupBoxStats.Controls.Add(this.textBoxTriples);
            this.groupBoxStats.Controls.Add(this.textBoxDoubles);
            this.groupBoxStats.Controls.Add(this.textBoxSingles);
            this.groupBoxStats.Controls.Add(this.textBoxHits);
            this.groupBoxStats.Controls.Add(this.labelHits);
            this.groupBoxStats.Controls.Add(this.labelTotalBases);
            this.groupBoxStats.Controls.Add(this.labelSingles);
            this.groupBoxStats.Controls.Add(this.labelHomeruns);
            this.groupBoxStats.Controls.Add(this.labelDoubles);
            this.groupBoxStats.Controls.Add(this.labelTriples);
            this.groupBoxStats.Location = new System.Drawing.Point(16, 66);
            this.groupBoxStats.Name = "groupBoxStats";
            this.groupBoxStats.Size = new System.Drawing.Size(432, 199);
            this.groupBoxStats.TabIndex = 8;
            this.groupBoxStats.TabStop = false;
            this.groupBoxStats.Text = "Statistics";
            // 
            // textBoxSluggingPercentage
            // 
            this.textBoxSluggingPercentage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSluggingPercentage.Location = new System.Drawing.Point(361, 80);
            this.textBoxSluggingPercentage.Name = "textBoxSluggingPercentage";
            this.textBoxSluggingPercentage.ReadOnly = true;
            this.textBoxSluggingPercentage.Size = new System.Drawing.Size(56, 15);
            this.textBoxSluggingPercentage.TabIndex = 30;
            // 
            // textBoxOnBasePercentage
            // 
            this.textBoxOnBasePercentage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxOnBasePercentage.Location = new System.Drawing.Point(361, 52);
            this.textBoxOnBasePercentage.Name = "textBoxOnBasePercentage";
            this.textBoxOnBasePercentage.ReadOnly = true;
            this.textBoxOnBasePercentage.Size = new System.Drawing.Size(56, 15);
            this.textBoxOnBasePercentage.TabIndex = 29;
            // 
            // textBoxBattingAverage
            // 
            this.textBoxBattingAverage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBattingAverage.Location = new System.Drawing.Point(361, 24);
            this.textBoxBattingAverage.Name = "textBoxBattingAverage";
            this.textBoxBattingAverage.ReadOnly = true;
            this.textBoxBattingAverage.Size = new System.Drawing.Size(56, 15);
            this.textBoxBattingAverage.TabIndex = 28;
            // 
            // labelSluggingPercentage
            // 
            this.labelSluggingPercentage.AutoSize = true;
            this.labelSluggingPercentage.Location = new System.Drawing.Point(309, 78);
            this.labelSluggingPercentage.Name = "labelSluggingPercentage";
            this.labelSluggingPercentage.Size = new System.Drawing.Size(40, 17);
            this.labelSluggingPercentage.TabIndex = 27;
            this.labelSluggingPercentage.Text = "SLG:";
            // 
            // labelOnBasePercentage
            // 
            this.labelOnBasePercentage.AutoSize = true;
            this.labelOnBasePercentage.Location = new System.Drawing.Point(309, 50);
            this.labelOnBasePercentage.Name = "labelOnBasePercentage";
            this.labelOnBasePercentage.Size = new System.Drawing.Size(41, 17);
            this.labelOnBasePercentage.TabIndex = 26;
            this.labelOnBasePercentage.Text = "OBP:";
            // 
            // labelBattingAverage
            // 
            this.labelBattingAverage.AutoSize = true;
            this.labelBattingAverage.Location = new System.Drawing.Point(309, 22);
            this.labelBattingAverage.Name = "labelBattingAverage";
            this.labelBattingAverage.Size = new System.Drawing.Size(30, 17);
            this.labelBattingAverage.TabIndex = 25;
            this.labelBattingAverage.Text = "BA:";
            // 
            // textBoxOPS
            // 
            this.textBoxOPS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxOPS.Location = new System.Drawing.Point(361, 108);
            this.textBoxOPS.Name = "textBoxOPS";
            this.textBoxOPS.ReadOnly = true;
            this.textBoxOPS.Size = new System.Drawing.Size(56, 15);
            this.textBoxOPS.TabIndex = 24;
            // 
            // textBoxHitByPitch
            // 
            this.textBoxHitByPitch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxHitByPitch.Location = new System.Drawing.Point(245, 136);
            this.textBoxHitByPitch.Name = "textBoxHitByPitch";
            this.textBoxHitByPitch.ReadOnly = true;
            this.textBoxHitByPitch.Size = new System.Drawing.Size(56, 15);
            this.textBoxHitByPitch.TabIndex = 23;
            // 
            // textBoxOuts
            // 
            this.textBoxOuts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxOuts.Location = new System.Drawing.Point(245, 108);
            this.textBoxOuts.Name = "textBoxOuts";
            this.textBoxOuts.ReadOnly = true;
            this.textBoxOuts.Size = new System.Drawing.Size(56, 15);
            this.textBoxOuts.TabIndex = 22;
            // 
            // textBoxStrikeouts
            // 
            this.textBoxStrikeouts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStrikeouts.Location = new System.Drawing.Point(245, 80);
            this.textBoxStrikeouts.Name = "textBoxStrikeouts";
            this.textBoxStrikeouts.ReadOnly = true;
            this.textBoxStrikeouts.Size = new System.Drawing.Size(56, 15);
            this.textBoxStrikeouts.TabIndex = 21;
            // 
            // textBoxWalks
            // 
            this.textBoxWalks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxWalks.Location = new System.Drawing.Point(245, 52);
            this.textBoxWalks.Name = "textBoxWalks";
            this.textBoxWalks.ReadOnly = true;
            this.textBoxWalks.Size = new System.Drawing.Size(56, 15);
            this.textBoxWalks.TabIndex = 20;
            // 
            // textBoxPlateApperances
            // 
            this.textBoxPlateApperances.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPlateApperances.Location = new System.Drawing.Point(245, 24);
            this.textBoxPlateApperances.Name = "textBoxPlateApperances";
            this.textBoxPlateApperances.ReadOnly = true;
            this.textBoxPlateApperances.Size = new System.Drawing.Size(56, 15);
            this.textBoxPlateApperances.TabIndex = 19;
            // 
            // labelPlateApperances
            // 
            this.labelPlateApperances.AutoSize = true;
            this.labelPlateApperances.Location = new System.Drawing.Point(166, 22);
            this.labelPlateApperances.Name = "labelPlateApperances";
            this.labelPlateApperances.Size = new System.Drawing.Size(34, 17);
            this.labelPlateApperances.TabIndex = 13;
            this.labelPlateApperances.Text = "PA: ";
            // 
            // labelOPS
            // 
            this.labelOPS.AutoSize = true;
            this.labelOPS.Location = new System.Drawing.Point(309, 106);
            this.labelOPS.Name = "labelOPS";
            this.labelOPS.Size = new System.Drawing.Size(41, 17);
            this.labelOPS.TabIndex = 18;
            this.labelOPS.Text = "OPS:";
            // 
            // labelWalks
            // 
            this.labelWalks.AutoSize = true;
            this.labelWalks.Location = new System.Drawing.Point(166, 50);
            this.labelWalks.Name = "labelWalks";
            this.labelWalks.Size = new System.Drawing.Size(50, 17);
            this.labelWalks.TabIndex = 14;
            this.labelWalks.Text = "Walks:";
            // 
            // labelHitByPitch
            // 
            this.labelHitByPitch.AutoSize = true;
            this.labelHitByPitch.Location = new System.Drawing.Point(166, 134);
            this.labelHitByPitch.Name = "labelHitByPitch";
            this.labelHitByPitch.Size = new System.Drawing.Size(40, 17);
            this.labelHitByPitch.TabIndex = 17;
            this.labelHitByPitch.Text = "HBP:";
            // 
            // labelStrikeouts
            // 
            this.labelStrikeouts.AutoSize = true;
            this.labelStrikeouts.Location = new System.Drawing.Point(166, 78);
            this.labelStrikeouts.Name = "labelStrikeouts";
            this.labelStrikeouts.Size = new System.Drawing.Size(75, 17);
            this.labelStrikeouts.TabIndex = 15;
            this.labelStrikeouts.Text = "Strikeouts:";
            // 
            // labelOuts
            // 
            this.labelOuts.AutoSize = true;
            this.labelOuts.Location = new System.Drawing.Point(166, 106);
            this.labelOuts.Name = "labelOuts";
            this.labelOuts.Size = new System.Drawing.Size(42, 17);
            this.labelOuts.TabIndex = 16;
            this.labelOuts.Text = "Outs:";
            // 
            // textBoxTotalBases
            // 
            this.textBoxTotalBases.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTotalBases.Location = new System.Drawing.Point(96, 164);
            this.textBoxTotalBases.Name = "textBoxTotalBases";
            this.textBoxTotalBases.ReadOnly = true;
            this.textBoxTotalBases.Size = new System.Drawing.Size(56, 15);
            this.textBoxTotalBases.TabIndex = 12;
            // 
            // textBoxHomeruns
            // 
            this.textBoxHomeruns.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxHomeruns.Location = new System.Drawing.Point(96, 136);
            this.textBoxHomeruns.Name = "textBoxHomeruns";
            this.textBoxHomeruns.ReadOnly = true;
            this.textBoxHomeruns.Size = new System.Drawing.Size(56, 15);
            this.textBoxHomeruns.TabIndex = 11;
            // 
            // textBoxTriples
            // 
            this.textBoxTriples.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTriples.Location = new System.Drawing.Point(96, 108);
            this.textBoxTriples.Name = "textBoxTriples";
            this.textBoxTriples.ReadOnly = true;
            this.textBoxTriples.Size = new System.Drawing.Size(56, 15);
            this.textBoxTriples.TabIndex = 10;
            // 
            // textBoxDoubles
            // 
            this.textBoxDoubles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDoubles.Location = new System.Drawing.Point(96, 80);
            this.textBoxDoubles.Name = "textBoxDoubles";
            this.textBoxDoubles.ReadOnly = true;
            this.textBoxDoubles.Size = new System.Drawing.Size(56, 15);
            this.textBoxDoubles.TabIndex = 9;
            // 
            // textBoxSingles
            // 
            this.textBoxSingles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSingles.Location = new System.Drawing.Point(96, 52);
            this.textBoxSingles.Name = "textBoxSingles";
            this.textBoxSingles.ReadOnly = true;
            this.textBoxSingles.Size = new System.Drawing.Size(56, 15);
            this.textBoxSingles.TabIndex = 8;
            // 
            // groupBoxBatterInfo
            // 
            this.groupBoxBatterInfo.Controls.Add(this.buttonAddPlayer);
            this.groupBoxBatterInfo.Controls.Add(this.textBoxNickname);
            this.groupBoxBatterInfo.Controls.Add(this.labelNickname);
            this.groupBoxBatterInfo.Controls.Add(this.textBoxLastName);
            this.groupBoxBatterInfo.Controls.Add(this.labelLastName);
            this.groupBoxBatterInfo.Controls.Add(this.textBoxFirstName);
            this.groupBoxBatterInfo.Controls.Add(this.labelFirstName);
            this.groupBoxBatterInfo.Location = new System.Drawing.Point(467, 66);
            this.groupBoxBatterInfo.Name = "groupBoxBatterInfo";
            this.groupBoxBatterInfo.Size = new System.Drawing.Size(282, 151);
            this.groupBoxBatterInfo.TabIndex = 9;
            this.groupBoxBatterInfo.TabStop = false;
            this.groupBoxBatterInfo.Text = "Batter Info";
            // 
            // buttonAddPlayer
            // 
            this.buttonAddPlayer.Location = new System.Drawing.Point(54, 106);
            this.buttonAddPlayer.Name = "buttonAddPlayer";
            this.buttonAddPlayer.Size = new System.Drawing.Size(189, 35);
            this.buttonAddPlayer.TabIndex = 34;
            this.buttonAddPlayer.Text = "Create &Player";
            this.buttonAddPlayer.UseVisualStyleBackColor = true;
            this.buttonAddPlayer.Click += new System.EventHandler(this.ButtonAddPlayer_Click);
            // 
            // textBoxNickname
            // 
            this.textBoxNickname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNickname.Location = new System.Drawing.Point(88, 78);
            this.textBoxNickname.Name = "textBoxNickname";
            this.textBoxNickname.Size = new System.Drawing.Size(179, 15);
            this.textBoxNickname.TabIndex = 33;
            // 
            // labelNickname
            // 
            this.labelNickname.AutoSize = true;
            this.labelNickname.Location = new System.Drawing.Point(6, 78);
            this.labelNickname.Name = "labelNickname";
            this.labelNickname.Size = new System.Drawing.Size(74, 17);
            this.labelNickname.TabIndex = 2;
            this.labelNickname.Text = "Nickname:";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLastName.Location = new System.Drawing.Point(88, 50);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(179, 15);
            this.textBoxLastName.TabIndex = 32;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(6, 50);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(69, 17);
            this.labelLastName.TabIndex = 1;
            this.labelLastName.Text = "Surname:";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFirstName.Location = new System.Drawing.Point(88, 22);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(179, 15);
            this.textBoxFirstName.TabIndex = 31;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(7, 22);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(80, 17);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "First Name:";
            // 
            // buttonSwing
            // 
            this.buttonSwing.Enabled = false;
            this.buttonSwing.Location = new System.Drawing.Point(318, 281);
            this.buttonSwing.Name = "buttonSwing";
            this.buttonSwing.Size = new System.Drawing.Size(300, 35);
            this.buttonSwing.TabIndex = 10;
            this.buttonSwing.Text = " &Swing";
            this.buttonSwing.UseVisualStyleBackColor = true;
            this.buttonSwing.Click += new System.EventHandler(this.ButtonSwing_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 402);
            this.Controls.Add(this.buttonSwing);
            this.Controls.Add(this.groupBoxBatterInfo);
            this.Controls.Add(this.groupBoxStats);
            this.Controls.Add(this.textBoxCommentary);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Play Ball!";
            this.groupBoxStats.ResumeLayout(false);
            this.groupBoxStats.PerformLayout();
            this.groupBoxBatterInfo.ResumeLayout(false);
            this.groupBoxBatterInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCommentary;
        private System.Windows.Forms.Label labelHits;
        private System.Windows.Forms.Label labelSingles;
        private System.Windows.Forms.Label labelDoubles;
        private System.Windows.Forms.Label labelTriples;
        private System.Windows.Forms.Label labelHomeruns;
        private System.Windows.Forms.Label labelTotalBases;
        private System.Windows.Forms.TextBox textBoxHits;
        private System.Windows.Forms.GroupBox groupBoxStats;
        private System.Windows.Forms.TextBox textBoxSluggingPercentage;
        private System.Windows.Forms.TextBox textBoxOnBasePercentage;
        private System.Windows.Forms.TextBox textBoxBattingAverage;
        private System.Windows.Forms.Label labelSluggingPercentage;
        private System.Windows.Forms.Label labelOnBasePercentage;
        private System.Windows.Forms.Label labelBattingAverage;
        private System.Windows.Forms.TextBox textBoxOPS;
        private System.Windows.Forms.TextBox textBoxHitByPitch;
        private System.Windows.Forms.TextBox textBoxOuts;
        private System.Windows.Forms.TextBox textBoxStrikeouts;
        private System.Windows.Forms.TextBox textBoxWalks;
        private System.Windows.Forms.TextBox textBoxPlateApperances;
        private System.Windows.Forms.Label labelPlateApperances;
        private System.Windows.Forms.Label labelOPS;
        private System.Windows.Forms.Label labelWalks;
        private System.Windows.Forms.Label labelHitByPitch;
        private System.Windows.Forms.Label labelStrikeouts;
        private System.Windows.Forms.Label labelOuts;
        private System.Windows.Forms.TextBox textBoxTotalBases;
        private System.Windows.Forms.TextBox textBoxHomeruns;
        private System.Windows.Forms.TextBox textBoxTriples;
        private System.Windows.Forms.TextBox textBoxDoubles;
        private System.Windows.Forms.TextBox textBoxSingles;
        private System.Windows.Forms.GroupBox groupBoxBatterInfo;
        private System.Windows.Forms.TextBox textBoxNickname;
        private System.Windows.Forms.Label labelNickname;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Button buttonSwing;
        private System.Windows.Forms.Button buttonAddPlayer;
    }
}

