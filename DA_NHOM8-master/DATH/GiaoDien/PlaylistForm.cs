using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GiaoDien
{
    
    using System.Collections.Generic;



    public partial class PlaylistForm : Form
    {

        private Playlist _currentPlaylist;
        public PlaylistForm(string playlistname)
        {
            InitializeComponent();
            dgvPlayList.AutoGenerateColumns = false;
            _currentPlaylist = DataManager.GetPlaylistByName(playlistname);

            if (_currentPlaylist != null)
            {
                this.Text = "Danh sách Bài hát của: " + playlistname;
                // 2. Gán danh sách Songs của Playlist này vào DataGridView
                dgvPlayList.DataSource = _currentPlaylist.Songs;
            }
            else
            {
                MessageBox.Show("Không tìm thấy Playlist này!");
                this.Close();
            }
        }



        private void RefreshDataGridView()
        {
            // Buộc DataGridView phải tải lại dữ liệu mới
            dgvPlayList.DataSource = null;
            dgvPlayList.DataSource = _currentPlaylist.Songs;
        }
        private void btnPlaylistManager2_Click(object sender, EventArgs e)
        {
            PlaylistManagerForm qlPlaylist = new PlaylistManagerForm();
            qlPlaylist.ShowDialog();
        }

        private void btnAddSong_Click(object sender, EventArgs e)
        {
            if(_currentPlaylist==null)
            {
                return;
            }
            using (var df = new OpenFileDialog { Multiselect = true, Filter = "Audio Files | *.mp3;*.wav;*.flac" })
            {
                if (df.ShowDialog() == DialogResult.OK)
                {
                    foreach(var filePath in df.FileNames)
                    {
                        Song song = new Song()
                        {
                            TenBaiHat = Path.GetFileNameWithoutExtension(filePath),
                            ThoiLuong = "0:00",
                            FilePath = filePath
                        };
                        _currentPlaylist.Songs.Add(song);
                    }
                    RefreshDataGridView();
                    DataManager.SaveData();

                }


                }


        }

        private void dgvPlayList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       
        private void btnRemoveSong_Click(object sender, EventArgs e)
        {
            
                if (_currentPlaylist == null) return;
                if (dgvPlayList.CurrentRow == null) return;

                if (dgvPlayList.CurrentRow.DataBoundItem is Song selectedSong)
                {
                    var confirm = MessageBox.Show(
                        $"Xoá bài '{selectedSong.TenBaiHat}' khỏi playlist?",
                        "Xác nhận xoá",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (confirm == DialogResult.Yes)
                    {
                        _currentPlaylist.Songs.Remove(selectedSong);
                        RefreshDataGridView();
                        DataManager.SaveData();
                    }
                }
            }

        }
    }



