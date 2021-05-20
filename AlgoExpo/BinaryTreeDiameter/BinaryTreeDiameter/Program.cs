using System;

namespace BinaryTreeDiameter
{
    public class BinaryTree
    {
        public int value;
        public BinaryTree left;
        public BinaryTree right;

        public BinaryTree(int value)
        {
            this.value = value;
        }
    }

    public class TreeInfo
    {
        public int diameter;
        public int height;
        public TreeInfo(int diameter, int height)
        {
            this.diameter = diameter;
            this.height = height;
        }
    }

    class Program
    {
        static int max;
        static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree(1);
            binaryTree.left = new BinaryTree(3);
            binaryTree.left.left = new BinaryTree(7);
            binaryTree.left.left.left = new BinaryTree(8);
            binaryTree.left.left.left.left = new BinaryTree(9);

            binaryTree.left.right = new BinaryTree(4);
            binaryTree.left.right.right = new BinaryTree(5);
            binaryTree.left.right.right.right = new BinaryTree(6);

            binaryTree.right = new BinaryTree(2);

            var result = BinaryTreeDiameter(binaryTree);
        }

        static int BinaryTreeDiameter(BinaryTree tree)
        {
            return GetTreeInfo(tree).diameter;
        }

        static TreeInfo GetTreeInfo(BinaryTree tree)
        {
            if (tree == null)
                return new TreeInfo(0,0);

            TreeInfo leftTreeInfo = GetTreeInfo(tree.left);
            TreeInfo rightTreeInfo = GetTreeInfo(tree.right);

            int longestPathThroughRoot = leftTreeInfo.height + rightTreeInfo.height;
            int maxDiameterSoFar = Math.Max(leftTreeInfo.diameter, rightTreeInfo.diameter);
            int currentDiameter = Math.Max(longestPathThroughRoot, maxDiameterSoFar);
            int currentHeight = 1 + Math.Max(leftTreeInfo.height, rightTreeInfo.height);

            return new TreeInfo(currentDiameter, currentHeight);
        }
    }
}
