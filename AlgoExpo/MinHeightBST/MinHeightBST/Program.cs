using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinHeightBST
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> array = new List<int>();
            array.Add(1);
            array.Add(2);
            array.Add(5);
            array.Add(7);
            array.Add(10);
            array.Add(13);
            array.Add(14);
            array.Add(15);
            array.Add(22);

            var bst = MinHeightBst(array);
            Console.ReadKey();
        }

        public static BST MinHeightBst(List<int> array)
        {
            int startIdx = 0;
            int endIdx = array.Count - 1;

            return MinHeightBst2(array, null, startIdx, endIdx);
        }

        public static BST MinHeightBst(List<int> array, BST tree, int startIdx, int endIdx)
        {
            //This implementation takes O(N*log(N)) beacuse we make N inserts and every insert takes log(N) time
            if (endIdx < startIdx)
                return null;

            int midIdx = (startIdx + endIdx) / 2;
            int valueToAdd = array[midIdx];
            
            if(tree != null)
            {
                tree.insert(valueToAdd);
            }
            else
            {
                tree = new BST(valueToAdd);
            }

            MinHeightBst(array, tree, startIdx, midIdx - 1);
            MinHeightBst(array, tree, midIdx + 1, endIdx);

            return tree;
        }

        public static BST MinHeightBst2(List<int> array, BST tree, int startIdx, int endIdx)
        {
            if (endIdx < startIdx)
                return null;

            int midIdx = (startIdx + endIdx) / 2;
            int valueToAdd = array[midIdx];

            if (tree != null)
            {
                if (valueToAdd < tree.value)
                {
                    tree.left = new BST(valueToAdd);
                    tree = tree.left;
                }
                else
                {
                    tree.right = new BST(valueToAdd);
                    tree = tree.right;
                }
                   
            }
            else
            {
                tree = new BST(valueToAdd);
            }

            MinHeightBst2(array, tree, startIdx, midIdx - 1);
            MinHeightBst2(array, tree, midIdx + 1, endIdx);

            return tree;
        }
    }
}
