using System;
using System.Collections.Generic;

namespace DataStructuresProject.DataStructures
{
    /// <summary>
    /// Hash Table implementation with separate chaining for collision resolution
    /// Time Complexity: Insert O(1) average, Search O(1) average, Delete O(1) average
    /// </summary>
    public class HashTable<TKey, TValue>
    {
        private class HashNode
        {
            public TKey Key { get; set; }
            public TValue Value { get; set; }
            public HashNode Next { get; set; }

            public HashNode(TKey key, TValue value)
            {
                Key = key;
                Value = value;
            }
        }

        private HashNode[] buckets;
        private int size;
        private int count;

        public HashTable(int size = 16)
        {
            this.size = size;
            buckets = new HashNode[size];
            count = 0;
        }

        private int Hash(TKey key)
        {
            return Math.Abs(key.GetHashCode()) % size;
        }

        /// <summary>
        /// Inserts or updates a key-value pair
        /// </summary>
        public void Put(TKey key, TValue value)
        {
            int index = Hash(key);
            HashNode newNode = new HashNode(key, value);

            if (buckets[index] == null)
            {
                buckets[index] = newNode;
                count++;
                return;
            }

            HashNode current = buckets[index];
            while (current != null)
            {
                if (current.Key.Equals(key))
                {
                    current.Value = value; // Update existing
                    return;
                }
                if (current.Next == null) break;
                current = current.Next;
            }

            current.Next = newNode;
            count++;
        }

        /// <summary>
        /// Gets value by key
        /// </summary>
        public TValue Get(TKey key)
        {
            int index = Hash(key);
            HashNode current = buckets[index];

            while (current != null)
            {
                if (current.Key.Equals(key))
                    return current.Value;
                current = current.Next;
            }

            throw new KeyNotFoundException($"Key '{key}' not found");
        }

        /// <summary>
        /// Checks if key exists
        /// </summary>
        public bool ContainsKey(TKey key)
        {
            try
            {
                Get(key);
                return true;
            }
            catch (KeyNotFoundException)
            {
                return false;
            }
        }

        public int Count => count;

        public void PrintAll()
        {
            Console.WriteLine("HashTable contents:");
            for (int i = 0; i < size; i++)
            {
                HashNode current = buckets[i];
                if (current != null)
                {
                    Console.Write($"Bucket {i}: ");
                    while (current != null)
                    {
                        Console.Write($"[{current.Key}:{current.Value}] ");
                        current = current.Next;
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
