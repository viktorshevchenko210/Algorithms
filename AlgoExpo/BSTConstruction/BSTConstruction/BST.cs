using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSTConstruction
{
    public class BST
    {
        public int value { get; set; }
        public BST left { get; set; }
        public BST right { get; set; }

        public BST(int value)
        {
            this.value = value;
        }

        public BST Insert(int value)
        {
            var node = FindLastNode(value);
            if (node.value < value)
            {
                node.right = new BST(value);
                return node.right;
            }
            else
            {
                node.left = new BST(value);
                return node.left;
            }
        }

        private BST FindLastNode(int value)
        {
            BST next = this;
            BST lastNode = this;

            while (next != null)
            {
                lastNode = next;

                if (next.value < value)
                    next = next.right;
                else
                    next = next.left;
            }

            return lastNode;
        }

        public bool Contains(int value)
        {
            BST next = this;

            while(next != null)
            {
                if (next.value == value)
                    return true;

                if (next.value < value)
                    next = next.right;
                else
                    next = next.left;
            }

            return false;
        }

        public BST Remove(int value)
        {
            if(this.value == value)
            {
                var smallest = FindAndDeleteTheSmallestInRightSubtree();
                smallest.left = left;
                smallest.right = right;
                left = null;
                right = null;
                return this;
            }

            var next = right;
            while (next != null)
            {
                if (next.value == value)
                {
                    var smallest = FindAndDeleteTheSmallestInRightSubtree();
                    smallest.left = next.left;
                    smallest.right = next.right;
                    return next;
                }
                next = next.left;
            }

            return null;
        }

        public BST FindAndDeleteTheSmallestInRightSubtree()
        {
            var next = this.right;
            BST lastNode = null;

            while(next != null)
            {

                if (next.left == null)
                {
                    lastNode.left = null;
                    return next;
                }

                lastNode = next;
                next = next.left;
            }

            return next;
        }
    }
}
