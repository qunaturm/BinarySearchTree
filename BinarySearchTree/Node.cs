using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace BinarySearchTree
{
    class Node<T> : IComparable<T>, IComparable where T : IComparable 
    {
        public T Data { get; private set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }

        public Node(T data)
        {
            Data = data;
        }

        public Node(T data, Node<T> left, Node<T> right)
        {
            Data = data;
            Left = left;
            Right = right;
        }

        public int CompareTo(object obj)
        {
            if (obj is Node<T>)
            {
                return Data.CompareTo(obj);
            }

            else throw new Exception("Wrong data type");
            
        }

        public int CompareTo([AllowNull] T other)
        {
            return Data.CompareTo(other);
        }
    }
}
