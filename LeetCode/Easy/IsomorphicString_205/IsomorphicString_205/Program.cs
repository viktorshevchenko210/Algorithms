using System;
using System.Collections.Generic;

namespace IsomorphicString_205
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "egg";
            string t = "add";
            IsIsomorphic(s,t);
        }

        static bool IsIsomorphic(string s, string t)
        {
            if (s.Length != t.Length)
                return false;

            Dictionary<char, char> mapS = new Dictionary<char, char>();
            Dictionary<char, char> mapT = new Dictionary<char, char>();

            for(int i = 0; i < s.Length; i++)
            {
                var sI = s[i];
                var tI = t[i];

                if(mapS.TryGetValue(sI, out char val))
                {
                    if (tI != val)
                        return false;
                }
                else
                {
                    mapS.Add(sI, tI);
                }

                if (mapT.TryGetValue(tI, out char val2))
                {
                    if (sI != val2)
                        return false;
                }
                else
                {
                    mapT.Add(tI, sI);
                }
            }

            return true;
        }
    }
}
