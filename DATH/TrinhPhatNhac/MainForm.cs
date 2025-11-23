using TrinhPhatNhac.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TagLib;
using WMPLib;
namespace TrinhPhatNhac
{
    public partial class MainForm : Form
    {

        LinkedListFilePath.LinkedListPath pathList = new LinkedListFilePath.LinkedListPath();
        List<Song> songList = new List<Song>();

        List<Song> songListRoot = new List<Song>();
        DoubleLinkedListFileSong.DoubleLinkedListSong songLinkedList;


        public MainForm()
        {
            InitializeComponent();
        }

        public void LoadSong(LinkedListFilePath.LinkedListPath filePath)
        {
            string currentPath = filePath.GetCurrentPath();
            if (filePath.GetCurrentPath() == null)
            {
                Console.WriteLine(1);
            }
            while (currentPath != null)
            {
                if (string.IsNullOrEmpty(filePath.GetCurrentPath()) || !System.IO.File.Exists(filePath.GetCurrentPath()))
                {
                    lblNameSong.Text = "Không tìm thấy thông tin bài hát";
                    lblSingerName.Text = "Không tìm thấy thông tim ca sỹ";
                    pctMusicPicture.Image = Properties.Resources.DefaultMusicIcon;
                    return;
                }

                TagLib.File file = TagLib.File.Create(filePath.GetCurrentPath(), TagLib.ReadStyle.Average);
                string songNameFile = file.Tag.Title;
                string singerNameFile = string.Join(",", file.Tag.Performers);
                string songName = string.IsNullOrEmpty(songNameFile) ?
                    Path.GetFileNameWithoutExtension(filePath.GetCurrentPath()) : songNameFile;
                string singerName = string.IsNullOrWhiteSpace(singerNameFile) ?
                    Path.GetFileNameWithoutExtension(filePath.GetCurrentPath()) : singerNameFile;
                TimeSpan minute = file.Properties.Duration;
                Image image;
                if (file.Tag.Pictures.Length > 0)
                {
                    IPicture picture = file.Tag.Pictures[0];
                    byte[] pitureBytes = picture.Data.Data;
                    if (pitureBytes != null && pitureBytes.Length > 0)
                    {
                        using (MemoryStream ms = new MemoryStream(pitureBytes))
                        {
                            Image tmp = Image.FromStream(ms);
                            image = new Bitmap(tmp);
                        }
                    }
                    else
                    {
                        image = Properties.Resources.DefaultMusicIcon;
                    }
                }
                else
                {
                    image = Properties.Resources.DefaultMusicIcon;
                }
                Song song = new Song(songName, singerName, filePath.GetCurrentPath(), image, minute);
                songList.Add(song);
                songListRoot.Add(song);
                filePath.NextPath();
                currentPath = filePath.GetCurrentPath();
            }
            if (songList.Count > 0)
            {
                ConvertListSongToLinkedList();
                DisplayAndPlay(songLinkedList.GetCurrentSong());
            }
            else
            {
                lblNameSong.Text = "Không tìm thấy bài hát nào";
                lblSingerName.Text = "";
                pctMusicPicture.Image = Properties.Resources.DefaultMusicIcon;
            }
        }
        public void ConvertListSongToLinkedList()
        {
            songLinkedList = new DoubleLinkedListFileSong.DoubleLinkedListSong();
            foreach (var song in songList)
            {
                songLinkedList.AddLast(song);
            }
            songLinkedList.ResetSong();
            axWMP.settings.autoStart = false;
            axWMP.URL = songLinkedList.GetCurrentSong().FilePath;
        }
        public void DisplayAndPlay(Song song)
        {
            lblSongName.Text = song.SongName.ToString();
            lblSingerName.Text = song.SingerName.ToString();
            pctMusicPicture.Image = song.Image;
            axWMP.URL = song.FilePath;
        }
        private void checkAction()
        {
            if (axWMP.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                btnPlay.Visible = false;
                btnPause.Visible = true;
            }
            else
            {
                btnPause.Visible = false;
                btnPlay.Visible = true;
            }

        }
        private string GetPlayListFilePath(string playListName)
        {
            string fileName = playListName + ".txt";
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
        }
        public void SavePlayList(List<string> pathList, string playName)
        {
            if (pathList.Count > 0)
            {
                playName = "CurrentPlayList";
                string filePath = GetPlayListFilePath(playName);
                System.IO.File.WriteAllLines(filePath, pathList);
            }

        }
        private void btnPlaylist_Click(object sender, EventArgs e)
        {

            PlaylistForm OpenPlaylist = new PlaylistForm(songListRoot, songList);
            OpenPlaylist.ShowDialog();
            songLinkedList = new DoubleLinkedListFileSong.DoubleLinkedListSong();
            foreach (var song in songList)
            {
                songLinkedList.AddLast(song);
            }
            songLinkedList.ResetSong();
            DisplayAndPlay(songLinkedList.GetCurrentSong());
        }

