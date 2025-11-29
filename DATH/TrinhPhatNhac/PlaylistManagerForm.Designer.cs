namespace TrinhPhatNhac
{
	partial class PlaylistManagerForm
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
            this.btnRemovePlaylist = new System.Windows.Forms.Button();
            this.dgvPlaylistManager = new System.Windows.Forms.DataGridView();
            this.ColTenPlaylist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSoLuongBaiHat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditPlaylist = new System.Windows.Forms.Button();
            this.btnCreatePlaylist = new System.Windows.Forms.Button();
            this.lblList = new System.Windows.Forms.Label();
            this.btnAddSong = new System.Windows.Forms.Button();
            this.btnSelectPlayList = new System.Windows.Forms.Button();
            this.txtNamePlayList = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaylistManager)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRemovePlaylist
            // 
            this.btnRemovePlaylist.Location = new System.Drawing.Point(30, 431);
            this.btnRemovePlaylist.Name = "btnRemovePlaylist";
            this.btnRemovePlaylist.Size = new System.Drawing.Size(95, 43);
            this.btnRemovePlaylist.TabIndex = 16;
            this.btnRemovePlaylist.Text = "Xóa Playlist";
            this.btnRemovePlaylist.UseVisualStyleBackColor = true;
            this.btnRemovePlaylist.Click += new System.EventHandler(this.btnRemovePlaylist_Click);
            // 
            // dgvPlaylistManager
            // 
            this.dgvPlaylistManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlaylistManager.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColTenPlaylist,
            this.ColSoLuongBaiHat});
            this.dgvPlaylistManager.Location = new System.Drawing.Point(30, 52);
            this.dgvPlaylistManager.Name = "dgvPlaylistManager";
            this.dgvPlaylistManager.RowHeadersWidth = 51;
            this.dgvPlaylistManager.RowTemplate.Height = 24;
            this.dgvPlaylistManager.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlaylistManager.Size = new System.Drawing.Size(408, 295);
            this.dgvPlaylistManager.TabIndex = 15;
            // 
            // ColTenPlaylist
            // 
            this.ColTenPlaylist.DataPropertyName = "Name";
            this.ColTenPlaylist.HeaderText = "Tên Playlist";
            this.ColTenPlaylist.MinimumWidth = 6;
            this.ColTenPlaylist.Name = "ColTenPlaylist";
            this.ColTenPlaylist.Width = 125;
            // 
            // ColSoLuongBaiHat
            // 
            this.ColSoLuongBaiHat.DataPropertyName = "SongCount";
            this.ColSoLuongBaiHat.HeaderText = "Số Lượng Bài Hát";
            this.ColSoLuongBaiHat.MinimumWidth = 6;
            this.ColSoLuongBaiHat.Name = "ColSoLuongBaiHat";
            this.ColSoLuongBaiHat.Width = 125;
            // 
            // btnEditPlaylist
            // 
            this.btnEditPlaylist.Location = new System.Drawing.Point(131, 431);
            this.btnEditPlaylist.Name = "btnEditPlaylist";
            this.btnEditPlaylist.Size = new System.Drawing.Size(95, 43);
            this.btnEditPlaylist.TabIndex = 13;
            this.btnEditPlaylist.Text = "Sửa Playlist";
            this.btnEditPlaylist.UseVisualStyleBackColor = true;
            // 
            // btnCreatePlaylist
            // 
            this.btnCreatePlaylist.Location = new System.Drawing.Point(343, 373);
            this.btnCreatePlaylist.Name = "btnCreatePlaylist";
            this.btnCreatePlaylist.Size = new System.Drawing.Size(95, 43);
            this.btnCreatePlaylist.TabIndex = 12;
            this.btnCreatePlaylist.Text = "Tạo Playlist";
            this.btnCreatePlaylist.UseVisualStyleBackColor = true;
            this.btnCreatePlaylist.Click += new System.EventHandler(this.btnCreatePlaylist_Click);
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblList.Location = new System.Drawing.Point(26, 18);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(151, 20);
            this.lblList.TabIndex = 11;
            this.lblList.Text = "Danh Sách Playlist";
            // 
            // btnAddSong
            // 
            this.btnAddSong.Location = new System.Drawing.Point(242, 431);
            this.btnAddSong.Name = "btnAddSong";
            this.btnAddSong.Size = new System.Drawing.Size(95, 43);
            this.btnAddSong.TabIndex = 17;
            this.btnAddSong.Text = "Thêm Bài Hát";
            this.btnAddSong.UseVisualStyleBackColor = true;
            this.btnAddSong.Click += new System.EventHandler(this.btnAddSong_Click);
            // 
            // btnSelectPlayList
            // 
            this.btnSelectPlayList.Location = new System.Drawing.Point(343, 431);
            this.btnSelectPlayList.Name = "btnSelectPlayList";
            this.btnSelectPlayList.Size = new System.Drawing.Size(95, 43);
            this.btnSelectPlayList.TabIndex = 18;
            this.btnSelectPlayList.Text = "Chọn Playlist";
            this.btnSelectPlayList.UseVisualStyleBackColor = true;
            this.btnSelectPlayList.Click += new System.EventHandler(this.btnSelectPlayList_Click);
            // 
            // txtNamePlayList
            // 
            this.txtNamePlayList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamePlayList.Location = new System.Drawing.Point(30, 380);
            this.txtNamePlayList.Name = "txtNamePlayList";
            this.txtNamePlayList.Size = new System.Drawing.Size(307, 27);
            this.txtNamePlayList.TabIndex = 19;
            // 
            // PlaylistManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 486);
            this.Controls.Add(this.txtNamePlayList);
            this.Controls.Add(this.btnSelectPlayList);
            this.Controls.Add(this.btnAddSong);
            this.Controls.Add(this.btnRemovePlaylist);
            this.Controls.Add(this.dgvPlaylistManager);
            this.Controls.Add(this.btnEditPlaylist);
            this.Controls.Add(this.btnCreatePlaylist);
            this.Controls.Add(this.lblList);
            this.Name = "PlaylistManagerForm";
            this.Text = "PlaylistManagerForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaylistManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnRemovePlaylist;
		private System.Windows.Forms.DataGridView dgvPlaylistManager;
		private System.Windows.Forms.Button btnEditPlaylist;
		private System.Windows.Forms.Button btnCreatePlaylist;
		private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.Button btnAddSong;
        private System.Windows.Forms.Button btnSelectPlayList;
        private System.Windows.Forms.TextBox txtNamePlayList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTenPlaylist;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSoLuongBaiHat;
    }
}