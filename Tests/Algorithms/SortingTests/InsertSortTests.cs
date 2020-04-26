using DataStructures.Algorithms;
using FluentAssertions;
using Xunit;

namespace Tests.Algorithms.SortingTests
{
    public class InsertSortTests
    {
        [Theory]
        [InlineData(new int[] { 5, 4, 2, 3, 1 })]
        [InlineData(new int[] { 1, 2, 3 })]
        [InlineData(new int[] { 2, 1 })]
        [InlineData(new int[] { 1 })]
        public void GivenAnArray_WhenIsUnsorted_ShouldSort(int[] array)
        {
            // Act
            var sortedArray = Sorting.InsertSort(array);

            // Assert
            sortedArray.Should().BeInAscendingOrder();
        }

        [Fact]
        public void GivenAnArray_WhenIsEmpty_ShouldReturnEmpty()
        {
            // Arrange
            var array = new int[] { };

            // Act
            var sortedArray = Sorting.InsertSort(array);

            // Assert
            sortedArray.Should().BeEmpty();
        }

        [Fact]
        public void GivenNull_ShouldReturnNull()
        {
            // Arrange
            int[] array = null;

            // Act
            var sortedArray = Sorting.InsertSort(array);

            // Assert
            sortedArray.Should().BeNull();
        }
    }
}
