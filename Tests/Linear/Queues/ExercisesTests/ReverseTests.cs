using System.Collections.Generic;
using DataStructures.Queues;
using FluentAssertions;
using Xunit;

namespace DataStructures.Tests.Queues.ExercisesTests
{
    public class ReverseTests
    {
        [Fact]
        public void GivenAQueue_ShouldReturnAnotherQueueInReverseOrder()
        {
            // Arrange
            var queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            // Act
            var newQueue = Exercises.Reverse(queue);

            // Assert
            newQueue.Dequeue().Should().Be(3);
            newQueue.Dequeue().Should().Be(2);
            newQueue.Dequeue().Should().Be(1);
        }

        [Fact]
        public void GivenAnEmptyQueue_ShouldReturnEmptyQueueWhenTryToReverseIt()
        {
            // Arrange
            var queue = new Queue<int>();

            // Act
            var newQueue = Exercises.Reverse(queue);

            // Assert
            newQueue.Should().BeEmpty();
        }

        [Fact]
        public void GivenANullValue_ShouldReturnNull()
        {
            // Arrange
            Queue<int> queue = null;

            // Act
            var newQueue = Exercises.Reverse(queue);

            // Assert
            newQueue.Should().BeNull();
        }
    }
}
