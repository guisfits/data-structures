using FluentAssertions;
using Xunit;
using DataStructures.Algorithms;

namespace Tests.Algorithms.SortingTests
{
    public class BubbleSortTests
    {
        [Theory]
        [InlineData(new int[] { 10, 8, 4, 6, 2 })]
        [InlineData(new int[] { 1, 2, 3 })]
        [InlineData(new int[] { 2, 1 })]
        [InlineData(new int[] { 1 })]
        public void GivenArray_ShouldSortAscending(int[] array)
        {
            // Act
            var arraySort = Sorting.BubbleSort(array);

            // Assert
            arraySort.Should().BeInAscendingOrder();
        }

        [Fact]
        public void GivenAnEmptyArray_ShouldReturnEmpty()
        {
            // Arrange
            var array = new int[] { };

            // Act
            var arraySort = Sorting.BubbleSort(array);

            // Assert
            arraySort.Should().BeEmpty();
        }

        [Fact]
        public void GivenNull_ShouldReturnNull()
        {
            // Arrange
            int[] array = null;

            // Act
            var arraySort = Sorting.BubbleSort(array);

            // Assert
            arraySort.Should().BeNull();
        }
    }
}
