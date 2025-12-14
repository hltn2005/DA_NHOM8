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
        private double playbackRate = 1.0;

        public MainForm()
        {
            InitializeComponent();
        }

        #region Phương thức
        public void LoadSong(LinkedListFilePath.LinkedListPath filePath)// Phương thức LoadSong
        {
            string currentPath = filePath.GetCurrentPath();// Lấy file path hiện tại trong danh sách file path
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
                // Hàm tạo file để lấy các meta data của file nhạc 
                TagLib.File file = TagLib.File.Create(filePath.GetCurrentPath(), TagLib.ReadStyle.Average);
                string songNameFile = file.Tag.Title;
                // Dùng string.Join nếu bài hát có nhiều hơn 1 ca sĩ thì sẽ được phân cách bởi dấu phẩy
                string singerNameFile = string.Join(",", file.Tag.Performers);
                /* Sử dụng toán tử 3 ngôi để kiểm tra xem tên bài hát và ca sĩ có null hay rỗng không 
                 nếu có trả về tên file nhạc bỏ đuôi, nêu không thì trả về tên file nhạc đọc từ metadata */
                string songName = string.IsNullOrEmpty(songNameFile) ?
                    Path.GetFileNameWithoutExtension(filePath.GetCurrentPath()) : songNameFile;
                string singerName = string.IsNullOrWhiteSpace(singerNameFile) ?
                    Path.GetFileNameWithoutExtension(filePath.GetCurrentPath()) : singerNameFile;
                string minute = file.Properties.Duration.ToString(@"mm\:ss");// lấy thời gian 
                Image image;
                if (file.Tag.Pictures.Length > 0)// kiểm tra file có ảnh không
                {
                    IPicture picture = file.Tag.Pictures[0];// Sử dụng IPicture để lấy giá trị ảnh từ thư viện taglib
                    byte[] pitureBytes = picture.Data.Data;// Phân tách ảnh thành mảng byte 
                    if (pitureBytes != null && pitureBytes.Length > 0)// Điều kiện kiểm tra mảng có rỗng hay null không
                    {
                        /* Memorystream dùng để biến mảng byte của ảnh thành một luồng dữ liệu
                        giống như file trong RAM để Image.FromStream() có thể đọc và tạo ra hình ảnh*/
                        using (MemoryStream ms = new MemoryStream(pitureBytes))
                        {
                            Image tmp = Image.FromStream(ms);// tạo 1 biến tạm để lấy giá trị ảnh
                            // Sử dụng bitmap để sao chép dữ liệu hình ảnh  vào vùng nhớ riêng
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
                // Truyền các giá trị đọc được từ file nhạc cho đối tượng Song
                Song song = new Song(songName, singerName, filePath.GetCurrentPath(), image, minute);
                // Chuyển đổi ảnh sang string
                song.ImageBase64 = PlaylistManager.ConvertImageToBase64(image);
                // Sau đó nạp đối tượng song vào danh sách bài hát
                songListRoot.Add(song);
                songList.Add(song);
                filePath.NextPath();// Trỏ tới node kế 
                currentPath = filePath.GetCurrentPath();// Gán lại node kế cho current tiếp tục thực hiện điều kiện
            }
            //Điều kiển kiểm tra danh sách liên kết đôi có trống không
            if (songListRoot.Count > 0)
            {
                // Nạp các bài hát trong dánh sách bài hát vào danh sách liên kết đôi để phát nhạc
                ConvertListSongToLinkedList(songListRoot);
                // Gọi hàm trình lên các dữ liệu bài hát
                DisplayAndPlay(songLinkedList.GetCurrentSong());
            }
            else
            {
                lblSongName.Text = "Không tìm thấy thông tin bài hát";
                lblSingerName.Text = "Không tìm thấy thông tin ca sỹ";
                pctMusicPicture.Image = Properties.Resources.DefaultMusicIcon;
            }
        }
        // Phương thức nạp đối tượng song vào danh sách liên kết 
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
        // Phương thức gán các dữ liệu bài hát cho dữ liệu form
        public void DisplayAndPlay(Song song)
        {
            if (song == null)
            {
                axWMP.URL = "";
                lblSongName.Text = "Không tìm thấy thông tin bài hát";
                lblSingerName.Text = "Không tìm thấy thông tin ca sỹ";
                pctMusicPicture.Image = Properties.Resources.DefaultMusicIcon;
                lblTime.Text = "00:00";
                lblSecond.Text = "00:00";
                trackBar1.Value = 0;
                trackBar1.Maximum = 0;
                return;
            }
            lblSongName.Text = song.SongName.ToString();
            lblSingerName.Text = song.SingerName.ToString();
            pctMusicPicture.Image = song.Image;
            axWMP.URL = song.FilePath;
            axWMP.Ctlcontrols.currentPosition = 0;

        }
        // Phương thức thay đổi nút pause và play
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
        // Phương thúc kiểm tra danh sách nhạc và danh sách liên kết đôi để vận hành trình phát nhạc
        private bool CheckSongList()
        {
            if (songLinkedList != null && songList.Count >= 0)
            {
                return true;
            }
            return false;
        }
        // Phương thức cập nhật playlist 
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
        }
        // Phương thức xử lý âm thanh
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            axWMP.settings.volume = trackBar2.Value;
            lblVolume.Text = trackBar2.Value.ToString();
        }
        // Phương thức cập nhật trang thái trình phát nhạc
        private void axWMP_PlayStateChange_1(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            CheckAction();
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
        // Phương thức điều chỉnh tốc độ phát
        private void tsmSpeedOptions(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem selectedItem)
            {
                double newRate;

                // 1. Xác định tốc độ dựa trên tên của mục menu 
                switch (selectedItem.Name)
                {
                    case "tsmSpeed025":
                        newRate = 0.25;
                        break;
                    case "tsmSpeed05":
                        newRate = 0.5;
                        break;
                    case "tsmSpeed075":
                        newRate = 0.75;
                        break;
                    case "tsmSpeed1":
                        newRate = 1.0;
                        break;
                    case "tsmSpeed125":
                        newRate = 1.25;
                        break;
                    case "tsmSpeed15":
                        newRate = 1.5;
                        break;
                    case "tsmSpeed175":
                        newRate = 1.75;
                        break;
                    case "tsmSpeed2":
                        newRate = 2.0;
                        break;
                    default:
                        return;
                }
                // Lặp qua ContextMenuStrip chứa các mục 
                // Dùng ContextMenuStrip của Form để truy cập
                ContextMenuStrip cms = selectedItem.Owner as ContextMenuStrip;
                if (cms != null)
                {
                    foreach (ToolStripItem item in cms.Items)
                    {
                        if (item is ToolStripMenuItem subItem)
                        {
                            subItem.Checked = (subItem == selectedItem);
                        }
                    }
                }

                // Áp dụng tốc độ mới cho WMP Control
                if (axWMP != null)
                {
                    axWMP.settings.rate = newRate;
                }

                // Cập nhật biến theo dõi và Text hiển thị trên nút chính 
                playbackRate = newRate;
                btnSpeed.Text = $"Tốc đô phát: {newRate}x";

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
                // Tạo 2 biến để lấy thời gian tổng và hiện tại của bài hát
                double dur = axWMP.currentMedia.duration;
                double pos = axWMP.Ctlcontrols.currentPosition;
                // Gán cho thời gian của trackspace
                trackBar1.Maximum = (int)dur;
                trackBar1.Value = (int)pos;
                // Sử dụng timespan để chuyển đổi và biểu diễn thời gian
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

            // LƯU TRẠNG THÁI HIỆN TẠI 
            Song previousSong = (songLinkedList != null) ? songLinkedList.GetCurrentSong() : null;
            double previousPosition = 0;
            bool wasPlaying = false;

            if (previousSong != null && axWMP.playState != WMPLib.WMPPlayState.wmppsStopped)
            {
                previousPosition = axWMP.Ctlcontrols.currentPosition;
                wasPlaying = (axWMP.playState == WMPLib.WMPPlayState.wmppsPlaying);
                axWMP.Ctlcontrols.stop();
            }

            using (PlaylistForm OpenPlaylist = new PlaylistForm(songListRoot, songList))
            {
                // Cập nhật currentPlaylist ban đầu cho PlaylistForm (nếu đã có)
                if (currentPlaylist != null)
                {
                    OpenPlaylist.CurrentPlaylist = currentPlaylist;
                }

                OpenPlaylist.ShowDialog();

                // Xử lý kết quả và khôi phục trạng thái

                // Lấy cờ báo hiệu khi thay đổi nội dung (thêm/xóa bài)
                bool playlistContentChanged = OpenPlaylist.ChangeOccurred;

                if (OpenPlaylist.CurrentPlaylist != null && OpenPlaylist.CurrentPlaylist != currentPlaylist)
                {
                    // Đã chọn playlist khác
                    currentPlaylist = OpenPlaylist.CurrentPlaylist;
                    // Cập nhật lại songList từ Playlist mới được chọn trong Form con
                    songList.Clear();
                    songList.AddRange(currentPlaylist.PlayList.ToList());
                    playlistContentChanged = true;
                }

                if (playlistContentChanged)
                {
                    // Nếu có thay đổi nội dung hoặc chọn Playlist mới, tải lại và bắt đầu từ bài đầu
                    UpdatePlayList();

                    // Tiếp tục phát nếu trước đó đang phát 
                    if (wasPlaying)
                    {
                        axWMP.Ctlcontrols.play();
                    }
                }
                else if (previousSong != null && songLinkedList != null)
                {
                    // không có thay đổi playlist, khôi phục bài hát cũ và vị trí
                    UpdateSongLinkList(previousSong);
                    DisplayAndPlay(previousSong);
                    axWMP.Ctlcontrols.currentPosition = previousPosition;

                    if (wasPlaying)
                    {
                        axWMP.Ctlcontrols.play();
                    }
                }
            }
            // Cập nhật lại tốc độ phát
            axWMP.settings.rate = playbackRate;
        }
        // Nút xem danh sách playlist
        private void btnPlaylistManager_Click(object sender, EventArgs e)
        {
            // Lưu trạng thai hiện tại khi mở form
            Song previousSong = (songLinkedList != null) ? songLinkedList.GetCurrentSong() : null;
            double previousPosition = 0;
            bool wasPlaying = false;

            // Chỉ lưu vị trí và trạng thái nếu đang có bài hát và WMP đang tải/phát
            if (previousSong != null && axWMP.playState != WMPLib.WMPPlayState.wmppsStopped)
            {
                previousPosition = axWMP.Ctlcontrols.currentPosition;
                wasPlaying = (axWMP.playState == WMPLib.WMPPlayState.wmppsPlaying);
                axWMP.Ctlcontrols.stop();
            }

            using (PlaylistManagerForm qlPlaylist = new PlaylistManagerForm(songListRoot))
            {
                PlaylistSong oldCurrentPlaylist = currentPlaylist;
                qlPlaylist.ShowDialog();

                bool playlistChanged = false;

                if (qlPlaylist.SelectedPlayList != null)
                {
                    // Playlist mới được chọn
                    currentPlaylist = qlPlaylist.SelectedPlayList;
                    songList.Clear();
                    songList.AddRange(currentPlaylist.PlayList.ToList());
                    // Đánh dấu là đã thay đổi để UpdatePlayList chọn bài đầu tiên
                    playlistChanged = true;
                }
                else if (oldCurrentPlaylist != null && qlPlaylist.SelectedPlayList == null && qlPlaylist.CheckSelect())
                {
                    // Người dùng chọn xóa/làm trống Playlist
                    songList.Clear();
                    currentPlaylist = null;
                    playlistChanged = true;
                }

                // Khôi phục trạng thái sau khi form con đóng

                // Nếu Playlist thay đổi, chúng ta dùng UpdatePlayList() như cũ để tải bài đầu tiên
                if (playlistChanged)
                {
                    UpdatePlayList(); // Tạo lại list, tải bài đầu tiên 
                }
                // Nếu không thay đổi Playlist 
                else if (previousSong != null && songLinkedList != null)
                {
                    // Đảm bảo con trỏ danh sách liên kết kép trỏ đúng bài cũ
                    UpdateSongLinkList(previousSong);

                    // Tải lại bài hát và vị trí
                    DisplayAndPlay(previousSong);
                    axWMP.Ctlcontrols.currentPosition = previousPosition;

                    // Tiếp tục phát nếu trước đó đang phát
                    if (wasPlaying)
                    {
                        axWMP.Ctlcontrols.play();
                    }
                }
                // Cập nhật lại tốc độ phát
                axWMP.settings.rate = playbackRate;
            }
        }
        //Nút menu
        private void btnMenu_Click(object sender, EventArgs e)
        {
            // Lưu trạng thái hiện tại
            Song previousSong = (songLinkedList != null) ? songLinkedList.GetCurrentSong() : null;
            double previousPosition = 0;
            bool wasPlaying = false;
            bool pathChanged = false;

            if (previousSong != null && axWMP.playState != WMPLib.WMPPlayState.wmppsStopped)
            {
                previousPosition = axWMP.Ctlcontrols.currentPosition;
                wasPlaying = (axWMP.playState == WMPLib.WMPPlayState.wmppsPlaying);
                axWMP.Ctlcontrols.stop();
            }

            using (LoadFileForm loadFileForm = new LoadFileForm())
            {
                loadFileForm.ShowDialog();

                // Kiểm tra xem người dùng có chọn Folder mới không
                if (loadFileForm.CheckFolder())
                {
                    // Tải lại hoàn toàn 
                    pathList = loadFileForm.PATH();
                    songListRoot = new List<Song>();
                    songList = new List<Song>();
                    songLinkedList = null;
                    LoadSong(pathList);
                    pathChanged = true;
                }

                // Khôi phục trạng thái sau khi form con đóng
                if (pathChanged)
                {
                    // Nếu có folder mới, bắt đầu phát bài đầu tiên nếu trước đó đang phát
                    if (wasPlaying && songLinkedList != null)
                    {
                        axWMP.Ctlcontrols.play();
                    }
                }
                else if (previousSong != null && songLinkedList != null)
                {
                    // Nếu không chọn folder mới, khôi phục trạng thái cũ
                    UpdateSongLinkList(previousSong);
                    DisplayAndPlay(previousSong);
                    axWMP.Ctlcontrols.currentPosition = previousPosition;

                    if (wasPlaying)
                    {
                        axWMP.Ctlcontrols.play();
                    }
                }
                // Cập nhật lại tốc độ phát
                axWMP.settings.rate = playbackRate;
            }
        }
        // Nút play 
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (CheckSongList())
            {
                DisplayAndPlay(songLinkedList.GetCurrentSong());
                axWMP.Ctlcontrols.currentPosition = trackBar1.Value;
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
        // Nút điều chỉnh tốc độ phát
        private void btnSpeed_Click(object sender, EventArgs e)
        {
            cmsSpeedOptions.Show(btnSpeed, 0, btnSpeed.Height);
        }
        #endregion
        private void MainForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            trackBar2_Scroll(sender, e);
            axWMP.settings.rate = playbackRate;
            btnSpeed.Text = "Tốc độ phát: 1.0x";
            // Kiểm tra tồn tại của đường dẫn tới folder chưa bài hát trước khi hiện form
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
