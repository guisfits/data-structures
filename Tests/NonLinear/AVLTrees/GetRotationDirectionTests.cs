using DataStructures.AVLTrees;
using FluentAssertions;
using Xunit;

namespace DataStructures.Tests.AVLTrees
{
    public class GetRotationDirectionTests
    {
        [Fact]
        public void GivenATree_WhenIsRightHeavyOnRightSubtree_ShouldLeftRotate()
        {
            // Arrange
            var tree = new MyAVLTree();
            tree.Insert(10, 20, 30);

            // Act
            var rotation = tree.GetRotationDirection();

            // Assert
            rotation.Should().Be(MyAVLTree.Rotate.L);
        }

        [Fact]
        public void GivenATree_WhenIsRightHeavyOnLeftSubtree_ShouldRightAndLeftRotate()
        {
            // Arrange
            var tree = new MyAVLTree();
            tree.Insert(10, 30, 20);

            // Act
            var rotation = tree.GetRotationDirection();

            // Assert
            rotation.Should().Be(MyAVLTree.Rotate.RL);
        }

        [Fact]
        public void GivenATree_WhenIsLeftHeavyOnLeftSubtree_ShouldRightRotate()
        {
            // Arrange
            var tree = new MyAVLTree();
            tree.Insert(30, 20, 10);

            // Act
            var rotation = tree.GetRotationDirection();

            // Assert
            rotation.Should().Be(MyAVLTree.Rotate.R);
        }

        [Fact]
        public void GivenATree_WhenIsLeftHeavyOnRightSubtree_ShouldLeftAndRightRotate()
        {
            // Arrange
            var tree = new MyAVLTree();
            tree.Insert(30, 10, 20);

            // Act
            var rotation = tree.GetRotationDirection();

            // Assert
            rotation.Should().Be(MyAVLTree.Rotate.LR);
        }


        [Fact]
        public void GivenATree_WhenIsBalanced_ShouldNoRotate()
        {
            // Arrange
            var tree = new MyAVLTree();
            tree.Insert(20, 10, 30);

            // Act
            var rotation = tree.GetRotationDirection();

            // Assert
            rotation.Should().Be(MyAVLTree.Rotate.None);
        }
    }
}
