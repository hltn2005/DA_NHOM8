namespace DemoDoAn
{
	partial class PlaylistForm
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
			this.dgvPlayList = new System.Windows.Forms.DataGridView();
			this.ColSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColTenBaiHat = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColThoiLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lblNamePlaylist = new System.Windows.Forms.Label();
			this.btnPlaylistManager = new System.Windows.Forms.Button();
			this.txtThanhTimKiem = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnMoveUp = new System.Windows.Forms.Button();
			this.btnRemoveSong = new System.Windows.Forms.Button();
			this.btnAddSong = new System.Windows.Forms.Button();
			this.btnMoveDown = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvPlayList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvPlayList
			// 
			this.dgvPlayList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPlayList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSTT,
            this.ColTenBaiHat,
            this.ColThoiLuong});
			this.dgvPlayList.Location = new System.Drawing.Point(12, 94);
			this.dgvPlayList.Name = "dgvPlayList";
			this.dgvPlayList.RowHeadersWidth = 51;
			this.dgvPlayList.RowTemplate.Height = 24;
			this.dgvPlayList.Size = new System.Drawing.Size(498, 466);
			this.dgvPlayList.TabIndex = 8;
			// 
			// ColSTT
			// 
			this.ColSTT.HeaderText = "STT";
			this.ColSTT.MinimumWidth = 6;
			this.ColSTT.Name = "ColSTT";
			this.ColSTT.Width = 125;
			// 
			// ColTenBaiHat
			// 
			this.ColTenBaiHat.HeaderText = "Tên Bài Hát";
			this.ColTenBaiHat.MinimumWidth = 6;
			this.ColTenBaiHat.Name = "ColTenBaiHat";
			this.ColTenBaiHat.Width = 125;
			// 
			// ColThoiLuong
			// 
			this.ColThoiLuong.HeaderText = "Thời Lượng";
			this.ColThoiLuong.MinimumWidth = 6;
			this.ColThoiLuong.Name = "ColThoiLuong";
			this.ColThoiLuong.Width = 125;
			// 
			// lblNamePlaylist
			// 
			this.lblNamePlaylist.AutoSize = true;
			this.lblNamePlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNamePlaylist.Location = new System.Drawing.Point(12, 71);
			this.lblNamePlaylist.Name = "lblNamePlaylist";
			this.lblNamePlaylist.Size = new System.Drawing.Size(96, 20);
			this.lblNamePlaylist.TabIndex = 7;
			this.lblNamePlaylist.Text = "Tên Playlist";
			// 
			// btnPlaylistManager
			// 
			this.btnPlaylistManager.Location = new System.Drawing.Point(375, 29);
			this.btnPlaylistManager.Name = "btnPlaylistManager";
			this.btnPlaylistManager.Size = new System.Drawing.Size(135, 32);
			this.btnPlaylistManager.TabIndex = 6;
			this.btnPlaylistManager.Text = "Chọn PlayList";
			this.btnPlaylistManager.UseVisualStyleBackColor = true;
			this.btnPlaylistManager.Click += new System.EventHandler(this.btnPlaylistManager_Click);
			// 
			// txtThanhTimKiem
			// 
			this.txtThanhTimKiem.Location = new System.Drawing.Point(15, 29);
			this.txtThanhTimKiem.Name = "txtThanhTimKiem";
			this.txtThanhTimKiem.Size = new System.Drawing.Size(308, 22);
			this.txtThanhTimKiem.TabIndex = 5;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::DemoDoAn.Properties.Resources.KinhLup;
			this.pictureBox1.Location = new System.Drawing.Point(329, 29);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(25, 22);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 9;
			this.pictureBox1.TabStop = false;
			// 
			// btnMoveUp
			// 
			this.btnMoveUp.Location = new System.Drawing.Point(264, 575);
			this.btnMoveUp.Name = "btnMoveUp";
			this.btnMoveUp.Size = new System.Drawing.Size(120, 43);
			this.btnMoveUp.TabIndex = 12;
			this.btnMoveUp.Text = "Di chuyển lên";
			this.btnMoveUp.UseVisualStyleBackColor = true;
			// 
			// btnRemoveSong
			// 
			this.btnRemoveSong.Location = new System.Drawing.Point(138, 575);
			this.btnRemoveSong.Name = "btnRemoveSong";
			this.btnRemoveSong.Size = new System.Drawing.Size(120, 43);
			this.btnRemoveSong.TabIndex = 11;
			this.btnRemoveSong.Text = "Xóa bài hát";
			this.btnRemoveSong.UseVisualStyleBackColor = true;
			// 
			// btnAddSong
			// 
			this.btnAddSong.Location = new System.Drawing.Point(12, 575);
			this.btnAddSong.Name = "btnAddSong";
			this.btnAddSong.Size = new System.Drawing.Size(120, 43);
			this.btnAddSong.TabIndex = 10;
			this.btnAddSong.Text = "Thêm bài hát";
			this.btnAddSong.UseVisualStyleBackColor = true;
			// 
			// btnMoveDown
			// 
			this.btnMoveDown.Location = new System.Drawing.Point(390, 575);
			this.btnMoveDown.Name = "btnMoveDown";
			this.btnMoveDown.Size = new System.Drawing.Size(120, 43);
			this.btnMoveDown.TabIndex = 13;
			this.btnMoveDown.Text = "Di chuyển xuống";
			this.btnMoveDown.UseVisualStyleBackColor = true;
			// 
			// PlaylistForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(529, 646);
			this.Controls.Add(this.btnMoveDown);
			this.Controls.Add(this.btnMoveUp);
			this.Controls.Add(this.btnRemoveSong);
			this.Controls.Add(this.btnAddSong);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.dgvPlayList);
			this.Controls.Add(this.lblNamePlaylist);
			this.Controls.Add(this.btnPlaylistManager);
			this.Controls.Add(this.txtThanhTimKiem);
			this.Name = "PlaylistForm";
			this.Text = "PlaylistForm";
			((System.ComponentModel.ISupportInitialize)(this.dgvPlayList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvPlayList;
		private System.Windows.Forms.Label lblNamePlaylist;
		private System.Windows.Forms.Button btnPlaylistManager;
		private System.Windows.Forms.TextBox txtThanhTimKiem;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColSTT;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColTenBaiHat;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColThoiLuong;
		private System.Windows.Forms.Button btnMoveUp;
		private System.Windows.Forms.Button btnRemoveSong;
		private System.Windows.Forms.Button btnAddSong;
		private System.Windows.Forms.Button btnMoveDown;
	}
}