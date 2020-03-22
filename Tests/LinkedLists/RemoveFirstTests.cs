using DataStructure.Tests.LinkedLists;
using FluentAssertions;
using Xunit;

namespace Tests.LinkedLists
{
    public class RemoveFirstTests : Base
    {
        [Fact]
        public void GivenAListWithSomeItems_ShouldRemoveTheFirstItem()
        {
            // Arrange
            var list = CreateSequentialIntList(3);

            // Act
            list.RemoveFirst();

            // Assert
            list.GetFirst().Should().Be(2);
            list.GetLast().Should().Be(3);
        }
    }
}
