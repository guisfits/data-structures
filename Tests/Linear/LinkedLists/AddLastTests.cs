using FluentAssertions;
using Xunit;

namespace DataStructures.Tests.LinkedLists
{
    public class AddLastTests : Base
    {
        [Fact]
        public void GivenAValue_WhenTheListIsEmpty_ShouldFirstAndLastHaveTheSameValue()
        {
            // Arrange
            var list = CreateSequentialIntList();

            // Act
            list.AddLast(1);

            // Assert
            list.GetFirst().Should().NotBeNull().And.Be(1);
            list.GetLast().Should().NotBeNull().And.Be(1);
        }

        [Fact]
        public void GivenTwoValues_WhenTheListIsEmpty_ShouldFirstAndLastBeDifferent()
        {
            // Arrange
            var list = CreateSequentialIntList();

            // Act
            list.AddLast(1);
            list.AddLast(2);

            // Assert
            list.GetFirst().Should().Be(1);
            list.GetLast().Should().Be(2);
        }

        [Fact]
        public void GivenMoreThanTwoValues_WhenTheListIsEmpty_ShouldFirstAndLastBeDifferent()
        {
            // Arrange
            var list = CreateSequentialIntList();

            // Act
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);

            // Assert
            list.GetFirst().Should().Be(1);
            list.GetLast().Should().Be(3);
        }
    }
}
