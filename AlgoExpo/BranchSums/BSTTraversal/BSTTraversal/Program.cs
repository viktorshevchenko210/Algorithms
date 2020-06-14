using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSTTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            BST tree = new BST(10);
            List<int> preOrder = new List<int>();
            List<int> inOrder = new List<int>();
            List<int> postOrder = new List<int>();
            Initialize(tree);
            var preOrderResult = PreOrderTraverse(tree, preOrder);
            var inOrderResult = InOrderTraverse(tree, inOrder);
            var postOrderResult = PostOrderTraverse(tree, postOrder);
        }

        public static List<int> PreOrderTraverse(BST tree, List<int> array)
        {
            array.Add(tree.value);

            if (tree.left != null)
                PreOrderTraverse(tree.left, array);

            if (tree.right != null)
                PreOrderTraverse(tree.right, array);

            return array;
        }

        public static List<int> InOrderTraverse(BST tree, List<int> array)
        {
            if (tree.left != null)
            {
                InOrderTraverse(tree.left, array);
            }

            array.Add(tree.value);

            if (tree.right != null)
            {
                InOrderTraverse(tree.right, array);
            }

            return array;
        }

        public static List<int> PostOrderTraverse(BST tree, List<int> array)
        {
            InOrderTraverse(tree.left, array);
            PostOrderRight(tree.right, array);
            array.Add(tree.value);

            return array;
        }

        private static List<int> PostOrderRight(BST tree, List<int> array)
        {
            if (tree.right != null)
            {
                PostOrderRight(tree.right, array);
            }

            array.Add(tree.value);

            if (tree.left != null)
            {
                PostOrderRight(tree.left, array);
            }

            return array;
        }

        static void Initialize(BST tree)
        {

            tree.left = new BST(5);
            tree.right = new BST(15);

            tree.left.left = new BST(2);
            tree.left.right = new BST(5);

            tree.left.left.left = new BST(1);

            tree.right.right = new BST(22);
        }
    }
}
