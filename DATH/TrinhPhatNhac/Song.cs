using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrinhPhatNhac
{
    public class Song
    {
        private string songName;
        private string singerName;
        private Image image;
        private TimeSpan minute;
        private string filePath;
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
        public Image Image
        {
            get { return image; }
            set { image = value; }
        }
        public TimeSpan Minute
        {
            get { return minute; }
            set { minute = value; }
        }
        public Song(string songname, string singername,string filepath, Image imagesong,TimeSpan minutesong)
        {
            songName=songname;
            singerName=singername;
            filePath = filepath;
            image = imagesong;
            minute = minutesong;
        }
    }
}
