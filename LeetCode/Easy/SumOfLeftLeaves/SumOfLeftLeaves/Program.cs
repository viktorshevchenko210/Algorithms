using System;

namespace SumOfLeftLeaves
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode tree = new TreeNode(1);
            tree.left = new TreeNode(2);

            tree.right = new TreeNode(3);

            tree.left.left = new TreeNode(4);
            tree.left.right = new TreeNode(5);

            SumOfLeftLeaves(tree);
        }

        static int SumOfLeftLeaves(TreeNode root)
        {
            int sum = 0;
            return Sum(root, ref sum);
        }

        static int Sum(TreeNode root, ref int sum)
        {
            if (root == null)
                return sum;

            if (root.left != null)
            {
                Sum(root.left, ref sum);
                sum += root.left.val;
            }

            Sum(root.right, ref sum);

            return sum;
        }
    }
}
