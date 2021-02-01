using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSTConstruction
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = CreateBST2();
            tree.Insert(2);
            tree.Insert(3);
            tree.Insert(4);
            tree.Insert(5);
            tree.Insert(6);
            tree.Insert(7);
            tree.Insert(8);
            tree.Insert(9);
            tree.Insert(10);
            tree.Insert(11);
            tree.Insert(12);
            tree.Insert(13);
            tree.Insert(14);
            tree.Insert(15);
            tree.Insert(16);
            tree.Insert(17);
            tree.Insert(18);
            tree.Insert(19);
            tree.Insert(20);

            tree.Remove(2);
            tree.Remove(4);
            tree.Remove(6);
            tree.Remove(8);
            tree.Remove(11);
            tree.Remove(13);
            tree.Remove(15);
            tree.Remove(17);
            tree.Remove(19);

            tree.Insert(1);
            tree.Insert(2);
            tree.Insert(3);
            tree.Insert(4);
            tree.Insert(5);
            tree.Insert(6);
            tree.Insert(7);
            tree.Insert(8);
            tree.Insert(9);
            tree.Insert(10);

            tree.Contains(9000);


            Console.ReadKey();
        }

        static BST CreateBST()
        {
            BST root = new BST(10);
            root.left = new BST(5);
            root.right = new BST(15);

            root.left.left = new BST(2);
            root.left.right = new BST(5);

            root.left.left.left = new BST(1);
            root.right.left = new BST(13);
            root.right.right = new BST(22);

            root.right.left.right = new BST(14);

            return root;

        }

        static BST CreateBST2()
        {
            BST root = new BST(1);

            return root;

        }
    }
}
