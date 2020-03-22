using DataStructure.Tests.LinkedLists;
using DataStructures.LinkedLists;
using FluentAssertions;
using Xunit;

namespace Tests.LinkedLists
{
    public class ContainsTest : Base
    {
        [Fact]
        public void GivenAValue_WhenListContainThisValue_ShouldReturnTrue()
        {
            // Arrange
            var list = CreateSequentialIntList(3);

            // Assert
            list.Contains(2).Should().BeTrue();
        }

        [Fact]
        public void GivenAValue_WhenListNotContainThisValue_ShouldReturnFalse()
        {
            // Arrange
            var list = CreateSequentialIntList(3);

            // Assert
            list.Contains(4).Should().BeFalse();
        }

        [Fact]
        public void GivenAValue_WhenListIsEmpty_ShouldReturnFalse()
        {
            // Arrange
            var list = CreateSequentialIntList();

            // Assert
            list.Contains(1).Should().BeFalse();
        }
    }
}
