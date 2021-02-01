using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiralTraverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[,]
            {
                { 1, 2, 3, 4},
                { 12, 13, 14, 5,},
                { 11, 16, 15, 6},
                { 10, 9, 8, 7}
            };

            var list = SpiralTraverse(array);

            foreach(var element in list)
            {
                Console.WriteLine(element);
            }

            Console.ReadKey();
        }

        public static List<int> SpiralTraverse(int[,] array)
        {
            if (array.GetLength(0) == 0) return new List<int>();

            var result = new List<int>();

            var startRow = 0;
            var endRow = array.GetLength(0) - 1;

            var startCol = 0;
            var endCol = array.GetLength(1) - 1;

            while (startRow <= endRow && startCol <= endCol)
            {
                for (int col = startCol; col <= endCol; col++)
                    result.Add(array[startRow, col]);

                for (int row = startRow + 1; row <= endRow; row++)
                    result.Add(array[row, endCol]);

                for (int col = endCol - 1; col >= startCol; col--)
                {
                    if (startRow == endRow)
                        break;

                    result.Add(array[endRow, col]);
                }

                for (int row = endRow - 1; row > startRow; row--)
                {
                    if (startCol == endCol)
                        break;

                    result.Add(array[row, startCol]);
                }

                startCol++;
                endCol--;
                startRow++;
                endRow--;
            }

            return result;
        }
    }

    public enum State
    {
        Down,
        Left,
        Up,
        Right
    }
}
