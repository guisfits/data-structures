using DataStructures.Algorithms.Sorting;
using FluentAssertions;
using Xunit;

namespace Tests.Algorithms.Sorting
{
    public class BubbleSortTests
    {
        [Fact]
        public void GivenArray_WhenIsUnsortedArray_ShouldSortAscending()
        {
            // Arrange
            var array = new int[] { 10, 8, 4, 6, 2 };

            // Act
            var arraySort = BubbleSort.Sort(array);

            // Assert
            arraySort.Should().BeEquivalentTo(2, 4, 6, 8, 10);
        }
    }
}
