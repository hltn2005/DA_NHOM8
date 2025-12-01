namespace TrinhPhatNhac
{
    partial class AddSongForm
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
			this.dgvAddSong = new System.Windows.Forms.DataGridView();
			this.ColSongName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColSingerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnThem = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvAddSong)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvAddSong
			// 
			this.dgvAddSong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvAddSong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAddSong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSongName,
            this.ColSingerName});
			this.dgvAddSong.Location = new System.Drawing.Point(12, 12);
			this.dgvAddSong.Name = "dgvAddSong";
			this.dgvAddSong.RowHeadersWidth = 51;
			this.dgvAddSong.RowTemplate.Height = 24;
			this.dgvAddSong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvAddSong.Size = new System.Drawing.Size(688, 431);
			this.dgvAddSong.TabIndex = 18;
			// 
			// ColSongName
			// 
			this.ColSongName.DataPropertyName = "SongName";
			this.ColSongName.HeaderText = "Tên Bài Hát";
			this.ColSongName.MinimumWidth = 6;
			this.ColSongName.Name = "ColSongName";
			// 
			// ColSingerName
			// 
			this.ColSingerName.DataPropertyName = "SingerName";
			this.ColSingerName.HeaderText = "Ca Sĩ";
			this.ColSingerName.MinimumWidth = 6;
			this.ColSingerName.Name = "ColSingerName";
			// 
			// btnThem
			// 
			this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThem.Location = new System.Drawing.Point(580, 449);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(85, 51);
			this.btnThem.TabIndex = 19;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = false;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// AddSongForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(712, 512);
			this.Controls.Add(this.btnThem);
			this.Controls.Add(this.dgvAddSong);
			this.Name = "AddSongForm";
			this.Text = "AddSongForm";
			this.Load += new System.EventHandler(this.AddSongForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvAddSong)).EndInit();
			this.ResumeLayout(false);
=======
            this.dgvAddSong = new System.Windows.Forms.DataGridView();
            this.ColSongName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSingerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddSong)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAddSong
            // 
            this.dgvAddSong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddSong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSongName,
            this.ColSingerName});
            this.dgvAddSong.Location = new System.Drawing.Point(12, 12);
            this.dgvAddSong.Name = "dgvAddSong";
            this.dgvAddSong.RowHeadersWidth = 51;
            this.dgvAddSong.RowTemplate.Height = 24;
            this.dgvAddSong.Size = new System.Drawing.Size(688, 431);
            this.dgvAddSong.TabIndex = 18;
            // 
            // ColSongName
            // 
            this.ColSongName.DataPropertyName = "SongName";
            this.ColSongName.HeaderText = "Tên Bài Hát";
            this.ColSongName.MinimumWidth = 6;
            this.ColSongName.Name = "ColSongName";
            this.ColSongName.Width = 125;
            // 
            // ColSingerName
            // 
            this.ColSingerName.DataPropertyName = "SingerName";
            this.ColSingerName.HeaderText = "Ca Sĩ";
            this.ColSingerName.MinimumWidth = 6;
            this.ColSingerName.Name = "ColSingerName";
            this.ColSingerName.Width = 125;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(580, 449);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(85, 51);
            this.btnThem.TabIndex = 19;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // AddSongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 512);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvAddSong);
            this.Name = "AddSongForm";
            this.Text = "AddSongForm";
            this.Load += new System.EventHandler(this.AddSongForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddSong)).EndInit();
            this.ResumeLayout(false);
>>>>>>> bb97091cb84098b8a9cde50f6ce5deb0ecf38d7c

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAddSong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSongName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSingerName;
    }
}