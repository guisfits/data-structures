using DataStructures.AVLTrees;
using FluentAssertions;
using Xunit;

namespace DataStructures.Tests.AVLTrees
{
    public class GetBalanceTests
    {
        [Fact]
        public void GivenATree_WhenInsertThreeItemInAscendingOrder_ShouldBeRightHeavy()
        {
            // Arrange
            var tree = new MyAVLTree();
            tree.Insert(10, 20, 30);

            // Act
            var balance = tree.GetBalance();

            // Assert
            balance.Should().Be(MyAVLTree.Balance.RightHeavy);
        }

        [Fact]
        public void GivenATree_WhenInsertThreeItemInDescendingOrder_ShouldBeLeftHeavy()
        {
            // Arrange
            var tree = new MyAVLTree();
            tree.Insert(30, 20, 10);

            // Act
            var balance = tree.GetBalance();

            // Assert
            balance.Should().Be(MyAVLTree.Balance.LeftHeavy);
        }

        [Fact]
        public void GivenATree_WhenInsertThreeItemInBalanceOrder_ShouldBeBalanced()
        {
            // Arrange
            var tree = new MyAVLTree();
            tree.Insert(20, 10, 30);

            // Act
            var balance = tree.GetBalance();

            // Assert
            balance.Should().Be(MyAVLTree.Balance.Balanced);
        }

        [Fact]
        public void GivenATree_WhenIsEmpty_ShouldBeBalanced()
        {
            // Arrange
            var tree = new MyAVLTree();

            // Act
            var balance = tree.GetBalance();

            // Assert
            balance.Should().Be(MyAVLTree.Balance.Balanced);
        }
    }
}
