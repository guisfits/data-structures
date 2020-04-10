using DataStructures.Heaps;
using FluentAssertions;
using Xunit;

namespace Tests.Heaps.ExercisesTests
{
    public class FindKthLargestItemTests
    {
        [Theory]
        [InlineData(1, 10)]
        [InlineData(2, 8)]
        [InlineData(3, 7)]
        [InlineData(4, 5)]
        [InlineData(5, 2)]
        public void GivenAHeapWithSomeItems_ShouldTheKthLargestItem(int k, int largestExpected)
        {
            // Arrange
            var heap = new MyHeap();
            heap.Insert(new int[]{ 5, 10, 8, 7, 2 });

            // Act
            var largest = Exercises.FindKthLasgestItem(heap, k);

            // Assert
            largest.Should().Be(largestExpected);
        }
    }
}
