using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TrinhPhatNhac
{
    public partial class btnFindSongs : Form
    {

        List<Song> songList = new List<Song>();
        List<Song> songListRoot = new List<Song>();
        private PlayListSong PlayListSong = new PlayListSong();
        public btnFindSongs(List<Song> songlistroot, List<Song> songlist)
        {
            InitializeComponent();
            songList = songlist;
            songListRoot = songlistroot;
            dgvPlayList.AutoGenerateColumns = false;
            dgvPlayList.DataSource = songlist;
            dgvPlayList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        #region Button
        private void btnPlaylistManager2_Click(object sender, EventArgs e)
        {
            PlaylistManagerForm qlPlaylist = new PlaylistManagerForm(songListRoot, songList);
            qlPlaylist.ShowDialog();
            // điều kiện kiểm tra nếu playlist đã chọn rỗng hoặc null thì dgv sẽ không có dữ liệu
            if (songList == null || songList.Count == 0)
            {
                dgvPlayList.DataSource = null;
                return;
            }
            if (qlPlaylist.SelectedPlayList != null && qlPlaylist.SelectedPlayList.PlayList.Count > 0)
            {
                songList.Clear();
                songList.AddRange(qlPlaylist.SelectedPlayList.PlayList);// addrange thêm nhiều bài hát 1 lần 
                dgvPlayList.DataSource = null;
                dgvPlayList.DataSource = songList;// tạo lại data cho dgv
            }
        }

        private void btnAddSong_Click(object sender, EventArgs e)
        {
            AddSongForm newForm = new AddSongForm(songListRoot, songList);
            newForm.ShowDialog();
            if (newForm.CheckSelect())// nếu danh sách có thêm bài hát mới thì cập nhật lại data cho dgv
            {
                dgvPlayList.DataSource = null;
                dgvPlayList.DataSource = songList;
            }
        }

        private void btnRemoveSong_Click(object sender, EventArgs e)
        {
            if (dgvPlayList.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvPlayList.SelectedRows[0];
                string songRemove = selectedRow.Cells[0].Value.ToString();
                DialogResult result = MessageBox.Show($"Bạn có chắc chăn muốn xóa bài {songRemove} không ?", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    Song song = selectedRow.DataBoundItem as Song;
                    songList.Remove((Song)song);
                    dgvPlayList.DataSource = null;
                    dgvPlayList.DataSource = songList;
                }
            }
        }
        #endregion
        private void PlaylistForm_Load(object sender, EventArgs e)
        {
            //dgvPlayList.DataSource=currentList.ConvertToList();
        }

        private List<Song> FindSongs(string searchKeyword)
        {
            List<Song> foundSongs = new List<Song>();
            if (string.IsNullOrEmpty(searchKeyword))
                return foundSongs;
            foreach (Song song in songList)
            {
                if ((song.SongName != null && song.SongName.ToLower().Contains(searchKeyword))
                    || (song.SingerName != null && song.SingerName.ToLower().Contains(searchKeyword)))
                {
                    foundSongs.Add(song);
                }
            }
            return foundSongs;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string keyword = txtFindSongs.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(keyword))
                dgvPlayList.DataSource = songList;
            else
            {
                List<Song> foundSongs = FindSongs(keyword);
                dgvPlayList.DataSource = foundSongs;
            }
        }

        private int GetSelectedRowIndex()
        {
            if (dgvPlayList.SelectedRows.Count == 1)
                return dgvPlayList.SelectedRows[0].Index;
            return -1;
        }
        private void SwapSong(List<Song> list, int indexA, int indexB)
        {
            Song song = list[indexA];
            list[indexA] = list[indexB];
            list[indexB] = song;
        }

        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            int selectedIndex = GetSelectedRowIndex();
            if (selectedIndex > 0)
            {
                SwapSong(songList, selectedIndex, selectedIndex - 1);

                dgvPlayList.DataSource = null;
                dgvPlayList.DataSource = songList;

				//Bỏ chọn tất cả các hàng
				dgvPlayList.ClearSelection();
				//Trỏ lại chỗ được chọn
				dgvPlayList.Rows[selectedIndex - 1].Selected = true;
            }
        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            int selectedIndex = GetSelectedRowIndex();
            if (selectedIndex != -1 && selectedIndex < songList.Count - 1)
            {
                SwapSong(songList, selectedIndex, selectedIndex + 1);

                dgvPlayList.DataSource = null;
                dgvPlayList.DataSource = songList;

                //Bỏ chọn tất cả các hàng
                dgvPlayList.ClearSelection();
				//Trỏ lại chỗ được chọn
				dgvPlayList.Rows[selectedIndex + 1].Selected = true;
            }
        }
    }
}
