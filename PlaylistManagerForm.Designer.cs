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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
			this.btnRemovePlaylist.BackColor = System.Drawing.SystemColors.HighlightText;
			this.btnRemovePlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRemovePlaylist.Location = new System.Drawing.Point(30, 431);
			this.btnRemovePlaylist.Name = "btnRemovePlaylist";
			this.btnRemovePlaylist.Size = new System.Drawing.Size(110, 45);
			this.btnRemovePlaylist.TabIndex = 16;
			this.btnRemovePlaylist.Text = "Xóa Playlist";
			this.btnRemovePlaylist.UseVisualStyleBackColor = false;
			this.btnRemovePlaylist.Click += new System.EventHandler(this.btnRemovePlaylist_Click);
			// 
			// dgvPlaylistManager
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.dgvPlaylistManager.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvPlaylistManager.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvPlaylistManager.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvPlaylistManager.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvPlaylistManager.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPlaylistManager.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColTenPlaylist,
            this.ColSoLuongBaiHat});
			this.dgvPlaylistManager.EnableHeadersVisualStyles = false;
			this.dgvPlaylistManager.Location = new System.Drawing.Point(30, 52);
			this.dgvPlaylistManager.Name = "dgvPlaylistManager";
			this.dgvPlaylistManager.RowHeadersWidth = 51;
			this.dgvPlaylistManager.RowTemplate.Height = 24;
			this.dgvPlaylistManager.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvPlaylistManager.Size = new System.Drawing.Size(458, 295);
			this.dgvPlaylistManager.TabIndex = 15;
			this.dgvPlaylistManager.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvPlaylistManager_CellBeginEdit);
			// 
			// ColTenPlaylist
			// 
			this.ColTenPlaylist.DataPropertyName = "Name";
			this.ColTenPlaylist.HeaderText = "Tên Playlist";
			this.ColTenPlaylist.MinimumWidth = 6;
			this.ColTenPlaylist.Name = "ColTenPlaylist";
			// 
			// ColSoLuongBaiHat
			// 
			this.ColSoLuongBaiHat.DataPropertyName = "SongCount";
			this.ColSoLuongBaiHat.HeaderText = "Số Lượng Bài Hát";
			this.ColSoLuongBaiHat.MinimumWidth = 6;
			this.ColSoLuongBaiHat.Name = "ColSoLuongBaiHat";
			// 
			// btnEditPlaylist
			// 
			this.btnEditPlaylist.BackColor = System.Drawing.SystemColors.HighlightText;
			this.btnEditPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEditPlaylist.Location = new System.Drawing.Point(146, 431);
			this.btnEditPlaylist.Name = "btnEditPlaylist";
			this.btnEditPlaylist.Size = new System.Drawing.Size(110, 45);
			this.btnEditPlaylist.TabIndex = 13;
			this.btnEditPlaylist.Text = "Sửa Playlist";
			this.btnEditPlaylist.UseVisualStyleBackColor = false;
			this.btnEditPlaylist.Click += new System.EventHandler(this.btnEditPlaylist_Click);
			// 
			// btnCreatePlaylist
			// 
			this.btnCreatePlaylist.BackColor = System.Drawing.SystemColors.HighlightText;
			this.btnCreatePlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCreatePlaylist.Location = new System.Drawing.Point(378, 372);
			this.btnCreatePlaylist.Name = "btnCreatePlaylist";
			this.btnCreatePlaylist.Size = new System.Drawing.Size(110, 45);
			this.btnCreatePlaylist.TabIndex = 12;
			this.btnCreatePlaylist.Text = "Tạo Playlist";
			this.btnCreatePlaylist.UseVisualStyleBackColor = false;
			this.btnCreatePlaylist.Click += new System.EventHandler(this.btnCreatePlaylist_Click);
			// 
			// lblList
			// 
			this.lblList.AutoSize = true;
			this.lblList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblList.Location = new System.Drawing.Point(26, 18);
			this.lblList.Name = "lblList";
			this.lblList.Size = new System.Drawing.Size(192, 20);
			this.lblList.TabIndex = 11;
			this.lblList.Text = "DANH SÁCH PLAYLIST\r\n";
			// 
			// btnAddSong
			// 
			this.btnAddSong.BackColor = System.Drawing.SystemColors.HighlightText;
			this.btnAddSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddSong.Location = new System.Drawing.Point(262, 431);
			this.btnAddSong.Name = "btnAddSong";
			this.btnAddSong.Size = new System.Drawing.Size(110, 45);
			this.btnAddSong.TabIndex = 17;
			this.btnAddSong.Text = "Thêm Bài Hát";
			this.btnAddSong.UseVisualStyleBackColor = false;
			this.btnAddSong.Click += new System.EventHandler(this.btnAddSong_Click);
			// 
			// btnSelectPlayList
			// 
			this.btnSelectPlayList.BackColor = System.Drawing.SystemColors.HighlightText;
			this.btnSelectPlayList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSelectPlayList.Location = new System.Drawing.Point(378, 431);
			this.btnSelectPlayList.Name = "btnSelectPlayList";
			this.btnSelectPlayList.Size = new System.Drawing.Size(110, 45);
			this.btnSelectPlayList.TabIndex = 18;
			this.btnSelectPlayList.Text = "Chọn Playlist";
			this.btnSelectPlayList.UseVisualStyleBackColor = false;
			this.btnSelectPlayList.Click += new System.EventHandler(this.btnSelectPlayList_Click);
			// 
			// txtNamePlayList
			// 
			this.txtNamePlayList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNamePlayList.Location = new System.Drawing.Point(30, 380);
			this.txtNamePlayList.Name = "txtNamePlayList";
			this.txtNamePlayList.Size = new System.Drawing.Size(342, 27);
			this.txtNamePlayList.TabIndex = 19;
			// 
			// PlaylistManagerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.ClientSize = new System.Drawing.Size(514, 491);
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
			this.Load += new System.EventHandler(this.PlaylistManagerForm_Load);
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