using DataStructures.Trees;
using FluentAssertions;
using Xunit;

namespace DataStructures.Tests.Trees.MyTreeTests
{
    public class ContainsTests
    {
        [Fact]
        public void GivenATreeWithSomeItems_WhenTryToFindAItemThatExists_ShouldReturnTrue()
        {
            // Arrange
            var tree = new MyTree();
            tree.Insert(10);
            tree.Insert(12);
            tree.Insert(9);

            // Act
            var contains10 = tree.Contains(10);
            var contains12 = tree.Contains(12);
            var contains9 = tree.Contains(9);

            // Assert
            contains10.Should().BeTrue();
            contains12.Should().BeTrue();
            contains9.Should().BeTrue();
        }

        [Fact]
        public void GivenATreeWithSomeItems_WhenTryToFindAItemThatNotExists_ShouldReturnFalse()
        {
            // Arrange
            var tree = new MyTree();
            tree.Insert(10);
            tree.Insert(12);
            tree.Insert(9);

            // Act
            var contains11 = tree.Contains(11);
            var contains13 = tree.Contains(13);
            var contains8 = tree.Contains(8);

            // Assert
            contains11.Should().BeFalse();
            contains13.Should().BeFalse();
            contains8.Should().BeFalse();
        }

        [Fact]
        public void GivenAnEmptyTree_WhenTryToFindAItem_ShouldReturnFalse()
        {
            // Arrange
            var tree = new MyTree();

            // Act
            var contains = tree.Contains(1);

            // Assert
            contains.Should().BeFalse();
        }
    }
}
