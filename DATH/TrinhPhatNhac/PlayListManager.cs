
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Windows.Forms;

namespace TrinhPhatNhac
{
    public class PlayListManager
    {
        // tên file chứa dữ liệu playlist, dùng chung cho cả class
        private static readonly string dataFile = "playlists.json";
        // tên folder ứng dụng bên trong appdata, dùng chung cho cả class
        private static readonly string appDataFolder = "TrinhPhatNhac";
        // đừng dẫn đến file Json trong AppData
        private static readonly string dataPath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            appDataFolder, dataFile);
        public static List<PlayListSong> LoadPlayList()
        {
            if (!File.Exists(dataPath))// điều kiên nếu đường dẫn không tồn tại
            {
                return new List<PlayListSong>();
            }
            string jsonString = File.ReadAllText(dataPath);// đọc tất cả nội dung file thành chuỗi
            //Chuyển chuỗi JSON → danh sách object PlayListSong
            var playLists = JsonSerializer.Deserialize<List<PlayListSong>>(jsonString);
            if (playLists != null)
            {
                return playLists;
            }
            else
            {
                return new List<PlayListSong>();
            }
        }
        public static void SavePlayLists(List<PlayListSong> playLists)
        {
            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(dataPath));// tạo đường dẫn đến thư mục
                string jsonString = JsonSerializer.Serialize(playLists,
                    new JsonSerializerOptions { WriteIndented = true });////Serialize() → biến list thành chuỗi JSON.
                File.WriteAllText(dataPath, jsonString);// tạo format đẹp, dễ đọc
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu playlist: {ex.Message}", "Lỗi lưu trữ");
            }

        }

    }
}
