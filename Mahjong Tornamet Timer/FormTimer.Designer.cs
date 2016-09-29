namespace Mahjong_Tornamet_Timer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblTime = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.imgMMLogo = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnChangeMaxTime = new System.Windows.Forms.Button();
            this.lblRound = new System.Windows.Forms.Label();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.btnReplay = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.lblRoundNum = new System.Windows.Forms.Label();
            this.btnRoundUp = new System.Windows.Forms.Button();
            this.btnRoundDown = new System.Windows.Forms.Button();
            this.btnLblTimeUp = new System.Windows.Forms.Button();
            this.btnLblTimeRight = new System.Windows.Forms.Button();
            this.btnLblTimeDown = new System.Windows.Forms.Button();
            this.btnLblTimeLeft = new System.Windows.Forms.Button();
            this.newProgressBarTimer = new Mahjong_Tournament_Timer.NewProgressBar();
            this.btnLogoSettings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgMMLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTime.Font = new System.Drawing.Font("Gang of Three", 240F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTime.Location = new System.Drawing.Point(-229, 60);
            this.lblTime.Margin = new System.Windows.Forms.Padding(0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(1833, 611);
            this.lblTime.TabIndex = 0;
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTime.Paint += new System.Windows.Forms.PaintEventHandler(this.labelTime_Paint);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(1316, 9);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(50, 50);
            this.btnExit.TabIndex = 1;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlay.BackgroundImage")));
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Location = new System.Drawing.Point(661, 674);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(0);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(50, 50);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPause
            // 
            this.btnPause.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPause.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPause.BackgroundImage")));
            this.btnPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPause.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPause.FlatAppearance.BorderSize = 0;
            this.btnPause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnPause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Location = new System.Drawing.Point(661, 674);
            this.btnPause.Margin = new System.Windows.Forms.Padding(0);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(50, 50);
            this.btnPause.TabIndex = 3;
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Visible = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReset.BackgroundImage")));
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Location = new System.Drawing.Point(62, 674);
            this.btnReset.Margin = new System.Windows.Forms.Padding(0);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(50, 50);
            this.btnReset.TabIndex = 5;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // imgMMLogo
            // 
            this.imgMMLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imgMMLogo.BackgroundImage")));
            this.imgMMLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.imgMMLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgMMLogo.Location = new System.Drawing.Point(12, 12);
            this.imgMMLogo.Name = "imgMMLogo";
            this.imgMMLogo.Size = new System.Drawing.Size(150, 150);
            this.imgMMLogo.TabIndex = 7;
            this.imgMMLogo.TabStop = false;
            this.imgMMLogo.Click += new System.EventHandler(this.imgMMLogo_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimize.BackgroundImage")));
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(1216, 9);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(50, 50);
            this.btnMinimize.TabIndex = 8;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnChangeMaxTime
            // 
            this.btnChangeMaxTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnChangeMaxTime.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnChangeMaxTime.BackgroundImage")));
            this.btnChangeMaxTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeMaxTime.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnChangeMaxTime.FlatAppearance.BorderSize = 0;
            this.btnChangeMaxTime.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnChangeMaxTime.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnChangeMaxTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeMaxTime.Location = new System.Drawing.Point(12, 674);
            this.btnChangeMaxTime.Margin = new System.Windows.Forms.Padding(0);
            this.btnChangeMaxTime.Name = "btnChangeMaxTime";
            this.btnChangeMaxTime.Size = new System.Drawing.Size(50, 50);
            this.btnChangeMaxTime.TabIndex = 10;
            this.btnChangeMaxTime.UseVisualStyleBackColor = true;
            this.btnChangeMaxTime.Click += new System.EventHandler(this.btnChangeMaxTime_Click);
            // 
            // lblRound
            // 
            this.lblRound.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRound.AutoSize = true;
            this.lblRound.Font = new System.Drawing.Font("Gang of Three", 50F);
            this.lblRound.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRound.Location = new System.Drawing.Point(541, 60);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(231, 75);
            this.lblRound.TabIndex = 11;
            this.lblRound.Text = "Round";
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZoomIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnZoomIn.BackgroundImage")));
            this.btnZoomIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZoomIn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnZoomIn.FlatAppearance.BorderSize = 0;
            this.btnZoomIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnZoomIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnZoomIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoomIn.Location = new System.Drawing.Point(1275, 674);
            this.btnZoomIn.Margin = new System.Windows.Forms.Padding(0);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(50, 50);
            this.btnZoomIn.TabIndex = 13;
            this.btnZoomIn.UseVisualStyleBackColor = true;
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZoomOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnZoomOut.BackgroundImage")));
            this.btnZoomOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnZoomOut.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnZoomOut.FlatAppearance.BorderSize = 0;
            this.btnZoomOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnZoomOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnZoomOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoomOut.Location = new System.Drawing.Point(1225, 674);
            this.btnZoomOut.Margin = new System.Windows.Forms.Padding(0);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(50, 50);
            this.btnZoomOut.TabIndex = 14;
            this.btnZoomOut.UseVisualStyleBackColor = true;
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // btnReplay
            // 
            this.btnReplay.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnReplay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReplay.BackgroundImage")));
            this.btnReplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReplay.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnReplay.FlatAppearance.BorderSize = 0;
            this.btnReplay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnReplay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnReplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReplay.Location = new System.Drawing.Point(661, 674);
            this.btnReplay.Margin = new System.Windows.Forms.Padding(0);
            this.btnReplay.Name = "btnReplay";
            this.btnReplay.Size = new System.Drawing.Size(50, 50);
            this.btnReplay.TabIndex = 15;
            this.btnReplay.UseVisualStyleBackColor = true;
            this.btnReplay.Visible = false;
            this.btnReplay.Click += new System.EventHandler(this.btnReplay_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMaximize.BackgroundImage")));
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximize.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Location = new System.Drawing.Point(1266, 9);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(50, 50);
            this.btnMaximize.TabIndex = 16;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // lblRoundNum
            // 
            this.lblRoundNum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRoundNum.AutoSize = true;
            this.lblRoundNum.Font = new System.Drawing.Font("Gang of Three", 50F);
            this.lblRoundNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblRoundNum.Location = new System.Drawing.Point(767, 60);
            this.lblRoundNum.Name = "lblRoundNum";
            this.lblRoundNum.Size = new System.Drawing.Size(68, 75);
            this.lblRoundNum.TabIndex = 17;
            this.lblRoundNum.Text = "1";
            // 
            // btnRoundUp
            // 
            this.btnRoundUp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRoundUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRoundUp.BackgroundImage")));
            this.btnRoundUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoundUp.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRoundUp.FlatAppearance.BorderSize = 0;
            this.btnRoundUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnRoundUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnRoundUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoundUp.Location = new System.Drawing.Point(755, 76);
            this.btnRoundUp.Margin = new System.Windows.Forms.Padding(0);
            this.btnRoundUp.Name = "btnRoundUp";
            this.btnRoundUp.Size = new System.Drawing.Size(24, 24);
            this.btnRoundUp.TabIndex = 18;
            this.btnRoundUp.UseVisualStyleBackColor = true;
            this.btnRoundUp.Click += new System.EventHandler(this.btnRoundUp_Click);
            // 
            // btnRoundDown
            // 
            this.btnRoundDown.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRoundDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRoundDown.BackgroundImage")));
            this.btnRoundDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoundDown.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRoundDown.FlatAppearance.BorderSize = 0;
            this.btnRoundDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnRoundDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnRoundDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoundDown.Location = new System.Drawing.Point(755, 100);
            this.btnRoundDown.Margin = new System.Windows.Forms.Padding(0);
            this.btnRoundDown.Name = "btnRoundDown";
            this.btnRoundDown.Size = new System.Drawing.Size(24, 24);
            this.btnRoundDown.TabIndex = 19;
            this.btnRoundDown.UseVisualStyleBackColor = true;
            this.btnRoundDown.Click += new System.EventHandler(this.btnRoundDown_Click);
            // 
            // btnLblTimeUp
            // 
            this.btnLblTimeUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLblTimeUp.BackColor = System.Drawing.Color.Transparent;
            this.btnLblTimeUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLblTimeUp.BackgroundImage")));
            this.btnLblTimeUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLblTimeUp.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLblTimeUp.FlatAppearance.BorderSize = 0;
            this.btnLblTimeUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnLblTimeUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnLblTimeUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLblTimeUp.Location = new System.Drawing.Point(1340, 682);
            this.btnLblTimeUp.Margin = new System.Windows.Forms.Padding(0);
            this.btnLblTimeUp.Name = "btnLblTimeUp";
            this.btnLblTimeUp.Size = new System.Drawing.Size(12, 12);
            this.btnLblTimeUp.TabIndex = 20;
            this.btnLblTimeUp.UseVisualStyleBackColor = false;
            this.btnLblTimeUp.Click += new System.EventHandler(this.btnLblTimeUp_Click);
            // 
            // btnLblTimeRight
            // 
            this.btnLblTimeRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLblTimeRight.BackColor = System.Drawing.Color.Transparent;
            this.btnLblTimeRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLblTimeRight.BackgroundImage")));
            this.btnLblTimeRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLblTimeRight.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLblTimeRight.FlatAppearance.BorderSize = 0;
            this.btnLblTimeRight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnLblTimeRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnLblTimeRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLblTimeRight.Location = new System.Drawing.Point(1352, 693);
            this.btnLblTimeRight.Margin = new System.Windows.Forms.Padding(0);
            this.btnLblTimeRight.Name = "btnLblTimeRight";
            this.btnLblTimeRight.Size = new System.Drawing.Size(12, 12);
            this.btnLblTimeRight.TabIndex = 21;
            this.btnLblTimeRight.UseVisualStyleBackColor = false;
            this.btnLblTimeRight.Click += new System.EventHandler(this.btnLblTimeRight_Click);
            // 
            // btnLblTimeDown
            // 
            this.btnLblTimeDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLblTimeDown.BackColor = System.Drawing.Color.Transparent;
            this.btnLblTimeDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLblTimeDown.BackgroundImage")));
            this.btnLblTimeDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLblTimeDown.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLblTimeDown.FlatAppearance.BorderSize = 0;
            this.btnLblTimeDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnLblTimeDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnLblTimeDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLblTimeDown.Location = new System.Drawing.Point(1340, 705);
            this.btnLblTimeDown.Margin = new System.Windows.Forms.Padding(0);
            this.btnLblTimeDown.Name = "btnLblTimeDown";
            this.btnLblTimeDown.Size = new System.Drawing.Size(12, 12);
            this.btnLblTimeDown.TabIndex = 22;
            this.btnLblTimeDown.UseVisualStyleBackColor = false;
            this.btnLblTimeDown.Click += new System.EventHandler(this.btnLblTimeDown_Click);
            // 
            // btnLblTimeLeft
            // 
            this.btnLblTimeLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLblTimeLeft.BackColor = System.Drawing.Color.Transparent;
            this.btnLblTimeLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLblTimeLeft.BackgroundImage")));
            this.btnLblTimeLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLblTimeLeft.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLblTimeLeft.FlatAppearance.BorderSize = 0;
            this.btnLblTimeLeft.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnLblTimeLeft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnLblTimeLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLblTimeLeft.Location = new System.Drawing.Point(1328, 693);
            this.btnLblTimeLeft.Margin = new System.Windows.Forms.Padding(0);
            this.btnLblTimeLeft.Name = "btnLblTimeLeft";
            this.btnLblTimeLeft.Size = new System.Drawing.Size(12, 12);
            this.btnLblTimeLeft.TabIndex = 23;
            this.btnLblTimeLeft.UseVisualStyleBackColor = false;
            this.btnLblTimeLeft.Click += new System.EventHandler(this.btnLblTimeLeft_Click);
            // 
            // newProgressBarTimer
            // 
            this.newProgressBarTimer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newProgressBarTimer.ForeColor = System.Drawing.Color.White;
            this.newProgressBarTimer.Location = new System.Drawing.Point(0, 583);
            this.newProgressBarTimer.Maximum = 7200;
            this.newProgressBarTimer.Name = "newProgressBarTimer";
            this.newProgressBarTimer.Size = new System.Drawing.Size(1375, 3);
            this.newProgressBarTimer.Step = 1;
            this.newProgressBarTimer.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.newProgressBarTimer.TabIndex = 9;
            // 
            // btnLogoSettings
            // 
            this.btnLogoSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnLogoSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogoSettings.BackgroundImage")));
            this.btnLogoSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogoSettings.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogoSettings.FlatAppearance.BorderSize = 0;
            this.btnLogoSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnLogoSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnLogoSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogoSettings.Location = new System.Drawing.Point(12, 12);
            this.btnLogoSettings.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogoSettings.Name = "btnLogoSettings";
            this.btnLogoSettings.Size = new System.Drawing.Size(24, 24);
            this.btnLogoSettings.TabIndex = 24;
            this.btnLogoSettings.UseVisualStyleBackColor = false;
            this.btnLogoSettings.Click += new System.EventHandler(this.btnLogoSetting_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1375, 733);
            this.Controls.Add(this.btnLogoSettings);
            this.Controls.Add(this.btnLblTimeLeft);
            this.Controls.Add(this.btnLblTimeDown);
            this.Controls.Add(this.btnLblTimeRight);
            this.Controls.Add(this.btnLblTimeUp);
            this.Controls.Add(this.btnRoundDown);
            this.Controls.Add(this.btnRoundUp);
            this.Controls.Add(this.lblRoundNum);
            this.Controls.Add(this.btnMaximize);
            this.Controls.Add(this.btnReplay);
            this.Controls.Add(this.btnZoomOut);
            this.Controls.Add(this.btnZoomIn);
            this.Controls.Add(this.lblRound);
            this.Controls.Add(this.btnChangeMaxTime);
            this.Controls.Add(this.newProgressBarTimer);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.imgMMLogo);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTime);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.imgMMLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.PictureBox imgMMLogo;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnMinimize;
        private Mahjong_Tournament_Timer.NewProgressBar newProgressBarTimer;
        private System.Windows.Forms.Button btnChangeMaxTime;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.Button btnReplay;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Label lblRoundNum;
        private System.Windows.Forms.Button btnRoundUp;
        private System.Windows.Forms.Button btnRoundDown;
        private System.Windows.Forms.Button btnLblTimeUp;
        private System.Windows.Forms.Button btnLblTimeRight;
        private System.Windows.Forms.Button btnLblTimeDown;
        private System.Windows.Forms.Button btnLblTimeLeft;
        private System.Windows.Forms.Button btnLogoSettings;
    }
}

