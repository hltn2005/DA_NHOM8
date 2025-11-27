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
        List<Song> targetPlayList;
        public bool checkList;

        public AddSongForm(List<Song> songlistroot,List<Song> playListToUpdate)
        {
            InitializeComponent();
            songListRoot=songlistroot;
            targetPlayList=playListToUpdate;
            dgvAddSong.AutoGenerateColumns = false;
            dgvAddSong.DataSource = songlistroot;
            dgvAddSong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int songSelected=0;
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
                    if(!targetPlayList.Contains(song))
                    {
                        targetPlayList.Add(song);
                        songSelected++;
                    }
                }
            }
            if(songSelected>0)
            {
                checkList = true;
            }

            this.Close();
        }
        public bool CheckSelect()
        {
            return checkList;
        }

        private void AddSongForm_Load(object sender, EventArgs e)
        {

        }
    }
}
