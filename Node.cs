using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    public class Node<T> where T : IComparable
    {
        public int NodeData;
        public Node<T> LeftTree;
        public Node<T> RightTree;
    }
}
