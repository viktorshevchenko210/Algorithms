using System;

namespace SameTree_100
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode firstTree = new TreeNode(1, new TreeNode(2), new TreeNode(3));
            TreeNode secondTree = new TreeNode(1, new TreeNode(2), new TreeNode(3));

            var isSame = IsSameTree(firstTree, secondTree);
            Console.WriteLine(isSame);

            Console.ReadKey();
        }

        static bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
                return true;

            if (p == null && q != null)
                return false;

            if (q == null && p != null)
                return false;

            if (p.val != q.val)
                return false;

            var isSame = IsSameTree(p.left, q.left);
            if (!isSame)
                return false;

            isSame = IsSameTree(p.right, q.right);
            if (!isSame)
                return false;

            return true;
        }


    }
}
