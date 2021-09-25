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
        bool result = false;
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



        /// <summary>
        /// UC2-Finding Size of the Required Node.
        /// </summary>
        public void GetSize()
        {
            Console.WriteLine("Size" + " " + (1 + leftCount + rightCount));
        }

        ///// <summary>
        ///// UC3-Search for a Node
        ///// </summary>
        //method for search node in BST
        public bool Search(T item, MyBinaryTree<T> node)
        {
            //Check whether the node is null or not.If null it means tree is empty.
            if (node == null)
            {
                return false;
            }

            //if nodeData is equals  to item that means node has been found.
            if (node.nodeData.Equals(item))
            {
                Console.WriteLine("Found the element in BST" + " " + node.nodeData);
                result = true;
            }

            //If item is less than node data it moves to left side(+1) to search for.
            if (item.CompareTo(node.nodeData) < 0)
            {
                Search(item, node.leftTree);
            }
            //If item is greater than node data it moves to right side(-1) to search for.
            if (item.CompareTo(node.nodeData) > 0)
            {
                Search(item, node.rightTree);
            }
            return result; //result value stores here.
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

    }
}
