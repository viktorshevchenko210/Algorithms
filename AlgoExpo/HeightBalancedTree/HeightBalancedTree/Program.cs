using System;

namespace HeightBalancedTree
{
	public class BinaryTree
	{
		public int value;
		public BinaryTree left = null;
		public BinaryTree right = null;

		public BinaryTree(int value)
		{
			this.value = value;
		}
	}

	public class TreeInfo
	{
		public int height;


		public TreeInfo(int height)
		{
			this.height = height;
		}
	}

	class Program
    {
        static void Main(string[] args)
        {
			BinaryTree tree = new BinaryTree(1);
			tree.left = new BinaryTree(2);
			tree.left.left = new BinaryTree(4);
			tree.left.left.left = new BinaryTree(8);

			tree.left.left.right = new BinaryTree(9);

			tree.left.right = new BinaryTree(5);
			tree.left.right.left = new BinaryTree(9);
			tree.left.right.right = new BinaryTree(10);

			tree.right = new BinaryTree(3);
			tree.right.right = new BinaryTree(7);

			tree.right.left = new BinaryTree(6);
			tree.right.left.right = new BinaryTree(12);
			tree.right.left.right.right = new BinaryTree(13);
			

			HeightBalancedBinaryTree(tree);
		}

		static bool HeightBalancedBinaryTree(BinaryTree tree)
		{

			var leftHeight = HeightSubtree(tree.left).height;
			var rightHeight = HeightSubtree(tree.right).height;

			if (Math.Abs(leftHeight - rightHeight) <= 1)
				return false;

			return true;
		}

		static TreeInfo HeightSubtree(BinaryTree tree)
		{
			if (tree == null)
				return new TreeInfo(0);

			TreeInfo leftSubtree = HeightSubtree(tree.left);
			TreeInfo rigtSubtree = HeightSubtree(tree.right);

			int height = Math.Max(leftSubtree.height, rigtSubtree.height) + 1;

			return new TreeInfo(height);
		}
	}
}
