using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json; 


namespace GiaoDien
{
   

        public static class DataManager
         { 
        private static readonly string DataFilePath = "playlists.json";

      
        public static List<Playlist> AllPlaylists  = new List<Playlist>();

     
        public static void LoadData()
        {
            if (File.Exists(DataFilePath))
            {
                try
                {
                    
                    string jsonString = File.ReadAllText(DataFilePath);
                    List<Playlist> tempList = JsonConvert.DeserializeObject<List<Playlist>>(jsonString);

                    if (tempList != null)
                    {
                        AllPlaylists = tempList;   
                    }
                    else
                    {
                        AllPlaylists = new List<Playlist>();   
                    }

                }
                catch (Exception ex)
                {
              
                    MessageBox.Show("Lỗi khi tải dữ liệu từ file: " + ex.Message, "Lỗi Dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    AllPlaylists = new List<Playlist>(); 
                }
            }
            else
            {
          
                AllPlaylists = new List<Playlist>();
            }
        }

        public static void SaveData()
        {
            try
            {
            
                string jsonString = JsonConvert.SerializeObject(AllPlaylists, Formatting.Indented);

             
                File.WriteAllText(DataFilePath, jsonString);
            }
            catch (Exception ex)
            {
             
                MessageBox.Show("Lỗi khi lưu dữ liệu vào file: " + ex.Message, "Lỗi Ghi File", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

  
        /// <param name="name">Tên Playlist cần tìm.</param>
        /// <returns>Đối tượng Playlist nếu tìm thấy, ngược lại là null.</returns>
        public static Playlist GetPlaylistByName(string name)
        {
            // Sử dụng LINQ để tìm Playlist đầu tiên có tên trùng khớp
            // StringComparison.OrdinalIgnoreCase bỏ qua sự khác biệt giữa chữ hoa/chữ thường
            return AllPlaylists.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }
    }
}

