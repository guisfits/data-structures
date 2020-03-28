using FluentAssertions;
using Xunit;

namespace DataStructures.Tests.LinkedLists
{
    public class IndexOfTests : Base
    {
        [Fact]
        public void GivenAValue_WhenListHaveSomeItems_ShouldReturnTheIndexOfThisValue()
        {
            // Arrange
            var list = CreateSequentialIntList(3);

            // Act
            var index = list.IndexOf(2);

            // Assert
            index.Should().Be(1);
        }

        [Fact]
        public void GivenAValue_WhenTheListIsEmpty_ShouldReturnNegativeOne()
        {
            // Arrange
            var list = CreateSequentialIntList();

            // Act
            var index = list.IndexOf(1);

            // Assert
            index.Should().Be(-1);
        }

        [Fact]
        public void GivenAValue_WhenTheListDoesHaveTheValue_ShouldReturnNegativeOne()
        {
            // Arrange
            var list = CreateSequentialIntList(1);

            // Act
            var index = list.IndexOf(2);

            // Assert
            index.Should().Be(-1);
        }
    }
}
