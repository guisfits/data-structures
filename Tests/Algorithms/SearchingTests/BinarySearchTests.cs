using DataStructures.Algorithms;
using FluentAssertions;
using Xunit;

namespace Tests.Algorithms.SearchingTests
{
    public class BinarySearchTests
    {
        [Fact]
        public void GivenATarger_WhenArrayContains_ShouldReturnTheIndex()
        {
            // Arrange
            var array = new int[] { 1, 2, 3 };
            var target = 2;

            // Act
            var index = Searching.BinarySearch(array, target);

            // Assert
            index.Should().Be(1);
        }

        [Fact]
        public void GivenATarget_WhenArrayNotContains_ShouldReturnNegativeOne()
        {
            // Arrange
            var array = new int[] { 1, 2, 3 };
            var target = 4;

            // Act
            var index = Searching.BinarySearch(array, target);

            // Assert
            index.Should().Be(-1);
        }
    }
}
