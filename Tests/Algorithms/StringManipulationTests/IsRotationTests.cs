using DataStructures.Algorithms;
using FluentAssertions;
using Xunit;

namespace Tests.Algorithms.StringManipulationTests
{
    public class IsRotationTests
    {
        [Theory]
        [InlineData("ABCD", "DABC")]
        [InlineData("ABCD", "CDAB")]
        public void GivenTwoWords_WhenOneIsRotationOfOther_ShouldReturnTrue(string wordA, string wordB)
        {
            // Act
            var isRotation = StringManipulation.IsRotation(wordA, wordB);

            // Assert
            isRotation.Should().BeTrue();
        }
    }
}
