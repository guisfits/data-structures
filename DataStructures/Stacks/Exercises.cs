using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures.Stacks
{
    public static class Exercises
    {
        private static Tuple<char, char>[] keys = new Tuple<char, char>[]
        {
            new Tuple<char, char>('(', ')'),
            new Tuple<char, char>('[', ']'),
            new Tuple<char, char>('{', '}'),
            new Tuple<char, char>('<', '>'),
        };

        public static string ReverseString(string input)
        {
            if (input == null) return null;

            var stack = new Stack<char>();

            foreach (char item in input)
                stack.Push(item);

            var builder = new StringBuilder(input.Length);
            while (stack.Count > 0)
                builder.Append(stack.Pop());

            return builder.ToString();
        }

        public static bool IsExpressionIsBalanced(string expression)
        {
            if(string.IsNullOrEmpty(expression)) return false;

            var stack = new Stack<char>();
            foreach (var item in expression)
            {
                var key = keys.FirstOrDefault(x => x.Item1 == item || x.Item2 == item);
                if (key == null) continue;

                if (item == key.Item1)
                {
                    stack.Push(item);
                    continue;
                }

                if (stack.Count == 0 || item != key.Item2 || stack.Peek() != key.Item1)
                {
                    return false;
                }
                else
                {
                    stack.Pop();
                }
            }

            return stack.Count == 0;
        }
    }
}
