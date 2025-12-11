using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiaoDien
{
    public partial class PlaylistManagerForm : Form
    {
        private Playlist _currentPlaylist;
        public PlaylistManagerForm()
        {

            InitializeComponent();
        }

        private void PlaylistManagerForm_Load(object sender, EventArgs e)
        {
            dgvPlaylistManager.AutoGenerateColumns = true;
            DataManager.LoadData();
            dgvPlaylistManager.DataSource = DataManager.AllPlaylists;
        }
        private void Moplaylist(string name)
        {
            PlaylistForm frm = new PlaylistForm(name);
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (dgvPlaylistManager.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvPlaylistManager.SelectedRows[0];

                if (selectedRow.IsNewRow)
                {
                    MessageBox.Show("Vui lòng chọn một Playlist đã tồn tại hoặc đã được tạo.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


                if (selectedRow.DataBoundItem is Playlist selectedPlaylist)
                {
                    Moplaylist(selectedPlaylist.Name);
                    return;
                }


                object cellValue = selectedRow.Cells["ColTenPlaylist"].Value;

                if (cellValue != null)
                {
                    string playlistName = cellValue.ToString();
                    Moplaylist(playlistName);
                }
                else
                {
                    MessageBox.Show("Ô tên Playlist không có dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }


        private void btnCreatePlaylist_Click(object sender, EventArgs e)
        {

            string newPlaylistName = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(newPlaylistName))
            {
                MessageBox.Show("Vui lòng nhập tên Playlist.");
                return;
            }


            bool existed = DataManager.AllPlaylists
                             .Any(p => p.Name.Equals(newPlaylistName, StringComparison.OrdinalIgnoreCase));

            if (existed)
            {
                MessageBox.Show("Tên Playlist đã tồn tại.");
                return;
            }


            Playlist newPlaylist = new Playlist(newPlaylistName);
            DataManager.AllPlaylists.Add(newPlaylist);

            DataManager.SaveData();


            dgvPlaylistManager.DataSource = null;
            dgvPlaylistManager.DataSource = DataManager.AllPlaylists;

            MessageBox.Show($"Đã tạo Playlist '{newPlaylistName}' thành công!");


        }




        private void dgvPlaylistManager_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void RefreshPlaylistDataGridView()
        {

            dgvPlaylistManager.DataSource = null;
            dgvPlaylistManager.DataSource = _currentPlaylist.Songs;
        }
        private void btnRemovePlaylist_Click(object sender, EventArgs e)
        {
            Playlist selected = dgvPlaylistManager.CurrentRow.DataBoundItem as Playlist;
            DataManager.AllPlaylists.Remove(selected);
            DataManager.SaveData();
            dgvPlaylistManager .DataSource= null;
            dgvPlaylistManager.DataSource = DataManager.AllPlaylists;
            MessageBox.Show("đã xóa thành công");
        }
    }
}

    
    

     
