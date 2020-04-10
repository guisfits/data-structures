using DataStructures.Heaps;
using FluentAssertions;
using Xunit;

namespace Tests.Heaps.MyHeapTests
{
    public class InsertTests
    {
        [Fact]
        public void GivenAnEmptyHeap_WhenInsertNewValues_ShouldAddThoseValuesOnArray()
        {
            // Arrange
            var heap = new MyHeap();

            // Act
            heap.Insert(10, 5, 17);

            // Assert
            heap.GetAll().Should().BeEquivalentTo(17, 5, 10);
        }
    }
}
