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
    public partial class PlaylistManagerForm : Form
    {
        List<PlayListSong> playLists;
        List<Song> songListRoot;
        PlayListSong selectedPlayList;
        List<Song> songList=new List<Song>();
        public PlayListSong SelectedPlayList
        {
            get { return selectedPlayList; }
            set { selectedPlayList = value; }
        }// property dữ liệu của selectedPlayList
        public PlaylistManagerForm(List<Song> rootLists,List<Song> songlist)
        {
            InitializeComponent();
            songListRoot = rootLists;
            songList = songlist;
            playLists = PlayListManager.LoadPlayList();
            dgvPlaylistManager.AutoGenerateColumns = false;
            dgvPlaylistManager.DataSource = playLists;
        }
        #region Button
        private void btnCreatePlaylist_Click(object sender, EventArgs e)
        {
            string newNamePlayList = txtNamePlayList.Text;
            if (string.IsNullOrEmpty(newNamePlayList))
            {
                MessageBox.Show("Tên playlist không được để trống", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (playLists.Any(song => song.Name == newNamePlayList))
            {
                MessageBox.Show("Tên playlist đã tồn tại!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            PlayListSong newPlayList = new PlayListSong
            {
                Name = newNamePlayList,
                PlayList = new List<Song>()
            };
            playLists.Add(newPlayList);
            dgvPlaylistManager.DataSource = null;
            dgvPlaylistManager.DataSource = playLists;
            PlayListManager.SavePlayLists(playLists);
        }
        private void btnAddSong_Click(object sender, EventArgs e)
        {
            if (dgvPlaylistManager.SelectedRows.Count != 1)
                return;
            // khởi tạo giá trị cho đối tượng selectedPlayList từ dữ liệu trong dgv
            PlayListSong selectedPlayList = dgvPlaylistManager.SelectedRows[0].DataBoundItem
                as PlayListSong;
            if (selectedPlayList != null)
            {
                /* 
                    gọi đến form ds tất cả bài hát
                    gọi property  của class PlayListSong để truyền giá trị và trả về 1 list song
                    playlist sẽ nhận các bài hát đã chọn và được lưu lại sau khi form AddSongForm đóng
                */
                AddSongForm addForm = new AddSongForm(songListRoot,selectedPlayList.PlayList);
                addForm.ShowDialog();
                if (addForm.CheckSelect())
                {
                    dgvPlaylistManager.DataSource = null;
                    dgvPlaylistManager.DataSource = playLists;
                    PlayListManager.SavePlayLists(playLists);
                }
            }
        }

        private void btnSelectPlayList_Click(object sender, EventArgs e)
        {
            selectedPlayList = dgvPlaylistManager.SelectedRows[0].DataBoundItem as PlayListSong;
            songList.Clear();
            foreach (Song song in selectedPlayList.PlayList)
            {
                songList.Add(song);
            }
        }
        private void btnRemovePlaylist_Click(object sender, EventArgs e)
        {
            if(dgvPlaylistManager.SelectedRows.Count==0)
            {
                MessageBox.Show("Vui lòng chọn playlist cần xóa", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            PlayListSong playListToRemove = dgvPlaylistManager.SelectedRows[0].DataBoundItem as PlayListSong;

            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa playlist {playListToRemove.Name}" +
                $" này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                playLists.Remove(playListToRemove);
                dgvPlaylistManager.DataSource = null;
                dgvPlaylistManager.DataSource= playLists;
                PlayListManager.SavePlayLists(playLists);
            }
        }
        #endregion
    }
}
