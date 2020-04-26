using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures.Stacks
{
    public static class Exercises
    {

        #region ReveseString

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

        #endregion

        #region IsBalanced

        private readonly static List<char> leftKeys = new List<char> { '(', '{', '[', '<' };
        private readonly static List<char> rightKeys = new List<char> { ')', '}', ']', '>' };

        public static bool IsExpressionIsBalanced(string expression)
        {
            if (string.IsNullOrEmpty(expression))
                return false;

            var stack = new Stack<char>();
            foreach (var item in expression)
            {
                if (IsLeftKey(item))
                {
                    stack.Push(item);
                }
                else if (IsRightKey(item))
                {
                    if (stack.Count == 0)
                        return false;

                    if (IsKeysMatch(stack.Peek(), item))
                        stack.Pop();
                    else
                        return false;
                }
            }

            return stack.Count == 0;
        }

        private static bool IsRightKey(char key)
        {
            return rightKeys.Contains(key);
        }

        private static bool IsLeftKey(char key)
        {
            return leftKeys.Contains(key);
        }

        private static bool IsKeysMatch(char left, char right)
        {
            return leftKeys.IndexOf(left) == rightKeys.IndexOf(right);
        }

        #endregion
    }
}
