using System;
using System.Windows.Forms;
using System.Collections.Generic;

public class frmMain : Form
{
    private Label lbl1;
    private Label lbl2;
    private Label lbl3;
    private Label label4;
    private Label lblBallsNum;
    private Label lblStrikesNum;
    private Label lblOutsNum;
    private Label label8;
    private TextBox txtCatcher;
    private Label lblHomePlate;
    private TextBox txt1stBaseman;
    private TextBox txtBatter;
    private TextBox txt1stBaseRunner;
    private Label lbl1stBase;
    private Label lbl2ndBase;
    private Label lbl3rdBase;
    private TextBox txt3rdBaseman;
    private TextBox txt3rdBaseRunner;
    private TextBox txt2ndBaseRunner;
    private TextBox txt2ndBaseman;
    private Label lblTeam1;
    private Label lblTeam2;
    private Label label15;
    private Label lbl1stInningTop;
    private Label lbl1stInningBottom;
    private Label lbl2ndInningBottom;
    private Label lbl2ndInningTop;
    private Label lbl3rdInningBottom;
    private Label lbl3rdInningTop;
    private Label lbl4thInningBottom;
    private Label lbl4thInningTop;
    private Label lbl5thInningBottom;
    private Label lbl5thInningTop;
    private Label lbl6thInningBottom;
    private Label lbl6thInningTop;
    private Label lbl7thInningBottom;
    private Label lbl7thInningTop;
    private Label lbl8thInningBottom;
    private Label lbl8thInningTop;
    private Label lbl9thInningBottom;
    private Label lbl9thInningTop;
    private Label lblTeam2Runs;
    private Label lblTeam1Runs;
    private Label lblTeam2Hits;
    private Label lblTeam1Hits;
    private Label lblTeam2Errors;
    private Label lblTeam1Errors;
    private Label lblFlavorText;
    private Button btnNext;
    private Button btnNewGame;
    private ComboBox cmbTeam1Select;
    private ComboBox cmbTeam2Select;
    private TextBox txtPitcher;
    #region Windows Code
    private void InitializeComponent()
    {
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblBallsNum = new System.Windows.Forms.Label();
            this.lblStrikesNum = new System.Windows.Forms.Label();
            this.lblOutsNum = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCatcher = new System.Windows.Forms.TextBox();
            this.lblHomePlate = new System.Windows.Forms.Label();
            this.txt1stBaseman = new System.Windows.Forms.TextBox();
            this.txtBatter = new System.Windows.Forms.TextBox();
            this.txt1stBaseRunner = new System.Windows.Forms.TextBox();
            this.lbl1stBase = new System.Windows.Forms.Label();
            this.lbl2ndBase = new System.Windows.Forms.Label();
            this.lbl3rdBase = new System.Windows.Forms.Label();
            this.txt3rdBaseman = new System.Windows.Forms.TextBox();
            this.txt3rdBaseRunner = new System.Windows.Forms.TextBox();
            this.txt2ndBaseRunner = new System.Windows.Forms.TextBox();
            this.txt2ndBaseman = new System.Windows.Forms.TextBox();
            this.lblTeam1 = new System.Windows.Forms.Label();
            this.lblTeam2 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbl1stInningTop = new System.Windows.Forms.Label();
            this.lbl1stInningBottom = new System.Windows.Forms.Label();
            this.lbl2ndInningBottom = new System.Windows.Forms.Label();
            this.lbl2ndInningTop = new System.Windows.Forms.Label();
            this.lbl3rdInningBottom = new System.Windows.Forms.Label();
            this.lbl3rdInningTop = new System.Windows.Forms.Label();
            this.lbl4thInningBottom = new System.Windows.Forms.Label();
            this.lbl4thInningTop = new System.Windows.Forms.Label();
            this.lbl5thInningBottom = new System.Windows.Forms.Label();
            this.lbl5thInningTop = new System.Windows.Forms.Label();
            this.lbl6thInningBottom = new System.Windows.Forms.Label();
            this.lbl6thInningTop = new System.Windows.Forms.Label();
            this.lbl7thInningBottom = new System.Windows.Forms.Label();
            this.lbl7thInningTop = new System.Windows.Forms.Label();
            this.lbl8thInningBottom = new System.Windows.Forms.Label();
            this.lbl8thInningTop = new System.Windows.Forms.Label();
            this.lbl9thInningBottom = new System.Windows.Forms.Label();
            this.lbl9thInningTop = new System.Windows.Forms.Label();
            this.lblTeam2Runs = new System.Windows.Forms.Label();
            this.lblTeam1Runs = new System.Windows.Forms.Label();
            this.lblTeam2Hits = new System.Windows.Forms.Label();
            this.lblTeam1Hits = new System.Windows.Forms.Label();
            this.lblTeam2Errors = new System.Windows.Forms.Label();
            this.lblTeam1Errors = new System.Windows.Forms.Label();
            this.lblFlavorText = new System.Windows.Forms.Label();
            this.txtPitcher = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.cmbTeam1Select = new System.Windows.Forms.ComboBox();
            this.cmbTeam2Select = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(16, 133);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(32, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Balls:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(16, 154);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(42, 13);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Strikes:";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(16, 172);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(35, 13);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "Outs: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // lblBallsNum
            // 
            this.lblBallsNum.AutoSize = true;
            this.lblBallsNum.Location = new System.Drawing.Point(58, 133);
            this.lblBallsNum.Name = "lblBallsNum";
            this.lblBallsNum.Size = new System.Drawing.Size(13, 13);
            this.lblBallsNum.TabIndex = 4;
            this.lblBallsNum.Text = "o";
            // 
            // lblStrikesNum
            // 
            this.lblStrikesNum.AutoSize = true;
            this.lblStrikesNum.Location = new System.Drawing.Point(58, 154);
            this.lblStrikesNum.Name = "lblStrikesNum";
            this.lblStrikesNum.Size = new System.Drawing.Size(19, 13);
            this.lblStrikesNum.TabIndex = 5;
            this.lblStrikesNum.Text = "oo";
            // 
            // lblOutsNum
            // 
            this.lblOutsNum.AutoSize = true;
            this.lblOutsNum.Location = new System.Drawing.Point(58, 172);
            this.lblOutsNum.Name = "lblOutsNum";
            this.lblOutsNum.Size = new System.Drawing.Size(25, 13);
            this.lblOutsNum.TabIndex = 6;
            this.lblOutsNum.Text = "ooo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "label8";
            // 
            // txtCatcher
            // 
            this.txtCatcher.Location = new System.Drawing.Point(546, 287);
            this.txtCatcher.Name = "txtCatcher";
            this.txtCatcher.Size = new System.Drawing.Size(96, 20);
            this.txtCatcher.TabIndex = 8;
            // 
            // lblHomePlate
            // 
            this.lblHomePlate.AutoSize = true;
            this.lblHomePlate.Location = new System.Drawing.Point(603, 271);
            this.lblHomePlate.Name = "lblHomePlate";
            this.lblHomePlate.Size = new System.Drawing.Size(16, 13);
            this.lblHomePlate.TabIndex = 9;
            this.lblHomePlate.Text = "◆";
            // 
            // txt1stBaseman
            // 
            this.txt1stBaseman.Location = new System.Drawing.Point(729, 126);
            this.txt1stBaseman.Name = "txt1stBaseman";
            this.txt1stBaseman.Size = new System.Drawing.Size(100, 20);
            this.txt1stBaseman.TabIndex = 10;
            // 
            // txtBatter
            // 
            this.txtBatter.Location = new System.Drawing.Point(625, 261);
            this.txtBatter.Name = "txtBatter";
            this.txtBatter.Size = new System.Drawing.Size(100, 20);
            this.txtBatter.TabIndex = 11;
            // 
            // txt1stBaseRunner
            // 
            this.txt1stBaseRunner.Location = new System.Drawing.Point(742, 164);
            this.txt1stBaseRunner.Name = "txt1stBaseRunner";
            this.txt1stBaseRunner.Size = new System.Drawing.Size(100, 20);
            this.txt1stBaseRunner.TabIndex = 12;
            // 
            // lbl1stBase
            // 
            this.lbl1stBase.AutoSize = true;
            this.lbl1stBase.Location = new System.Drawing.Point(752, 148);
            this.lbl1stBase.Name = "lbl1stBase";
            this.lbl1stBase.Size = new System.Drawing.Size(16, 13);
            this.lbl1stBase.TabIndex = 13;
            this.lbl1stBase.Text = "◆";
            // 
            // lbl2ndBase
            // 
            this.lbl2ndBase.AutoSize = true;
            this.lbl2ndBase.Location = new System.Drawing.Point(603, 50);
            this.lbl2ndBase.Name = "lbl2ndBase";
            this.lbl2ndBase.Size = new System.Drawing.Size(16, 13);
            this.lbl2ndBase.TabIndex = 14;
            this.lbl2ndBase.Text = "◆";
            // 
            // lbl3rdBase
            // 
            this.lbl3rdBase.AutoSize = true;
            this.lbl3rdBase.Location = new System.Drawing.Point(444, 148);
            this.lbl3rdBase.Name = "lbl3rdBase";
            this.lbl3rdBase.Size = new System.Drawing.Size(16, 13);
            this.lbl3rdBase.TabIndex = 15;
            this.lbl3rdBase.Text = "◆";
            // 
            // txt3rdBaseman
            // 
            this.txt3rdBaseman.Location = new System.Drawing.Point(385, 126);
            this.txt3rdBaseman.Name = "txt3rdBaseman";
            this.txt3rdBaseman.Size = new System.Drawing.Size(100, 20);
            this.txt3rdBaseman.TabIndex = 16;
            // 
            // txt3rdBaseRunner
            // 
            this.txt3rdBaseRunner.Location = new System.Drawing.Point(360, 166);
            this.txt3rdBaseRunner.Name = "txt3rdBaseRunner";
            this.txt3rdBaseRunner.Size = new System.Drawing.Size(100, 20);
            this.txt3rdBaseRunner.TabIndex = 17;
            // 
            // txt2ndBaseRunner
            // 
            this.txt2ndBaseRunner.Location = new System.Drawing.Point(542, 29);
            this.txt2ndBaseRunner.Name = "txt2ndBaseRunner";
            this.txt2ndBaseRunner.Size = new System.Drawing.Size(100, 20);
            this.txt2ndBaseRunner.TabIndex = 18;
            // 
            // txt2ndBaseman
            // 
            this.txt2ndBaseman.Location = new System.Drawing.Point(533, 4);
            this.txt2ndBaseman.Name = "txt2ndBaseman";
            this.txt2ndBaseman.Size = new System.Drawing.Size(100, 20);
            this.txt2ndBaseman.TabIndex = 19;
            // 
            // lblTeam1
            // 
            this.lblTeam1.AutoSize = true;
            this.lblTeam1.Location = new System.Drawing.Point(29, 28);
            this.lblTeam1.Name = "lblTeam1";
            this.lblTeam1.Size = new System.Drawing.Size(29, 13);
            this.lblTeam1.TabIndex = 20;
            this.lblTeam1.Text = "BOS";
            // 
            // lblTeam2
            // 
            this.lblTeam2.AutoSize = true;
            this.lblTeam2.Location = new System.Drawing.Point(29, 45);
            this.lblTeam2.Name = "lblTeam2";
            this.lblTeam2.Size = new System.Drawing.Size(30, 13);
            this.lblTeam2.TabIndex = 21;
            this.lblTeam2.Text = "TOR";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(61, 13);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(156, 13);
            this.label15.TabIndex = 22;
            this.label15.Text = "1  2  3  4  5  6  7  8  9  R  H  E  ";
            // 
            // lbl1stInningTop
            // 
            this.lbl1stInningTop.AutoSize = true;
            this.lbl1stInningTop.Location = new System.Drawing.Point(61, 28);
            this.lbl1stInningTop.Name = "lbl1stInningTop";
            this.lbl1stInningTop.Size = new System.Drawing.Size(13, 13);
            this.lbl1stInningTop.TabIndex = 23;
            this.lbl1stInningTop.Text = "0";
            // 
            // lbl1stInningBottom
            // 
            this.lbl1stInningBottom.AutoSize = true;
            this.lbl1stInningBottom.Location = new System.Drawing.Point(61, 45);
            this.lbl1stInningBottom.Name = "lbl1stInningBottom";
            this.lbl1stInningBottom.Size = new System.Drawing.Size(13, 13);
            this.lbl1stInningBottom.TabIndex = 24;
            this.lbl1stInningBottom.Text = "0";
            // 
            // lbl2ndInningBottom
            // 
            this.lbl2ndInningBottom.AutoSize = true;
            this.lbl2ndInningBottom.Location = new System.Drawing.Point(73, 45);
            this.lbl2ndInningBottom.Name = "lbl2ndInningBottom";
            this.lbl2ndInningBottom.Size = new System.Drawing.Size(13, 13);
            this.lbl2ndInningBottom.TabIndex = 26;
            this.lbl2ndInningBottom.Text = "0";
            // 
            // lbl2ndInningTop
            // 
            this.lbl2ndInningTop.AutoSize = true;
            this.lbl2ndInningTop.Location = new System.Drawing.Point(73, 28);
            this.lbl2ndInningTop.Name = "lbl2ndInningTop";
            this.lbl2ndInningTop.Size = new System.Drawing.Size(13, 13);
            this.lbl2ndInningTop.TabIndex = 25;
            this.lbl2ndInningTop.Text = "0";
            // 
            // lbl3rdInningBottom
            // 
            this.lbl3rdInningBottom.AutoSize = true;
            this.lbl3rdInningBottom.Location = new System.Drawing.Point(85, 45);
            this.lbl3rdInningBottom.Name = "lbl3rdInningBottom";
            this.lbl3rdInningBottom.Size = new System.Drawing.Size(13, 13);
            this.lbl3rdInningBottom.TabIndex = 28;
            this.lbl3rdInningBottom.Text = "0";
            // 
            // lbl3rdInningTop
            // 
            this.lbl3rdInningTop.AutoSize = true;
            this.lbl3rdInningTop.Location = new System.Drawing.Point(85, 28);
            this.lbl3rdInningTop.Name = "lbl3rdInningTop";
            this.lbl3rdInningTop.Size = new System.Drawing.Size(13, 13);
            this.lbl3rdInningTop.TabIndex = 27;
            this.lbl3rdInningTop.Text = "0";
            // 
            // lbl4thInningBottom
            // 
            this.lbl4thInningBottom.AutoSize = true;
            this.lbl4thInningBottom.Location = new System.Drawing.Point(97, 45);
            this.lbl4thInningBottom.Name = "lbl4thInningBottom";
            this.lbl4thInningBottom.Size = new System.Drawing.Size(13, 13);
            this.lbl4thInningBottom.TabIndex = 30;
            this.lbl4thInningBottom.Text = "0";
            // 
            // lbl4thInningTop
            // 
            this.lbl4thInningTop.AutoSize = true;
            this.lbl4thInningTop.Location = new System.Drawing.Point(97, 28);
            this.lbl4thInningTop.Name = "lbl4thInningTop";
            this.lbl4thInningTop.Size = new System.Drawing.Size(13, 13);
            this.lbl4thInningTop.TabIndex = 29;
            this.lbl4thInningTop.Text = "0";
            // 
            // lbl5thInningBottom
            // 
            this.lbl5thInningBottom.AutoSize = true;
            this.lbl5thInningBottom.Location = new System.Drawing.Point(109, 45);
            this.lbl5thInningBottom.Name = "lbl5thInningBottom";
            this.lbl5thInningBottom.Size = new System.Drawing.Size(13, 13);
            this.lbl5thInningBottom.TabIndex = 32;
            this.lbl5thInningBottom.Text = "0";
            // 
            // lbl5thInningTop
            // 
            this.lbl5thInningTop.AutoSize = true;
            this.lbl5thInningTop.Location = new System.Drawing.Point(109, 28);
            this.lbl5thInningTop.Name = "lbl5thInningTop";
            this.lbl5thInningTop.Size = new System.Drawing.Size(13, 13);
            this.lbl5thInningTop.TabIndex = 31;
            this.lbl5thInningTop.Text = "0";
            // 
            // lbl6thInningBottom
            // 
            this.lbl6thInningBottom.AutoSize = true;
            this.lbl6thInningBottom.Location = new System.Drawing.Point(121, 45);
            this.lbl6thInningBottom.Name = "lbl6thInningBottom";
            this.lbl6thInningBottom.Size = new System.Drawing.Size(13, 13);
            this.lbl6thInningBottom.TabIndex = 34;
            this.lbl6thInningBottom.Text = "0";
            // 
            // lbl6thInningTop
            // 
            this.lbl6thInningTop.AutoSize = true;
            this.lbl6thInningTop.Location = new System.Drawing.Point(121, 28);
            this.lbl6thInningTop.Name = "lbl6thInningTop";
            this.lbl6thInningTop.Size = new System.Drawing.Size(13, 13);
            this.lbl6thInningTop.TabIndex = 33;
            this.lbl6thInningTop.Text = "0";
            // 
            // lbl7thInningBottom
            // 
            this.lbl7thInningBottom.AutoSize = true;
            this.lbl7thInningBottom.Location = new System.Drawing.Point(133, 45);
            this.lbl7thInningBottom.Name = "lbl7thInningBottom";
            this.lbl7thInningBottom.Size = new System.Drawing.Size(13, 13);
            this.lbl7thInningBottom.TabIndex = 36;
            this.lbl7thInningBottom.Text = "0";
            // 
            // lbl7thInningTop
            // 
            this.lbl7thInningTop.AutoSize = true;
            this.lbl7thInningTop.Location = new System.Drawing.Point(133, 28);
            this.lbl7thInningTop.Name = "lbl7thInningTop";
            this.lbl7thInningTop.Size = new System.Drawing.Size(13, 13);
            this.lbl7thInningTop.TabIndex = 35;
            this.lbl7thInningTop.Text = "0";
            // 
            // lbl8thInningBottom
            // 
            this.lbl8thInningBottom.AutoSize = true;
            this.lbl8thInningBottom.Location = new System.Drawing.Point(145, 45);
            this.lbl8thInningBottom.Name = "lbl8thInningBottom";
            this.lbl8thInningBottom.Size = new System.Drawing.Size(13, 13);
            this.lbl8thInningBottom.TabIndex = 38;
            this.lbl8thInningBottom.Text = "0";
            // 
            // lbl8thInningTop
            // 
            this.lbl8thInningTop.AutoSize = true;
            this.lbl8thInningTop.Location = new System.Drawing.Point(145, 28);
            this.lbl8thInningTop.Name = "lbl8thInningTop";
            this.lbl8thInningTop.Size = new System.Drawing.Size(13, 13);
            this.lbl8thInningTop.TabIndex = 37;
            this.lbl8thInningTop.Text = "0";
            // 
            // lbl9thInningBottom
            // 
            this.lbl9thInningBottom.AutoSize = true;
            this.lbl9thInningBottom.Location = new System.Drawing.Point(157, 45);
            this.lbl9thInningBottom.Name = "lbl9thInningBottom";
            this.lbl9thInningBottom.Size = new System.Drawing.Size(13, 13);
            this.lbl9thInningBottom.TabIndex = 40;
            this.lbl9thInningBottom.Text = "0";
            // 
            // lbl9thInningTop
            // 
            this.lbl9thInningTop.AutoSize = true;
            this.lbl9thInningTop.Location = new System.Drawing.Point(157, 28);
            this.lbl9thInningTop.Name = "lbl9thInningTop";
            this.lbl9thInningTop.Size = new System.Drawing.Size(13, 13);
            this.lbl9thInningTop.TabIndex = 39;
            this.lbl9thInningTop.Text = "0";
            // 
            // lblTeam2Runs
            // 
            this.lblTeam2Runs.AutoSize = true;
            this.lblTeam2Runs.Location = new System.Drawing.Point(170, 45);
            this.lblTeam2Runs.Name = "lblTeam2Runs";
            this.lblTeam2Runs.Size = new System.Drawing.Size(13, 13);
            this.lblTeam2Runs.TabIndex = 42;
            this.lblTeam2Runs.Text = "0";
            // 
            // lblTeam1Runs
            // 
            this.lblTeam1Runs.AutoSize = true;
            this.lblTeam1Runs.Location = new System.Drawing.Point(170, 28);
            this.lblTeam1Runs.Name = "lblTeam1Runs";
            this.lblTeam1Runs.Size = new System.Drawing.Size(13, 13);
            this.lblTeam1Runs.TabIndex = 41;
            this.lblTeam1Runs.Text = "0";
            // 
            // lblTeam2Hits
            // 
            this.lblTeam2Hits.AutoSize = true;
            this.lblTeam2Hits.Location = new System.Drawing.Point(184, 45);
            this.lblTeam2Hits.Name = "lblTeam2Hits";
            this.lblTeam2Hits.Size = new System.Drawing.Size(13, 13);
            this.lblTeam2Hits.TabIndex = 44;
            this.lblTeam2Hits.Text = "0";
            // 
            // lblTeam1Hits
            // 
            this.lblTeam1Hits.AutoSize = true;
            this.lblTeam1Hits.Location = new System.Drawing.Point(184, 28);
            this.lblTeam1Hits.Name = "lblTeam1Hits";
            this.lblTeam1Hits.Size = new System.Drawing.Size(13, 13);
            this.lblTeam1Hits.TabIndex = 43;
            this.lblTeam1Hits.Text = "0";
            // 
            // lblTeam2Errors
            // 
            this.lblTeam2Errors.AutoSize = true;
            this.lblTeam2Errors.Location = new System.Drawing.Point(198, 45);
            this.lblTeam2Errors.Name = "lblTeam2Errors";
            this.lblTeam2Errors.Size = new System.Drawing.Size(13, 13);
            this.lblTeam2Errors.TabIndex = 46;
            this.lblTeam2Errors.Text = "0";
            // 
            // lblTeam1Errors
            // 
            this.lblTeam1Errors.AutoSize = true;
            this.lblTeam1Errors.Location = new System.Drawing.Point(198, 28);
            this.lblTeam1Errors.Name = "lblTeam1Errors";
            this.lblTeam1Errors.Size = new System.Drawing.Size(13, 13);
            this.lblTeam1Errors.TabIndex = 45;
            this.lblTeam1Errors.Text = "0";
            // 
            // lblFlavorText
            // 
            this.lblFlavorText.AutoSize = true;
            this.lblFlavorText.Location = new System.Drawing.Point(16, 228);
            this.lblFlavorText.Name = "lblFlavorText";
            this.lblFlavorText.Size = new System.Drawing.Size(75, 13);
            this.lblFlavorText.TabIndex = 47;
            this.lblFlavorText.Text = "Let\'s Play Ball!";
            // 
            // txtPitcher
            // 
            this.txtPitcher.Location = new System.Drawing.Point(546, 165);
            this.txtPitcher.Name = "txtPitcher";
            this.txtPitcher.Size = new System.Drawing.Size(100, 20);
            this.txtPitcher.TabIndex = 48;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(304, 374);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(315, 23);
            this.btnNext.TabIndex = 49;
            this.btnNext.Text = "Ne&xt";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(304, 345);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(315, 23);
            this.btnNewGame.TabIndex = 50;
            this.btnNewGame.Text = "&New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            // 
            // cmbTeam1Select
            // 
            this.cmbTeam1Select.FormattingEnabled = true;
            this.cmbTeam1Select.Location = new System.Drawing.Point(18, 271);
            this.cmbTeam1Select.Name = "cmbTeam1Select";
            this.cmbTeam1Select.Size = new System.Drawing.Size(77, 21);
            this.cmbTeam1Select.TabIndex = 51;
            // 
            // cmbTeam2Select
            // 
            this.cmbTeam2Select.FormattingEnabled = true;
            this.cmbTeam2Select.Location = new System.Drawing.Point(106, 271);
            this.cmbTeam2Select.Name = "cmbTeam2Select";
            this.cmbTeam2Select.Size = new System.Drawing.Size(77, 21);
            this.cmbTeam2Select.TabIndex = 52;
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(890, 428);
            this.Controls.Add(this.cmbTeam2Select);
            this.Controls.Add(this.cmbTeam1Select);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txtPitcher);
            this.Controls.Add(this.lblFlavorText);
            this.Controls.Add(this.lblTeam2Errors);
            this.Controls.Add(this.lblTeam1Errors);
            this.Controls.Add(this.lblTeam2Hits);
            this.Controls.Add(this.lblTeam1Hits);
            this.Controls.Add(this.lblTeam2Runs);
            this.Controls.Add(this.lblTeam1Runs);
            this.Controls.Add(this.lbl9thInningBottom);
            this.Controls.Add(this.lbl9thInningTop);
            this.Controls.Add(this.lbl8thInningBottom);
            this.Controls.Add(this.lbl8thInningTop);
            this.Controls.Add(this.lbl7thInningBottom);
            this.Controls.Add(this.lbl7thInningTop);
            this.Controls.Add(this.lbl6thInningBottom);
            this.Controls.Add(this.lbl6thInningTop);
            this.Controls.Add(this.lbl5thInningBottom);
            this.Controls.Add(this.lbl5thInningTop);
            this.Controls.Add(this.lbl4thInningBottom);
            this.Controls.Add(this.lbl4thInningTop);
            this.Controls.Add(this.lbl3rdInningBottom);
            this.Controls.Add(this.lbl3rdInningTop);
            this.Controls.Add(this.lbl2ndInningBottom);
            this.Controls.Add(this.lbl2ndInningTop);
            this.Controls.Add(this.lbl1stInningBottom);
            this.Controls.Add(this.lbl1stInningTop);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblTeam2);
            this.Controls.Add(this.lblTeam1);
            this.Controls.Add(this.txt2ndBaseman);
            this.Controls.Add(this.txt2ndBaseRunner);
            this.Controls.Add(this.txt3rdBaseRunner);
            this.Controls.Add(this.txt3rdBaseman);
            this.Controls.Add(this.lbl3rdBase);
            this.Controls.Add(this.lbl2ndBase);
            this.Controls.Add(this.lbl1stBase);
            this.Controls.Add(this.txt1stBaseRunner);
            this.Controls.Add(this.txtBatter);
            this.Controls.Add(this.txt1stBaseman);
            this.Controls.Add(this.lblHomePlate);
            this.Controls.Add(this.txtCatcher);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblOutsNum);
            this.Controls.Add(this.lblStrikesNum);
            this.Controls.Add(this.lblBallsNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }
    #endregion
    public frmMain()
    {
        InitializeComponent();
    }
    [STAThread]
    public static void Main()
    {
        frmMain main = new frmMain();
        Application.Run(main);
    }

    private void frmMain_Load(object sender, EventArgs e)
    {
        // insert team names in combo box
        cmbTeam1Select.Items.Add(new KeyValuePair<string, string>("ARI", "0"));
        cmbTeam1Select.Items.Add(new KeyValuePair<string, string>("ATL", "1"));
        cmbTeam1Select.Items.Add(new KeyValuePair<string, string>("BAL", "2"));
        cmbTeam1Select.Items.Add(new KeyValuePair<string, string>("BOS", "3"));
        cmbTeam1Select.Items.Add(new KeyValuePair<string, string>("CHI", "4"));
        cmbTeam1Select.Items.Add(new KeyValuePair<string, string>("CWS", "5"));
        cmbTeam1Select.Items.Add(new KeyValuePair<string, string>("CIN", "6"));
        cmbTeam1Select.Items.Add(new KeyValuePair<string, string>("CLE", "7"));
        cmbTeam1Select.Items.Add(new KeyValuePair<string, string>("COL", "8"));
        cmbTeam1Select.Items.Add(new KeyValuePair<string, string>("DET", "9"));
        cmbTeam1Select.Items.Add(new KeyValuePair<string, string>("HOU", "10"));
        cmbTeam1Select.Items.Add(new KeyValuePair<string, string>("KC", "11"));
        cmbTeam1Select.Items.Add(new KeyValuePair<string, string>("LAA", "12"));
        cmbTeam1Select.Items.Add(new KeyValuePair<string, string>("LAD", "13"));
        cmbTeam1Select.Items.Add(new KeyValuePair<string, string>("MIA", "14"));
        cmbTeam1Select.Items.Add(new KeyValuePair<string, string>("MIL", "15"));
        cmbTeam1Select.Items.Add(new KeyValuePair<string, string>("MIN", "16"));
        cmbTeam1Select.Items.Add(new KeyValuePair<string, string>("NYM", "17"));
        cmbTeam1Select.Items.Add(new KeyValuePair<string, string>("NYY", "18"));
        cmbTeam1Select.Items.Add(new KeyValuePair<string, string>("OAK", "19"));
        cmbTeam1Select.Items.Add(new KeyValuePair<string, string>("PHI", "20"));
        cmbTeam1Select.Items.Add(new KeyValuePair<string, string>("PIT", "21"));
        cmbTeam1Select.Items.Add(new KeyValuePair<string, string>("SD", "22"));
        cmbTeam1Select.Items.Add(new KeyValuePair<string, string>("SEA", "23"));
        cmbTeam1Select.Items.Add(new KeyValuePair<string, string>("SF", "24"));
        cmbTeam1Select.Items.Add(new KeyValuePair<string, string>("STL", "25"));
        cmbTeam1Select.Items.Add(new KeyValuePair<string, string>("TB", "26"));
        cmbTeam1Select.Items.Add(new KeyValuePair<string, string>("TEX", "27"));
        cmbTeam1Select.Items.Add(new KeyValuePair<string, string>("TOR", "28"));
        cmbTeam1Select.Items.Add(new KeyValuePair<string, string>("WAS", "29"));

        cmbTeam2Select.Items.Add(new KeyValuePair<string, string>("ARI", "0"));
        cmbTeam2Select.Items.Add(new KeyValuePair<string, string>("ATL", "1"));
        cmbTeam2Select.Items.Add(new KeyValuePair<string, string>("BAL", "2"));
        cmbTeam2Select.Items.Add(new KeyValuePair<string, string>("BOS", "3"));
        cmbTeam2Select.Items.Add(new KeyValuePair<string, string>("CHI", "4"));
        cmbTeam2Select.Items.Add(new KeyValuePair<string, string>("CWS", "5"));
        cmbTeam2Select.Items.Add(new KeyValuePair<string, string>("CIN", "6"));
        cmbTeam2Select.Items.Add(new KeyValuePair<string, string>("CLE", "7"));
        cmbTeam2Select.Items.Add(new KeyValuePair<string, string>("COL", "8"));
        cmbTeam2Select.Items.Add(new KeyValuePair<string, string>("DET", "9"));
        cmbTeam2Select.Items.Add(new KeyValuePair<string, string>("HOU", "10"));
        cmbTeam2Select.Items.Add(new KeyValuePair<string, string>("KC", "11"));
        cmbTeam2Select.Items.Add(new KeyValuePair<string, string>("LAA", "12"));
        cmbTeam2Select.Items.Add(new KeyValuePair<string, string>("LAD", "13"));
        cmbTeam2Select.Items.Add(new KeyValuePair<string, string>("MIA", "14"));
        cmbTeam2Select.Items.Add(new KeyValuePair<string, string>("MIL", "15"));
        cmbTeam2Select.Items.Add(new KeyValuePair<string, string>("MIN", "16"));
        cmbTeam2Select.Items.Add(new KeyValuePair<string, string>("NYM", "17"));
        cmbTeam2Select.Items.Add(new KeyValuePair<string, string>("NYY", "18"));
        cmbTeam2Select.Items.Add(new KeyValuePair<string, string>("OAK", "19"));
        cmbTeam2Select.Items.Add(new KeyValuePair<string, string>("PHI", "20"));
        cmbTeam2Select.Items.Add(new KeyValuePair<string, string>("PIT", "21"));
        cmbTeam2Select.Items.Add(new KeyValuePair<string, string>("SD", "22"));
        cmbTeam2Select.Items.Add(new KeyValuePair<string, string>("SEA", "23"));
        cmbTeam2Select.Items.Add(new KeyValuePair<string, string>("SF", "24"));
        cmbTeam2Select.Items.Add(new KeyValuePair<string, string>("STL", "25"));
        cmbTeam2Select.Items.Add(new KeyValuePair<string, string>("TB", "26"));
        cmbTeam2Select.Items.Add(new KeyValuePair<string, string>("TEX", "27"));
        cmbTeam2Select.Items.Add(new KeyValuePair<string, string>("TOR", "28"));
        cmbTeam2Select.Items.Add(new KeyValuePair<string, string>("WAS", "29"));
    }

    private void btnNext_Click(object sender, EventArgs e)
    {

    }
}