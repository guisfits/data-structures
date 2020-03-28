using FluentAssertions;
using Xunit;

namespace DataStructures.Tests.LinkedLists
{
    public class AddFirstTests : Base
    {
        [Fact]
        public void GivenAUniqueValue_WhenTheListIsEmpty_ShouldFirstAndLastHaveTheSameValue()
        {
            // Arrange
            var list = CreateSequentialIntList(0);

            // Act
            list.AddFirst(1);

            // Assert
            list.GetFirst().Should().NotBeNull().And.Be(1);
            list.GetLast().Should().NotBeNull().And.Be(1);
        }

        [Fact]
        public void GivenTwoValues_WhenListContainMoreThanOneItem_ShouldFirstAndLastBeDifferent()
        {
            // Arrange
            var list = CreateSequentialIntList(0);

            // Act
            list.AddFirst(1);
            list.AddFirst(0);

            // Assert
            list.GetFirst().Should().Be(0);
            list.GetLast().Should().Be(1);
        }

        [Fact]
        public void GivenMoreThanTwoValues_WhenListContainMoreThanOneItem_ShouldFirstAndLastBeDifferent()
        {
            // Arrange
            var list = CreateSequentialIntList(0);

            // Act
            list.AddFirst(3);
            list.AddFirst(2);
            list.AddFirst(1);

            // Assert
            list.GetFirst().Should().Be(1);
            list.GetLast().Should().Be(3);
        }
    }
}
