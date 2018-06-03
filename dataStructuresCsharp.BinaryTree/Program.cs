using System;

namespace dataStructuresCsharp.BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new BinaryTree<int>();

            tree.Root = new Node<int>(1);

            tree.AddNode(2);
            tree.AddNode(3);
            tree.AddNode(4);
            tree.AddNode(5);
            
            tree.DisplayInOder(tree.Root);
        }
    }
}
