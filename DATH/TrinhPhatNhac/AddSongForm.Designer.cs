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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgvAddSong = new System.Windows.Forms.DataGridView();
			this.ColSongName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColSongTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColSingerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnThem = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvAddSong)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvAddSong
			// 
			this.dgvAddSong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvAddSong.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			this.dgvAddSong.BackgroundColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvAddSong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvAddSong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAddSong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSongName,
            this.ColSongTime,
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
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.ColSongName.DefaultCellStyle = dataGridViewCellStyle5;
			this.ColSongName.HeaderText = "Tên Bài Hát";
			this.ColSongName.MinimumWidth = 6;
			this.ColSongName.Name = "ColSongName";
			// 
			// ColSongTime
			// 
			this.ColSongTime.DataPropertyName = "Minute";
			this.ColSongTime.HeaderText = "Thời Gian";
			this.ColSongTime.MinimumWidth = 6;
			this.ColSongTime.Name = "ColSongTime";
			// 
			// ColSingerName
			// 
			this.ColSingerName.DataPropertyName = "SingerName";
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.ColSingerName.DefaultCellStyle = dataGridViewCellStyle6;
			this.ColSingerName.HeaderText = "Ca Sĩ";
			this.ColSingerName.MinimumWidth = 6;
			this.ColSingerName.Name = "ColSingerName";
			// 
			// btnThem
			// 
			this.btnThem.BackColor = System.Drawing.Color.Chartreuse;
			this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
			this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.ClientSize = new System.Drawing.Size(712, 512);
			this.Controls.Add(this.btnThem);
			this.Controls.Add(this.dgvAddSong);
			this.Name = "AddSongForm";
			this.Text = "AddSongForm";
			
			((System.ComponentModel.ISupportInitialize)(this.dgvAddSong)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAddSong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSongName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSongTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSingerName;
    }
}