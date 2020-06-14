using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidateBST
{
    class Program
    {

        static void Main(string[] args)
        {
            BST tree = new BST(10);
            Initialize(tree);
            var isValid = ValidateBST(tree, Int32.MinValue, Int32.MaxValue);
        }

        public static bool ValidateBST(BST tree, int minValue, int maxValue)
        {
            if (tree.value < minValue || tree.value >= maxValue)
                return false;

            if (tree.left != null && !ValidateBST(tree.left, minValue, tree.value))
                return false;

            if (tree.right != null && !ValidateBST(tree.right, tree.value, maxValue))
                return false;

            return true;
        }

        public static bool ValidateBST(BST tree, int head)
        {
            return true;
        }

        static void Initialize(BST tree)
        {
            //tree.left = new BST(5);
            //tree.right = new BST(15);

            //tree.left.right = new BST(10);

            tree.left = new BST(5);
            tree.right = new BST(15);

            tree.left.left = new BST(2);
            tree.left.right = new BST(5);

            tree.left.left.left = new BST(1);

            tree.right.left = new BST(13);
            tree.right.left.right = new BST(14);

            tree.right.right = new BST(22);
            tree.right.right.left = new BST(5);
        }
    }
}
