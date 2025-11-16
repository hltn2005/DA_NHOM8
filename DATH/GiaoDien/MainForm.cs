using GiaoDien.Properties;
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
using WMPLib;
namespace GiaoDien
{
    public partial class MainForm : Form
    {
        LoadFileForm frmloadform;
        DoubleLinkedList.DoubleLinkedListSong songList;
        public MainForm(DoubleLinkedList.DoubleLinkedListSong list, LoadFileForm load)
        {
            InitializeComponent();
            songList = list;
            frmloadform = load;

        }
        public void LoadSong(string filePath)
        {
            if (string.IsNullOrEmpty(filePath) || !System.IO.File.Exists(filePath))
            {
                lblNameSong.Text = "Không tìm thấy thông tin bài hát";
                lblSingerName.Text = "Không tìm thấy thông tim ca sỹ";
                pctMusicPicture.Image = Properties.Resources.DefaultMusicIcon;
                return;
            }

            TagLib.File file = TagLib.File.Create(filePath);
            string songName = file.Tag.Title;
            string singerName = string.Join(",", file.Tag.Performers);
            string displaySongName = string.IsNullOrEmpty(songName) ?
                Path.GetFileNameWithoutExtension(filePath) : songName;
            string displaySingerName = string.IsNullOrWhiteSpace(singerName) ?
                Path.GetFileNameWithoutExtension(filePath) : singerName;
            lblSongName.Text = displaySongName.ToString();
            lblSingerName.Text = displaySingerName.ToString();
            if (file.Tag.Pictures.Length > 0)
            {
                IPicture picture = file.Tag.Pictures[0];
                byte[] pitureBytes = picture.Data.Data;
                if (pitureBytes != null && pitureBytes.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(pitureBytes))
                    {
                        Image tmp = Image.FromStream(ms);
                        pctMusicPicture.Image = new Bitmap(tmp);
                    }
                }
                else
                {
                    pctMusicPicture.Image = Properties.Resources.DefaultMusicIcon;
                }
            }
            else
            {
                pctMusicPicture.Image = Properties.Resources.DefaultMusicIcon;
            }
            axWMP.settings.autoStart = false;
            axWMP.URL = filePath;
        }
        private void checkAction()
        {
            if(axWMP.playState==WMPLib.WMPPlayState.wmppsPlaying)
            {
                btnPlay.Visible = false;
                btnPause.Visible = true;
            }
            else 
            {
                btnPause.Visible = false;
                btnPlay.Visible = true;
            }
            if(axWMP.playState == WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                LoadSong(songList.NextSong());
                axWMP.Ctlcontrols.play();
            }
        }
        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            PlaylistForm xemPlaylist = new PlaylistForm(songList);
            xemPlaylist.Show();
        }

        private void btnPlaylistManager_Click(object sender, EventArgs e)
        {
            PlaylistManagerForm qlPlaylist = new PlaylistManagerForm();
            qlPlaylist.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmloadform.Show();
            this.Hide();
        }

        

        private void btnPlay_Click(object sender, EventArgs e)
        {
                axWMP.Ctlcontrols.play();
        }
        private void btnPause_Click(object sender, EventArgs e)
        {
            axWMP.Ctlcontrols.pause();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {

            bool isPlaying = (axWMP.playState == WMPLib.WMPPlayState.wmppsPlaying);
            LoadSong(songList.PrevSong());
            if (isPlaying)
                axWMP.Ctlcontrols.play();
            else
                axWMP.Ctlcontrols.pause();

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            bool isPlaying = (axWMP.playState == WMPLib.WMPPlayState.wmppsPlaying);
            LoadSong(songList.PrevSong());
            if (isPlaying)
                axWMP.Ctlcontrols.play();
            else 
                axWMP.Ctlcontrols.pause();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadSong(songList.GetCurrentSong());
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void axWMP_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            checkAction();
        }

        private void btnRepeat_Click(object sender, EventArgs e)
        {
            LoadSong(songList.GetCurrentSong());
            axWMP.Ctlcontrols.play();
        }
    }
}
