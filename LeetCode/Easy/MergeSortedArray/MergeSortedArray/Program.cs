using System;

namespace MergeSortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
            //int m = 3;

            //int[] nums2 = new int[] { 2, 5, 6 };
            //int n = 3;

            int[] nums1 = new int[] { 4,5,6, 0,0,0 };
            int m = 3;

            int[] nums2 = new int[] { 1,2,3 };
            int n = 3;

            OptimalMerge(nums1, m, nums2, n);
        }

        static void Merge(int[] nums1, int m, int[] nums2, int n)
        {

            int nums2Index = 0;
            int insertedIndex = m;

            int lastInsertedIndex = m;

            int totalLength = m + n;

            while (insertedIndex != totalLength)
            {
                if(insertedIndex == 0)
                {
                    nums1[insertedIndex] = nums2[nums2Index];
                    insertedIndex++;
                    nums2Index++;
                    lastInsertedIndex++;
                    continue;
                }

                if (nums1[lastInsertedIndex - 1] > nums2[nums2Index])
                {
                    nums1[insertedIndex] = nums1[lastInsertedIndex - 1];
                    nums1[lastInsertedIndex - 1] = nums2[nums2Index];

                    insertedIndex++;
                    lastInsertedIndex--;

                    while (lastInsertedIndex != 0 && nums1[lastInsertedIndex] < nums1[lastInsertedIndex-1])
                    {
                        var temp = nums1[lastInsertedIndex];
                        nums1[lastInsertedIndex] = nums1[lastInsertedIndex - 1];
                        nums1[lastInsertedIndex - 1] = temp;

                        lastInsertedIndex--;

                    }

                    lastInsertedIndex = insertedIndex;
                    nums2Index++;
                }
                else
                {
                    nums1[insertedIndex] = nums2[nums2Index];
                    insertedIndex++;
                    nums2Index++;
                }
            }
        }

        static void OptimalMerge(int[] nums1, int m, int[] nums2, int n)
        {
            int p = m + n - 1;

            m = m - 1;
            n = n - 1;

            while(m >= 0 && n >= 0)
            {
                if(nums1[m] >= nums2[n])
                {
                    nums1[p] = nums1[m];
                    m--;
                }
                else
                {
                    nums1[p] = nums2[p];
                    n--;
                }

                p--;
            }

            while(n >= 0)
            {

                nums1[p] = nums2[n];
                n--;
                p--;
            }
        }
    }
}
