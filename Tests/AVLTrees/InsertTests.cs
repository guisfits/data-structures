using DataStructures.AVLTrees;
using FluentAssertions;
using Xunit;

namespace DataStructures.Tests.AVLTrees
{
    public class InsertTests
    {
        [Fact]
        public void GivenFourValues_WhenTreeIsEmpty_ShouldAddThisValuesOnTree()
        {
            // Arrange
            var tree = new MyAVLTree();

            // Act
            tree.Insert(20);
            tree.Insert(10);
            tree.Insert(30);
            tree.Insert(21);

            // Assert
            tree.Contains(20).Should().BeTrue();
            tree.Contains(10).Should().BeTrue();
            tree.Contains(30).Should().BeTrue();
            tree.Contains(21).Should().BeTrue();
        }
    }
}
