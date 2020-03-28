using FluentAssertions;
using Xunit;

namespace DataStructures.Tests.LinkedLists
{
    public class GetByIndexBackwardTests : Base
    {
        [Theory]
        [InlineData(1, 70)]
        [InlineData(2, 60)]
        [InlineData(3, 50)]
        [InlineData(4, 40)]
        [InlineData(5, 30)]
        [InlineData(6, 20)]
        [InlineData(7, 10)]
        [InlineData(0, null)]
        [InlineData(-1, null)]
        [InlineData(100, null)]
        public void GivenAIndex_WhenListHaveSomeItems_ShouldReturnedValueBeEqualToExpected(int index, int? expectValue)
        {
            // Arrange
            var list = CreateSequentialIntList(7, 10);

            // Act
            var value = list.GetByIndexBackward(index);

            // Assert
            value.Should().Be(expectValue);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        public void GivenAValue_WhenListIsEmpty_ShouldReturnNull(int index)
        {
            // Arrange
            var list = CreateSequentialIntList();

            // Act
            var value = list.GetByIndexBackward(index);

            // Assert
            value.Should().BeNull();
        }
    }
}
