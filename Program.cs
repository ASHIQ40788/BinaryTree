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
            //UC2-Finding size of the Binary Search Tree
            myBinaryTree.GetSize();

            Console.ReadLine();

            // UC3 - Searching a node in a Binary Tree
            //Node root = new Node(56);
            //Node num1 = new Node(30);
            //Node num2 = new Node(70);
            //Node num3 = new Node(63);
            //root.Left = num1;
            //root.Right = num2;
            //num2.Left = num3;

            //Node nodeFind = BinarySearchTree.Search(root, 63);
            //Console.WriteLine(nodeFind.Data);
            //Console.ReadLine();



        }
    }
}
