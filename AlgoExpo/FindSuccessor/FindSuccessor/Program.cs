using System;

namespace FindSuccessor
{
    public class BinaryTree
    {
        public int value;
        public BinaryTree left = null;
        public BinaryTree right = null;
        public BinaryTree parent = null;

        public BinaryTree(int value)
        {
            this.value = value;
        }
    }

    public class TreeInfo
    {
        public BinaryTree Successor { get; private set; }
        public bool isFound = false;

        public TreeInfo(BinaryTree successor)
        {
            this.Successor = successor;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree(1);
            tree.left = new BinaryTree(2);
            tree.right = new BinaryTree(3);

            tree.right.left = new BinaryTree(4);
            tree.right.left.left = new BinaryTree(5);
            tree.right.left.left.left = new BinaryTree(6);
            tree.right.left.left.left.left = new BinaryTree(7);

            BinaryTree node = new BinaryTree(1);

            FindSuccessor(tree, node);
        }

        static BinaryTree FindSuccessor(BinaryTree tree, BinaryTree node)
        {
            TreeInfo info = new TreeInfo(null);
            FindSuccessor(tree, node, ref info);
            return info.Successor;
        }

        static BinaryTree FindSuccessor(BinaryTree tree, BinaryTree node, ref TreeInfo treeInfo)
        {
            if (tree == null || (treeInfo.isFound && treeInfo.Successor != null))
            {
                return tree;
            }


            FindSuccessor(tree.left, node, ref treeInfo);

            if (treeInfo.isFound)
            {
                if (treeInfo.Successor == null)
                {
                    treeInfo = new TreeInfo(tree);
                }

                return tree;
            }
            else
            {
                if (tree.value == node.value)
                {
                    treeInfo.isFound = true;
                }
            }

            FindSuccessor(tree.right, node, ref treeInfo);

            return tree;
        }
    }
}
