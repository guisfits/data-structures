using DataStructures.Trees;
using FluentAssertions;
using Xunit;

namespace DataStructures.Tests.Trees.MyTreeTests
{
    public class InsertTests
    {
        [Fact]
        public void GivenAnValue_WhenTreeIsEmpty_ShouldInsertThisValueOneRoot()
        {
            // Arrange
            var tree = new MyTree();

            // Act
            tree.Insert(10);

            // Assert
            tree.Contains(10).Should().BeTrue();
        }

        [Fact]
        public void GivenAValue_WhenTreeAlreadyHaveItems_ShouldFindANodeAndInsertTheNewValue()
        {
            // Arrange
            var tree = new MyTree();
            tree.Insert(10);
            tree.Insert(7);
            tree.Insert(5);
            tree.Insert(15);

            // Act
            tree.Insert(20);

            // Assert
            tree.Contains(20).Should().BeTrue();
        }

    }
}
