using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresPractice.DataStructures
{
    /// <summary>
    /// Singly Linked List implementation
    /// </summary>
    public class LinkedLists<T>
    {
        public class Node
        {
            public T Data { get; set; }
            public Node Next { get; set; }

            public Node(T data) => Data = data;
        }

        private Node head;
        private int count;

        /// <summary>
        /// Adds element to the beginning of the list
        /// </summary>
        public void AddFirst(T data)
        {
            Node newNode = new Node(data) { Next = head };
            head = newNode;
            count++;
        }

        /// <summary>
        /// Adds element to the end of the list
        /// </summary>
        public void AddLast(T data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                    current = current.Next;
                current.Next = newNode;
            }
            count++;
        }

        /// <summary>
        /// Removes first occurrence of specified data
        /// </summary>
        public bool Remove(T data)
        {
            if (head == null) return false;

            if (head.Data.Equals(data))
            {
                head = head.Next;
                count--;
                return true;
            }

            Node current = head;
            while (current.Next != null && !current.Next.Data.Equals(data))
                current = current.Next;

            if (current.Next != null)
            {
                current.Next = current.Next.Next;
                count--;
                return true;
            }
            return false;
        }

        public int Count => count;

        public void PrintAll()
        {
            var values = new List<T>();
            Node current = head;
            while (current != null)
            {
                values.Add(current.Data);
                current = current.Next;
            }
            Console.WriteLine($"LinkedList: {string.Join(" -> ", values)}");
        }
    }
}
