using System.Collections.Generic;
using System.Linq;

namespace DataStructures.HashTables
{
    public class Exercises
    {
        public static char? FindFirstNonRepeatCharacter(string input)
        {
            var characters = TransformString(input);
            if (characters == null) return null;

            var count = characters.Count();
            var repeatedCharacters = new HashSet<char>();

            for (int i = 0; i < count; i++)
            {
                var c = characters[i];
                if (repeatedCharacters.Contains(c))
                    continue;

                var isUnique = true;
                for (var y = (count - 1); y > i; y--)
                {
                    if (c == characters[y])
                    {
                        isUnique = false;
                        repeatedCharacters.Add(c);
                        break;
                    }
                }

                if (isUnique)
                    return c;
            }

            return null;
        }

        public static char? FindFirstRepeatCharacter(string input)
        {
            var characters = TransformString(input);
            if (characters == null) return null;

            var setChars = new HashSet<char>();
            foreach (var c in characters)
            {
                if(setChars.Contains(c))
                    return c;

                setChars.Add(c);
            }

            return null;
        }

        private static char[] TransformString(string input)
        {

            if (string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input))
                return null;

            return input.ToCharArray().Where(x => x != ' ').ToArray();
        }
    }
}
