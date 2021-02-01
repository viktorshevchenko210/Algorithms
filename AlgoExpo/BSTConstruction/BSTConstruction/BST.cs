using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSTConstruction
{
    public class BST
    {
        public int value;
        public BST left;
        public BST right;

        public BST(int value)
        {
            this.value = value;
        }

        public BST Insert(int value)
        {
            if (this.value > value)
            {
                if (left == null)
                    left = new BST(value);
                else
                    left.Insert(value);
            }
            else if (this.value < value)
            {
                if (right == null)
                    right = new BST(value);
                else
                    right.Insert(value);
            }
            else if(this.value == value)
            {
                if (right == null)
                    right = new BST(value);
                else
                    right.Insert(value);
            }

            return this;
        }

        public bool Contains(int value)
        {
            if (this.value > value)
            {
                if (left == null)
                    return false;

                return left.Contains(value);
            }
            else if (this.value < value)
            {
                if (right == null)
                    return false;

                return right.Contains(value);
            }
            else if(this.value == value)
                return true;

            return false;
        }

        public BST Remove(int value)
        {
            return Remove(value, null);
        }

        private BST Remove(int value, BST parent)
        {
            if(this.value > value)
            {
                left.Remove(value, this);
            }
            else if(this.value < value)
            {
                right.Remove(value, this);
            }
            else
            {
                if (right == null && left == null)
                {
                    if (parent == null)
                        return null;

                    if (parent.left != null && parent.left.value == value)
                        parent.left = null;
                    else if (parent.right != null && parent.right.value == value)
                        parent.right = null;
                }
                else if(right != null && left != null)
                {
                    var min = right.FindMinValue();
                    this.value = min.value;
                    right.Remove(min.value, this);
                }
                else if(right != null || left != null)
                {
                    if (right != null)
                    {
                        this.value = right.value;
                        this.right = right.right;
                    }
                    else if(left != null)
                    {
                        this.value = left.value;
                        this.left = left.left;
                    }
                }
            }

            return this;
        }

        private BST FindMinValue()
        {
            if (left == null)
            {
                return this;
            }
            else
            {
                return left.FindMinValue();
            }
        }
    }
}
