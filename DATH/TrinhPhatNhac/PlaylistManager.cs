
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrinhPhatNhac
{
    public class PlaylistManager
    {
        // Tên file chứa dữ liệu playlist, dùng chung cho cả class
        private static readonly string dataFile = "playlists.json";
        // Tên folder ứng dụng bên trong appdata, dùng chung cho cả class
        private static readonly string appDataFolder = "TrinhPhatNhac";
        // Đừơng dẫn đến file Json trong AppData
        private static readonly string dataPath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            appDataFolder, dataFile);

        public static string ConvertImageToBase64(Image image)
        {
            if (image == null) return null;

            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    // Lưu hình ảnh dưới dạng PNG để lưu trữ
                    image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    return Convert.ToBase64String(ms.ToArray());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi chuyển ảnh sang Base64: {ex.Message}");
                return null;
            }
        }
        public static Image ConvertBase64ToImage(string base64String)
        {
            if (string.IsNullOrWhiteSpace(base64String)) return null;

            try
            {
                byte[] imageBytes = Convert.FromBase64String(base64String);

                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    // Sử dụng Bitmap để sao chép dữ liệu ảnh và giải phóng MemoryStream ngay lập tức
                    Image tmp = Image.FromStream(ms);
                    return new Bitmap(tmp);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi chuyển Base64 sang ảnh: {ex.Message}");
                // Trả về ảnh mặc định nếu có lỗi
                return TrinhPhatNhac.Properties.Resources.DefaultMusicIcon;
            }
        }
        // Phương thức đọc file Json và trả về danh sách playlist
        public static List<PlaylistSong> LoadPlayList()
        {
            if (!File.Exists(dataPath))// Điều kiện nếu đường dẫn không tồn tại
            {
                return new List<PlaylistSong>();
            }
            string jsonString = File.ReadAllText(dataPath);// Đọc tất cả nội dung file thành chuỗi
            //Chuyển chuỗi JSON sang danh sách PlayListSong
            var playLists = JsonSerializer.Deserialize<List<PlaylistSong>>(jsonString);

            if (playLists != null)
            {
                // Chuyển Base64 sang Image
                foreach (var playlist in playLists)
                {
                    foreach (var song in playlist.PlayList)
                    {
                        song.Image = ConvertBase64ToImage(song.ImageBase64);
                    }
                }
                return playLists;
            }
            else
            {
                return new List<PlaylistSong>();
            }
        }
        public static void SavePlayLists(List<PlaylistSong> playLists)
        {
            try
            {
                // Cập nhật ImageBase64 trước khi lưu
                foreach (var playlist in playLists)
                {
                    foreach (var song in playlist.PlayList)
                    {
                        if (song.Image != null)
                        {
                            song.ImageBase64 = ConvertImageToBase64(song.Image);
                        }
                    }
                }
                Directory.CreateDirectory(Path.GetDirectoryName(dataPath));// Tạo đường dẫn đến thư mục
                string jsonString = JsonSerializer.Serialize(playLists,
                    new JsonSerializerOptions { WriteIndented = true });//Serialize() → biến list thành chuỗi JSON.
                File.WriteAllText(dataPath, jsonString);// Tạo format đẹp, dễ đọc
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu playlist: {ex.Message}", "Lỗi lưu trữ");
            }

        }

    }
}
