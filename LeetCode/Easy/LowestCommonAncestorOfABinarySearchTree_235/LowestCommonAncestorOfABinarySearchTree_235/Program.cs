using System;

namespace LowestCommonAncestorOfABinarySearchTree_235
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(2);
            root.left = new TreeNode(1);
            root.left = new TreeNode(3);


            //TreeNode root = new TreeNode(6);
            //root.left = new TreeNode(2);
            //root.left.left = new TreeNode(0);
            //root.left.right = new TreeNode(4);
            //root.left.right.left = new TreeNode(3);
            //root.left.right.right = new TreeNode(5);

            //root.right = new TreeNode(8);
            //root.right.right = new TreeNode(9);
            //root.right.left = new TreeNode(7);

            LowestCommonAncestor(root, root.left, root.right);
        }

        static TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root.val > p.val && root.val < q.val)
                return root;

            if (root.val > q.val && root.val < p.val)
                return root;

            if (root.val == p.val)
                return p;

            if (root.val == q.val)
                return q;

            if (root.val > p.val && root.val > q.val)
                return LowestCommonAncestor(root.left, p, q);

            if (root.val < p.val && root.val < q.val)
                return LowestCommonAncestor(root.right, p, q);

            return null;
        }

        static TreeNode LowestCommonAncestorIterative(TreeNode root, TreeNode p, TreeNode q)
        {
            while (root != null)
            {
                if (root.val > p.val && root.val < q.val)
                    return root;

                if (root.val > q.val && root.val < p.val)
                    return root;

                if (root.val == p.val)
                    return p;

                if (root.val == q.val)
                    return q;

                if (root.val > p.val && root.val > q.val)
                    root = root.left;

                if (root.val < p.val && root.val < q.val)
                    root = root.right;
            }

            return root;
        }
    }
}
