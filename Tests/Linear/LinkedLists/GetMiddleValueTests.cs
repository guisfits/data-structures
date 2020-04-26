using FluentAssertions;
using Xunit;

namespace DataStructures.Tests.LinkedLists
{
    public class GetMiddleValueTests : Base
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(2, 1)]
        [InlineData(3, 2)]
        [InlineData(5, 3)]
        [InlineData(7, 4)]
        [InlineData(9, 5)]
        [InlineData(10, 5)]
        public void GivenAValue_WhenTheListContainNItems_ShouldMiddleValueBeEqualToExpected(int listSize, int expect)
        {
            // Arrange
            var list = CreateSequentialIntList(listSize);

            // Act
            var middle = list.GetMiddleValue();

            // Assert
            middle.Should().Be(expect);
        }
    }
}
