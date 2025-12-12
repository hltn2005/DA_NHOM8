using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrinhPhatNhac
{
    public partial class RenamePlaylistForm : Form
    {
        public RenamePlaylistForm()
        {
            InitializeComponent();
        }
        // Property để PlaylistManagerForm lấy tên mới sau khi đóng Form
        public string NewPlaylistName
        {
            get { return txtNewName.Text.Trim(); }
        }
        public RenamePlaylistForm(string currentName)
        {
            InitializeComponent();
            txtNewName.Text = currentName;
            txtNewName.SelectionStart = txtNewName.Text.Length;
            txtNewName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Kiểm tra tên rỗng cơ bản trước khi đóng Form
            if (string.IsNullOrWhiteSpace(NewPlaylistName))
            {
                MessageBox.Show("Tên playlist không được để trống.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Giữ nguyên Form
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
