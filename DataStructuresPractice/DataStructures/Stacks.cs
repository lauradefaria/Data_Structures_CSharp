using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresPractice.DataStructures
{
    /// <summary>
    /// Stack implementation using linked list (LIFO - Last In, First Out)
    /// </summary>
    public class Stacks<T>
    {
        private Node top;
        private int count;

        private class Node
        {
            public T Data { get; set; }
            public Node Next { get; set; }
            public Node(T data) => Data = data;
        }

        /// <summary>
        /// Adds element to top of stack
        /// </summary>
        public void Push(T item)
        {
            Node newNode = new Node(item) { Next = top };
            top = newNode;
            count++;
        }

        /// <summary>
        /// Removes and returns top element
        /// </summary>
        public T Pop()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack is empty");

            T data = top.Data;
            top = top.Next;
            count--;
            return data;
        }

        /// <summary>
        /// Returns top element without removing it
        /// </summary>
        public T Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack is empty");
            return top.Data;
        }

        public bool IsEmpty() => top == null;
        public int Count => count;

        public void PrintAll()
        {
            var values = new List<T>();
            Node current = top;
            while (current != null)
            {
                values.Add(current.Data);
                current = current.Next;
            }
            Console.WriteLine($"Stack (top to bottom): {string.Join(" | ", values)}");
        }
    }
}
