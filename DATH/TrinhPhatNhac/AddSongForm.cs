using TrinhPhatNhac;
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
using TagLib;

namespace TrinhPhatNhac
{
    public partial class AddSongForm : Form
    {
        List<Song> songListRoot = new List<Song>();
        List<Song> songList = new List<Song>();
        public bool checkList;
        public AddSongForm(List<Song> songlistroot,List<Song> songlist)
        {
            InitializeComponent();
            songList = songlist;
            songListRoot=songlistroot;
            dgvAddSong.AutoGenerateColumns = false;
            dgvAddSong.DataSource = songlistroot;
            dgvAddSong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            List<Song> selectecSong = new List<Song>();
            if (dgvAddSong.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn bài hát cần thêm hoặc thoát",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach (DataGridViewRow row in dgvAddSong.SelectedRows)
            {
                if(row.DataBoundItem is Song song)
                {
                    selectecSong.Add(song);
                }
            }
            songList.Clear();
            foreach (var song in selectecSong)
            {
                songList.Add(song);
            }
            checkList = true;
            this.Close();
        }
        public bool CheckSelect()
        {
            if (checkList)
                return true;
            else
                return false;
        }
        
    }
}
