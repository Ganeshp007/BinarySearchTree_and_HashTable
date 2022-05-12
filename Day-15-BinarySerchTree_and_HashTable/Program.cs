// See https://aka.ms/new-console-template for more information
using Day_15_BinarySerchTree_and_HashTable;

Console.WriteLine("----- Binary_Search_Tree -----\n");

BinarySearchTreeOps<int> binarySearchTree = new BinarySearchTreeOps<int>(56); //Root=56  
binarySearchTree.Insert(30);
binarySearchTree.Insert(70);

Console.WriteLine("\n>> Binary_Search_Tree :- ");
binarySearchTree.Display();

Console.ReadKey();