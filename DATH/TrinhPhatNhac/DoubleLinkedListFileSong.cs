using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrinhPhatNhac
{
    
    public class DoubleLinkedListFileSong
    {
        #region class SongNode
        public class SongNode
        {
            public Song song;
            public SongNode Next;
            public SongNode Prev;
            public SongNode(Song Song)
            {
                song = Song;
                Next = Prev = null;
            }
        }
        #endregion
        #region class DoubleLinkedListSong
        public class DoubleLinkedListSong
        {
            SongNode head, tail, current;
            public DoubleLinkedListSong()
            {
                head = tail = current = null;
            }
            public void AddLast(Song Song)// phương thức thêm cuối bài hát
            {
                SongNode newNode = new SongNode(Song);
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
            public Song GetCurrentSong()// phương thức lấy bài hát đầu tiên
            {
                if (current != null)
                    return current.song;
                else
                {
                    return null;
                }
            }
            public Song NextSong()// phương thức lấy bài hát kế
            {
                if (current != null)
                {
                    current = current.Next;
                    return current.song;
                }
                else { return null; }
            }
            public Song PrevSong()// phương thức lấy bài hát trước
            {
                if (current != null)
                {
                    current = current.Prev;
                    return current.song;
                }
                else { return null; }
            }
            public void ResetSong()// hàm reset lại Node
            {
                current = head;
            }
        }
        #endregion
    }
}
