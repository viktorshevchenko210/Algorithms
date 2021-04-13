using System;

namespace RansomNote_383
{
    class Program
    {
        static void Main(string[] args)
        {
            string ransomNote = "aa";
            string magazine = "aab";
        }

        static bool CanConstruct(string ransomNote, string magazine)
        {
            for (int i = 0; i < ransomNote.Length; i++)
            {
                if (ransomNote[i] != magazine[i])
                    return false;
            }

            return true;
        }
    }
}
