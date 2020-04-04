using DataStructures.Trees;
using FluentAssertions;
using Xunit;

namespace DataStructures.Tests.Trees.MyTreeTests
{
    public class GetAllTests
    {
        [Fact]
        public void GivenATreeWithSomeItems_WhenGetAllInPreOrder_ShouldReturnAnArray()
        {
            // Arrange
            var tree = CreateTree();

            // Act
            var values = tree.GetAll(MyTree.TraversingMethod.PreOrder);

            // Assert
            values.Should().BeEquivalentTo(new int[] { 20, 10, 6, 3, 8, 14, 30, 24, 26 });
        }

        [Fact]
        public void GivenATreeWithSomeItems_WhenGetAllInOrder_ShouldReturnAnArray()
        {
            // Arrange
            var tree = CreateTree();

            // Act
            var values = tree.GetAll(MyTree.TraversingMethod.InOrder);

            // Assert
            values.Should().BeEquivalentTo(new int[] { 3, 6, 8, 10, 14, 20, 24, 26, 30 });
        }

        [Fact]
        public void GivenATreeWithSomeItems_WhenGetAllPostOrder_ShouldReturnAnArray()
        {
            // Arrange
            var tree = CreateTree();

            // Act
            var values = tree.GetAll(MyTree.TraversingMethod.PostOrder);

            // Assert
            values.Should().BeEquivalentTo(new int[] { 3, 8, 6, 14, 10, 26, 24, 30, 20 });
        }

        [Fact]
        public void GivenATreeWithSomeItems_WhenGetAllInLevelOrder_ShouldReturnAnArray()
        {
            // Arrange
            var tree = CreateTree();

            // Act
            var values = tree.GetAll(MyTree.TraversingMethod.LevelOrder);

            // Assert
            values.Should().BeEquivalentTo(new int[] { 20, 10, 30, 6, 14, 24, 3, 8, 26 });
        }

        private MyTree CreateTree()
        {
            var tree = new MyTree();
            tree.Insert(new int[] { 20, 10, 30, 6, 14, 24, 3, 8, 26 });

            return tree;
        }
    }
}
