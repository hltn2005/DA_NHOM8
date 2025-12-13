namespace TrinhPhatNhac
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRemoveSong = new System.Windows.Forms.Button();
            this.btnAddSong = new System.Windows.Forms.Button();
            this.dgvPlayList = new System.Windows.Forms.DataGridView();
            this.ColSongName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSigerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSongTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnPlaylistManager2 = new System.Windows.Forms.Button();
            this.txtThanhTimKiem = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNamePlaylist = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.btnMoveDown = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRemoveSong
            // 
            this.btnRemoveSong.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnRemoveSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveSong.Location = new System.Drawing.Point(150, 562);
            this.btnRemoveSong.Name = "btnRemoveSong";
            this.btnRemoveSong.Size = new System.Drawing.Size(120, 43);
            this.btnRemoveSong.TabIndex = 20;
            this.btnRemoveSong.Text = "Xóa bài hát";
            this.btnRemoveSong.UseVisualStyleBackColor = false;
            this.btnRemoveSong.Click += new System.EventHandler(this.btnRemoveSong_Click);
            // 
            // btnAddSong
            // 
            this.btnAddSong.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnAddSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSong.Location = new System.Drawing.Point(24, 562);
            this.btnAddSong.Name = "btnAddSong";
            this.btnAddSong.Size = new System.Drawing.Size(120, 43);
            this.btnAddSong.TabIndex = 19;
            this.btnAddSong.Text = "Thêm bài hát";
            this.btnAddSong.UseVisualStyleBackColor = false;
            this.btnAddSong.Click += new System.EventHandler(this.btnAddSong_Click);
            // 
            // dgvPlayList
            // 
            this.dgvPlayList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlayList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvPlayList.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlayList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPlayList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSongName,
            this.ColSigerName,
            this.ColSongTime});
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
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ColSongName.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColSongName.HeaderText = "Tên Bài Hát";
            this.ColSongName.MinimumWidth = 6;
            this.ColSongName.Name = "ColSongName";
            // 
            // ColSigerName
            // 
            this.ColSigerName.DataPropertyName = "SingerName";
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ColSigerName.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColSigerName.HeaderText = "Ca Sĩ";
            this.ColSigerName.MinimumWidth = 6;
            this.ColSigerName.Name = "ColSigerName";
            // 
            // ColSongTime
            // 
            this.ColSongTime.DataPropertyName = "Minute";
            this.ColSongTime.HeaderText = "Thời Gian";
            this.ColSongTime.MinimumWidth = 6;
            this.ColSongTime.Name = "ColSongTime";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(23, 58);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(129, 20);
            this.lbl1.TabIndex = 16;
            this.lbl1.Text = "TÊN PLAYLIST:";
            // 
            // btnPlaylistManager2
            // 
            this.btnPlaylistManager2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnPlaylistManager2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaylistManager2.Location = new System.Drawing.Point(387, 12);
            this.btnPlaylistManager2.Name = "btnPlaylistManager2";
            this.btnPlaylistManager2.Size = new System.Drawing.Size(135, 32);
            this.btnPlaylistManager2.TabIndex = 15;
            this.btnPlaylistManager2.Text = "Chọn PlayList";
            this.btnPlaylistManager2.UseVisualStyleBackColor = false;
            this.btnPlaylistManager2.Click += new System.EventHandler(this.btnPlaylistManager2_Click);
            // 
            // txtThanhTimKiem
            // 
            this.txtThanhTimKiem.Location = new System.Drawing.Point(27, 16);
            this.txtThanhTimKiem.Name = "txtThanhTimKiem";
            this.txtThanhTimKiem.Size = new System.Drawing.Size(308, 22);
            this.txtThanhTimKiem.TabIndex = 14;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(125, 58);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 20);
            this.lblName.TabIndex = 23;
            // 
            // lblNamePlaylist
            // 
            this.lblNamePlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamePlaylist.Location = new System.Drawing.Point(158, 58);
            this.lblNamePlaylist.Name = "lblNamePlaylist";
            this.lblNamePlaylist.Size = new System.Drawing.Size(208, 20);
            this.lblNamePlaylist.TabIndex = 24;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TrinhPhatNhac.Properties.Resources.Search;
            this.pictureBox1.Location = new System.Drawing.Point(341, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnMoveUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveUp.Location = new System.Drawing.Point(276, 562);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(120, 43);
            this.btnMoveUp.TabIndex = 25;
            this.btnMoveUp.Text = "Di chuyển lên";
            this.btnMoveUp.UseVisualStyleBackColor = false;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnMoveDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveDown.Location = new System.Drawing.Point(402, 562);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(131, 43);
            this.btnMoveDown.TabIndex = 26;
            this.btnMoveDown.Text = "Di chuyển xuống";
            this.btnMoveDown.UseVisualStyleBackColor = false;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // PlaylistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(712, 633);
            this.Controls.Add(this.btnMoveDown);
            this.Controls.Add(this.btnMoveUp);
            this.Controls.Add(this.lblNamePlaylist);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnRemoveSong);
            this.Controls.Add(this.btnAddSong);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvPlayList);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnPlaylistManager2);
            this.Controls.Add(this.txtThanhTimKiem);
            this.Name = "PlaylistForm";
            this.Text = "PlaylistForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PlaylistForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnRemoveSong;
		private System.Windows.Forms.Button btnAddSong;
		private System.Windows.Forms.DataGridView dgvPlayList;
		private System.Windows.Forms.Label lbl1;
		private System.Windows.Forms.Button btnPlaylistManager2;
		private System.Windows.Forms.TextBox txtThanhTimKiem;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNamePlaylist;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSongName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSigerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSongTime;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Button btnMoveDown;
    }
}