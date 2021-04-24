using System;
using System.Collections.Generic;
using System.Linq;

namespace FindTheDifference_389
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "abcd";
            string t = "abcde";
            FindTheDifference(s, t);
        }

        static char FindTheDifference(string s, string t)
        {
            Dictionary<char, int> chars = new Dictionary<char, int>();
            for(int i = 0; i < t.Length; i++)
            {
                if (chars.ContainsKey(t[i]))
                    chars[t[i]]++;
                else
                    chars.Add(t[i], 1);
            }

            for(int i = 0; i < s.Length; i++)
            {
                if(chars.TryGetValue(s[i], out int count))
                {
                    if (count == 1)
                        chars.Remove(s[i]);
                    else
                        chars[s[i]]--;
                }
            }

            return chars.First().Key;
        }
    }
}
