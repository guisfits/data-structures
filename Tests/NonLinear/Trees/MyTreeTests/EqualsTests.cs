using DataStructures.Trees;
using FluentAssertions;
using Xunit;

namespace DataStructures.Tests.Trees.MyTreeTests
{
    public class EqualsTests
    {
        [Fact]
        public void GivenTwoTrees_WhenTheyAreIdentical_ShouldReturnTrue()
        {
            // Arrange
            var treeA = new MyTree();
            var treeB = new MyTree();
            var values = new [] { 7, 4, 9, 1, 6, 8, 10 };
            treeA.Insert(values);
            treeB.Insert(values);

            // Act
            var equal = treeA.Equals(treeB);

            // Assert
            equal.Should().BeTrue();
        }

        [Fact]
        public void GivenTwoTress_WhenTheyAreDifferent_ShouldReturnFalse()
        {
            // Arrange
            var treeA = new MyTree();
            var treeB = new MyTree();
            treeA.Insert(new [] { 7, 4, 9, 1, 6, 8, 10 });
            treeB.Insert(new [] { 7, 4, 9, 2, 6, 8, 10 });

            // Act
            var equal = treeA.Equals(treeB);

            // Assert
            equal.Should().BeFalse();
        }
    }
}
