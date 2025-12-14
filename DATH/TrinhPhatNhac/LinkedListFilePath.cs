using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrinhPhatNhac
{
    public class LinkedListFilePath
    {
        #region class PathNode
        public class PathNode
        {
            public string File;
            public PathNode Next;
            public PathNode(string file)
            {
                File = file;
                Next = null;
            }
        }
        #endregion
        #region class LinkedListPath
        public class LinkedListPath
        {
            PathNode head, tail, current;
            public LinkedListPath()
            {
                head = tail = current = null;
            }
            public void AddLast(string file) // Phương thúc thêm cuối path 
            {
                PathNode newNode = new PathNode(file);
                if (head == null)
                {
                    head = tail = current = newNode;
                }
                else
                {
                    tail.Next = newNode;
                    newNode.Next = null;
                    tail = newNode;
                }
            }
            public string GetCurrentPath()// Phương thức lấy path hiện tại
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
            public string NextPath()// Phương thức lấy path kế
            {
                if (current == null)
                {
                    return null;
                }
                else if (current.Next != null)
                {
                    current = current.Next;
                    return current.File;
                }
                else
                {
                    current=null;
                    return null;
                }
            }
            public void ResetPos()// Phương thức reset Node
            {
                current = head;
            }
            
        }
        #endregion
    }
}
