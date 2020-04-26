using DataStructures.Stacks;
using FluentAssertions;
using Xunit;

namespace DataStructures.Tests.Stacks.ExercisesTests
{
    public class ReverseStringTests
    {
        [Theory]
        [InlineData("abcd", "dcba")]
        [InlineData("", "")]
        [InlineData(null, null)]
        public void GivenAWord_ShouldReturnTheWordInReverseOrder(string input, string expected)
        {
            // Act
            var reversed = Exercises.ReverseString(input);

            // Assert
            reversed.Should().Be(expected);
        }
    }
}
