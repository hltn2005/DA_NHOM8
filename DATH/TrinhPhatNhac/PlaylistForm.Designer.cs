namespace TrinhPhatNhac
{
	partial class btnFindSongs
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
			this.btnMoveDown = new System.Windows.Forms.Button();
			this.btnMoveUp = new System.Windows.Forms.Button();
			this.btnRemoveSong = new System.Windows.Forms.Button();
			this.btnAddSong = new System.Windows.Forms.Button();
			this.dgvPlayList = new System.Windows.Forms.DataGridView();
			this.ColSongName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColSigerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lblNamePlaylist = new System.Windows.Forms.Label();
			this.btnPlaylistManager2 = new System.Windows.Forms.Button();
			this.txtFindSongs = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvPlayList)).BeginInit();
			this.SuspendLayout();
			// 
			// btnMoveDown
			// 
			this.btnMoveDown.Location = new System.Drawing.Point(402, 562);
			this.btnMoveDown.Name = "btnMoveDown";
			this.btnMoveDown.Size = new System.Drawing.Size(120, 43);
			this.btnMoveDown.TabIndex = 22;
			this.btnMoveDown.Text = "Di chuyển xuống";
			this.btnMoveDown.UseVisualStyleBackColor = true;
			this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
			// 
			// btnMoveUp
			// 
			this.btnMoveUp.Location = new System.Drawing.Point(276, 562);
			this.btnMoveUp.Name = "btnMoveUp";
			this.btnMoveUp.Size = new System.Drawing.Size(120, 43);
			this.btnMoveUp.TabIndex = 21;
			this.btnMoveUp.Text = "Di chuyển lên";
			this.btnMoveUp.UseVisualStyleBackColor = true;
			this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
			// 
			// btnRemoveSong
			// 
			this.btnRemoveSong.Location = new System.Drawing.Point(150, 562);
			this.btnRemoveSong.Name = "btnRemoveSong";
			this.btnRemoveSong.Size = new System.Drawing.Size(120, 43);
			this.btnRemoveSong.TabIndex = 20;
			this.btnRemoveSong.Text = "Xóa bài hát";
			this.btnRemoveSong.UseVisualStyleBackColor = true;
			this.btnRemoveSong.Click += new System.EventHandler(this.btnRemoveSong_Click);
			// 
			// btnAddSong
			// 
			this.btnAddSong.Location = new System.Drawing.Point(24, 562);
			this.btnAddSong.Name = "btnAddSong";
			this.btnAddSong.Size = new System.Drawing.Size(120, 43);
			this.btnAddSong.TabIndex = 19;
			this.btnAddSong.Text = "Thêm bài hát";
			this.btnAddSong.UseVisualStyleBackColor = true;
			this.btnAddSong.Click += new System.EventHandler(this.btnAddSong_Click);
			// 
			// dgvPlayList
			// 
			this.dgvPlayList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvPlayList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPlayList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSongName,
            this.ColSigerName});
			this.dgvPlayList.Location = new System.Drawing.Point(24, 81);
			this.dgvPlayList.Name = "dgvPlayList";
			this.dgvPlayList.RowHeadersWidth = 51;
			this.dgvPlayList.RowTemplate.Height = 24;
			this.dgvPlayList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvPlayList.Size = new System.Drawing.Size(664, 466);
			this.dgvPlayList.TabIndex = 17;
			// 
			// ColSongName
			// 
			this.ColSongName.DataPropertyName = "SongName";
			this.ColSongName.HeaderText = "Tên Bài Hát";
			this.ColSongName.MinimumWidth = 6;
			this.ColSongName.Name = "ColSongName";
			// 
			// ColSigerName
			// 
			this.ColSigerName.DataPropertyName = "SingerName";
			this.ColSigerName.HeaderText = "Ca Sĩ";
			this.ColSigerName.MinimumWidth = 6;
			this.ColSigerName.Name = "ColSigerName";
			// 
			// lblNamePlaylist
			// 
			this.lblNamePlaylist.AutoSize = true;
			this.lblNamePlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNamePlaylist.Location = new System.Drawing.Point(24, 58);
			this.lblNamePlaylist.Name = "lblNamePlaylist";
			this.lblNamePlaylist.Size = new System.Drawing.Size(96, 20);
			this.lblNamePlaylist.TabIndex = 16;
			this.lblNamePlaylist.Text = "Tên Playlist";
			// 
			// btnPlaylistManager2
			// 
			this.btnPlaylistManager2.Location = new System.Drawing.Point(387, 11);
			this.btnPlaylistManager2.Name = "btnPlaylistManager2";
			this.btnPlaylistManager2.Size = new System.Drawing.Size(135, 32);
			this.btnPlaylistManager2.TabIndex = 15;
			this.btnPlaylistManager2.Text = "Chọn PlayList";
			this.btnPlaylistManager2.UseVisualStyleBackColor = true;
			this.btnPlaylistManager2.Click += new System.EventHandler(this.btnPlaylistManager2_Click);
			// 
			// txtFindSongs
			// 
			this.txtFindSongs.Location = new System.Drawing.Point(27, 16);
			this.txtFindSongs.Name = "txtFindSongs";
			this.txtFindSongs.Size = new System.Drawing.Size(308, 22);
			this.txtFindSongs.TabIndex = 14;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
			this.button1.Location = new System.Drawing.Point(326, 11);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(40, 32);
			this.button1.TabIndex = 23;
			this.button1.Text = "🔍";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnFindSongs
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(712, 633);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnMoveDown);
			this.Controls.Add(this.btnMoveUp);
			this.Controls.Add(this.btnRemoveSong);
			this.Controls.Add(this.btnAddSong);
			this.Controls.Add(this.dgvPlayList);
			this.Controls.Add(this.lblNamePlaylist);
			this.Controls.Add(this.btnPlaylistManager2);
			this.Controls.Add(this.txtFindSongs);
			this.Name = "btnFindSongs";
			this.Text = "PlaylistForm";
			this.Load += new System.EventHandler(this.PlaylistForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvPlayList)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnMoveDown;
		private System.Windows.Forms.Button btnMoveUp;
		private System.Windows.Forms.Button btnRemoveSong;
		private System.Windows.Forms.Button btnAddSong;
		private System.Windows.Forms.DataGridView dgvPlayList;
		private System.Windows.Forms.Label lblNamePlaylist;
		private System.Windows.Forms.Button btnPlaylistManager2;
		private System.Windows.Forms.TextBox txtFindSongs;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSongName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSigerName;
		private System.Windows.Forms.Button button1;
	}
}