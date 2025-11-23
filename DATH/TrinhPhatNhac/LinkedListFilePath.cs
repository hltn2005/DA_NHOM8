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
        public class LinkedListPath
        {
            PathNode head, tail, current;
            public LinkedListPath()
            {
                head = tail = current = null;
            }
            public void AddLast(string file)
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
            public string GetCurrentPath()
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
            public string NextPath()
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
            public void ResetPos()
            {
                current = head;
            }
            
        }
    }
}
