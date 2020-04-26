using DataStructures.AVLTrees;
using FluentAssertions;
using Xunit;

namespace DataStructures.Tests.AVLTrees
{
    public class RebalanceTests
    {
        [Fact]
        public void GivenATree_WhenIsRightHeavy_ShouldRebalanceToLeft()
        {
            // Arrange
            var tree = new MyAVLTree();
            tree.Insert(10, 20, 30, 40);

            // Act
            var items = tree.GetAll();

            // Assert
            items.Should().ContainInOrder(20, 10, 30, 40);
        }

        [Fact]
        public void GivenATree_WhenIsLeftHeavy_ShouldRebalanceToRight()
        {
            // Arrange
            var tree = new MyAVLTree();
            tree.Insert(40, 30, 20, 10);

            // Act
            var items = tree.GetAll();

            // Assert
            items.Should().ContainInOrder(30, 20, 10, 40);
        }
    }
}
