using System.Linq;
using DataStructures.Heaps;
using FluentAssertions;
using Xunit;

namespace Tests.Heaps.MyHeapTests
{
    public class RemoveTests
    {
        [Fact]
        public void GivenAHeapWithSomeItems_WhenRemoveTheRootValue_ShouldRebalanceTheHeap()
        {
            // Arrange
            var heap = new MyHeap();
            heap.Insert(10, 5, 17, 4, 22);

            // Act
            heap.Remove();

            // Assert
            heap.GetAll().First().Should().Be(17);
        }
    }
}
