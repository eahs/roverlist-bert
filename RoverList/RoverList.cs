using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverList
{
    public class RoverList<T> : RoverListBase<T>
    {
        // Add any variables you need here
        public int count;
        public RoverList ()
        {
            count = 0;
        }

        public int toCount()
        {
            current = head;
            if (head == null)
            {
                count = 0;
            }

            while (current != null)
            {
                count++;
                current = current.Next;
            }

            return count;
        }

        public override int Count
        {
            get
            {
                return count;
            }
        }
        
        public override void Add(T data)
        {
            Node newNode = new Node(data);
            Node current = head;
            if (head == null)
            {
                newNode.Next = head;
                head = newNode;
            }
            else
            {
                while (current != null)
                {
                    if (current.Next == null)
                    {
                        current.Next = newNode;
                        break;
                    }

                    current = base.current.Next;
                }
            }

            count++;
        }

        public override void Add(int Position, T data)
        {
            Node current = head;
            Node newNode = new Node(data);
            int pos = 0;
            if (Position == 0)
            {
                newNode.Next = head;
                head = newNode;
            }
            else
            {
                while (current != null)
                {
                    if (pos == Position)
                    {
                        current.Next = newNode;
                        break;
                    }

                    current = current.Next;
                    pos++;
                }
            }

            count++;
        }

        public override void Clear()
        {
            head = null;
            count = 0;
        }

        public override T ElementAt(int Position)
        {
            Node current = head;
            int pos = 0;
            while (current != null)
            {
                if (pos == Position)
                {
                    return current.Data;
                }

                current = current.Next;
                pos++;
            }

            return default(T);
        }

        public override void ListNodes()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.Data + " ,");
                current = base.current.Next;
            }
        }

        public override bool RemoveAt(int Position)
        {
            Node current = head;
            bool removed = false;
            int pos = 0;
            if (Position == 0)
            {
                head = head.Next;
                removed = true;
            }
            else
            {
                while (current != null)
                {
                    if (pos == Position)
                    {
                        current.Next = current.Next.Next;
                        removed = true;
                        break;
                    }

                    current = base.current.Next;
                    pos++;
                }
            }

            count--;
            return removed;
        }
    }
}