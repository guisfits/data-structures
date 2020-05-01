using DataStructures.Algorithms;
using FluentAssertions;
using Xunit;

namespace Tests.Algorithms.StringManipulationTests
{
    public class ReverseStringTests
    {
        [Fact]
        public void GivenAWord_ShouldReverseIt()
        {
            // Arrange
            var word = "hello";

            // Act
            var reversedWord = StringManipulation.Reverse(word);

            // Assert
            reversedWord.Should().Be("olleh");
        }
    }
}
