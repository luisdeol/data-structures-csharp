using System;
using System.Collections.Generic;

namespace dataStructuresCsharp.BinaryTree
{
    public class BinaryTree<T> where T: IComparable
    {
        public Node<T> Root { get; set; }

        public BinaryTree()
        {
            
        }

        public void AddNode(T value){
            var node = new Node<T>(value);
            var queue = new Queue<Node<T>>();
            queue.Enqueue(Root);

            while(queue.Count > 0){
                var current = queue.Dequeue();

                if (current.LeftChild == null){
                    current.LeftChild = node;
                    break;
                }
                else queue.Enqueue(current.LeftChild);

                if (current.RightChild == null){
                    current.RightChild = node;
                    break;
                }
                else queue.Enqueue(current.RightChild);
            }
        }

        public void DisplayInOder(Node<T> node){
            if (node == null)
                return;
            
            Display(node.LeftChild);
            Console.WriteLine(node.Value + " ");
            Display(node.RightChild);
        }
    }
}