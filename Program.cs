using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Binary Search Tree program!");
            BinarySearchTree<int> binarySearch = new BinarySearchTree<int>();

            //Display Root 
            Console.WriteLine("Root : 56 ");

            binarySearch.Insert(56);
            binarySearch.Insert(30);
            binarySearch.Insert(70);
            binarySearch.Insert(22);
            binarySearch.Insert(40);
            binarySearch.Insert(60);
            binarySearch.Insert(95);
            binarySearch.Insert(11);
            binarySearch.Insert(65);
            binarySearch.Insert(3);
            binarySearch.Insert(16);
            binarySearch.Insert(63);
            binarySearch.Insert(67);

            //Display Result
            Console.Write("\n:: BST Elements Traversal :: \n");
            
            Console.WriteLine("\n--------------------------------------");
            binarySearch.SizeOfTree();
        }
    }
}
