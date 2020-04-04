using DataStructures.Trees;
using FluentAssertions;
using Xunit;

namespace DataStructures.Tests.Trees.MyTreeTests
{
    public class IsBinarySearchTreeTests
    {
        [Fact]
        public void GivenATree_WhenIsBalanced_ShouldReturnTrue()
        {
            // Arrange
            var tree = new MyTree();
            tree.Insert(new int[] { 20, 19, 21, 6, 3, 8, 4 });

            // Act
            var isBST = tree.IsBinarySearchTree();

            // Assert
            isBST.Should().BeTrue();
        }
    }
}
