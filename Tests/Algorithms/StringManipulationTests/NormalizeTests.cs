using DataStructures.Algorithms;
using FluentAssertions;
using Xunit;

namespace Tests.Algorithms.StringManipulationTests
{
    public class NormalizeTests
    {
        [Fact]
        public void GivenAWord_WhenTheWordDoNotBeginWithUppercase_ShouldNormalize()
        {
            // Arrange
            var str = "nirVana iS a  greaTer    bAnd";

            // Act
            var normalize = StringManipulation.Normalize(str);

            // Assert
            normalize.Should().Be("Nirvana Is A Greater Band");
        }
    }
}
