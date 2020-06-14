using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSTConstruction
{
    class Program
    {
        static BST tree;
        static void Main(string[] args)
        {
            Initialize();
            tree.Insert(12);
            var cont = tree.Contains(12);
            var removedItem = tree.Remove(10);
        }

        static void Initialize()
        {
            tree = new BST(10);
            tree.left = new BST(5);
            tree.right = new BST(15);

            tree.left.left = new BST(2);
            tree.left.right = new BST(5);

            tree.left.left.left = new BST(1);

            tree.right.left = new BST(13);
            tree.right.left.right = new BST(14);

            tree.right.right = new BST(22);
        }
    }
}
