using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchSums
{
    class Program
    {
        static BinaryTree binaryTree = null;
        static List<int> result = new List<int>();

        static void Main(string[] args)
        {
            int sum = 0;
            Initialize2();
            BranchSum(binaryTree, sum);
        }

        public static void BranchSum(BinaryTree tree, int sum)
        {

        }

        static void Initialize()
        {
            binaryTree = new BinaryTree();
            binaryTree.Value = 1;

            binaryTree.Left = new BinaryTree();
            binaryTree.Left.Value = 2;

            binaryTree.Left.Left = new BinaryTree();
            binaryTree.Left.Left.Value = 4;

            binaryTree.Left.Left.Left = new BinaryTree();
            binaryTree.Left.Left.Left.Value = 8;

            binaryTree.Left.Left.Right = new BinaryTree();
            binaryTree.Left.Left.Right.Value = 9;

            binaryTree.Left.Right = new BinaryTree();
            binaryTree.Left.Right.Value = 5;

            binaryTree.Left.Right.Right = new BinaryTree();
            binaryTree.Left.Right.Right.Value = 10;

            binaryTree.Right = new BinaryTree();
            binaryTree.Right.Value = 3;

            binaryTree.Right.Right = new BinaryTree();
            binaryTree.Right.Right.Value = 7;

            binaryTree.Right.Left = new BinaryTree();
            binaryTree.Right.Left.Value = 6;

        }

        static void Initialize2()
        {
            binaryTree = new BinaryTree();
            binaryTree.Value = 1;

            binaryTree.Left = new BinaryTree();
            binaryTree.Left.Value = 2;
        }
    }
}
