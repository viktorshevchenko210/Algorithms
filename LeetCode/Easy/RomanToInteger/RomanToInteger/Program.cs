using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanToInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "DCXXI";

            var result = RomanToInt2(input);
        }

        public static int RomanToInt(string s)
        {
            HashSet<string> mapExluded = new HashSet<string>();
            mapExluded.Add("IX");
            mapExluded.Add("IV");
            mapExluded.Add("XL");
            mapExluded.Add("XC");
            mapExluded.Add("CD");
            mapExluded.Add("CM");

            Dictionary<char, int> map = new Dictionary<char, int>();
            map.Add('I', 1);
            map.Add('V', 5);
            map.Add('X', 10);
            map.Add('L', 50);
            map.Add('C', 100);
            map.Add('D', 500);
            map.Add('M', 1000);

            int result = 0;

            for (int i = 0; i < s.Length; i++)
            {
                char current = s[i];

                if ((current == 'V' ||
                   current == 'X' ||
                   current == 'C' ||
                   current == 'L' ||
                   current == 'D' ||
                   current == 'M') && i != 0)
                {
                    char previous = s[i - 1];
                    string symbol = $"{previous}{current}";

                    if (mapExluded.Contains(symbol))
                    {
                        result += map[current] - (map[previous] * 2);
                        continue;
                    }
                }
                result += map[current];
            }

            return result;
        }

        public static int RomanToInt2(string s)
        {
            int sum = 0;
            int cur = 0;
            int pre = 0;

            for (int i = 0; i < s.Length; i++)
            {
                cur = GetNum(s[i]);
                if (cur > pre) { sum = sum + cur - 2 * pre; pre = cur; }
                else if (cur == pre) sum += cur;
                else { sum += cur; pre = cur; }
            }
            return sum;
        }

        public static int GetNum(char a)
        {
            switch (a)
            {
                case 'I': return 1;
                case 'V': return 5;
                case 'X': return 10;
                case 'L': return 50;
                case 'C': return 100;
                case 'D': return 500;
                case 'M': return 1000;
                default: throw new ArgumentException();
            }
        }
    }
}
