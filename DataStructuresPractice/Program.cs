using DataStructuresPractice.DataStructures;

namespace DataStructuresProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=== DATA STRUCTURES IMPLEMENTATION DEMO ===\n");

            // 1. Dynamic Array Demo
            Console.WriteLine("1. DYNAMIC ARRAY:");
            var array = new DynamicArray<int>();
            array.Add(10);
            array.Add(20);
            array.Add(30);
            array.PrintAll();
            Console.WriteLine($"Element at index 1: {array.Get(1)}");
            array.Remove(1);
            array.PrintAll();
            Console.WriteLine($"Size: {array.Size}\n");

            // 2. Linked List Demo
            Console.WriteLine("2. LINKED LIST:");
            var linkedList = new LinkedList<string>();
            linkedList.AddFirst("World");
            linkedList.AddFirst("Hello");
            linkedList.AddLast("!");
            linkedList.PrintAll();
            linkedList.Remove("World");
            linkedList.PrintAll();
            Console.WriteLine($"Count: {linkedList.Count}\n");

            // 3. Stack Demo
            Console.WriteLine("3. STACK:");
            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.PrintAll();
            Console.WriteLine($"Popped: {stack.Pop()}");
            Console.WriteLine($"Peek: {stack.Peek()}");
            stack.PrintAll();
            Console.WriteLine($"Count: {stack.Count}\n");

            // 4. Queue Demo
            Console.WriteLine("4. QUEUE:");
            var queue = new Queue<string>();
            queue.Enqueue("First");
            queue.Enqueue("Second");
            queue.Enqueue("Third");
            queue.PrintAll();
            Console.WriteLine($"Dequeued: {queue.Dequeue()}");
            Console.WriteLine($"Peek: {queue.Peek()}");
            queue.PrintAll();
            Console.WriteLine($"Count: {queue.Count}\n");

            // 5. Binary Search Tree Demo
            Console.WriteLine("5. BINARY SEARCH TREE:");
            var bst = new BinarySearchTree<int>();
            bst.Insert(50);
            bst.Insert(30);
            bst.Insert(70);
            bst.Insert(20);
            bst.Insert(40);
            bst.Insert(60);
            bst.Insert(80);
            bst.InOrderTraversal();
            Console.WriteLine($"Search 40: {bst.Search(40)}");
            Console.WriteLine($"Search 100: {bst.Search(100)}\n");

            // 6. Hash Table Demo
            Console.WriteLine("6. HASH TABLE:");
            var hashTable = new HashTable<string, int>();
            hashTable.Put("apple", 5);
            hashTable.Put("banana", 3);
            hashTable.Put("orange", 8);
            hashTable.Put("grape", 12);
            hashTable.PrintAll();
            Console.WriteLine($"Get 'banana': {hashTable.Get("banana")}");
            Console.WriteLine($"Contains 'apple': {hashTable.ContainsKey("apple")}");
            Console.WriteLine($"Count: {hashTable.Count}\n");
        }
    }

}
