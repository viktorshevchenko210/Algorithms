using System;
using System.Collections.Generic;

namespace ReconstructBST
{
    public class BST
    {
        public int value;
        public BST left = null;
        public BST right = null;

        public BST(int value)
        {
            this.value = value;
        }
    }

    public class TreeInfo
    {
        public int rootIdx;

        public TreeInfo(int rootIdx)
        {
            this.rootIdx = rootIdx;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<int> preOrderTraversal = new List<int>() { 10, 4, 2, 1, 5, 17, 19, 18 };
            ReconstructBst(preOrderTraversal);
        }

        static BST ReconstructBst(List<int> preOrderTraversalValues)
        {
            TreeInfo treeInfo = new TreeInfo(0);
            return ReconstructBSTFromRange(Int32.MinValue, Int32.MaxValue, preOrderTraversalValues, treeInfo);
        }

        static BST ReconstructBSTFromRange(int lowerBound, int upperBound, 
            List<int> preOrderTraversalValues,
            TreeInfo currentSubtreeInfo)
        {
            if (currentSubtreeInfo.rootIdx == preOrderTraversalValues.Count)
                return null;

            int rootValue = preOrderTraversalValues[currentSubtreeInfo.rootIdx];
            if (rootValue < lowerBound || rootValue >= upperBound)
                return null;

            currentSubtreeInfo.rootIdx += 1;

            BST leftSubtree = ReconstructBSTFromRange(lowerBound, rootValue,
                preOrderTraversalValues,
                currentSubtreeInfo);

            BST rightSubtree = ReconstructBSTFromRange(rootValue, upperBound,
                preOrderTraversalValues,
                currentSubtreeInfo);


            BST bst = new BST(rootValue);
            bst.left = leftSubtree;
            bst.right = rightSubtree;

            return bst;
        }
    }
}
