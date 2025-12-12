using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TrinhPhatNhac
{
    public class Song
    {
        private string songName;
        private string singerName;
        private Image image;
        private string minute;
        private string filePath;
        private string imageBase64;
        #region Property
        public string SongName 
        {
            get { return songName; }
            set { songName = value; }
        }
        public string SingerName
        {
            get { return singerName; }
            set { singerName = value; }
        }
        public string FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }
        [JsonIgnore]// JsonIgnore: bỏ qua hình ảnh
        public Image Image
        {
            get { return image; }
            set { image = value; }
        }
        public string Minute
        {
            get { return minute; }
            set { minute = value; }
        }
        public string ImageBase64
        {
            get { return imageBase64;}
            set { imageBase64 = value; }
        }
        #endregion
        //Constructor
        public Song() { }
        //Constructor
        public Song(string songname, string singername,string filepath, Image imagesong,string minutesong)
        {
            songName=songname;
            singerName=singername;
            filePath = filepath;
            image = imagesong;
            minute = minutesong;
        }
        // GHI ĐÈ PHƯƠNG THỨC EQUALS
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Song otherSong = (Song)obj;

            // So sánh dựa trên thuộc tính  FilePath
            return this.FilePath == otherSong.FilePath;
        }

        // GHI ĐÈ PHƯƠNG THỨC GETHASHCODE
        public override int GetHashCode()
        {
            // Dùng thuộc tính trong Equals để tính toán mã băm.
            return (FilePath != null ? FilePath.GetHashCode() : 0);
        }
    }
}
