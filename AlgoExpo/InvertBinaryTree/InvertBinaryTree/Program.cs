using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvertBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = Create();
            InvertBinaryTree(tree);
        }

        public static void InvertBinaryTree(BinaryTree tree)
        {
            if (tree == null)
                return;

            SwapLeftAndRight(tree);

            InvertBinaryTree(tree.left);
            InvertBinaryTree(tree.right);
        }

        public static void SwapLeftAndRight(BinaryTree tree)
        {
            BinaryTree left = tree.left;
            tree.left = tree.right;
            tree.right = left;
        }

        private static BinaryTree Create()
        {
            BinaryTree tree = new BinaryTree(1);
            tree.left = new BinaryTree(2);
            tree.left.left = new BinaryTree(4);
            tree.left.left.left = new BinaryTree(8);
            tree.left.left.right = new BinaryTree(9);

            tree.left.right = new BinaryTree(5);

            tree.right = new BinaryTree(3);
            tree.right.left = new BinaryTree(6);
            tree.right.right = new BinaryTree(7);

            return tree;
        }
    }
}
