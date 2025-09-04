# Data Structures Implementation in C#

A comprehensive implementation of fundamental data structures in C#, demonstrating computer science principles and clean code practices.

## Overview

This project provides custom implementations of essential data structures, each designed with **performance**, **type safety**, and **clean architecture** in mind. All implementations use **C# Generics** for flexibility and include comprehensive documentation.

## Features

- [X] **Dynamic Array**
- [X] **Linked List** 
- [X] **Stack**
- [X] **Queue**
- [ ] **Binary Search Tree**
- [ ] **Hash Table**
- [ ] **Trie**
- [ ] **Complete Documentation** with XML comments
- [ ] **Interactive Demo** with practical examples

## Project Structure

```
DataStructuresProject/
├── Program.cs                    # Main demo application
├── DataStructures/               # Core implementations
│   ├── DynamicArray.cs          # Resizable array
│   ├── LinkedList.cs            # Singly linked list
│   ├── Stack.cs                 # LIFO structure
│   ├── Queue.cs                 # FIFO structure
│   ├── BinarySearchTree.cs      # BST implementation
│   ├── HashTable.cs             # Hash table with chaining
│   └── Trie.cs                  # Prefix tree
├── README.md                    # This file
└── DataStructuresProject.csproj # Project configuration
```

## Data Structures Implemented

### 1. Dynamic Array
- **Description**: Automatically resizing array with O(1) amortized insertions
- **Use Cases**: Collections that need random access and dynamic sizing
- **Key Operations**: Add, Get, Remove, Resize

### 2. Linked List  
- **Description**: Singly linked list for efficient insertions/deletions
- **Use Cases**: Frequent insertions at beginning, unknown size collections
- **Key Operations**: AddFirst, AddLast, Remove

### 3. Stack
- **Description**: Last-In-First-Out (LIFO) data structure
- **Use Cases**: Function calls, undo operations, expression evaluation
- **Key Operations**: Push, Pop, Peek

### 4. Queue
- **Description**: First-In-First-Out (FIFO) data structure  
- **Use Cases**: Task scheduling, breadth-first search, buffering
- **Key Operations**: Enqueue, Dequeue, Peek

### 5. Binary Search Tree
- **Description**: Self-organizing tree for efficient searching
- **Use Cases**: Sorted data, range queries, fast lookups
- **Key Operations**: Insert, Search, InOrder traversal

### 6. Hash Table
- **Description**: Key-value storage with separate chaining for collisions
- **Use Cases**: Dictionaries, caches, database indexing
- **Key Operations**: Put, Get, ContainsKey

### 7. Trie (Prefix Tree)
- **Description**: Tree structure for efficient string operations
- **Use Cases**: Autocomplete, spell checkers, IP routing
- **Key Operations**: Insert, Search, StartsWith, GetWordsWithPrefix

## Getting Started

### Prerequisites
- [.NET 6.0 or later](https://dotnet.microsoft.com/download)
- Any IDE (Visual Studio, VS Code, Rider)

### Installation & Running

1. **Clone the repository**:
   ```bash
   git clone https://github.com/yourusername/data-structures-csharp.git
   cd data-structures-csharp
   ```

2. **Run the project**:
   ```bash
   dotnet run
   ```

3. **Or build and run separately**:
   ```bash
   dotnet build
   dotnet run --project DataStructuresProject
   ```

## Usage Examples

### Dynamic Array Example

| Operation | Input | Expected Output |
|-----------|-------|-----------------|
| Create & Add | `numbers.Add(10)`, `numbers.Add(20)`, `numbers.Add(30)` | Array: [10, 20, 30] |
| Get Element | `numbers.Get(1)` | Returns: 20 |
| Remove Element | `numbers.Remove(1)` | Array: [10, 30] |
| Size Check | `numbers.Size` | Returns: 2 |

### Hash Table Example

| Operation | Input | Expected Output |
|-----------|-------|-----------------|
| Put Values | `inventory.Put("apples", 50)`, `inventory.Put("oranges", 30)` | HashTable with 2 entries |
| Get Value | `inventory.Get("apples")` | Returns: 50 |
| Check Key | `inventory.ContainsKey("oranges")` | Returns: true |
| Print All | `inventory.PrintAll()` | Bucket 0: [apples:50] [oranges:30] |

### Binary Search Tree Example

| Operation | Input | Expected Output |
|-----------|-------|-----------------|
| Insert Values | `bst.Insert(50)`, `bst.Insert(30)`, `bst.Insert(70)`, `bst.Insert(20)`, `bst.Insert(40)` | BST with 5 nodes |
| Search Value | `bst.Search(40)` | Returns: true |
| Search Missing | `bst.Search(100)` | Returns: false |
| InOrder Traversal | `bst.InOrderTraversal()` | Output: 20 30 40 50 70 |

### Stack Example

| Operation | Input | Expected Output |
|-----------|-------|-----------------|
| Push Values | `stack.Push(1)`, `stack.Push(2)`, `stack.Push(3)` | Stack: [3, 2, 1] (top to bottom) |
| Peek Top | `stack.Peek()` | Returns: 3 |
| Pop Value | `stack.Pop()` | Returns: 3, Stack: [2, 1] |
| Check Count | `stack.Count` | Returns: 2 |

### Queue Example

| Operation | Input | Expected Output |
|-----------|-------|-----------------|
| Enqueue Values | `queue.Enqueue("First")`, `queue.Enqueue("Second")`, `queue.Enqueue("Third")` | Queue: [First, Second, Third] |
| Peek Front | `queue.Peek()` | Returns: "First" |
| Dequeue Value | `queue.Dequeue()` | Returns: "First", Queue: [Second, Third] |
| Check Count | `queue.Count` | Returns: 2 |

### Trie Example

| Operation | Input | Expected Output |
|-----------|-------|-----------------|
| Insert Words | `trie.Insert("cat")`, `trie.Insert("car")`, `trie.Insert("card")` | Trie with 3 words |
| Search Word | `trie.Search("car")` | Returns: true |
| Search Missing | `trie.Search("cart")` | Returns: false |
| Check Prefix | `trie.StartsWith("ca")` | Returns: true |
| Get Words | `trie.GetWordsWithPrefix("car")` | Returns: ["car", "card"] |

## Running Tests

The main program includes comprehensive demonstrations of all data structures:

```bash
dotnet run
```

**Expected Output:**
```
=== DATA STRUCTURES IMPLEMENTATION DEMO ===

1. DYNAMIC ARRAY:
Array: [10, 20, 30]
Element at index 1: 20
Array: [10, 30]
Size: 2

2. LINKED LIST:
LinkedList: Hello -> World -> !
LinkedList: Hello -> !
Count: 2

... (continues with all structures)
```

## Performance Comparison

| Data Structure | Access | Search | Insert | Delete |
|---------------|--------|--------|--------|--------|
| Dynamic Array | O(1)   | O(n)   | O(1)*  | O(n)   |
| Linked List   | O(n)   | O(n)   | O(1)   | O(n)   |
| Stack         | O(1)   | -      | O(1)   | O(1)   |
| Queue         | O(1)   | -      | O(1)   | O(1)   |
| BST           |  | |  |  |
| Hash Table    |   |   |   | |
| Trie          |    |    |    |   |

_* Amortized time complexity_  

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Author

**Laura de Faria Maranhão Ayres**
- GitHub: [@lauradefaria](https://github.com/lauradefaria)
- LinkedIn: [/in/lauradefaria](https://linkedin.com/in/lauradefaria)
