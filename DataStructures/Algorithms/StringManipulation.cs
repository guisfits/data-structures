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

        public static char FindMostRepeatableCharacter(string str)
        {
            if (string.IsNullOrEmpty(str))
                throw new ArgumentException(str);

            var characterQuantity = new Dictionary<char, int>();
            foreach (var letter in str)
            {
                if (characterQuantity.ContainsKey(letter))
                {
                    characterQuantity[letter]++;
                }
                else
                {
                    characterQuantity.Add(letter, 1);
                }
            }

            return characterQuantity.OrderByDescending(x => x.Value).First().Key;
        }

        public static string Normalize(string str)
        {
            if (string.IsNullOrEmpty(str))
                return "";

            str = str.Trim();
            var words = str
                .Split(' ')
                .Where(x => !string.IsNullOrWhiteSpace(x))
                .ToArray();

            for (var i = 0; i < words.Length; i++)
            {
                words[i] = words[i].Substring(0, 1).ToUpper() + words[i].Substring(1).ToLower();
            }

            return string.Join(" ", words);
        }

        public static bool AreAnagrams(string str1, string str2)
        {
            if (string.IsNullOrEmpty(str1) || string.IsNullOrEmpty(str2))
                return false;

            if (str1.Length != str2.Length)
                return false;

            str1 = new string(str1.OrderBy(_ => _).ToArray());
            str2 = new string(str2.OrderBy(_ => _).ToArray());

            return str1 == str2;
        }

        public static bool IsPalindrome(string str)
        {
            if(string.IsNullOrEmpty(str))
                return false;

            var left = 0;
            var right = str.Length - 1;

            while(left < right)
                if(str[left++] != str[right--])
                    return false;

            return true;
        }
    }
}
