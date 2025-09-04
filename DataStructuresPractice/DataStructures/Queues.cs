using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresPractice.DataStructures
{
    /// <summary>
    /// Queue implementation using linked list (FIFO - First In, First Out)
    /// </summary>
    public class Queues<T>
    {
        private Node front, rear;
        private int count;

        private class Node
        {
            public T Data { get; set; }
            public Node Next { get; set; }
            public Node(T data) => Data = data;
        }

        /// <summary>
        /// Adds element to rear of queue
        /// </summary>
        public void Enqueue(T item)
        {
            Node newNode = new Node(item);
            if (rear == null)
            {
                front = rear = newNode;
            }
            else
            {
                rear.Next = newNode;
                rear = newNode;
            }
            count++;
        }

        /// <summary>
        /// Removes and returns front element
        /// </summary>
        public T Dequeue()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Queue is empty");

            T data = front.Data;
            front = front.Next;
            if (front == null) rear = null;
            count--;
            return data;
        }

        /// <summary>
        /// Returns front element without removing it
        /// </summary>
        public T Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Queue is empty");
            return front.Data;
        }

        public bool IsEmpty() => front == null;
        public int Count => count;

        public void PrintAll()
        {
            var values = new List<T>();
            Node current = front;
            while (current != null)
            {
                values.Add(current.Data);
                current = current.Next;
            }
            Console.WriteLine($"Queue (front to rear): {string.Join(" <- ", values)}");
        }
    }
}
