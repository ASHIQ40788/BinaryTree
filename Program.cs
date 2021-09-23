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

            myBinaryTree.Display();
            Console.ReadLine();


        }
    }
}
