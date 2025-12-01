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
<<<<<<< HEAD
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.lblVolume = new System.Windows.Forms.Label();
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
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.axWMP = new AxWMPLib.AxWindowsMediaPlayer();
			((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pctMusicPicture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.axWMP)).BeginInit();
			this.SuspendLayout();
			// 
			// lblVolume
			// 
			this.lblVolume.AutoSize = true;
			this.lblVolume.Location = new System.Drawing.Point(236, 526);
			this.lblVolume.Name = "lblVolume";
			this.lblVolume.Size = new System.Drawing.Size(67, 16);
			this.lblVolume.TabIndex = 42;
			this.lblVolume.Text = "Âm Lượng";
			// 
			// lblTime
			// 
			this.lblTime.AutoSize = true;
			this.lblTime.Location = new System.Drawing.Point(372, 378);
			this.lblTime.Name = "lblTime";
			this.lblTime.Size = new System.Drawing.Size(74, 16);
			this.lblTime.TabIndex = 41;
			this.lblTime.Text = "Thời Lượng";
			// 
			// trackBar2
			// 
			this.trackBar2.Location = new System.Drawing.Point(342, 515);
			this.trackBar2.Name = "trackBar2";
			this.trackBar2.Size = new System.Drawing.Size(104, 56);
			this.trackBar2.TabIndex = 39;
			// 
			// lblSecond
			// 
			this.lblSecond.AutoSize = true;
			this.lblSecond.Location = new System.Drawing.Point(21, 378);
			this.lblSecond.Name = "lblSecond";
			this.lblSecond.Size = new System.Drawing.Size(35, 16);
			this.lblSecond.TabIndex = 38;
			this.lblSecond.Text = "Giây";
			// 
			// trackBar1
			// 
			this.trackBar1.Location = new System.Drawing.Point(21, 397);
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(422, 56);
			this.trackBar1.TabIndex = 37;
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
			this.lblPlaying.Size = new System.Drawing.Size(74, 16);
			this.lblPlaying.TabIndex = 34;
			this.lblPlaying.Text = "Đang phát: ";
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
			this.btnPause.Image = global::TrinhPhatNhac.Properties.Resources.Pause;
			this.btnPause.Location = new System.Drawing.Point(196, 436);
			this.btnPause.Name = "btnPause";
			this.btnPause.Size = new System.Drawing.Size(53, 43);
			this.btnPause.TabIndex = 55;
			this.btnPause.UseVisualStyleBackColor = true;
			this.btnPause.Visible = false;
			this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
			// 
			// pctMusicPicture
			// 
			this.pctMusicPicture.Image = global::TrinhPhatNhac.Properties.Resources.MusicNotes;
			this.pctMusicPicture.Location = new System.Drawing.Point(107, 161);
			this.pctMusicPicture.Name = "pctMusicPicture";
			this.pctMusicPicture.Size = new System.Drawing.Size(229, 191);
			this.pctMusicPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pctMusicPicture.TabIndex = 50;
			this.pctMusicPicture.TabStop = false;
			// 
			// btnPlaylist
			// 
			this.btnPlaylist.Image = global::TrinhPhatNhac.Properties.Resources.OpenPlaylist;
			this.btnPlaylist.Location = new System.Drawing.Point(24, 505);
			this.btnPlaylist.Name = "btnPlaylist";
			this.btnPlaylist.Size = new System.Drawing.Size(46, 37);
			this.btnPlaylist.TabIndex = 49;
			this.btnPlaylist.UseVisualStyleBackColor = true;
			this.btnPlaylist.Click += new System.EventHandler(this.btnPlaylist_Click);
			// 
			// btnPlaylistManager
			// 
			this.btnPlaylistManager.Image = global::TrinhPhatNhac.Properties.Resources.ManagePlaylist;
			this.btnPlaylistManager.Location = new System.Drawing.Point(88, 505);
			this.btnPlaylistManager.Name = "btnPlaylistManager";
			this.btnPlaylistManager.Size = new System.Drawing.Size(46, 37);
			this.btnPlaylistManager.TabIndex = 48;
			this.btnPlaylistManager.UseVisualStyleBackColor = true;
			this.btnPlaylistManager.Click += new System.EventHandler(this.btnPlaylistManager_Click);
			// 
			// btnRepeat
			// 
			this.btnRepeat.Image = global::TrinhPhatNhac.Properties.Resources.RepeatIcon;
			this.btnRepeat.Location = new System.Drawing.Point(371, 437);
			this.btnRepeat.Name = "btnRepeat";
			this.btnRepeat.Size = new System.Drawing.Size(53, 42);
			this.btnRepeat.TabIndex = 47;
			this.btnRepeat.UseVisualStyleBackColor = true;
			this.btnRepeat.Click += new System.EventHandler(this.btnRepeat_Click);
			// 
			// btnNext
			// 
			this.btnNext.Image = global::TrinhPhatNhac.Properties.Resources.NextIcon;
			this.btnNext.Location = new System.Drawing.Point(283, 437);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(53, 43);
			this.btnNext.TabIndex = 46;
			this.btnNext.UseVisualStyleBackColor = true;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// btnPlay
			// 
			this.btnPlay.Image = global::TrinhPhatNhac.Properties.Resources.PlayIcon;
			this.btnPlay.Location = new System.Drawing.Point(196, 437);
			this.btnPlay.Name = "btnPlay";
			this.btnPlay.Size = new System.Drawing.Size(53, 43);
			this.btnPlay.TabIndex = 45;
			this.btnPlay.UseVisualStyleBackColor = true;
			this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
			// 
			// btnPrevious
			// 
			this.btnPrevious.Image = global::TrinhPhatNhac.Properties.Resources.PreviousIcon;
			this.btnPrevious.Location = new System.Drawing.Point(107, 437);
			this.btnPrevious.Name = "btnPrevious";
			this.btnPrevious.Size = new System.Drawing.Size(53, 43);
			this.btnPrevious.TabIndex = 44;
			this.btnPrevious.UseVisualStyleBackColor = true;
			this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
			// 
			// btnShuffle
			// 
			this.btnShuffle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnShuffle.Image = global::TrinhPhatNhac.Properties.Resources.ShuffleIcon;
			this.btnShuffle.Location = new System.Drawing.Point(24, 437);
			this.btnShuffle.Name = "btnShuffle";
			this.btnShuffle.Size = new System.Drawing.Size(53, 43);
			this.btnShuffle.TabIndex = 43;
			this.btnShuffle.UseVisualStyleBackColor = false;
			this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Location = new System.Drawing.Point(309, 517);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(27, 27);
			this.pictureBox2.TabIndex = 40;
			this.pictureBox2.TabStop = false;
			// 
			// axWMP
			// 
			this.axWMP.Enabled = true;
			this.axWMP.Location = new System.Drawing.Point(21, 560);
			this.axWMP.Name = "axWMP";
			this.axWMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWMP.OcxState")));
			this.axWMP.Size = new System.Drawing.Size(75, 23);
			this.axWMP.TabIndex = 56;
			this.axWMP.Visible = false;
			this.axWMP.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWMP_PlayStateChange_1);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(472, 595);
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
			this.Controls.Add(this.lblVolume);
			this.Controls.Add(this.lblTime);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.trackBar2);
			this.Controls.Add(this.lblSecond);
			this.Controls.Add(this.trackBar1);
			this.Controls.Add(this.lblSinger);
			this.Controls.Add(this.lblNameSong);
			this.Controls.Add(this.lblPlaying);
			this.Name = "MainForm";
			this.Text = "Trình phát nhạc";
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pctMusicPicture)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.axWMP)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
=======
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblVolume = new System.Windows.Forms.Label();
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.axWMP = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMusicPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWMP)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(236, 526);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(67, 16);
            this.lblVolume.TabIndex = 42;
            this.lblVolume.Text = "Âm Lượng";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(372, 378);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(74, 16);
            this.lblTime.TabIndex = 41;
            this.lblTime.Text = "Thời Lượng";
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(342, 515);
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(104, 56);
            this.trackBar2.TabIndex = 39;
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Location = new System.Drawing.Point(21, 378);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(35, 16);
            this.lblSecond.TabIndex = 38;
            this.lblSecond.Text = "Giây";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(21, 397);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(422, 56);
            this.trackBar1.TabIndex = 37;
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
            this.lblPlaying.Size = new System.Drawing.Size(74, 16);
            this.lblPlaying.TabIndex = 34;
            this.lblPlaying.Text = "Đang phát: ";
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
            this.btnPause.Image = global::TrinhPhatNhac.Properties.Resources.Pause;
            this.btnPause.Location = new System.Drawing.Point(196, 436);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(53, 43);
            this.btnPause.TabIndex = 55;
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Visible = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // pctMusicPicture
            // 
            this.pctMusicPicture.Image = global::TrinhPhatNhac.Properties.Resources.MusicNotes;
            this.pctMusicPicture.Location = new System.Drawing.Point(107, 161);
            this.pctMusicPicture.Name = "pctMusicPicture";
            this.pctMusicPicture.Size = new System.Drawing.Size(229, 191);
            this.pctMusicPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctMusicPicture.TabIndex = 50;
            this.pctMusicPicture.TabStop = false;
            // 
            // btnPlaylist
            // 
            this.btnPlaylist.Image = global::TrinhPhatNhac.Properties.Resources.OpenPlaylist;
            this.btnPlaylist.Location = new System.Drawing.Point(24, 505);
            this.btnPlaylist.Name = "btnPlaylist";
            this.btnPlaylist.Size = new System.Drawing.Size(46, 37);
            this.btnPlaylist.TabIndex = 49;
            this.btnPlaylist.UseVisualStyleBackColor = true;
            this.btnPlaylist.Click += new System.EventHandler(this.btnPlaylist_Click);
            // 
            // btnPlaylistManager
            // 
            this.btnPlaylistManager.Image = global::TrinhPhatNhac.Properties.Resources.ManagePlaylist;
            this.btnPlaylistManager.Location = new System.Drawing.Point(88, 505);
            this.btnPlaylistManager.Name = "btnPlaylistManager";
            this.btnPlaylistManager.Size = new System.Drawing.Size(46, 37);
            this.btnPlaylistManager.TabIndex = 48;
            this.btnPlaylistManager.UseVisualStyleBackColor = true;
            this.btnPlaylistManager.Click += new System.EventHandler(this.btnPlaylistManager_Click);
            // 
            // btnRepeat
            // 
            this.btnRepeat.Image = global::TrinhPhatNhac.Properties.Resources.RepeatIcon;
            this.btnRepeat.Location = new System.Drawing.Point(371, 437);
            this.btnRepeat.Name = "btnRepeat";
            this.btnRepeat.Size = new System.Drawing.Size(53, 42);
            this.btnRepeat.TabIndex = 47;
            this.btnRepeat.UseVisualStyleBackColor = true;
            this.btnRepeat.Click += new System.EventHandler(this.btnRepeat_Click);
            // 
            // btnNext
            // 
            this.btnNext.Image = global::TrinhPhatNhac.Properties.Resources.NextIcon;
            this.btnNext.Location = new System.Drawing.Point(283, 437);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(53, 43);
            this.btnNext.TabIndex = 46;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Image = global::TrinhPhatNhac.Properties.Resources.PlayIcon;
            this.btnPlay.Location = new System.Drawing.Point(196, 437);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(53, 43);
            this.btnPlay.TabIndex = 45;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Image = global::TrinhPhatNhac.Properties.Resources.PreviousIcon;
            this.btnPrevious.Location = new System.Drawing.Point(107, 437);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(53, 43);
            this.btnPrevious.TabIndex = 44;
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnShuffle
            // 
            this.btnShuffle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShuffle.Image = global::TrinhPhatNhac.Properties.Resources.ShuffleIcon;
            this.btnShuffle.Location = new System.Drawing.Point(24, 437);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(53, 43);
            this.btnShuffle.TabIndex = 43;
            this.btnShuffle.UseVisualStyleBackColor = false;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(309, 517);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 27);
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            // 
            // axWMP
            // 
            this.axWMP.Enabled = true;
            this.axWMP.Location = new System.Drawing.Point(21, 560);
            this.axWMP.Name = "axWMP";
            this.axWMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWMP.OcxState")));
            this.axWMP.Size = new System.Drawing.Size(75, 23);
            this.axWMP.TabIndex = 56;
            this.axWMP.Visible = false;
            this.axWMP.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWMP_PlayStateChange_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 595);
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
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.lblSecond);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.lblSinger);
            this.Controls.Add(this.lblNameSong);
            this.Controls.Add(this.lblPlaying);
            this.Name = "MainForm";
            this.Text = "Trình phát nhạc";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMusicPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWMP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
>>>>>>> bb97091cb84098b8a9cde50f6ce5deb0ecf38d7c

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
		private System.Windows.Forms.Label lblVolume;
		private System.Windows.Forms.Label lblTime;
		private System.Windows.Forms.PictureBox pictureBox2;
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
    }
}

