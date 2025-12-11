namespace GiaoDien
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
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.btnRemoveSong = new System.Windows.Forms.Button();
            this.btnAddSong = new System.Windows.Forms.Button();
            this.dgvPlayList = new System.Windows.Forms.DataGridView();
            this.lblNamePlaylist = new System.Windows.Forms.Label();
            this.btnPlaylistManager2 = new System.Windows.Forms.Button();
            this.txtThanhTimKiem = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ColSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTenBaiHat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColThoiLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Location = new System.Drawing.Point(276, 562);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(120, 43);
            this.btnMoveUp.TabIndex = 21;
            this.btnMoveUp.Text = "Di chuyển lên";
            this.btnMoveUp.UseVisualStyleBackColor = true;
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
            this.dgvPlayList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSTT,
            this.ColTenBaiHat,
            this.ColThoiLuong});
            this.dgvPlayList.Location = new System.Drawing.Point(24, 81);
            this.dgvPlayList.Name = "dgvPlayList";
            this.dgvPlayList.RowHeadersWidth = 51;
            this.dgvPlayList.RowTemplate.Height = 24;
            this.dgvPlayList.Size = new System.Drawing.Size(498, 466);
            this.dgvPlayList.TabIndex = 17;
            this.dgvPlayList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlayList_CellContentClick);
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
            this.btnPlaylistManager2.Location = new System.Drawing.Point(387, 16);
            this.btnPlaylistManager2.Name = "btnPlaylistManager2";
            this.btnPlaylistManager2.Size = new System.Drawing.Size(135, 32);
            this.btnPlaylistManager2.TabIndex = 15;
            this.btnPlaylistManager2.Text = "Chọn PlayList";
            this.btnPlaylistManager2.UseVisualStyleBackColor = true;
            this.btnPlaylistManager2.Click += new System.EventHandler(this.btnPlaylistManager2_Click);
            // 
            // txtThanhTimKiem
            // 
            this.txtThanhTimKiem.Location = new System.Drawing.Point(27, 16);
            this.txtThanhTimKiem.Name = "txtThanhTimKiem";
            this.txtThanhTimKiem.Size = new System.Drawing.Size(308, 22);
            this.txtThanhTimKiem.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GiaoDien.Properties.Resources.Search;
            this.pictureBox1.Location = new System.Drawing.Point(341, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // ColSTT
            // 
            this.ColSTT.DataPropertyName = "STT";
            this.ColSTT.HeaderText = "STT";
            this.ColSTT.MinimumWidth = 6;
            this.ColSTT.Name = "ColSTT";
            this.ColSTT.Width = 125;
            // 
            // ColTenBaiHat
            // 
            this.ColTenBaiHat.DataPropertyName = "TenBaiHat";
            this.ColTenBaiHat.HeaderText = "Tên Bài Hát";
            this.ColTenBaiHat.MinimumWidth = 6;
            this.ColTenBaiHat.Name = "ColTenBaiHat";
            this.ColTenBaiHat.Width = 125;
            // 
            // ColThoiLuong
            // 
            this.ColThoiLuong.DataPropertyName = "ThoiLuong";
            this.ColThoiLuong.HeaderText = "Thời Lượng";
            this.ColThoiLuong.MinimumWidth = 6;
            this.ColThoiLuong.Name = "ColThoiLuong";
            this.ColThoiLuong.Width = 125;
            // 
            // PlaylistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 624);
            this.Controls.Add(this.btnMoveDown);
            this.Controls.Add(this.btnMoveUp);
            this.Controls.Add(this.btnRemoveSong);
            this.Controls.Add(this.btnAddSong);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvPlayList);
            this.Controls.Add(this.lblNamePlaylist);
            this.Controls.Add(this.btnPlaylistManager2);
            this.Controls.Add(this.txtThanhTimKiem);
            this.Name = "PlaylistForm";
            this.Text = "PlaylistForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnMoveDown;
		private System.Windows.Forms.Button btnMoveUp;
		private System.Windows.Forms.Button btnRemoveSong;
		private System.Windows.Forms.Button btnAddSong;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.DataGridView dgvPlayList;
		private System.Windows.Forms.Label lblNamePlaylist;
		private System.Windows.Forms.Button btnPlaylistManager2;
		private System.Windows.Forms.TextBox txtThanhTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTenBaiHat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColThoiLuong;
    }
}