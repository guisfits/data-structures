using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures.Algorithms
{
    public static class StringManipulation
    {
        private readonly static char[] _vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };

        public static int FindTheNumberOfVowels(string word)
        {
            return word.Where(letter => _vowels.Contains(letter)).Count();
        }

        public static string Reverse(string word)
        {
            if (word == null)
                return "";

            var builder = new StringBuilder();
            for (var i = word.Length - 1; i >= 0; i--)
            {
                builder.Append(word[i]);
            }

            return builder.ToString();
        }

        public static string ReverseWords(string sentence)
        {
            var sentenceSplit = sentence.Trim().Split(' ');
            var builder = new StringBuilder();

            for (var i = sentenceSplit.Count() - 1; i >= 0; i--)
            {
                builder.Append(sentenceSplit[i] + " ");
            }

            return builder.ToString().TrimEnd();
        }

        public static bool IsRotation(string wordA, string wordB)
        {
            return wordA.Length == wordB.Length &&
                (wordA + wordA).Contains(wordB);
        }

        public static string RemoveDuplicates(string word)
        {
            var set = new HashSet<char>();
            foreach (var letter in word)
                set.Add(letter);

            return string.Concat(set.ToArray());
        }
    }
}
