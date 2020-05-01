using DataStructures.Algorithms;
using FluentAssertions;
using Xunit;

namespace Tests.Algorithms.StringManipulationTests
{
    public class RemoveDuplicatesCharactersTests
    {
        [Fact]
        public void GivenAWord_WhenHasDuplicateCharacters_ShouldRemoveAllDuplicatesAndReturn()
        {
            // Arrange
            var word = "Hellooo!!";

            // Act
            var noDuplication = StringManipulation.RemoveDuplicates(word);

            // Assert
            noDuplication.Should().Be("Helo!");
        }
    }
}
