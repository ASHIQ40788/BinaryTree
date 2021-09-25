using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            //UC1-Inserting a Node in Binary Search Tree.
            MyBinaryTree<int> myBinaryTree = new MyBinaryTree<int>(56);
            myBinaryTree.Insert(30);
            myBinaryTree.Insert(70);
            myBinaryTree.Insert(22);
            myBinaryTree.Insert(40);
            myBinaryTree.Insert(95);

           
            //UC2-Finding size of the Binary Search Tree
            myBinaryTree.GetSize();

            //UC3-Search for a Required Node.
            MyBinaryTree<int> binarySearch = new MyBinaryTree<int>(56);
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
            binarySearch.Display();
            Console.WriteLine(binarySearch.Search(63, binarySearch));

            myBinaryTree.Display();
            Console.ReadLine();


        }
    }
}
