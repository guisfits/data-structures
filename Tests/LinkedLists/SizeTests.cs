using DataStructure.Tests.LinkedLists;
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

            // Arrange
            list.Size().Should().Be(3);
        }
    }
}
