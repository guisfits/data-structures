using DataStructures.Algorithms;
using FluentAssertions;
using Xunit;

namespace Tests.Algorithms.SearchingTests
{
    public class ExponentialSearch
    {
        [Fact]
        public void GivenATarget_WhenArrayContains_ShouldReturnTheIndex()
        {
            // Arrange
            var array = new int[] { 1, 2, 3, 4, 5 };
            var target = 4;

            // Act
            var index = Searching.ExponentialSearch(array, target);

            // Assert
            index.Should().Be(3);
        }

        [Fact]
        public void GivenATarget_WhenArrayNotContains_ShouldReturnNegativeOne()
        {
            // Arrange
            var array = new int[] { 1, 2, 3, 4, 5 };
            var target = 6;

            // Act
            var index = Searching.ExponentialSearch(array, target);

            // Assert
            index.Should().Be(-1);
        }
    }
}
