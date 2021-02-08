using System;

namespace ConvertSortedArrayToBinarySearchTree_108
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { -10, -3, 0, 5, 9 };
            var tree = SortedArrayToBST(nums);
        }

        static TreeNode SortedArrayToBST(int[] nums)
        {
            return SortedArrayToBST(nums, null, 0, nums.Length - 1);
        }

        static TreeNode SortedArrayToBST(int[] nums, TreeNode tree, int startIndex, int endIndex)
        {
            if (startIndex > endIndex)
                return null;

            int middleIndex = (startIndex + endIndex) / 2;

            int middle = nums[middleIndex];

            TreeNode newNode = new TreeNode(middle);

            if (tree == null)
            {
                tree = newNode;
            }
            else
            {
                if (middle < tree.val)
                {
                    tree.left = newNode;
                    tree = tree.left;
                }
                else
                {
                    tree.right = newNode;
                    tree = tree.right;
                }
            }

            SortedArrayToBST(nums, tree, startIndex, middleIndex - 1);
            SortedArrayToBST(nums, tree, middleIndex + 1, endIndex);

            return tree;

        }
    }
}
