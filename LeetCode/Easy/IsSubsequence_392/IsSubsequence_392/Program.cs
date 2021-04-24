using System;
using System.Collections.Generic;

namespace IsSubsequence_392
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "abc";
            string t = "ahcgdb";
            IsSubsequence(s,t);
        }

        static bool IsSubsequence(string s, string t)
        {

            if (s.Length == 0)
                return true;

            List<char> chars = new List<char>(s.Length);
            for (int i = 0; i < s.Length; i++)
            {
                chars.Add(s[i]);
            }

            for (int i = 0; i < t.Length; i++)
            {
                if (chars.Count == 0)
                    return true;

                if (chars[0] == t[i])
                    chars.RemoveAt(0);
            }

            if (chars.Count == 0)
                return true;

            return false;
        }
    }
}
