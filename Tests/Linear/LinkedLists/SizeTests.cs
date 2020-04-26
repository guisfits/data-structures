using DataStructures.Tests.LinkedLists;
using FluentAssertions;
using Xunit;

namespace DataStructures.Tests.LinkedLists
{
    public class SizeTests : Base
    {
        [Fact]
        public void GivenAListWithSomeItems_ShouldReturnTheQuantityOfItems()
        {
            // Arrange
            var list = CreateSequentialIntList(3);
            list.AddFirst(4);
            list.RemoveFirst();
            list.AddLast(5);
            list.RemoveLast();

            // Arrange
            list.Size().Should().Be(3);
        }

        [Fact]
        public void GivenAEmptyList_ShouldReturnZero()
        {
            // Arrange
            var list = CreateSequentialIntList();

            // Arrange
            list.Size().Should().Be(0);
        }
    }
}
