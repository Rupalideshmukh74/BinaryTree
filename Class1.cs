using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class BinarySearchTree<T> where T : IComparable
    {
        int treeSize = 0;
        public Node<T> root;
        public BinarySearchTree()
        {
            root = null;
        }

        public void Insert(int element)
        {
            Node<T> newNode = new Node<T>();
            newNode.NodeData = element;
            if (root == null)
            {
                root = newNode;
                //Console.WriteLine(" Root ");
                treeSize++;
            }
            else
            {
                Node<T> newRoot = root;
                Node<T> parent;
                while (true)
                {
                    parent = newRoot;
                    if (element < newRoot.NodeData)
                    {
                        Console.WriteLine(" {0} | To Left", element);
                        newRoot = newRoot.LeftTree;
                        if (newRoot == null)
                        {
                            parent.LeftTree = newNode;
                            treeSize++;
                            return;

                        }
                    }
                    else
                    {
                        Console.WriteLine(" {0} | To Right", element);
                        newRoot = newRoot.RightTree;
                        if (newRoot == null)
                        {
                            parent.RightTree = newNode;
                            treeSize++;
                            return;
                        }
                    }
                }
            }
        }
            public void SizeOfTree()
            {
                if (root == null)
                {
                    Console.WriteLine("Binary Search Tree is Empty");
                }
                Console.WriteLine("\nSize of tree is : " + treeSize);
            }
        public void SearchTree(Node<T> newNode, int value)
        {
            if (null == newNode)
            {
                Console.WriteLine("{0} is Not Present in BST", value);
            }
            //found
            else if (newNode.NodeData == value)
            {
                Console.WriteLine("{0} is Present in BST", value);
            }
            //left tree
            else if (value < newNode.NodeData)
                SearchTree(newNode.LeftTree, value);
            //right tree
            else
                SearchTree(newNode.RightTree, value);
        }
    }

   
    }
