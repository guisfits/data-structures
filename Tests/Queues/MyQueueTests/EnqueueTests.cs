using FluentAssertions;
using Xunit;

namespace DataStructures.Tests.Queues.MyQueueTests
{
    public class EnqueueTests : Base
    {
        [Fact]
        public void GivenAnEmptyQueue_WhenEnqueueTwoNewItems_ShouldDequeueTheFirstItemAdded()
        {
            // Arrange
            var queue = Create(0);

            // Act
            queue.Enqueue(1);
            queue.Enqueue(2);

            // Assert
            queue.Peek().Should().Be(1);
        }

        [Fact]
        public void GivenAnQueueWithSomeItems_WhenEnqueueANewItem_ShouldPutThisItemLast()
        {
            // Arrange
            var queue = Create(3);

            // Act
            queue.Enqueue(40);

            // Assert
            queue.Peek().Should().NotBe(40);
        }
    }
}
