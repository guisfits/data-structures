using DataStructures.HashTables;
using FluentAssertions;
using Xunit;

namespace DataStructures.Tests.HashTables.ExercisesTests
{
    public class FindUniqueCharactersTests
    {
        [Theory]
        [InlineData("a b a", 'b')]
        [InlineData("aAa", 'A')]
        [InlineData("aA", 'a')]
        [InlineData("a", 'a')]
        [InlineData("aa", null)]
        [InlineData(null, null)]
        [InlineData(" ", null)]
        public void GivenAString_WhenHaveSomeUniqueCharacters_ShouldReturnTheFirstOne(string input, char? expected)
        {
            // Act
            var uniques = Exercises.FindFirstNonRepeatCharacter(input);

            // Assert
            uniques.Should().Be(expected);
        }
    }
}
