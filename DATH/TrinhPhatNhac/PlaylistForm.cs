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
<<<<<<< HEAD
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TrinhPhatNhac
{
    public partial class btnFindSongs : Form
    {

        List<Song> songList = new List<Song>();
        List<Song> songListRoot = new List<Song>();
        private PlayListSong PlayListSong = new PlayListSong();
        public btnFindSongs(List<Song> songlistroot, List<Song> songlist)
=======

namespace TrinhPhatNhac
{
    public partial class PlaylistForm : Form
    {
 
        List<Song> songList = new List<Song>();
        List<Song> songListRoot=new List<Song>();
        public PlaylistForm(List<Song> songlistroot,List<Song> songlist)
>>>>>>> bb97091cb84098b8a9cde50f6ce5deb0ecf38d7c
        {
            InitializeComponent();
            songList = songlist;
            songListRoot = songlistroot;
            dgvPlayList.AutoGenerateColumns = false;
<<<<<<< HEAD
            dgvPlayList.DataSource = songlist;
=======
            dgvPlayList.DataSource=songlist;
>>>>>>> bb97091cb84098b8a9cde50f6ce5deb0ecf38d7c
            dgvPlayList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        #region Button
        private void btnPlaylistManager2_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            PlaylistManagerForm qlPlaylist = new PlaylistManagerForm(songListRoot, songList);
=======
            PlaylistManagerForm qlPlaylist = new PlaylistManagerForm( songListRoot,songList);
>>>>>>> bb97091cb84098b8a9cde50f6ce5deb0ecf38d7c
            qlPlaylist.ShowDialog();
            // điều kiện kiểm tra nếu playlist đã chọn rỗng hoặc null thì dgv sẽ không có dữ liệu
            if (songList == null || songList.Count == 0)
            {
                dgvPlayList.DataSource = null;
                return;
            }
<<<<<<< HEAD
            if (qlPlaylist.SelectedPlayList != null && qlPlaylist.SelectedPlayList.PlayList.Count > 0)
=======
            if (qlPlaylist.SelectedPlayList!=null&&qlPlaylist.SelectedPlayList.PlayList.Count>0)
>>>>>>> bb97091cb84098b8a9cde50f6ce5deb0ecf38d7c
            {
                songList.Clear();
                songList.AddRange(qlPlaylist.SelectedPlayList.PlayList);// addrange thêm nhiều bài hát 1 lần 
                dgvPlayList.DataSource = null;
                dgvPlayList.DataSource = songList;// tạo lại data cho dgv
            }
        }

        private void btnAddSong_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            AddSongForm newForm = new AddSongForm(songListRoot, songList);
            newForm.ShowDialog();
            if (newForm.CheckSelect())// nếu danh sách có thêm bài hát mới thì cập nhật lại data cho dgv
=======
            AddSongForm newForm = new AddSongForm(songListRoot,songList);
            newForm.ShowDialog();
            if(newForm.CheckSelect())// nếu danh sách có thêm bài hát mới thì cập nhật lại data cho dgv
>>>>>>> bb97091cb84098b8a9cde50f6ce5deb0ecf38d7c
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
<<<<<<< HEAD
                string songRemove = selectedRow.Cells[0].Value.ToString();
                DialogResult result = MessageBox.Show($"Bạn có chắc chăn muốn xóa bài {songRemove} không ?", "Thông báo",
=======
                string songRemove= selectedRow.Cells[0].Value.ToString();
                DialogResult result= MessageBox.Show($"Bạn có chắc chăn muốn xóa bài {songRemove} không ?", "Thông báo",
>>>>>>> bb97091cb84098b8a9cde50f6ce5deb0ecf38d7c
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
<<<<<<< HEAD

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

                //Trỏ lại chỗ được chọn
                dgvPlayList.Rows[selectedIndex].Selected = false;
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

                //Trỏ lại chỗ được chọn
                dgvPlayList.Rows[selectedIndex].Selected = false;
                dgvPlayList.Rows[selectedIndex + 1].Selected = true;
            }
        }
=======
>>>>>>> bb97091cb84098b8a9cde50f6ce5deb0ecf38d7c
    }
}
