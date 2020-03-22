using FluentAssertions;
using Xunit;

namespace DataStructure.Tests.LinkedLists
{
    public class ToArrayTests : Base
    {
        [Fact]
        public void GivenAListWithSomeItems_ReturnAnArrayWithSameItems()
        {
            // Arrange
            var list = CreateSequentialIntList(3);

            // Act
            var array = list.ToArray();

            // Assert
            array.Should().BeEquivalentTo(new int[] { 1, 2, 3 });
        }

        [Fact]
        public void GivenAnEmptyList_ReturnAnEmptyArray()
        {
            // Arrange
            var list = CreateSequentialIntList();

            // Act
            var array = list.ToArray();

            // Assert
            array.Should().BeEquivalentTo(new int[] { });
        }
    }
}
