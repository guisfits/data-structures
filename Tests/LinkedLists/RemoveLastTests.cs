using DataStructure.Tests.LinkedLists;
using DataStructures.LinkedLists;
using FluentAssertions;
using Xunit;

namespace DataStructures.Tests.LinkedLists
{
    public class RemoveLastTests : Base
    {
        [Fact]
        public void GivenAListWithSomeItems_ShouldRemoveLastItem()
        {
            // Arrange
            var list = CreateSequentialIntList(3);

            // Act
            list.RemoveLast();

            // Arrange
            list.GetLast().Should().Be(2);
            list.GetFirst().Should().Be(1);
        }
    }
}
