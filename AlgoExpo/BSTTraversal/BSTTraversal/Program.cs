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
            BST tree = CreateBST();
            List<int> inOrder = InOrderTraverse(tree, new List<int>());
            List<int> preOrder = PreOrderTraverse(tree, new List<int>());
            List<int> postOrder = PostOrderTraverse(tree, new List<int>());
        }

        public static List<int> InOrderTraverse(BST tree, List<int> array)
        {
            if(tree.left != null)
                InOrderTraverse(tree.left, array);

            array.Add(tree.value);

            if(tree.right != null)
                InOrderTraverse(tree.right, array);

            return array;
        }

        public static List<int> PreOrderTraverse(BST tree, List<int> array)
        {
            if (tree != null)
                array.Add(tree.value);

            if(tree.left != null)
                PreOrderTraverse(tree.left, array);

            if (tree.right != null)
                PreOrderTraverse(tree.right, array);

            return array;
        }

        public static List<int> PostOrderTraverse(BST tree, List<int> array)
        {
            if (tree.left != null)
                PostOrderTraverse(tree.left, array);

            if (tree.right != null)
                PostOrderTraverse(tree.right, array);

            array.Add(tree.value);

            return array;
        }

        static BST CreateBST()
        {
            BST root = new BST(10);
            root.left = new BST(5);
            root.left.left = new BST(2);
            root.left.right = new BST(5);

            root.left.left.left = new BST(1);

            root.right = new BST(15);
            root.right.right = new BST(22);

            return root;
        }
    }
}
