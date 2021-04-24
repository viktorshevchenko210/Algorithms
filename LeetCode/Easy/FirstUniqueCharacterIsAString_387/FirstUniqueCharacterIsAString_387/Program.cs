using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstUniqueCharacterIsAString_387
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstUniqChar("leetcode");
        }

        static int FirstUniqChar(string s)
        {
            Dictionary<char, Tuple<int,int>> map = new Dictionary<char, Tuple<int, int>>();

            for(int i = 0; i < s.Length; i++)
            {
                if (map.ContainsKey(s[i]))
                {
                    var tuple = map[s[i]];
                    map[s[i]] = Tuple.Create(tuple.Item1, tuple.Item2+1);
                }
                else
                    map.Add(s[i], Tuple.Create(i, 1));
            }

            var item = map
                .Where(s => s.Value.Item2 == 1)
                .FirstOrDefault();

            if (item.Value == null)
                return -1;
            else
                return item.Value.Item1;
        }
    }
}
