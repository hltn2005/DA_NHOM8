using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaoDien
{
    public class Song
    {
        private string songName;
        private string singerName;
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
        public Song(string SongName, string SingerName)
        {
            songName=SongName;
            singerName=SingerName;
        }
    }
}
