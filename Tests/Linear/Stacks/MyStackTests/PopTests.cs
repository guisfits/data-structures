using System;
using DataStructures.Stacks;
using FluentAssertions;
using Xunit;

namespace DataStructures.Tests.Stacks.MyStackTests
{
    public class PopTests
    {
        [Fact]
        public void GivenAnStack_WhenIsEmpty_ShouldThrowAnException()
        {
            // Arrange
            var stack = new MyStack<int>();

            // Act and Assert
            Assert.Throws<IndexOutOfRangeException>(() => stack.Pop());
        }

        [Fact]
        public void GivenAStack_WhenHaveTwoItems_ShouldReturnTheLastItemAndRemoveFromTheStack()
        {
            // Arrange
            var stack = new MyStack<int>();
            stack.Push(1);
            stack.Push(2);

            // Act
            var item = stack.Pop();

            // Assert
            item.Should().Be(2);
            stack.Size.Should().Be(1);
        }

        [Fact]
        public void GivenAStack_WhenHaveTreeItems_ShouldReturnThoseItemsInReverseOrder()
        {
            // Arrange
            var stack = new MyStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            // Act
            var item1 = stack.Pop();
            var item2 = stack.Pop();
            var item3 = stack.Pop();

            // Assert
            item1.Should().Be(3);
            item2.Should().Be(2);
            item3.Should().Be(1);
            stack.IsEmpty().Should().BeTrue();
        }
    }
}
