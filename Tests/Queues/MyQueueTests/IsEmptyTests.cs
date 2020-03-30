using FluentAssertions;
using Xunit;

namespace DataStructures.Tests.Queues.MyQueueTests
{
    public class IsEmptyTests : Base
    {
        [Fact]
        public void GivenAEmptyQueue_WhenCheckIfIsEmpty_ShouldReturnTrue()
        {
            // Arrange
            var queue = Create(0);

            // Act | Assert
            queue.IsEmpty().Should().BeTrue();
        }

        [Fact]
        public void GivenAQueueWithSomeItems_WhenDequeueItAll_ShouldReturnTrue()
        {
            // Arrange
            var queue = Create(3);
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();

            // Act | Assert
            queue.IsEmpty().Should().BeTrue();
        }

        [Fact]
        public void GivenAQueue_WhenHaveSomeItems_ShouldReturnFalse()
        {
            // Arrange
            var queue = Create(3);

            // Act | Assert
            queue.IsEmpty().Should().BeFalse();
        }
    }
}