        private void btnPlaylistManager_Click(object sender, EventArgs e)
        {
            PlaylistManagerForm qlPlaylist = new PlaylistManagerForm();
            qlPlaylist.ShowDialog();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            LoadFileForm loadFileForm = new LoadFileForm(pathList);
            loadFileForm.ShowDialog();
            LoadSong(pathList);
        }



        private void btnPlay_Click(object sender, EventArgs e)
        {
            DisplayAndPlay(songLinkedList.GetCurrentSong());
            if (songLinkedList.GetCurrentSong() != null)
            {
                axWMP.Ctlcontrols.play();
                axWMP.Ctlcontrols.currentPosition = 180;
            }
            else
            {
                MessageBox.Show("Đường dẫn đến folder chưa được bổ sung hoặc sai đường dẫn",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnPause_Click(object sender, EventArgs e)
        {
            axWMP.Ctlcontrols.pause();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            Song nextSong = songLinkedList.NextSong();
            if (nextSong != null)
            {
                bool isPlaying = (axWMP.playState == WMPLib.WMPPlayState.wmppsPlaying);
                DisplayAndPlay(nextSong);
                if (isPlaying)
                {
                    axWMP.Ctlcontrols.play();
                    axWMP.Ctlcontrols.currentPosition = 180;
                }
                else
                    axWMP.Ctlcontrols.pause();
            }
            else
            {
                MessageBox.Show("Đường dẫn đến folder chưa được bổ sung hoặc sai đường dẫn",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            Song prevSong = songLinkedList.PrevSong();
            if (prevSong != null)
            {
                bool isPlaying = (axWMP.playState == WMPLib.WMPPlayState.wmppsPlaying);
                DisplayAndPlay(prevSong);
                if (isPlaying)
                {
                    axWMP.Ctlcontrols.play();
                }
                else
                    axWMP.Ctlcontrols.pause();
            }
            else
            {
                MessageBox.Show("Đường dẫn đến folder chưa được bổ sung hoặc sai đường dẫn",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.SongFolderPath != null)
            {
                string folderPath = Properties.Settings.Default.SongFolderPath;
                if (folderPath != null)
                {
                    string[] files = Directory.GetFiles(folderPath, "*.mp3");
                    if (files.Length > 0)
                    {
                        foreach (string file in files)
                        {
                            pathList.AddLast(file);
                        }
                        LoadSong(pathList);
                        songLinkedList.ResetSong();
                    }
                }
                else
                {
                    MessageBox.Show("Đường dẫn file nhạc bị lỗi. " +
                        "Hãy thêm lại đường dẫn ở mục menu.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa thêm đường dẫn file nhạc hoặc lỗi đường dẫn. " +
                    "Hãy thêm lại đường dẫn ở mục menu.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }



        private void btnRepeat_Click(object sender, EventArgs e)
        {
            DisplayAndPlay(songLinkedList.GetCurrentSong());
            axWMP.Ctlcontrols.play();
        }

        private void axWMP_PlayStateChange_1(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            checkAction();
            if (axWMP.playState == WMPLib.WMPPlayState.wmppsMediaEnded)
            {

                axWMP.settings.autoStart = true;
                DisplayAndPlay(songLinkedList.NextSong());
                axWMP.Ctlcontrols.play();
            }
        }
    }
}
