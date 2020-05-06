using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new Tree<int>();
            tree.Add(5);
            tree.Add(3);
            tree.Add(7);
            tree.Add(1);
            tree.Add(2);
            tree.Add(6);
            tree.Add(8);
            tree.Add(9);
            tree.Add(4);
            tree.Add(11);

            foreach (var i in tree.Preorder())
            {
                Console.Write(i + ", ");
            }

            Console.WriteLine(System.Environment.NewLine);


            foreach (var i in tree.PosrOrder())
            {
                Console.Write( i + ", ");
            }

            Console.WriteLine(System.Environment.NewLine);

            foreach (var i in tree.InOrder())
            {
                Console.Write(i + ", ");
            }

            //tree.Print(tree.Preorder());
            //Console.WriteLine(System.Environment.NewLine);
            //tree.Print(tree.PosrOrder());
        }
    }
}
