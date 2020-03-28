using DataStructures.Stacks;
using FluentAssertions;
using Xunit;

namespace DataStructures.Tests.Stacks.MyStackTests
{
    public class PushTests
    {
        [Fact]
        public void GivenAnEmptyStack_WhenPushAnItem_ShouldAddThisItemInternally()
        {
            // Arrange
            var stack = new MyStack<int>();

            // Act
            stack.Push(1);

            // Assert
            stack.Peek().Should().Be(1);
        }


        [Fact]
        public void GivenAStackWithFullCapacity_WhenPushANewItem_ShouldAddThisItemInternally()
        {
            // Arrange
            var stack = new MyStack<int>(2);
            stack.Push(1);
            stack.Push(2);

            // Act
            stack.Push(3);

            // Assert
            stack.Peek().Should().Be(3);
        }
    }
}
