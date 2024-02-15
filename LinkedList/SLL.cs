using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class SLL : LinkedListADT
    {
        
        LinkedListNode head;

        public SLL()
        {
            head = null;
        }

        public void Append(object data)
        {

            if (head == null)
            {
                Prepend(data);
            }

            else 
            {
                LinkedListNode runner = head;
                while (runner.next != null)
                {
                    runner = runner.next;
                }
                LinkedListNode node = new LinkedListNode(data);
                runner.next = node;
            }
        }

        public void Clear()
        {
            head = null;
        }

        public bool Contains(object data)
        {
            LinkedListNode runner = head;
            while(runner.next != null)
            {
                if (runner.data == data)
                {
                    return true;
                }
                runner = runner.next;
            }
            return false;
        }

        public void Delete(int index)
        {
            LinkedListNode runner = head;
            LinkedListNode previous = null;
            int currentIndex = 0;
            if (index == 0)
            {
                head = head.next;
            }
            else
            {
                while (runner != null && currentIndex < index)
                {
                    previous = runner;
                    runner = runner.next;
                    currentIndex++;
                }

                previous.next = previous.next.next;
                /*            throw new NotImplementedException();*/
            }
        }

        public int IndexOf(object data)
        {
            LinkedListNode runner = head;
            int currentIndex = 0;
            while (runner != null)
            {
                if (runner.data == data)
                {
                    break;
                }
                runner = runner.next;
                currentIndex++;
            }
            return currentIndex;
            /*throw new NotImplementedException();*/
        }

        public void Insert(object data, int index)
        {
            LinkedListNode runner = head;
            LinkedListNode previous = null;
            LinkedListNode temp;
            LinkedListNode newNode = new LinkedListNode(data);
            int currentIndex = 0;

            if (index == 0)
            {
                temp = head;
                newNode.next = temp;
                head = newNode;
            }
            else
            {
                while (runner != null && currentIndex < index)
                {
                    previous = runner;
                    runner = runner.next;
                    currentIndex++;
                }
                temp = previous.next;
                previous.next = newNode;
                newNode.next = temp;
            }
/*            throw new NotImplementedException();*/
        }

        public bool IsEmpty()
        {
            if (head == null)
            {
                return true;
            }
            else
            {
                return false;
            }
/*            throw new NotImplementedException();*/
        }

        public void Prepend(object data)
        {
            LinkedListNode node = new LinkedListNode(data);
            node.next = head;
            head = node;
/*            throw new NotImplementedException();*/
        }

        public void Replace(object data, int index)
        {
            LinkedListNode runner = head;
            int currentIndex = 0;
            while (runner != null)
            {
                if (currentIndex == index)
                {
                    runner.data = data;
                    break;
                }
                currentIndex++;
                runner = runner.next;
            }
/*            throw new NotImplementedException();*/
        }

        public object Retrieve(int index)
        {
            LinkedListNode runner = head;
            int currentIndex = 0;
            while (runner != null)
            {
                if (currentIndex == index)
                {
                    return runner.data;
                }
                currentIndex++;
                runner = runner.next;
            }
            return null;
/*            throw new NotImplementedException();*/
        }

        public int Size()
        {
            LinkedListNode runner = head;
            int size = 0;
            while(runner != null)
            {
                size++;
                runner = runner.next;
            }
            return size;
/*            throw new NotImplementedException();*/
        }
    }
}
