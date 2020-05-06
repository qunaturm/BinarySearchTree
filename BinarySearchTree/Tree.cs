using System;
using System.Collections;
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
            if (Root != null)
            {
                var current = Root;
                list.Add(current.Data);
               if (current.Left != null)
               {
                    list.AddRange(Preorder(current.Left));
               }

               if (current.Right != null)
                {
                    list.AddRange(Preorder(current.Right));
                }

            }

            return list;
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

        public List<T> Sort()
        {
            var list = new List<T>();
            if (Root != null)
            {
                var current = Root;
                if (current.Left != null)
                {
                    list.AddRange(Sort(current.Left));
                }

                if (current.Right != null)
                {
                    list.AddRange(Sort(current.Right));
                }
                list.Add(current.Data);
            }

            return list;
        }

        private List<T> Sort(Node<T> node)
        {
            if (node != null)
            {
                var list = new List<T>();
                if (node.Left != null)
                {
                    list.AddRange(Sort(node.Left));
                }

                if (node.Right != null)
                {
                    list.AddRange(Sort(node.Right));
                }

                list.Add(node.Data);
                return list;
            }
            else throw new Exception("meeee v2");
        }

        public IEnumerator GetEnumerator(List<T> list)
        {
            for (int i = 0; i < Count; ++i)
            {
                yield return list[i];
            }
        }

        public void Print(List<T> list) //postfiks dlya printa!!!!!!!!!!!
        {

            if (Root != null)
            {
                for (int i = 0; i < Count; i++)
                {
                    Console.WriteLine(list[i]);
                }

                //foreach (T n in list)
                //{
                //    Console.WriteLine(list);
                //    yield return list[];
                //}
            }
        }
    }
}
