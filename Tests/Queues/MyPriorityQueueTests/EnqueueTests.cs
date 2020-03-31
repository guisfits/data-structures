using DataStructures.Queues;
using FluentAssertions;
using Xunit;

namespace DataStructures.Tests.Queues.MyPriorityQueueTests
{
    public class EnqueueTests
    {
        [Fact]
        public void GivenAQueueWith1And3Enqueued_WhenEnqueue2_ShouldEnqueueThisNewValueOnMiddle()
        {
            // Arrange
            var queue = new MyPriorityQueue(3);
            queue.Enqueue(1);
            queue.Enqueue(3);

            // Act
            queue.Enqueue(2);

            // Assert
            queue.Dequeue().Should().Be(1);
            queue.Dequeue().Should().Be(2);
            queue.Dequeue().Should().Be(3);
        }

        [Fact]
        public void GivenAQueueWithSomeItems_WhenTryToEnqueueANewValueThatIsLowerThanAll_ShouldEnqueueThisFirst()
        {
            // Arrange
            var queue = new MyPriorityQueue(3);
            queue.Enqueue(2);
            queue.Enqueue(3);

            // Act
            queue.Enqueue(1);

            // Assert
            queue.Dequeue().Should().Be(1);
            queue.Dequeue().Should().Be(2);
            queue.Dequeue().Should().Be(3);
        }

        [Fact]
        public void GivenAQueueWithSomeItems_WhenTryToEnqueueANewValueThatIsGreaterThanAll_ShouldEnqueueThisLast()
        {
            // Arrange
            var queue = new MyPriorityQueue(3);
            queue.Enqueue(1);
            queue.Enqueue(2);

            // Act
            queue.Enqueue(3);

            // Assert
            queue.Dequeue().Should().Be(1);
            queue.Dequeue().Should().Be(2);
            queue.Dequeue().Should().Be(3);
        }
    }
}
