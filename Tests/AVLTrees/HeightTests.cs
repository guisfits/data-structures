using DataStructures.AVLTrees;
using FluentAssertions;
using Xunit;

namespace DataStructures.Tests.AVLTrees
{
    public class HeightTests
    {
        [Fact]
        public void GivenABalanceTree_WhenHaveFourItems_ShouldTheTopNodeBeThree()
        {
            // Arrange
            var tree = new MyAVLTree();
            tree.Insert(20, 30, 10, 11);

            // Act
            var height = tree.GetHeightOfValue(20);

            // Assert
            height.Should().Be(3);
        }

        [Fact]
        public void GivenABalanceTree_WhenHaveFourItems_ShouldTheBottomNodeBeOne()
        {
            // Arrange
            var tree = new MyAVLTree();
            tree.Insert(20, 30, 10, 11);

            // Act
            var height = tree.GetHeightOfValue(11);

            // Assert
            height.Should().Be(1);
        }

        [Fact]
        public void GivenAnEmptyTree_ShouldReturnNegativeOne()
        {
            // Arrange
            var tree = new MyAVLTree();

            // Act
            var height = tree.GetHeightOfValue(0);

            // Assert
            height.Should().Be(-1);
        }
    }
}
