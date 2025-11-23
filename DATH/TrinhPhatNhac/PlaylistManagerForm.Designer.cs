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
			((System.ComponentModel.ISupportInitialize)(this.dgvPlaylistManager)).BeginInit();
			this.SuspendLayout();
			// 
			// btnRemovePlaylist
			// 
			this.btnRemovePlaylist.Location = new System.Drawing.Point(232, 369);
			this.btnRemovePlaylist.Name = "btnRemovePlaylist";
			this.btnRemovePlaylist.Size = new System.Drawing.Size(95, 43);
			this.btnRemovePlaylist.TabIndex = 16;
			this.btnRemovePlaylist.Text = "Xóa Playlist";
			this.btnRemovePlaylist.UseVisualStyleBackColor = true;
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
			this.dgvPlaylistManager.Size = new System.Drawing.Size(393, 295);
			this.dgvPlaylistManager.TabIndex = 15;
			// 
			// ColTenPlaylist
			// 
			this.ColTenPlaylist.HeaderText = "Tên Playlist";
			this.ColTenPlaylist.MinimumWidth = 6;
			this.ColTenPlaylist.Name = "ColTenPlaylist";
			this.ColTenPlaylist.Width = 125;
			// 
			// ColSoLuongBaiHat
			// 
			this.ColSoLuongBaiHat.HeaderText = "Số Lượng Bài Hát";
			this.ColSoLuongBaiHat.MinimumWidth = 6;
			this.ColSoLuongBaiHat.Name = "ColSoLuongBaiHat";
			this.ColSoLuongBaiHat.Width = 125;
			// 
			// btnEditPlaylist
			// 
			this.btnEditPlaylist.Location = new System.Drawing.Point(131, 369);
			this.btnEditPlaylist.Name = "btnEditPlaylist";
			this.btnEditPlaylist.Size = new System.Drawing.Size(95, 43);
			this.btnEditPlaylist.TabIndex = 13;
			this.btnEditPlaylist.Text = "Sửa Playlist";
			this.btnEditPlaylist.UseVisualStyleBackColor = true;
			// 
			// btnCreatePlaylist
			// 
			this.btnCreatePlaylist.Location = new System.Drawing.Point(30, 369);
			this.btnCreatePlaylist.Name = "btnCreatePlaylist";
			this.btnCreatePlaylist.Size = new System.Drawing.Size(95, 43);
			this.btnCreatePlaylist.TabIndex = 12;
			this.btnCreatePlaylist.Text = "Tạo Playlist";
			this.btnCreatePlaylist.UseVisualStyleBackColor = true;
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
			// PlaylistManagerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(452, 454);
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
		private System.Windows.Forms.DataGridViewTextBoxColumn ColTenPlaylist;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColSoLuongBaiHat;
		private System.Windows.Forms.Button btnEditPlaylist;
		private System.Windows.Forms.Button btnCreatePlaylist;
		private System.Windows.Forms.Label lblList;
	}
}