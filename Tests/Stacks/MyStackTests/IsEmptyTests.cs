using DataStructures.Stacks;
using FluentAssertions;
using Xunit;

namespace DataStructures.Tests.Stacks.MyStackTests
{
    public class IsEmptyTests
    {
        [Fact]
        public void GivenANewStack_WhenVerifyIfIsEmpty_ShouldReturnTrue()
        {
            // Arrange
            var stack = new MyStack<int>();

            // Act
            var isEmpty = stack.IsEmpty();

            // Assert
            isEmpty.Should().BeTrue();
        }

        [Fact]
        public void GivenAStackWithSomeItems_WhenVerifyIfIsEmpty_ShouldReturnFalse()
        {
            // Arrange
            var stack = new MyStack<int>();
            stack.Push(1);
            stack.Push(2);

            // Act
            var isEmpty = stack.IsEmpty();

            // Assert
            isEmpty.Should().BeFalse();
        }

        [Fact]
        public void GivenAStackWithSomeItems_WhenItemsAreRemovedAndVerifyIfIsEmpty_ShouldReturnTrue()
        {
            // Arrange
            var stack = new MyStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Pop();
            stack.Pop();

            // Act
            var isEmpty = stack.IsEmpty();

            // Assert
            isEmpty.Should().BeTrue();
        }
    }
}
