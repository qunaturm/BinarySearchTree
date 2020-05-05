using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class Tree<T> where T : IComparable
    {
        public Node<T> Root { get; private set; }
        public int Count { get; private set; }

        public void Add(T data)
        {
            var node = new Node<T>(data);

            if (Root == null)
            {
                Root = node;
                Count = 1;
                return;
            }

            if (Root != null)
            {
                var current = Root;

                if (node.CompareTo(current) < 0) //this > new
                {
                    if (current.Left == null)
                    {
                        current.Left = node;
                        Count += 1;
                        return;
                    }
                    else
                    {
                        while(current.Left != null)
                        {
                            current = current.Left;
                        }
                        current.Left = node;
                        return;
                    }
                }

                if (node.CompareTo(current) == 0) //this == new
                {

                }

                if (node.CompareTo(current) > 0) //this < new
                {
                    if (current.Right == null)
                    {
                        current.Right = node;
                        Count += 1;
                        return;
                    }
                    else
                    {
                        while(current.Right != null)
                        {
                            current = current.Right;
                        }
                        current.Right = node; 
                    }
                }
            }

        }
    }
}
