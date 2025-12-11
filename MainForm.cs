using AxWMPLib;
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
using TrinhPhatNhac.Properties;
using WMPLib;
namespace TrinhPhatNhac
{
    public partial class MainForm : Form
    {

        LinkedListFilePath.LinkedListPath pathList = new LinkedListFilePath.LinkedListPath();
        List<Song> songList = new List<Song>();
        List<Song> songListRoot = new List<Song>();
        DoubleLinkedListFileSong.DoubleLinkedListSong songLinkedList;
        private PlaylistSong currentPlaylist;
        bool shuffle = false;
        bool repeat = false;
        private Random random = new Random();
        bool state = false;

        public MainForm()
        {
            InitializeComponent();
        }

        #region Phương thức
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
                string minute = file.Properties.Duration.ToString(@"mm\:ss");// lấy thời gian 
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
                // chuyển đổi ảnh sang string
                song.ImageBase64 = PlaylistManager.ConvertImageToBase64(image);
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
            if (songLinkedList != null && songList.Count >= 0)
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

            foreach (Song song in songList)
            {
                songLinkedList.AddLast(song);
            }
            songLinkedList.ResetSong();
            if (songLinkedList.GetCurrentSong() != null)
            {
                DisplayAndPlay(songLinkedList.GetCurrentSong());
            }
            else
                return;
            if (state)
            {
                axWMP.Ctlcontrols.play();
            }
        }
        // Phương thức xử lý âm thanh
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            axWMP.settings.volume = trackBar2.Value;
            lblVolume.Text = trackBar2.Value.ToString();
        }
        // phương thức cập nhật trang thái trình phát nhạc
        private void axWMP_PlayStateChange_1(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            CheckAction();
            if (axWMP.playState == WMPLib.WMPPlayState.wmppsPlaying)
                state = true;
            else if (axWMP.playState == WMPLib.WMPPlayState.wmppsPaused ||
             axWMP.playState == WMPLib.WMPPlayState.wmppsStopped ||
             axWMP.playState == WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                state = false; // Nhạc dừng/tạm dừng/kết thúc -> state = false
            }
            //điều kiển để phát bài tiếp theo khi kết thúc bài trước 
            if (axWMP.playState == WMPLib.WMPPlayState.wmppsMediaEnded)// kiểm tra trang thái bài hát có đã kết thúc chưa
            {
                this.BeginInvoke((Action)(() =>
                {
                    Song nextSong = new Song();
                    if (shuffle && songList.Count > 1 && !repeat)
                    {
                        Song currentSong = songLinkedList.GetCurrentSong();
                        nextSong = ShuffleSong(currentSong);
                        DisplayAndPlay(nextSong);
                        axWMP.Ctlcontrols.play();
                    }
                    if (repeat && songList.Count > 1 && !shuffle)
                    {
                        Song currentSong = songLinkedList.GetCurrentSong();
                        DisplayAndPlay(currentSong);
                        axWMP.Ctlcontrols.play();
                    }
                    else
                    {
                        DisplayAndPlay(songLinkedList.NextSong());
                        axWMP.Ctlcontrols.play();
                    }
                }));
            }
        }
        #region Phương thức Shuffle
        private void UpdateSongLinkList(Song song)
        {
            while (songLinkedList.GetCurrentSong() != song)
            {
                songLinkedList.NextSong();
            }
        }
        private Song ShuffleSong(Song currentSong)
        {
            Song nextSong = new Song();
            int index = random.Next(songList.Count);
            nextSong = songList[index];
            while (currentSong == nextSong)
            {
                index = random.Next(songList.Count);
                nextSong = songList[index];
            }
            UpdateSongLinkList(nextSong);
            return nextSong;
        }
        #endregion
        #region Phương thức thao tác thời gian bài hát
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (axWMP.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                // tạo 2 biến để lấy thời gian tổng và hiện tại của bài hát
                double dur = axWMP.currentMedia.duration;
                double pos = axWMP.Ctlcontrols.currentPosition;
                // gán cho thời gian của trackspace
                trackBar1.Maximum = (int)dur;
                trackBar1.Value = (int)pos;
                // sử dụng timespan để chuyển đổi và biểu diễn thời gian
                lblSecond.Text = TimeSpan.FromSeconds(pos).ToString(@"mm\:ss");
                lblTime.Text = TimeSpan.FromSeconds(dur).ToString(@"mm\:ss");
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            axWMP.Ctlcontrols.currentPosition = trackBar1.Value;
        }
        #endregion
        #endregion
        #region Buttons 
        // Nút xem playlist
        private void btnPlaylist_Click(object sender, EventArgs e)
        {

            using (PlaylistForm OpenPlaylist = new PlaylistForm(songListRoot, songList))
            {// Cập nhật currentPlaylist ban đầu cho PlaylistForm (nếu đã có)
                if (currentPlaylist != null)
                {
                    OpenPlaylist.CurrentPlaylist = currentPlaylist;
                }
                OpenPlaylist.ShowDialog();
                if (OpenPlaylist.CurrentPlaylist != null && OpenPlaylist.CurrentPlaylist != currentPlaylist)
                {
                    currentPlaylist = OpenPlaylist.CurrentPlaylist;
                }
                UpdatePlayList();
            }
        }
        // Nút xem danh sách playlist
        private void btnPlaylistManager_Click(object sender, EventArgs e)
        {
            using (PlaylistManagerForm qlPlaylist = new PlaylistManagerForm(songListRoot))
            {
                PlaylistSong oldCurrentPlaylist = currentPlaylist;
                qlPlaylist.ShowDialog();
                if (qlPlaylist.SelectedPlayList != null)
                {
                    currentPlaylist = qlPlaylist.SelectedPlayList;
                    songList.Clear();
                    songList.AddRange(currentPlaylist.PlayList.ToList());
                }
                else if (oldCurrentPlaylist != null && qlPlaylist.SelectedPlayList == null && qlPlaylist.CheckSelect())
                {
                    songList.Clear();
                    currentPlaylist = null;
                    UpdatePlayList(); // Hàm này sẽ xử lý playlist trống
                }
                // 4. Xử lý trường hợp không chọn gì mới, nhưng nội dung playlist đã thay đổi (xóa bài hát)
                else if (oldCurrentPlaylist == currentPlaylist)
                {
                    UpdatePlayList();
                }
                UpdatePlayList();
            }
        }
        //nut menu
        private void btnMenu_Click(object sender, EventArgs e)
        {
            using (LoadFileForm loadFileForm = new LoadFileForm())
            {
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
        }
        // Nút play 
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (CheckSongList())
            {
                DisplayAndPlay(songLinkedList.GetCurrentSong());
                axWMP.Ctlcontrols.play();
            }
            else
            {
                return;
            }
        }
        //Nút Pause
        private void btnPause_Click(object sender, EventArgs e)
        {
            axWMP.Ctlcontrols.pause();
        }
        //Nút chuyển sang bài nhạc kế tiếp
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (CheckSongList())
            {
                Song nextSong = new Song();
                if (shuffle && songList.Count > 1)
                {
                    Song currentSong = songLinkedList.GetCurrentSong();
                    nextSong = ShuffleSong(currentSong);
                }
                else
                {
                    nextSong = songLinkedList.NextSong();
                }
                if (nextSong != null)
                {
                    bool isPlaying = (axWMP.playState == WMPLib.WMPPlayState.wmppsPlaying);
                    DisplayAndPlay(nextSong);
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
        // Nút chuyển sang bài nhạc trước
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
        //Nút lặp lại bài hát
        private void btnRepeat_Click(object sender, EventArgs e)
        {
            if (CheckSongList())
            {
                repeat = !repeat;
                if (repeat)
                {
                    shuffle = false;
                    btnShuffle.Image = Resources.ShuffleIcon;
                    btnRepeat.Image = null;
                    btnRepeat.Image = Resources.RepeatIconOn;
                }
                else
                {
                    btnRepeat.Image = Resources.RepeatIcon;
                }
            }
        }
        //Nút phát nhạc ngẫu nhiên
        private void btnShuffle_Click(object sender, EventArgs e)
        {
            btnShuffle.BackColor = Color.Green;
            shuffle = !shuffle;
            if (shuffle)
            {
                repeat = false;
                btnRepeat.Image = Resources.RepeatIcon;
                btnShuffle.Image = null;
                btnShuffle.Image = Resources.ShuffleIconOn;
            }
            else
            {
                btnShuffle.Image = Resources.ShuffleIcon;
            }

        }
        #endregion
        private void MainForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            trackBar2_Scroll(sender, e);
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

    }
}
