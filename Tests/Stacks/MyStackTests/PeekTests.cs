using System;
using DataStructures.Stacks;
using FluentAssertions;
using Xunit;

namespace DataStructures.Tests.Stacks.MyStackTests
{
    public class PeekTests
    {
        [Fact]
        public void GivenAnStack_WhenIsEmpty_ShouldThrowAnException()
        {
            // Arrange
            var stack = new MyStack<int>();

            // Act and Assert
            Assert.Throws<IndexOutOfRangeException>(() => stack.Peek());
        }

        [Fact]
        public void GivenAStackWithTwoItems_ShouldReturnTheSameValueTwice()
        {
            // Arrange
            var stack = new MyStack<int>();
            stack.Push(1);
            stack.Push(2);

            // Act
            var item1 = stack.Peek();
            var item2 = stack.Peek();

            // Assert
            item1.Should().Be(2);
            item2.Should().Be(2);
            stack.Size.Should().Be(2);
        }
    }
}
