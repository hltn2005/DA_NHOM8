namespace DemoDoAn
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
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.lblVolume = new System.Windows.Forms.Label();
			this.lblTime = new System.Windows.Forms.Label();
			this.trackBar2 = new System.Windows.Forms.TrackBar();
			this.lblSecond = new System.Windows.Forms.Label();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.lblSinger = new System.Windows.Forms.Label();
			this.lblNameSong = new System.Windows.Forms.Label();
			this.lblPlaying = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnPlaylist = new System.Windows.Forms.Button();
			this.btnPlaylistManager = new System.Windows.Forms.Button();
			this.btnRepeat = new System.Windows.Forms.Button();
			this.btnNext = new System.Windows.Forms.Button();
			this.btnPlayPause = new System.Windows.Forms.Button();
			this.btnPrevious = new System.Windows.Forms.Button();
			this.btnShuffle = new System.Windows.Forms.Button();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// lblVolume
			// 
			this.lblVolume.AutoSize = true;
			this.lblVolume.Location = new System.Drawing.Point(227, 477);
			this.lblVolume.Name = "lblVolume";
			this.lblVolume.Size = new System.Drawing.Size(67, 16);
			this.lblVolume.TabIndex = 25;
			this.lblVolume.Text = "Âm Lượng";
			// 
			// lblTime
			// 
			this.lblTime.AutoSize = true;
			this.lblTime.Location = new System.Drawing.Point(363, 329);
			this.lblTime.Name = "lblTime";
			this.lblTime.Size = new System.Drawing.Size(74, 16);
			this.lblTime.TabIndex = 24;
			this.lblTime.Text = "Thời Lượng";
			// 
			// trackBar2
			// 
			this.trackBar2.Location = new System.Drawing.Point(333, 466);
			this.trackBar2.Name = "trackBar2";
			this.trackBar2.Size = new System.Drawing.Size(104, 56);
			this.trackBar2.TabIndex = 22;
			// 
			// lblSecond
			// 
			this.lblSecond.AutoSize = true;
			this.lblSecond.Location = new System.Drawing.Point(12, 329);
			this.lblSecond.Name = "lblSecond";
			this.lblSecond.Size = new System.Drawing.Size(35, 16);
			this.lblSecond.TabIndex = 21;
			this.lblSecond.Text = "Giây";
			// 
			// trackBar1
			// 
			this.trackBar1.Location = new System.Drawing.Point(12, 348);
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(422, 56);
			this.trackBar1.TabIndex = 20;
			// 
			// lblSinger
			// 
			this.lblSinger.AutoSize = true;
			this.lblSinger.Location = new System.Drawing.Point(18, 64);
			this.lblSinger.Name = "lblSinger";
			this.lblSinger.Size = new System.Drawing.Size(39, 16);
			this.lblSinger.TabIndex = 19;
			this.lblSinger.Text = "Ca sĩ";
			// 
			// lblNameSong
			// 
			this.lblNameSong.AutoSize = true;
			this.lblNameSong.Location = new System.Drawing.Point(18, 38);
			this.lblNameSong.Name = "lblNameSong";
			this.lblNameSong.Size = new System.Drawing.Size(74, 16);
			this.lblNameSong.TabIndex = 18;
			this.lblNameSong.Text = "Tên bài hát";
			// 
			// lblPlaying
			// 
			this.lblPlaying.AutoSize = true;
			this.lblPlaying.Location = new System.Drawing.Point(18, 12);
			this.lblPlaying.Name = "lblPlaying";
			this.lblPlaying.Size = new System.Drawing.Size(68, 16);
			this.lblPlaying.TabIndex = 17;
			this.lblPlaying.Text = "Đang phát";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::DemoDoAn.Properties.Resources.NotNhac;
			this.pictureBox1.Location = new System.Drawing.Point(98, 112);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(229, 191);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 33;
			this.pictureBox1.TabStop = false;
			// 
			// btnPlaylist
			// 
			this.btnPlaylist.Image = global::DemoDoAn.Properties.Resources.NutXemPlaylist;
			this.btnPlaylist.Location = new System.Drawing.Point(15, 456);
			this.btnPlaylist.Name = "btnPlaylist";
			this.btnPlaylist.Size = new System.Drawing.Size(46, 37);
			this.btnPlaylist.TabIndex = 32;
			this.btnPlaylist.UseVisualStyleBackColor = true;
			this.btnPlaylist.Click += new System.EventHandler(this.btnPlaylist_Click);
			// 
			// btnPlaylistManager
			// 
			this.btnPlaylistManager.Image = global::DemoDoAn.Properties.Resources.NutThemPlaylist;
			this.btnPlaylistManager.Location = new System.Drawing.Point(79, 456);
			this.btnPlaylistManager.Name = "btnPlaylistManager";
			this.btnPlaylistManager.Size = new System.Drawing.Size(46, 37);
			this.btnPlaylistManager.TabIndex = 31;
			this.btnPlaylistManager.UseVisualStyleBackColor = true;
			this.btnPlaylistManager.Click += new System.EventHandler(this.btnPlaylistManager_Click);
			// 
			// btnRepeat
			// 
			this.btnRepeat.Image = global::DemoDoAn.Properties.Resources.NutLapLai;
			this.btnRepeat.Location = new System.Drawing.Point(362, 388);
			this.btnRepeat.Name = "btnRepeat";
			this.btnRepeat.Size = new System.Drawing.Size(53, 42);
			this.btnRepeat.TabIndex = 30;
			this.btnRepeat.UseVisualStyleBackColor = true;
			// 
			// btnNext
			// 
			this.btnNext.Image = global::DemoDoAn.Properties.Resources.NutTiepTheo;
			this.btnNext.Location = new System.Drawing.Point(274, 388);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(53, 43);
			this.btnNext.TabIndex = 29;
			this.btnNext.UseVisualStyleBackColor = true;
			// 
			// btnPlayPause
			// 
			this.btnPlayPause.Image = ((System.Drawing.Image)(resources.GetObject("btnPlayPause.Image")));
			this.btnPlayPause.Location = new System.Drawing.Point(187, 388);
			this.btnPlayPause.Name = "btnPlayPause";
			this.btnPlayPause.Size = new System.Drawing.Size(53, 43);
			this.btnPlayPause.TabIndex = 28;
			this.btnPlayPause.UseVisualStyleBackColor = true;
			// 
			// btnPrevious
			// 
			this.btnPrevious.Image = global::DemoDoAn.Properties.Resources.NutQuayLai;
			this.btnPrevious.Location = new System.Drawing.Point(98, 388);
			this.btnPrevious.Name = "btnPrevious";
			this.btnPrevious.Size = new System.Drawing.Size(53, 43);
			this.btnPrevious.TabIndex = 27;
			this.btnPrevious.UseVisualStyleBackColor = true;
			// 
			// btnShuffle
			// 
			this.btnShuffle.Image = global::DemoDoAn.Properties.Resources.NutNgauNhien;
			this.btnShuffle.Location = new System.Drawing.Point(15, 388);
			this.btnShuffle.Name = "btnShuffle";
			this.btnShuffle.Size = new System.Drawing.Size(53, 43);
			this.btnShuffle.TabIndex = 26;
			this.btnShuffle.UseVisualStyleBackColor = true;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Location = new System.Drawing.Point(300, 468);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(27, 27);
			this.pictureBox2.TabIndex = 23;
			this.pictureBox2.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(446, 519);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnPlaylist);
			this.Controls.Add(this.btnPlaylistManager);
			this.Controls.Add(this.btnRepeat);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.btnPlayPause);
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
			this.Text = "MainForm";
			((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button btnPlaylist;
		private System.Windows.Forms.Button btnPlaylistManager;
		private System.Windows.Forms.Button btnRepeat;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Button btnPlayPause;
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
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}

