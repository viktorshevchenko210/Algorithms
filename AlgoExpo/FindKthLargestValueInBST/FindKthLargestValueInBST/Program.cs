using System;
using System.Collections.Generic;

namespace FindKthLargestValueInBST
{
    public class BST
    {
        public int value;
        public BST left = null;
        public BST right = null;

        public BST(int value)
        {
            this.value = value;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Reverse in order traversal

            //BST tree = new BST(15);

            //tree.left = new BST(5);
            //tree.left.right = new BST(5);

            //tree.left.left = new BST(2);
            //tree.left.left.right = new BST(3);

            //tree.left.left.left = new BST(1);

            //tree.right = new BST(20);
            //tree.right.right = new BST(22);

            //tree.right.left = new BST(17);

            BST tree = new BST(20);
            tree.left = new BST(15);
            tree.right = new BST(25);

            tree.left.left = new BST(10);
            tree.left.right = new BST(19);

            tree.right.left = new BST(21);
            tree.right.right = new BST(30);

            tree.right.left.right = new BST(22);

            int k = 3;

            FindKthLargestValueInBst(tree, k);
        }

        static int FindKthLargestValueInBst(BST tree, int k)
        {
            List<int> values = new List<int>();

            ReverseInOrderTraverse(tree, k, values);

            return values[k-1];
        }

        static void ReverseInOrderTraverse(BST tree, int k, List<int> values)
        {
            if (tree == null || values.Count >= k)
                return;

            ReverseInOrderTraverse(tree.right, k, values);
            if (values.Count < k)
            {
                values.Add(tree.value);
                ReverseInOrderTraverse(tree.left, k, values);
            }
        }
    }
}
