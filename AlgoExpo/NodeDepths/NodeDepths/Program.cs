using System;

namespace NodeDepths
{

	public class BinaryTree
	{
		public int value;
		public BinaryTree left;
		public BinaryTree right;

		public BinaryTree(int value)
		{
			this.value = value;
			left = null;
			right = null;
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

			tree.right = new BinaryTree(3);
			tree.right.left = new BinaryTree(6);

			tree.right.right = new BinaryTree(7);

			var result = NodeDepths(tree);
		}

		public static int NodeDepths(BinaryTree root)
		{
			return NodeDepths(root, 0, 0);
		}

		public static int NodeDepths(BinaryTree root, int depth, int sum)
		{
			if (root == null)
				return sum;

			sum = NodeDepths(root.left, depth + 1, sum);

			sum += depth;

			sum = NodeDepths(root.right, depth + 1, sum);

			return sum;
		}
	}
}
