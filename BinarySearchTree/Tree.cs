using System;
using System.Collections;
using System.Collections.Generic;

namespace BinarySearchTree
{
    class Tree<T> where T : IComparable
    {
        public Node<T> Root { get; private set; }
        public int Count { get; private set; }


        public void Add(T data)
        {

            if (Root == null)
            {
                Root = new Node<T>(data);
                Count = 1;
                return;
            }

            if (Root != null)
            {
                Root.Add(data);
                Count += 1;
                return;
            }

        }

        public List<T> Preorder()
        {
            var list = new List<T>();
            if (Root == null)
            {
                return list;

            }

            else return Preorder(Root);
        }

        private List<T> Preorder(Node<T> node)
        {
            if (node != null)
            {
                var list = new List<T>();
                list.Add(node.Data);
                if (node.Left != null)
                {
                    list.AddRange(Preorder(node.Left));
                }

                if (node.Right != null)
                {
                    list.AddRange(Preorder(node.Right));
                }
                return list;
            }
            else throw new Exception("meeeeee");
        }

        public List<T> PosrOrder()
        {
            var list = new List<T>();
            if (Root == null)
            {
                return list;

            }

            else return PosrOrder(Root);
        }

        private List<T> PosrOrder(Node<T> node)
        {
            if (node != null)
            {
                var list = new List<T>();
                if (node.Left != null)
                {
                    list.AddRange(PosrOrder(node.Left));
                }

                if (node.Right != null)
                {
                    list.AddRange(PosrOrder(node.Right));
                }

                list.Add(node.Data);
                return list;
            }
            else throw new Exception("meeee v2");
        }

        public List<T> InOrder()
        {
            var list = new List<T>();
            if (Root == null)
            {
                return list;

            }

            else return InOrder(Root);
        }

        public List<T> InOrder(Node<T> node)
        {
            if (node != null)
            {
                var list = new List<T>();
                if (node.Left != null)
                {
                    list.AddRange(InOrder(node.Left));
                }

                list.Add(node.Data);

                if (node.Right != null)
                {
                    list.AddRange(InOrder(node.Right));
                }

                return list;
            }

            else throw new Exception("meeeeeee v3");
        }

        public IEnumerator GetEnumerator(List<T> list)
        {
            for (int i = 0; i < Count; ++i)
            {
                yield return list[i];
            }
        }
    }
}
