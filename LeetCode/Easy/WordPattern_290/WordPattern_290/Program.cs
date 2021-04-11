using System;
using System.Collections.Generic;

namespace WordPattern_290
{
    class Program
    {
        static Dictionary<char, string> symbolWordMap = new Dictionary<char, string>();
        static Dictionary<string, char> wordSymbolMap = new Dictionary<string, char>();

        static void Main(string[] args)
        {
            WordPattern("abba", "dog cat cat fish");
        }

        static bool WordPattern(string pattern, string s)
        {
            var patternsArray = s.Split(" ");

            if (patternsArray.Length != pattern.Length)
                return false;

            for (int i = 0; i < pattern.Length; i++)
            {
                var symbol = pattern[i];
                var word = patternsArray[i];

                if (IsSavedWord(symbol))
                {
                    if (!CompareWord(symbol, word))
                        return false;
                }
                else
                    symbolWordMap.Add(symbol,word);

                if (IsSavedSymbol(word))
                {
                    if (!CompareSymbol(word, symbol))
                        return false;
                }
                else
                    wordSymbolMap.Add(word, symbol);

            }

            return true;
        }

        static bool IsSavedWord(char symbol)
        {
            if (symbolWordMap.ContainsKey(symbol))
                return true;

            return false;
        }

        static bool CompareWord(char symbol, string word)
        {
            if (symbolWordMap[symbol] == word)
                return true;

            return false;
        }

        static bool IsSavedSymbol(string word)
        {
            if (wordSymbolMap.ContainsKey(word))
                return true;

            return false;
        }

        static bool CompareSymbol(string word, char symbol)
        {
            if (wordSymbolMap[word] == symbol)
                return true;

            return false;
        }
    }
}
