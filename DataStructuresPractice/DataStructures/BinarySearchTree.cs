using System;

namespace DataStructuresProject.DataStructures
{
    /// <summary>
    /// Binary Search Tree implementation
    /// Time Complexity: Search O(log n) average, Insert O(log n) average, Delete O(log n) average
    /// </summary>
    public class BinarySearchTree<T> where T : IComparable<T>
    {
        public class TreeNode
        {
            public T Data { get; set; }
            public TreeNode Left { get; set; }
            public TreeNode Right { get; set; }
            public TreeNode(T data) => Data = data;
        }

        private TreeNode root;

        /// <summary>
        /// Inserts a value into the BST
        /// </summary>
        public void Insert(T data)
        {
            root = InsertRecursive(root, data);
        }

        private TreeNode InsertRecursive(TreeNode node, T data)
        {
            if (node == null)
                return new TreeNode(data);

            if (data.CompareTo(node.Data) < 0)
                node.Left = InsertRecursive(node.Left, data);
            else if (data.CompareTo(node.Data) > 0)
                node.Right = InsertRecursive(node.Right, data);

            return node;
        }

        /// <summary>
        /// Searches for a value in the BST
        /// </summary>
        public bool Search(T data)
        {
            return SearchRecursive(root, data);
        }

        private bool SearchRecursive(TreeNode node, T data)
        {
            if (node == null) return false;
            if (data.CompareTo(node.Data) == 0) return true;
            if (data.CompareTo(node.Data) < 0)
                return SearchRecursive(node.Left, data);
            return SearchRecursive(node.Right, data);
        }

        /// <summary>
        /// Performs in-order traversal (sorted order)
        /// </summary>
        public void InOrderTraversal()
        {
            Console.Write("BST InOrder: ");
            InOrderRecursive(root);
            Console.WriteLine();
        }

        private void InOrderRecursive(TreeNode node)
        {
            if (node != null)
            {
                InOrderRecursive(node.Left);
                Console.Write($"{node.Data} ");
                InOrderRecursive(node.Right);
            }
        }
    }
}
