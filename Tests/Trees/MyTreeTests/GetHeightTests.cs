using DataStructures.Trees;
using FluentAssertions;
using Xunit;

namespace DataStructures.Tests.Trees.MyTreeTests
{
    public class GetHeightTests
    {
        [Fact]
        public void GivenATree_WhenHaveSomeItems_ShouldReturnTheHeight()
        {
            // Arrange
            var tree = new MyTree();
            tree.Insert(new int[] { 20, 10, 30, 6, 21, 4, 2, 8 });

            // Act
            var height = tree.GetHeight();

            // Assert
            height.Should().Be(4);
        }

        [Fact]
        public void GivenATree_WhenIsEmpty_ShouldReturnNegativeOne()
        {
            // Arrange
            var tree = new MyTree();

            // Act
            var height = tree.GetHeight();

            // Assert
            height.Should().Be(-1);
        }
    }
}
