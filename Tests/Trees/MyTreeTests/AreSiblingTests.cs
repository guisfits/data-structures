using DataStructures.Trees;
using FluentAssertions;
using Xunit;

namespace DataStructures.Tests.Trees.MyTreeTests
{
    public class AreSiblingTests
    {
        [Fact]
        public void GivenATree_WhenHaveItemsThatAreSiblings_ShouldReturnTrue()
        {
            // Arrange
            var tree = new MyTree();
            tree.Insert(new int[] { 20, 11, 30 });

            // Act
            var areSibling = tree.AreSibling(11, 30);

            // Assert
            areSibling.Should().BeTrue();
        }

        [Fact]
        public void GivenATree_WhenDoNotHaveItemsThatAreSibling_ShouldReturnFalse()
        {
            // Arrange
            var tree = new MyTree();
            tree.Insert(new int[] { 20, 11, 30 });

            // Act
            var areSibling = tree.AreSibling(20, 11);

            // Assert
            areSibling.Should().BeFalse();
        }
    }
}
