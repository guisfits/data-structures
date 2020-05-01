using DataStructures.Algorithms;
using FluentAssertions;
using Xunit;

namespace Tests.Algorithms.StringManipulationTests
{
    public class FindTheMostRepeatableCharacterTests
    {
        [Fact]
        public void GivenAWord_WhenHasSomeRepeatableCharacters_ShouldTheMostRepeatable()
        {
            // Arrange
            var word = "Heellloooo!!";

            // Act
            var character = StringManipulation.FindMostRepeatableCharacter(word);

            // Assert
            character.Should().Be('o');
        }
    }
}
