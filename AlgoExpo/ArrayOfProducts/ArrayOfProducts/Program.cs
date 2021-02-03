using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOfProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 5, 1, 4, 2 };
            var arr = ArrayOfProductsMethod(array);
        }

        public static int[] ArrayOfProductsMethod(int[] array)
        {
            int[] products = new int[array.Length];

            int leftRunningProduct = 1;

            for(int i = 0; i < array.Length; i++)
            {
                products[i] = leftRunningProduct;
                leftRunningProduct *= array[i];
            }

            int rightRunningProduct = 1;
            for(int i = array.Length-1; i>=0; i--)
            {
                products[i] *= rightRunningProduct;
                rightRunningProduct *= array[i];
            }

            // Write your code here.
            return products;
        }
    }
}
