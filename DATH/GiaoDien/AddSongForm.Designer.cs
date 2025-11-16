namespace GiaoDien
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
            this.dgvPlayList = new System.Windows.Forms.DataGridView();
            this.ColSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSongName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSingerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPlayList
            // 
            this.dgvPlayList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSTT,
            this.ColSongName,
            this.ColSingerName});
            this.dgvPlayList.Location = new System.Drawing.Point(12, 12);
            this.dgvPlayList.Name = "dgvPlayList";
            this.dgvPlayList.RowHeadersWidth = 51;
            this.dgvPlayList.RowTemplate.Height = 24;
            this.dgvPlayList.Size = new System.Drawing.Size(583, 431);
            this.dgvPlayList.TabIndex = 18;
            // 
            // ColSTT
            // 
            this.ColSTT.HeaderText = "STT";
            this.ColSTT.MinimumWidth = 6;
            this.ColSTT.Name = "ColSTT";
            this.ColSTT.Width = 125;
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
            // AddSongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 486);
            this.Controls.Add(this.dgvPlayList);
            this.Name = "AddSongForm";
            this.Text = "AddSongForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPlayList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSongName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSingerName;
    }
}