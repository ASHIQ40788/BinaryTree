using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class MyBinaryTree<T> where T : IComparable
    {
        public T nodeData { get; set; }
        public MyBinaryTree<T> leftTree { get; set; }
        public MyBinaryTree<T> rightTree { get; set; }
        public static int leftCount;
        public static int rightCount;

        public MyBinaryTree(T nodeData)
        {
            this.nodeData = nodeData;
            this.leftTree = null;
            this.rightTree = null;

        }
        /// <summary>
        /// UC1- Inserting a Node.
        /// </summary>
        /// <param name="item"></param>
        public void Insert(T item)
        {
            T currentNodeValue = this.nodeData;
            int value = currentNodeValue.CompareTo(item);
            if ((value) > 0)
            {
                if (this.leftTree == null)
                {
                    this.leftTree = new MyBinaryTree<T>(item);
                    Console.WriteLine("Inserting" + item);
                }
                else
                    this.leftTree.Insert(item);
            }
            else
            {
                if (this.rightTree == null)
                {
                    this.rightTree = new MyBinaryTree<T>(item);
                    Console.WriteLine("Inserting " + item);
                }
                else
                {
                    this.rightTree.Insert(item);
                    Console.WriteLine("Inserting " + item);
                }

            }

        }

        public void Display()
        {
            if (this.leftTree != null)
            {
                leftCount++;
                this.leftTree.Display();
            }

            Console.WriteLine(this.nodeData.ToString());
            if (this.rightTree != null)
            {
                rightCount++;
                this.rightTree.Display();
            }

        }

        /// <summary>
        /// UC2-Finding Size of the Required Node.
        /// </summary>
        public void GetSize()
        {
            Console.WriteLine("Size" + " " + (1 + leftCount + rightCount));
        }

        /// <summary>
        /// UC3-Search for a Node
        /// </summary>
        public class Node
        {
            //instance variables(which is outside the method and inside the class)
            public int Data;
            public Node Left;
            public Node Right;
            public Node(int Data)
            {
                this.Data = Data;
            }
        }
        public class BinarySearchTree
        {
            public static Node Search(Node root, int Data)
            {
                if (root.Data == Data)
                {
                    return root; //because we found the node for which we are searching for.

                }
                else if (Data < root.Data)
                {
                    //Go to the left child
                    root = Search(root.Left, Data);

                }
                else if (Data > root.Data)
                {
                    //Go to the right child
                    root = Search(root.Right, Data);
                }
                return root;
            }

        }
    }
}
