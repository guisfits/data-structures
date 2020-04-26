using System;
using FluentAssertions;
using Xunit;

namespace DataStructures.Tests.Queues.MyQueueTests
{
    public class DequeueTests : Base
    {
        [Fact]
        public void GivenAQueueWithSomeItems_WhenDequeue_ShouldReturnTheFirstItemAdded()
        {
            // Arrange
            var queue = Create(3);

            // Act
            var firstOut = queue.Dequeue();

            // Assert
            firstOut.Should().Be(10);
        }

        [Fact]
        public void GivenAnEmptyQueue_WhenTryToDequeue_ShouldThorowAnException()
        {
            // Arrange
            var queue = Create(0);

            // Act
            Assert.ThrowsAny<Exception>(() => queue.Dequeue());
        }
    }
}
