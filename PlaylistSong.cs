using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace TrinhPhatNhac
{
    public class PlaylistSong
    {
        public string name;// Tên playlist
        public List<Song> playList;// Danh sách bài hát trong playlist

        #region Property
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public List<Song> PlayList
        {
            get { return playList; }
            set { playList = value; }
        }
        #endregion
        // phương thức trả về số lượn bài hát
        public int SongCount
        {
            get
            {
                if(playList!=null)
                    return playList.Count;
                else
                    return 0;
            }
        }
        //Constructor
        public PlaylistSong()
        {
            playList=new List<Song>();
        }
    }
}
