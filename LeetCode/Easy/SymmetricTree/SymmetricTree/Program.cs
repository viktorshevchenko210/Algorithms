using System;

namespace SymmetricTree
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode tree = new TreeNode(2);
            tree.left = new TreeNode(3);
            tree.left.left = new TreeNode(4);
            tree.left.right = new TreeNode(5);

            tree.right = new TreeNode(3);
            tree.right.right = new TreeNode(4);

            //TreeNode tree = new TreeNode(1);
            //tree.left = new TreeNode(2);
            //tree.left.left = new TreeNode(3);
            //tree.left.right = new TreeNode(4);

            //tree.right = new TreeNode(2);
            //tree.right.right = new TreeNode(3);
            //tree.right.left = new TreeNode(4);

            IsSymmetric(tree);
        }

        static bool IsSymmetric(TreeNode root)
        {
            return IsSymmetricRecursive(root.left, root.right);
        }

        static bool IsSymmetricRecursive(TreeNode left, TreeNode right)
        {
            if (left == null && right != null)
                return false;

            if (right == null && left != null)
                return false;

            if (left == null && right == null)
                return true;

            if (right.val != left.val)
                return false;

            if (!IsSymmetricRecursive(left.left, right.right))
                return false;

            if (!IsSymmetricRecursive(left.right, right.left))
                return false;

            return true;
        }

        //static bool IsSymmetricRecursive(TreeNode left, TreeNode right, ref bool result)
        //{
        //    if (left == null && right != null)
        //        return false;

        //    if (right == null && left != null)
        //        return false;

        //    if (left == null && right == null)
        //        return true;

        //    if (right.val != left.val)
        //        return false;

        //    if (left.left != null)
        //        return IsSymmetricRecursive(left.left, right.right);


        //        return  IsSymmetricRecursive(left.right, right.left);
        //}
    }
}
