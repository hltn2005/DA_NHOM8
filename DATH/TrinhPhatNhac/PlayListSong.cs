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
    public class PlayListSong
    {
        public string name;
        public List<Song> playList;

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

        [JsonIgnore]// bỏ qua số lượng bài hát trong playList
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
        public PlayListSong()
        {
            playList=new List<Song>();
        }

       
    }
}
