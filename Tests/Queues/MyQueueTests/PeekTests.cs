using System;
using FluentAssertions;
using Xunit;

namespace DataStructures.Tests.Queues.MyQueueTests
{
    public class PeekTests : Base
    {
        [Fact]
        public void GivenAQueueWithSomeItems_WhenPeek_ShouldReturnTheFirstItemAdded()
        {
            // Arrange
            var queue = Create(3);

            // Act
            var item = queue.Peek();

            // Assert
            item.Should().Be(10);
        }

        [Fact]
        public void GivenAnEmptyQueue_WhenTryToPeek_ShouldThrowAnException()
        {
            // Arrange
            var queue = Create(0);

            // Act | Assert
            Assert.ThrowsAny<Exception>(() => queue.Peek());
        }
    }
}
