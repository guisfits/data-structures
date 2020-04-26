using DataStructures.Trees;
using FluentAssertions;
using Xunit;

namespace DataStructures.Tests.Trees.MyTreeTests
{
    public class CountTests
    {
        [Fact]
        public void GivenATree_WhenHaveSomeItems_ShouldReturnCountOfItems()
        {
            // Arrange
            var tree = new MyTree();
            tree.Insert(new int[] { 20, 10, 30, 6, 14, 24, 3, 8, 26 });

            // Act
            var count = tree.Count();

            // Assert
            count.Should().Be(9);
        }
    }
}
