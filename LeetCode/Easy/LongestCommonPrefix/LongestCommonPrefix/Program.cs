using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestCommonPrefix
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] strs = new string[] {"flower", "flow", "flight"};
            //string[] strs = new string[] { "a" };
            string[] strs = new string[] { "", "" };

            var prefix = LongestCommonPrefix(strs);
            Console.WriteLine(prefix);
            Console.ReadLine();
        }

        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0)
                return "";

            for(int i = 0; i < strs[0].Length; i++)
            {
                char c = strs[0][i];
                for(int j = 1; j < strs.Length; j++)
                {
                    if (i == strs[j].Length || strs[j][i] != c)
                        return strs[0].Substring(0, i);
                }
            }

            return strs[0];
        }
    }
}
