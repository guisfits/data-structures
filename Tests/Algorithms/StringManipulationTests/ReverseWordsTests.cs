using DataStructures.Algorithms;
using FluentAssertions;
using Xunit;

namespace Tests.Algorithms.StringManipulationTests
{
    public class ReverseWordsTests
    {
        [Fact]
        public void GivenASentence_ShouldReturnTheWorldInReverseOrder()
        {
            // Arrange
            var sentence = "Slayer is brutal";

            // Act
            var reversedWords = StringManipulation.ReverseWords(sentence);

            // Assert
            reversedWords.Should().Be("brutal is Slayer");
        }
    }
}
