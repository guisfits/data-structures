using DataStructures.Algorithms;
using FluentAssertions;
using Xunit;

namespace Tests.Algorithms.StringManipulationTests
{
    public class FindTheNumberOfVowelsTests
    {
        [Fact]
        public void GivenAWord_WhenHasNVowels_ShouldReturnN()
        {
            // Arrange
            var word = "Banana";

            // Act
            var n = StringManipulation.FindTheNumberOfVowels(word);

            // Assert
            n.Should().Be(3);
        }
    }
}
