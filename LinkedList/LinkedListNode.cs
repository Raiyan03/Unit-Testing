using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_skeleton
{
    public class LinkedListNode
    {
        public object data;
        public LinkedListNode next;

        public LinkedListNode(object x) 
        {
            data = x;
            next = null;
        }
    }
}
