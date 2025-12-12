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
        List<PlaylistSong> playLists;
        List<Song> songListRoot;
        PlaylistSong selectedPlayList;
        public string oldPlaylistName;
        bool checkSelect = false;
        public PlaylistManagerForm(List<Song> rootLists)
        {
            InitializeComponent();
            songListRoot = rootLists;
            playLists = PlaylistManager.LoadPlayList();
            dgvPlaylistManager.AutoGenerateColumns = false;
            dgvPlaylistManager.DataSource = playLists;

        }
        // property dữ liệu của selectedPlayList
        public PlaylistSong SelectedPlayList
        {
            get { return selectedPlayList; }
            set { selectedPlayList = value; }
        }
        //Phương thức lấy tên playlist
        private void dgvPlaylistManager_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                oldPlaylistName = dgvPlaylistManager.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            }
        }
        #region Button
        // Nút tạo playlist
        private void btnCreatePlaylist_Click(object sender, EventArgs e)
        {
            string newNamePlayList = txtNamePlayList.Text;
            if (string.IsNullOrEmpty(newNamePlayList))
            {
                MessageBox.Show("Tên playlist không được để trống", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (var playListName in playLists)
                if (playListName.Name == newNamePlayList)
                {
                    MessageBox.Show("Tên playlist đã tồn tại!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            PlaylistSong newPlayList = new PlaylistSong
            {
                Name = newNamePlayList,
                PlayList = new List<Song>()
            };
            playLists.Add(newPlayList);
            dgvPlaylistManager.DataSource = null;
            dgvPlaylistManager.DataSource = playLists;
            PlaylistManager.SavePlayLists(playLists);
        }
        //Nút thêm bài hát vào playlist
        private void btnAddSong_Click(object sender, EventArgs e)
        {
            if (dgvPlaylistManager.SelectedRows.Count != 1)
                return;
            // khởi tạo giá trị cho đối tượng selectedPlayList từ dữ liệu trong dgv
            PlaylistSong selectedPlayList = dgvPlaylistManager.SelectedRows[0].DataBoundItem
                as PlaylistSong;
            if (selectedPlayList != null)
            {
                /* 
                    gọi đến form ds tất cả bài hát
                    gọi property  của class PlayListSong để truyền giá trị và trả về 1 list song
                    playlist sẽ nhận các bài hát đã chọn và được lưu lại sau khi form AddSongForm đóng
                */
                using (AddSongForm addForm = new AddSongForm(songListRoot, selectedPlayList.PlayList))
                {
                    addForm.ShowDialog();
                    if (addForm.CheckSelect())
                    {
                        dgvPlaylistManager.DataSource = null;
                        dgvPlaylistManager.DataSource = playLists;
                        PlaylistManager.SavePlayLists(playLists);
                    }
                }
            }
        }
        //Nút chọn playlist
        private void btnSelectPlayList_Click(object sender, EventArgs e)
        {
            if (dgvPlaylistManager.SelectedRows == null)
            {
                MessageBox.Show("Vui lòng chọn một Playlist.", "Thông báo"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // Gán selectedPlayList từ DataBoundItem (sử dụng tham chiếu)
            selectedPlayList = dgvPlaylistManager.SelectedRows[0].DataBoundItem as PlaylistSong;
            checkSelect = true;
            this.Close();
        }
        //Nút xóa playlist
        private void btnRemovePlaylist_Click(object sender, EventArgs e)
        {
            if (dgvPlaylistManager.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn playlist cần xóa", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            PlaylistSong playListToRemove = dgvPlaylistManager.SelectedRows[0].DataBoundItem as PlaylistSong;

            if (playListToRemove.Name == "List Songs Root")
            {
                MessageBox.Show("Không thể xóa playlist mặc định 'List Songs Root'.",
                                "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa playlist {playListToRemove.Name}" +
                $" này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                playLists.Remove(playListToRemove);
                dgvPlaylistManager.DataSource = null;
                dgvPlaylistManager.DataSource = playLists;
                PlaylistManager.SavePlayLists(playLists);
            }
            if (SelectedPlayList == playListToRemove)
            {
                SelectedPlayList = null;
            }
        }
        //Nút chỉnh sửa tên playlist
        private void btnEditPlaylist_Click(object sender, EventArgs e)
        {
            if (dgvPlaylistManager.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một playlist để sửa.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Đối tượng dữ liệu đang được sửa
            PlaylistSong playlistToUpdate = dgvPlaylistManager.SelectedRows[0].DataBoundItem as PlaylistSong;

            if (playlistToUpdate.Name == "List Songs Root")
            {
                MessageBox.Show("Không thể đổi tên Playlist mặc định.", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            oldPlaylistName = playlistToUpdate.Name;
            using (RenamePlaylistForm renameForm = new RenamePlaylistForm(oldPlaylistName))
            {
                renameForm.ShowDialog();
                string newName = renameForm.NewPlaylistName;
                if (string.IsNullOrWhiteSpace(newName) ||
                    newName.Equals(oldPlaylistName))
                {
                    return;
                }

                // KIỂM TRA TRÙNG TÊN 
                bool nameAlreadyExists = false;
                foreach (var playlist in playLists)
                {
                    // Kiểm tra trùng với tên playlist khác
                    if (playlist != playlistToUpdate &&
                        playlist.Name.Equals(newName))
                    {
                        nameAlreadyExists = true;
                        break;
                    }
                }

                if (nameAlreadyExists)
                {
                    MessageBox.Show($"Tên playlist '{newName}' đã tồn tại.", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // CẬP NHẬT TÊN VÀ LƯU
                DialogResult result = MessageBox.Show(
                    $"Bạn có chắc muốn đổi tên playlist từ '{oldPlaylistName}' thành '{newName}' không?",
                    "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    playlistToUpdate.Name = newName;
                    dgvPlaylistManager.DataSource = null;
                    dgvPlaylistManager.DataSource = playLists;
                    PlaylistManager.SavePlayLists(playLists);
                }
            }
        }
        #endregion

        private void PlaylistManagerForm_Load(object sender, EventArgs e)
        {
            PlaylistSong newplaylistRoot = new PlaylistSong();
            newplaylistRoot.Name = "List Songs Root";
            newplaylistRoot.PlayList = songListRoot.ToList();
            //CẬP NHẬT IMAGEBASE64 CHO 'List Songs Root'
            foreach (var song in newplaylistRoot.PlayList)
            {
                if (song.Image != null)
                {
                    song.ImageBase64 = PlaylistManager.ConvertImageToBase64(song.Image);
                }
            }
            PlaylistSong oldPlaylistRoot = null;
            int rootIndex = -1;
            //  Tìm và lưu trữ đối tượng "List Songs Root"
            for (int i = 0; i < playLists.Count; i++)
            {
                if (playLists[i].Name == newplaylistRoot.Name)
                {
                    oldPlaylistRoot = playLists[i];
                    rootIndex = i;
                    break;
                }
            }

            // BƯỚC B: Nếu tìm thấy, di chuyển nó lên đầu danh sách
            if (oldPlaylistRoot != null)
            {
                // Loại bỏ nó khỏi vị trí hiện tại
                playLists.RemoveAt(rootIndex);
            }
            // Chèn nó vào vị trí đầu tiên (Index 0)
            playLists.Insert(0, newplaylistRoot);
            // cập nhật lại danh sách playlist
            PlaylistManager.SavePlayLists(playLists);
            dgvPlaylistManager.DataSource = null;
            dgvPlaylistManager.DataSource = playLists;
        }
        public bool CheckSelect()
        {
            return checkSelect;
        }
    }
}
