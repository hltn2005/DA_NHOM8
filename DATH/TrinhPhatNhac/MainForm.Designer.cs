namespace TrinhPhatNhac
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
			this.lbl1 = new System.Windows.Forms.Label();
			this.lblTime = new System.Windows.Forms.Label();
			this.trackBar2 = new System.Windows.Forms.TrackBar();
			this.lblSecond = new System.Windows.Forms.Label();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.lblSinger = new System.Windows.Forms.Label();
			this.lblNameSong = new System.Windows.Forms.Label();
			this.lblPlaying = new System.Windows.Forms.Label();
			this.btnMenu = new System.Windows.Forms.Button();
			this.lblSongName = new System.Windows.Forms.Label();
			this.lblSingerName = new System.Windows.Forms.Label();
			this.btnPause = new System.Windows.Forms.Button();
			this.pctMusicPicture = new System.Windows.Forms.PictureBox();
			this.btnPlaylist = new System.Windows.Forms.Button();
			this.btnPlaylistManager = new System.Windows.Forms.Button();
			this.btnRepeat = new System.Windows.Forms.Button();
			this.btnNext = new System.Windows.Forms.Button();
			this.btnPlay = new System.Windows.Forms.Button();
			this.btnPrevious = new System.Windows.Forms.Button();
			this.btnShuffle = new System.Windows.Forms.Button();
			this.axWMP = new AxWMPLib.AxWindowsMediaPlayer();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.lblVolume = new System.Windows.Forms.Label();
			this.btnSpeed = new System.Windows.Forms.Button();
			this.cmsSpeedOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmSpeed025 = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmSpeed05 = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmSpeed075 = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmSpeed1 = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmSpeed125 = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmSpeed15 = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmSpeed175 = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmSpeed2 = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pctMusicPicture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.axWMP)).BeginInit();
			this.cmsSpeedOptions.SuspendLayout();
			this.SuspendLayout();
			// 
			// lbl1
			// 
			this.lbl1.AutoSize = true;
			this.lbl1.Location = new System.Drawing.Point(221, 543);
			this.lbl1.Name = "lbl1";
			this.lbl1.Size = new System.Drawing.Size(67, 16);
			this.lbl1.TabIndex = 42;
			this.lbl1.Text = "Âm Lượng";
			// 
			// lblTime
			// 
			this.lblTime.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.lblTime.Location = new System.Drawing.Point(351, 363);
			this.lblTime.Name = "lblTime";
			this.lblTime.Size = new System.Drawing.Size(85, 16);
			this.lblTime.TabIndex = 41;
			this.lblTime.Text = "Thời Lượng";
			this.lblTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// trackBar2
			// 
			this.trackBar2.Location = new System.Drawing.Point(342, 534);
			this.trackBar2.Maximum = 100;
			this.trackBar2.Name = "trackBar2";
			this.trackBar2.Size = new System.Drawing.Size(104, 56);
			this.trackBar2.TabIndex = 39;
			this.trackBar2.Value = 50;
			this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_Scroll);
			// 
			// lblSecond
			// 
			this.lblSecond.AutoSize = true;
			this.lblSecond.Location = new System.Drawing.Point(21, 363);
			this.lblSecond.Name = "lblSecond";
			this.lblSecond.Size = new System.Drawing.Size(35, 16);
			this.lblSecond.TabIndex = 38;
			this.lblSecond.Text = "Giây";
			// 
			// trackBar1
			// 
			this.trackBar1.Location = new System.Drawing.Point(21, 382);
			this.trackBar1.Maximum = 100;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(422, 56);
			this.trackBar1.TabIndex = 37;
			this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
			this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
			// 
			// lblSinger
			// 
			this.lblSinger.AutoSize = true;
			this.lblSinger.Location = new System.Drawing.Point(27, 113);
			this.lblSinger.Name = "lblSinger";
			this.lblSinger.Size = new System.Drawing.Size(45, 16);
			this.lblSinger.TabIndex = 36;
			this.lblSinger.Text = "Ca sĩ: ";
			// 
			// lblNameSong
			// 
			this.lblNameSong.AutoSize = true;
			this.lblNameSong.Location = new System.Drawing.Point(27, 87);
			this.lblNameSong.Name = "lblNameSong";
			this.lblNameSong.Size = new System.Drawing.Size(80, 16);
			this.lblNameSong.TabIndex = 35;
			this.lblNameSong.Text = "Tên bài hát: ";
			// 
			// lblPlaying
			// 
			this.lblPlaying.AutoSize = true;
			this.lblPlaying.Location = new System.Drawing.Point(27, 61);
			this.lblPlaying.Name = "lblPlaying";
			this.lblPlaying.Size = new System.Drawing.Size(85, 16);
			this.lblPlaying.TabIndex = 34;
			this.lblPlaying.Text = "ĐANG PHÁT";
			// 
			// btnMenu
			// 
			this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnMenu.ForeColor = System.Drawing.Color.Black;
			this.btnMenu.Location = new System.Drawing.Point(0, 0);
			this.btnMenu.Name = "btnMenu";
			this.btnMenu.Size = new System.Drawing.Size(101, 41);
			this.btnMenu.TabIndex = 51;
			this.btnMenu.Text = "Menu";
			this.btnMenu.UseVisualStyleBackColor = false;
			this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
			// 
			// lblSongName
			// 
			this.lblSongName.Location = new System.Drawing.Point(113, 87);
			this.lblSongName.Name = "lblSongName";
			this.lblSongName.Size = new System.Drawing.Size(330, 16);
			this.lblSongName.TabIndex = 52;
			// 
			// lblSingerName
			// 
			this.lblSingerName.Location = new System.Drawing.Point(78, 113);
			this.lblSingerName.Name = "lblSingerName";
			this.lblSingerName.Size = new System.Drawing.Size(330, 16);
			this.lblSingerName.TabIndex = 53;
			this.lblSingerName.Text = "\r\n";
			// 
			// btnPause
			// 
			this.btnPause.BackColor = System.Drawing.SystemColors.HighlightText;
			this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPause.Image = global::TrinhPhatNhac.Properties.Resources.Pause;
			this.btnPause.Location = new System.Drawing.Point(196, 456);
			this.btnPause.Name = "btnPause";
			this.btnPause.Size = new System.Drawing.Size(53, 43);
			this.btnPause.TabIndex = 55;
			this.btnPause.UseVisualStyleBackColor = false;
			this.btnPause.Visible = false;
			this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
			// 
			// pctMusicPicture
			// 
			this.pctMusicPicture.Image = global::TrinhPhatNhac.Properties.Resources.MusicNotes;
			this.pctMusicPicture.Location = new System.Drawing.Point(107, 148);
			this.pctMusicPicture.Name = "pctMusicPicture";
			this.pctMusicPicture.Size = new System.Drawing.Size(229, 191);
			this.pctMusicPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pctMusicPicture.TabIndex = 50;
			this.pctMusicPicture.TabStop = false;
			// 
			// btnPlaylist
			// 
			this.btnPlaylist.BackColor = System.Drawing.SystemColors.HighlightText;
			this.btnPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPlaylist.Image = global::TrinhPhatNhac.Properties.Resources.OpenPlaylist;
			this.btnPlaylist.Location = new System.Drawing.Point(24, 524);
			this.btnPlaylist.Name = "btnPlaylist";
			this.btnPlaylist.Size = new System.Drawing.Size(46, 37);
			this.btnPlaylist.TabIndex = 49;
			this.btnPlaylist.UseVisualStyleBackColor = false;
			this.btnPlaylist.Click += new System.EventHandler(this.btnPlaylist_Click);
			// 
			// btnPlaylistManager
			// 
			this.btnPlaylistManager.BackColor = System.Drawing.SystemColors.HighlightText;
			this.btnPlaylistManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPlaylistManager.Image = global::TrinhPhatNhac.Properties.Resources.ManagePlaylist;
			this.btnPlaylistManager.Location = new System.Drawing.Point(88, 524);
			this.btnPlaylistManager.Name = "btnPlaylistManager";
			this.btnPlaylistManager.Size = new System.Drawing.Size(46, 37);
			this.btnPlaylistManager.TabIndex = 48;
			this.btnPlaylistManager.UseVisualStyleBackColor = false;
			this.btnPlaylistManager.Click += new System.EventHandler(this.btnPlaylistManager_Click);
			// 
			// btnRepeat
			// 
			this.btnRepeat.BackColor = System.Drawing.SystemColors.HighlightText;
			this.btnRepeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRepeat.Image = global::TrinhPhatNhac.Properties.Resources.RepeatIcon;
			this.btnRepeat.Location = new System.Drawing.Point(365, 456);
			this.btnRepeat.Name = "btnRepeat";
			this.btnRepeat.Size = new System.Drawing.Size(53, 43);
			this.btnRepeat.TabIndex = 47;
			this.btnRepeat.UseVisualStyleBackColor = false;
			this.btnRepeat.Click += new System.EventHandler(this.btnRepeat_Click);
			// 
			// btnNext
			// 
			this.btnNext.BackColor = System.Drawing.SystemColors.HighlightText;
			this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNext.Image = global::TrinhPhatNhac.Properties.Resources.NextIcon;
			this.btnNext.Location = new System.Drawing.Point(283, 456);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(53, 43);
			this.btnNext.TabIndex = 46;
			this.btnNext.UseVisualStyleBackColor = false;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// btnPlay
			// 
			this.btnPlay.BackColor = System.Drawing.SystemColors.HighlightText;
			this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPlay.Image = global::TrinhPhatNhac.Properties.Resources.PlayIcon;
			this.btnPlay.Location = new System.Drawing.Point(196, 456);
			this.btnPlay.Name = "btnPlay";
			this.btnPlay.Size = new System.Drawing.Size(53, 43);
			this.btnPlay.TabIndex = 45;
			this.btnPlay.UseVisualStyleBackColor = false;
			this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
			// 
			// btnPrevious
			// 
			this.btnPrevious.BackColor = System.Drawing.SystemColors.HighlightText;
			this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPrevious.Image = global::TrinhPhatNhac.Properties.Resources.PreviousIcon;
			this.btnPrevious.Location = new System.Drawing.Point(107, 456);
			this.btnPrevious.Name = "btnPrevious";
			this.btnPrevious.Size = new System.Drawing.Size(53, 43);
			this.btnPrevious.TabIndex = 44;
			this.btnPrevious.UseVisualStyleBackColor = false;
			this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
			// 
			// btnShuffle
			// 
			this.btnShuffle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnShuffle.Image = global::TrinhPhatNhac.Properties.Resources.ShuffleIcon;
			this.btnShuffle.Location = new System.Drawing.Point(24, 457);
			this.btnShuffle.Name = "btnShuffle";
			this.btnShuffle.Size = new System.Drawing.Size(53, 43);
			this.btnShuffle.TabIndex = 43;
			this.btnShuffle.UseVisualStyleBackColor = false;
			this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
			// 
			// axWMP
			// 
			this.axWMP.Enabled = true;
			this.axWMP.Location = new System.Drawing.Point(21, 579);
			this.axWMP.Name = "axWMP";
			this.axWMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWMP.OcxState")));
			this.axWMP.Size = new System.Drawing.Size(75, 23);
			this.axWMP.TabIndex = 56;
			this.axWMP.Visible = false;
			this.axWMP.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWMP_PlayStateChange_1);
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 500;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// lblVolume
			// 
			this.lblVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVolume.Location = new System.Drawing.Point(294, 543);
			this.lblVolume.Name = "lblVolume";
			this.lblVolume.Size = new System.Drawing.Size(36, 21);
			this.lblVolume.TabIndex = 57;
			// 
			// btnSpeed
			// 
			this.btnSpeed.FlatAppearance.BorderSize = 0;
			this.btnSpeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSpeed.Location = new System.Drawing.Point(287, 411);
			this.btnSpeed.Name = "btnSpeed";
			this.btnSpeed.Size = new System.Drawing.Size(170, 27);
			this.btnSpeed.TabIndex = 58;
			this.btnSpeed.Text = "Tốc độ phát";
			this.btnSpeed.UseVisualStyleBackColor = true;
			this.btnSpeed.Click += new System.EventHandler(this.btnSpeed_Click);
			// 
			// cmsSpeedOptions
			// 
			this.cmsSpeedOptions.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.cmsSpeedOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSpeed025,
            this.tsmSpeed05,
            this.tsmSpeed075,
            this.tsmSpeed1,
            this.tsmSpeed125,
            this.tsmSpeed15,
            this.tsmSpeed175,
            this.tsmSpeed2});
			this.cmsSpeedOptions.Name = "cmsSpeedOptions";
			this.cmsSpeedOptions.Size = new System.Drawing.Size(198, 212);
			// 
			// tsmSpeed025
			// 
			this.tsmSpeed025.Name = "tsmSpeed025";
			this.tsmSpeed025.Size = new System.Drawing.Size(197, 26);
			this.tsmSpeed025.Text = "Rất chậm (0.25x)";
			this.tsmSpeed025.Click += new System.EventHandler(this.tsmSpeedOptions);
			// 
			// tsmSpeed05
			// 
			this.tsmSpeed05.Name = "tsmSpeed05";
			this.tsmSpeed05.Size = new System.Drawing.Size(197, 26);
			this.tsmSpeed05.Text = "Chậm (0.5x)";
			this.tsmSpeed05.Click += new System.EventHandler(this.tsmSpeedOptions);
			// 
			// tsmSpeed075
			// 
			this.tsmSpeed075.Name = "tsmSpeed075";
			this.tsmSpeed075.Size = new System.Drawing.Size(197, 26);
			this.tsmSpeed075.Text = "Hơi Chậm (0.75x)";
			this.tsmSpeed075.Click += new System.EventHandler(this.tsmSpeedOptions);
			// 
			// tsmSpeed1
			// 
			this.tsmSpeed1.Checked = true;
			this.tsmSpeed1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.tsmSpeed1.Name = "tsmSpeed1";
			this.tsmSpeed1.Size = new System.Drawing.Size(197, 26);
			this.tsmSpeed1.Text = "Bình Thường (1x)";
			this.tsmSpeed1.Click += new System.EventHandler(this.tsmSpeedOptions);
			// 
			// tsmSpeed125
			// 
			this.tsmSpeed125.Name = "tsmSpeed125";
			this.tsmSpeed125.Size = new System.Drawing.Size(197, 26);
			this.tsmSpeed125.Text = "Hơi Nhanh (1.25x)";
			this.tsmSpeed125.Click += new System.EventHandler(this.tsmSpeedOptions);
			// 
			// tsmSpeed15
			// 
			this.tsmSpeed15.Name = "tsmSpeed15";
			this.tsmSpeed15.Size = new System.Drawing.Size(197, 26);
			this.tsmSpeed15.Text = "Nhanh (1.5x)";
			this.tsmSpeed15.Click += new System.EventHandler(this.tsmSpeedOptions);
			// 
			// tsmSpeed175
			// 
			this.tsmSpeed175.Name = "tsmSpeed175";
			this.tsmSpeed175.Size = new System.Drawing.Size(197, 26);
			this.tsmSpeed175.Text = "Rất Nhanh (1.75x)";
			this.tsmSpeed175.Click += new System.EventHandler(this.tsmSpeedOptions);
			// 
			// tsmSpeed2
			// 
			this.tsmSpeed2.Name = "tsmSpeed2";
			this.tsmSpeed2.Size = new System.Drawing.Size(197, 26);
			this.tsmSpeed2.Text = "Gấp Đôi (2x)";
			this.tsmSpeed2.Click += new System.EventHandler(this.tsmSpeedOptions);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.ClientSize = new System.Drawing.Size(457, 613);
			this.Controls.Add(this.btnSpeed);
			this.Controls.Add(this.lblVolume);
			this.Controls.Add(this.axWMP);
			this.Controls.Add(this.btnPause);
			this.Controls.Add(this.lblSingerName);
			this.Controls.Add(this.lblSongName);
			this.Controls.Add(this.btnMenu);
			this.Controls.Add(this.pctMusicPicture);
			this.Controls.Add(this.btnPlaylist);
			this.Controls.Add(this.btnPlaylistManager);
			this.Controls.Add(this.btnRepeat);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.btnPlay);
			this.Controls.Add(this.btnPrevious);
			this.Controls.Add(this.btnShuffle);
			this.Controls.Add(this.lbl1);
			this.Controls.Add(this.lblTime);
			this.Controls.Add(this.trackBar2);
			this.Controls.Add(this.lblSecond);
			this.Controls.Add(this.trackBar1);
			this.Controls.Add(this.lblSinger);
			this.Controls.Add(this.lblNameSong);
			this.Controls.Add(this.lblPlaying);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "MainForm";
			this.Text = "Trình phát nhạc";
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pctMusicPicture)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.axWMP)).EndInit();
			this.cmsSpeedOptions.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pctMusicPicture;
		private System.Windows.Forms.Button btnPlaylist;
		private System.Windows.Forms.Button btnPlaylistManager;
		private System.Windows.Forms.Button btnRepeat;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Button btnPlay;
		private System.Windows.Forms.Button btnPrevious;
		private System.Windows.Forms.Button btnShuffle;
		private System.Windows.Forms.Label lbl1;
		private System.Windows.Forms.Label lblTime;
		private System.Windows.Forms.TrackBar trackBar2;
		private System.Windows.Forms.Label lblSecond;
		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.Label lblSinger;
		private System.Windows.Forms.Label lblNameSong;
		private System.Windows.Forms.Label lblPlaying;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lblSongName;
        private System.Windows.Forms.Label lblSingerName;
        private System.Windows.Forms.Button btnPause;
        private AxWMPLib.AxWindowsMediaPlayer axWMP;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Button btnSpeed;
        private System.Windows.Forms.ContextMenuStrip cmsSpeedOptions;
        private System.Windows.Forms.ToolStripMenuItem tsmSpeed05;
        private System.Windows.Forms.ToolStripMenuItem tsmSpeed075;
        private System.Windows.Forms.ToolStripMenuItem tsmSpeed1;
        private System.Windows.Forms.ToolStripMenuItem tsmSpeed125;
        private System.Windows.Forms.ToolStripMenuItem tsmSpeed15;
        private System.Windows.Forms.ToolStripMenuItem tsmSpeed2;
        private System.Windows.Forms.ToolStripMenuItem tsmSpeed025;
        private System.Windows.Forms.ToolStripMenuItem tsmSpeed175;
    }
}

