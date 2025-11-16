using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiaoDien
{
    public class DoubleLinkedList
    {
        public class SongNode
        {
            public string File;
            public SongNode Next, Prev;
            public SongNode(string file)
            {
                File = file;
                Next = Prev = null;
            }
        }
        public class DoubleLinkedListSong
        {
            SongNode head, tail, current;
            public DoubleLinkedListSong()
            {
                head = tail = current = null;
            }
            public void AddLast(string file)
            {
                SongNode newNode = new SongNode(file);
                if (head == null)
                {
                    head = tail = current = newNode;
                    head.Prev = head;
                    head.Next = head;
                }
                else
                {
                    tail.Next = newNode;
                    newNode.Prev = tail;
                    newNode.Next = head;
                    head.Prev = newNode;
                    tail = newNode;
                }
            }
            public string GetCurrentSong()
            {
                if (current != null)
                {
                    return current.File;
                }
                else
                {
                    return null;
                }
            }
            public string NextSong()
            {
                if (current != null)
                {
                    current = current.Next;
                    return current.File;
                }
                else
                {
                    return null;
                }
            }
            public string PrevSong()
            {
                if (current != null)
                {
                    current = current.Prev;
                    return current.File;
                }
                else
                {
                    return null;
                }
            }
            public List<Song> ConvertToList()
            {
                List<Song> songList = new List<Song>();
                if (head == null)
                    return songList;
                SongNode songCurrent = head;

                do
                {
                    string filePath = songCurrent.File;

                    TagLib.File file = TagLib.File.Create(filePath);
                    string songName = file.Tag.Title;
                    string singerName = string.Join(",", file.Tag.Performers);
                    string displaySongName = string.IsNullOrEmpty(songName) ?
                        Path.GetFileNameWithoutExtension(filePath) : songName;
                    string displaySingerName = string.IsNullOrWhiteSpace(singerName) ?
                        Path.GetFileNameWithoutExtension(filePath) : singerName;
                    Song songConvert = new Song(displaySongName, displaySingerName);
                    songList.Add(songConvert);
                    songCurrent = songCurrent.Next;
                } while (songCurrent != head);
                return songList;
            }
        }
    }
}
