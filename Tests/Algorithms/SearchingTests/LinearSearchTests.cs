using DataStructures.Algorithms;
using FluentAssertions;
using Xunit;

namespace Tests.Algorithms.SearchingTests
{
    public class LinearSearchTests
    {
        [Fact]
        public void GivenATarget_WhenArraysContains_ShouldReturnTheIndexOfTheTarget()
        {
            // Arrange
            var array = new int[] { 1, 2, 3 };
            var target = 2;

            // Act
            var index = Searching.LinearSearch(array, target);

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
            var index = Searching.LinearSearch(array, target);

            // Assert
            index.Should().Be(-1);
        }
    }
}
