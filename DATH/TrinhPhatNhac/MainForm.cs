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

        public void LoadSong(LinkedListFilePath.LinkedListPath filePath)// Phương thức LoadSong
        {
            string currentPath = filePath.GetCurrentPath();// lấy file path hiện tại trong danh sách file path
            while (currentPath != null)
            {
                // Điều kiện kiểm tra đường dẫn có null hoặc rỗng hay không tồn tại trong hệ thông không
                if (string.IsNullOrEmpty(filePath.GetCurrentPath()) || !System.IO.File.Exists(filePath.GetCurrentPath()))
                {
                    lblSongName.Text = "Không tìm thấy thông tin bài hát";
                    lblSingerName.Text = "Không tìm thấy thông tin ca sỹ";
                    pctMusicPicture.Image = Properties.Resources.DefaultMusicIcon;
                    return;
                }
                // hàm tạo file để lấy các meta data của file nhạc 
                TagLib.File file = TagLib.File.Create(filePath.GetCurrentPath(), TagLib.ReadStyle.Average);
                string songNameFile = file.Tag.Title;
                // dùng string.Join nếu bài hát có nhiều hơn 1 ca sĩ thì sẽ được phân cách bởi dấu phẩy
                string singerNameFile = string.Join(",", file.Tag.Performers);
                /* sử dụng toán tử 3 ngôi để kiểm tra xem tên bài hát và ca sĩ có null hay rỗng không 
                 nếu có trả về tên file nhạc bỏ đuôi, nêu không thì trả về tên file nhạc đọc từ metadata */
                string songName = string.IsNullOrEmpty(songNameFile) ?
                    Path.GetFileNameWithoutExtension(filePath.GetCurrentPath()) : songNameFile;
                string singerName = string.IsNullOrWhiteSpace(singerNameFile) ?
                    Path.GetFileNameWithoutExtension(filePath.GetCurrentPath()) : singerNameFile;
                TimeSpan minute = file.Properties.Duration;// lấy thời gian 
                Image image;
                if (file.Tag.Pictures.Length > 0)// kiểm tra file có ảnh không
                {
                    IPicture picture = file.Tag.Pictures[0];// sử dụng IPicture để lấy giá trị ảnh từ thư viện taglib
                    byte[] pitureBytes = picture.Data.Data;// phân tách ảnh thành mảng byte 
                    if (pitureBytes != null && pitureBytes.Length > 0)// điều kiện kiểm tra mảng có rỗng hay null không
                    {
                        /* memorystream dùng để biến mảng byte của ảnh thành một luồng dữ liệu
                        giống như file trong RAM để Image.FromStream() có thể đọc và tạo ra hình ảnh*/
                        using (MemoryStream ms = new MemoryStream(pitureBytes))
                        {
                            Image tmp = Image.FromStream(ms);// tạo 1 biến tạm để lấy giá trị ảnh
                            // sử dụng bitmap để sao chép dữ liệu hình ảnh  vào vùng nhớ riêng
                            image = new Bitmap(tmp);// tạo Bitmap từ ảnh tạm để tránh lỗi khi khối lệnh using kết thúc
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
                // truyền các giá trị đọc được từ file nhạc cho đối tượng Song
                Song song = new Song(songName, singerName, filePath.GetCurrentPath(), image, minute);
                // sau đó nạp đối tượng song vào danh sách bài hát
                songListRoot.Add(song);
                songList.Add(song);
                filePath.NextPath();// trỏ tới node kế 
                currentPath = filePath.GetCurrentPath();// gán lại node kế cho current tiếp tục thực hiện điều kiện
            }
            //Điều kiển kiểm tra danh sách liên kết đôi có trống không
            if (songListRoot.Count > 0)
            {
                // nạp các bài hát trong dánh sách bài hát vào danh sách liên kết đôi để phát nhạc
                ConvertListSongToLinkedList(songListRoot);
                // gọi hàm trình lên các dữ liệu bài hát
                DisplayAndPlay(songLinkedList.GetCurrentSong());
            }
            else
            {
                lblSongName.Text = "Không tìm thấy thông tin bài hát";
                lblSingerName.Text = "Không tìm thấy thông tin ca sỹ";
                pctMusicPicture.Image = Properties.Resources.DefaultMusicIcon;
            }
        }
        // phương thức nạp đối tượng song vào danh sách liên kết 
        public void ConvertListSongToLinkedList(List<Song> ListSong)
        {
            songLinkedList = new DoubleLinkedListFileSong.DoubleLinkedListSong();
            if (ListSong.Count > 0)
            {
                foreach (var song in ListSong)
                {
                    songLinkedList.AddLast(song);
                }
                songLinkedList.ResetSong();
                axWMP.settings.autoStart = false;
                axWMP.URL = songLinkedList.GetCurrentSong().FilePath;
            }
        }
        //phương thức gán các dữ liệu bài hát cho dữ liệu form
        public void DisplayAndPlay(Song song)
        {
            if (song == null)
            {
                axWMP.URL = "";
                lblSongName.Text = "Không tìm thấy thông tin bài hát";
                lblSingerName.Text = "Không tìm thấy thông tin ca sỹ";
                pctMusicPicture.Image = Properties.Resources.DefaultMusicIcon;
                return;
            }
            lblSongName.Text = song.SongName.ToString();
            lblSingerName.Text = song.SingerName.ToString();
            pctMusicPicture.Image = song.Image;
            axWMP.URL = song.FilePath;
        }
        // phương thức thay đổi nút pause và play
        private void CheckAction()
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
        // phương thúc kiểm tra danh sách nhạc và danh sách liên kết đôi để vận hành trình phát nhạc
        private bool CheckSongList()
        {
            if (songLinkedList != null && songList.Count >=0)
            {
                return true;
            }
            return false;
        }
        // phương thức cập nhật playlist 
        private void UpdatePlayList()
        {
            if (songList == null || songList.Count == 0)
            {
                songLinkedList = null;
                lblSongName.Text = "Playlist trống";
                lblSingerName.Text = "Playlist trống";
                pctMusicPicture.Image = Properties.Resources.DefaultMusicIcon;
                axWMP.URL = "";
                axWMP.Ctlcontrols.stop();
                return;

            }
            songLinkedList = new DoubleLinkedListFileSong.DoubleLinkedListSong();
            foreach (Song song in songListRoot)
            {
                foreach (Song song1 in songList)
                {
                    if (song.SongName == song1.SongName)
                    {
                        song1.Image = song.Image;
                    }
                }
            }
            foreach (Song song in songList)
            {
                songLinkedList.AddLast(song);
            }
            songLinkedList.ResetSong();
            if (songLinkedList.GetCurrentSong() != null)
                DisplayAndPlay(songLinkedList.GetCurrentSong());
            else
                return;

        }

        #region Buttons 
        private void btnPlaylist_Click(object sender, EventArgs e)
        {

            PlaylistForm OpenPlaylist = new PlaylistForm(songListRoot, songList);
            OpenPlaylist.ShowDialog();
            if (CheckSongList())
            {
                UpdatePlayList();
            }
        }

        private void btnPlaylistManager_Click(object sender, EventArgs e)
        {
            PlaylistManagerForm qlPlaylist = new PlaylistManagerForm(songListRoot, songList);

            qlPlaylist.ShowDialog();
            if (CheckSongList())
            {
                UpdatePlayList();
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            LoadFileForm loadFileForm = new LoadFileForm();
            loadFileForm.ShowDialog();
            if (loadFileForm.CheckFolder())
            {
                axWMP.Ctlcontrols.stop();
                pathList = loadFileForm.PATH();
                songListRoot = new List<Song>();
                songList = new List<Song>();
                songLinkedList = null;
                LoadSong(pathList);
            }
            else
            {
                return;
            }
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (CheckSongList())
            {
                DisplayAndPlay(songLinkedList.GetCurrentSong());
                axWMP.Ctlcontrols.play();
                axWMP.Ctlcontrols.currentPosition = 180;
            }
            else
            {
                return;
            }
        }
        private void btnPause_Click(object sender, EventArgs e)
        {
            axWMP.Ctlcontrols.pause();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (CheckSongList())
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
            }
            else
            {
                return;
            }

        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (CheckSongList())
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
            }
            else
            {
                return;
            }

        }
        private void btnRepeat_Click(object sender, EventArgs e)
        {
            if (CheckSongList())
            {
                DisplayAndPlay(songLinkedList.GetCurrentSong());
                axWMP.Ctlcontrols.play();
            }
        }
        #endregion
        private void MainForm_Load(object sender, EventArgs e)
        {
            // kiểm tra tồn tại của đường dẫn tới folder chưa bài hát trước khi hiện form
            if (Properties.Settings.Default.SongFolderPath != null)
            {
                string folderPath = Properties.Settings.Default.SongFolderPath;
                if (string.IsNullOrEmpty(folderPath) || !System.IO.Directory.Exists(folderPath))
                {
                    return;
                }
                else
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
        // phương thức cập nhật trang thái trình phát nhạc
        private void axWMP_PlayStateChange_1(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            CheckAction();
            //điều kiển để phát bài tiếp theo khi kết thúc bài trước 
            if (axWMP.playState == WMPLib.WMPPlayState.wmppsMediaEnded)// kiểm tra trang thái bài hát có đã kết thúc chưa
            {
                axWMP.settings.autoStart = true;
                DisplayAndPlay(songLinkedList.NextSong());
                axWMP.Ctlcontrols.play();
            }
        }
    }
}
