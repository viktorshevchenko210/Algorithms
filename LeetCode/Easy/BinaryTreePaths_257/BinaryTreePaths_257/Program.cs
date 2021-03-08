using System;
using System.Collections.Generic;

namespace BinaryTreePaths_257
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.left.right = new TreeNode(5);

            root.right = new TreeNode(3);

            BinaryTreePaths(root);
        }

        static IList<string> BinaryTreePaths(TreeNode root)
        {
            if (root == null)
                return new List<string>();

            return DFS(root, null, new List<string>());
        }

        static List<string> DFS(TreeNode node, string path, List<string> paths)
        {
            if (node == null)
            {
                return paths;
            }

            if (path != null)
                path = $"{path}->{node.val}";
            else
                path = $"{node.val}";

            if(node.left == null && node.right == null)
            {
                paths.Add(path);
            }

            DFS(node.left, path, paths);
            DFS(node.right, path, paths);

            return paths;
        }
    }
}
