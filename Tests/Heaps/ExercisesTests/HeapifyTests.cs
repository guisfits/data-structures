using Xunit;
using DataStructures.Heaps;
using FluentAssertions;

namespace Tests.Heaps.ExercisesTests
{
    public class HeapifyTests
    {
        [Fact]
        public void GivenAnArray_ShouldReturnANewArrayWithHeapStructure()
        {
            // Arrange
            var array = new int[] { 5, 3, 8, 4, 1, 2 };

            // Act
            var newArray = Exercises.Heapify(array);

            // Assert
            newArray.Should().BeEquivalentTo(8, 4, 5, 3, 1, 2);
        }
    }
}
