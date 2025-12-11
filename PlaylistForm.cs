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

namespace TrinhPhatNhac
{
    public partial class PlaylistForm : Form
    {

        private List<Song> songList = new List<Song>();
        private List<Song> songListRoot = new List<Song>();
        private PlaylistSong currentPlayList;
        public PlaylistForm(List<Song> songlistroot, List<Song> songlist)
        {
            InitializeComponent();
            songList = songlist;
            songListRoot = songlistroot;
            dgvPlayList.AutoGenerateColumns = false;
            dgvPlayList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        // Property khởi tạo và trả về playlist hiện tại
        public PlaylistSong CurrentPlaylist
        {
            get { return currentPlayList; }
            set
            {
                currentPlayList = value;
                if (currentPlayList != null)
                {
                    songList.Clear();
                    songList.AddRange(currentPlayList.PlayList.ToList());
                    lblNamePlaylist.Text = currentPlayList.Name;
                    dgvPlayList.DataSource = null;
                    dgvPlayList.DataSource = songList;
                }
            }
        }

        #region Phương thức
        // Phương thức lưu playlist đã chọn
        private void SaveSelectedPlayList()
        {
            if (currentPlayList == null)
            {
                MessageBox.Show("Vui lòng chọn một Playlist trước khi thực hiện thao tác.",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var allPlayLists = PlaylistManager.LoadPlayList();
            PlaylistSong playListToUpdate = new PlaylistSong();
            foreach (var playList in allPlayLists)
            {
                if (currentPlayList.Name == playList.Name)
                {
                    playListToUpdate = playList;
                    break;
                }
            }
            if (playListToUpdate != null)
            {
                playListToUpdate.playList = songList.ToList();
                PlaylistManager.SavePlayLists(allPlayLists);
            }
            else
            {
                MessageBox.Show($"Không tìm thấy Playlist '{currentPlayList.Name}' trong danh sách lưu trữ.",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Phương thức tìm bài hát
        private List<Song> FindSongs(string searchKeyword)
        {
            List<Song> foundSongs = new List<Song>();
            foreach (Song song in songListRoot)
            {
                if ((song.SongName != null && song.SongName.ToLower().Contains(searchKeyword))
                    || (song.SingerName != null && song.SingerName.ToLower().Contains(searchKeyword)))
                {
                    foundSongs.Add(song);
                }
            }
            return foundSongs;
        }
        //Phương thức lấy sư kiên nút enter
        private void PlaylistForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Ngăn hệ thống xử lý phím Enter
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
        #endregion
        #region Button
        // Nút mở danh sách playlist
        private void btnPlaylistManager2_Click(object sender, EventArgs e)
        {
            using (PlaylistManagerForm qlPlaylist = new PlaylistManagerForm(songListRoot))
            {
                qlPlaylist.ShowDialog();
                // điều kiện kiểm tra nếu playlist đã chọn rỗng hoặc null thì dgv sẽ không có dữ liệu
                if (qlPlaylist.SelectedPlayList != null)
                {
                    CurrentPlaylist = qlPlaylist.SelectedPlayList;
                }
            }

        }
        //Nút thêm bài hát
        private void btnAddSong_Click(object sender, EventArgs e)
        {
            using (AddSongForm newForm = new AddSongForm(songListRoot, songList))
            {
                newForm.ShowDialog();
                if (newForm.CheckSelect())// nếu danh sách có thêm bài hát mới thì cập nhật lại data cho dgv
                {
                    dgvPlayList.DataSource = null;
                    dgvPlayList.DataSource = songList;
                    SaveSelectedPlayList();
                }
            }
        }
        //Nút xóa bài hát
        private void btnRemoveSong_Click(object sender, EventArgs e)
        {
            if (currentPlayList != null && currentPlayList.Name == "List Songs Root")
            {
                MessageBox.Show("Không thể xóa bài hát khỏi playlist mặc định 'List Songs Root'.",
                                "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
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
                    SaveSelectedPlayList();
                }
            }
        }
        //Nút tìm kiếm bài hát
        private void ptbFindSongs_Click(object sender, EventArgs e)
        {
            this.Focus();//chuyển tiêu điểm khỏi ô tìm kiếm và đặt nó lên chính playlistForm này
            string keyword = txtThanhTimKiem.Text.Trim().ToLower();
            dgvPlayList.DataSource = null;
            if (string.IsNullOrEmpty(keyword))
            {
                //dgvPlayList.DataSource = songList;
                MessageBox.Show("Tên bài hát không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                List<Song> foundSongs = FindSongs(keyword);
                dgvPlayList.DataSource = foundSongs;
                if (foundSongs.Count == 0)
                {
                    MessageBox.Show($"Không tìm thấy bài hát nào với từ khóa '{keyword}'",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        #endregion
    }
}
