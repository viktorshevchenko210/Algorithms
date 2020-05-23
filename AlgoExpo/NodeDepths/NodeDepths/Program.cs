using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeDepths
{
    class Program
    {
        static BinaryTree tree;
        static int result = 0;

        static void Main(string[] args)
        {
            Initialize3();
            int depth = -1;
            FindNodeDepth(tree, depth);
        }

        static void FindNodeDepth(BinaryTree tree, int depth)
        {
            if (tree == null)
            {
                depth--;
                return;
            }

            depth++;
            result += depth;

            if(tree.Left == null)
            {
                FindNodeDepth(tree.Right, depth);
            }
            else
            {
                FindNodeDepth(tree.Left, depth);
                if (tree.Right != null)
                    FindNodeDepth(tree.Right, depth);
            }

        }

        public static void Initialize()
        {
            tree = new BinaryTree();
            tree.Value = 1;

            tree.Left = new BinaryTree();
            tree.Left.Value = 2;

            tree.Left.Right = new BinaryTree();
            tree.Left.Right.Value = 5;

            tree.Left.Left = new BinaryTree();
            tree.Left.Left.Value = 4;

            tree.Left.Left.Right = new BinaryTree();
            tree.Left.Left.Right.Value = 9;

            tree.Left.Left.Left = new BinaryTree();
            tree.Left.Left.Left.Value = 8;

            tree.Right = new BinaryTree();
            tree.Right.Value = 3;

            tree.Right.Left = new BinaryTree();
            tree.Right.Left.Value = 6;

            tree.Right.Right = new BinaryTree();
            tree.Right.Right.Value = 7;
        }

        public static void Initialize2()
        {
            tree = new BinaryTree();
            tree.Value = 1;

            tree.Left = new BinaryTree();
            tree.Left.Value = 2;

            tree.Left.Left = new BinaryTree();
            tree.Left.Left.Value = 3;

            tree.Left.Left.Left = new BinaryTree();
            tree.Left.Left.Left.Value = 4;

            tree.Left.Left.Left.Left = new BinaryTree();
            tree.Left.Left.Left.Left.Value = 5;

            tree.Left.Left.Left.Left.Left = new BinaryTree();
            tree.Left.Left.Left.Left.Left.Value = 6;

            tree.Left.Left.Left.Left.Left.Right = new BinaryTree();
            tree.Left.Left.Left.Left.Left.Right.Value = 7;
        }

        public static void Initialize3()
        {
            tree = new BinaryTree();
            tree.Value = 1;

            tree.Left = new BinaryTree();
            tree.Left.Value = 2;

            tree.Left.Left = new BinaryTree();
            tree.Left.Left.Value = 3;

            tree.Left.Left.Left = new BinaryTree();
            tree.Left.Left.Left.Value = 4;

            tree.Left.Left.Left.Left = new BinaryTree();
            tree.Left.Left.Left.Left.Value = 5;

            tree.Left.Left.Left.Left.Left = new BinaryTree();
            tree.Left.Left.Left.Left.Left.Value = 6;

            tree.Left.Left.Left.Left.Left.Right = new BinaryTree();
            tree.Left.Left.Left.Left.Left.Right.Value = 7;

            tree.Right = new BinaryTree();
            tree.Right.Value = 8;

            tree.Right.Right = new BinaryTree();
            tree.Right.Right.Value = 9;

            tree.Right.Right.Right = new BinaryTree();
            tree.Right.Right.Right.Value = 10;

            tree.Right.Right.Right.Right = new BinaryTree();
            tree.Right.Right.Right.Right.Value = 11;

            tree.Right.Right.Right.Right.Right = new BinaryTree();
            tree.Right.Right.Right.Right.Right.Value = 12;

            tree.Right.Right.Right.Right.Right.Left = new BinaryTree();
            tree.Right.Right.Right.Right.Right.Left.Value = 13;

        }
    }
}
