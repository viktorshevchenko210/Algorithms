using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidParentheses_20
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "([]";
            bool isvalid = IsValid(input);
            Console.WriteLine(isvalid);
            Console.ReadKey();
        }

        public static bool IsValid(string s)
        {
            if (s.Length <= 1)
                return false;

            var result = false;

            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < s.Length; i++)
            {
                char current = s[i];
                if (IsOpen(current))
                {
                    stack.Push(current);
                    result = false;
                }
                else
                {
                    if (stack.Count == 0)
                        return false;

                    if (GetOpposite(stack.Pop()) != current)
                        return false;

                    result = true;
                }
            }

            if (stack.Count != 0)
                return false;

            return result;
        }

        private static bool IsOpen(char a)
        {
            if (a == '(' || a == '[' || a == '{')
                return true;

            return false;
        }

        private static char GetOpposite(char s)
        {
            switch (s)
            {
                case '(':
                    return ')';
                case '[':  
                    return ']';
                case '{':  
                    return '}';


                case ')':  
                    return '(';
                case ']':  
                    return '[';
                case '}':  
                    return '{';
            }

            return '\0';
        }
    }
}
