using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresPractice.DataStructures
{
    /// <summary>
    /// Generic dynamic array implementation with automatic resizing
    /// </summary>
    public class DynamicArray<T>
    {
        private T[] array;
        private int size;
        private int capacity;

        public DynamicArray(int initialCapacity = 4)
        {
            capacity = initialCapacity;
            array = new T[capacity];
            size = 0;
        }

        /// <summary>
        /// Adds an element to the end of the array
        /// </summary>
        public void Add(T item)
        {
            if (size >= capacity)
                Resize();

            array[size++] = item;
        }

        /// <summary>
        /// Gets element at specified index
        /// </summary>
        public T Get(int index)
        {
            if (index < 0 || index >= size)
                throw new IndexOutOfRangeException("Index out of bounds");
            return array[index];
        }

        /// <summary>
        /// Removes element at specified index
        /// </summary>
        public void Remove(int index)
        {
            if (index < 0 || index >= size)
                throw new IndexOutOfRangeException("Index out of bounds");

            for (int i = index; i < size - 1; i++)
                array[i] = array[i + 1];

            size--;
        }

        private void Resize()
        {
            capacity *= 2;
            T[] newArray = new T[capacity];
            Array.Copy(array, newArray, size);
            array = newArray;
        }

        public int Size => size;
        public void PrintAll() => Console.WriteLine($"Array: [{string.Join(", ", array[0..size])}]");
    }
}
