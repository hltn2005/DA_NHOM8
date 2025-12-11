using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaoDien
{
        public class Playlist
        {
   

            public string Name { get; set; }

           
            public List<Song> Songs { get; set; } = new List<Song>();

            public Playlist(string name)
            {
                this.Name = name;
            }

        
            public int SongCount => Songs.Count;

 
            public Playlist()
            {
            }
        }
    }

