using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new Tree<int>();
            tree.Add(7);
            tree.Add(4);
            tree.Add(9);
            tree.Add(8);
            tree.Add(5);
            tree.Add(2);
            //tree.Add(6);
            //tree.Add(10);
            //tree.Add(12);
            //tree.Add(11);

            tree.Print(tree.Preorder());
            Console.WriteLine(System.Environment.NewLine);
            tree.Print(tree.Sort());
        }
    }
}
