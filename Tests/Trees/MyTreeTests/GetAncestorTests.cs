using DataStructures.Trees;
using FluentAssertions;
using Xunit;

namespace DataStructures.Tests.Trees.MyTreeTests
{
    public class GetAncestorTests
    {
        [Fact]
        public void GivenATree_WhenNodeHaveValueOnHisTree_ShouldReturnValueOfThisNode()
        {
            // Arrange
            var tree = new MyTree();
            tree.Insert(new int[] { 20, 11, 30 });

            // Act
            var value = tree.GetAncestor(11);

            // Assert
            value.Should().Be(20);
        }

        [Fact]
        public void GivenATree_WhenNodeDoNotHaveValueOnHisTree_ShouldReturnValueOfThisNode()
        {
            // Arrange
            var tree = new MyTree();
            tree.Insert(new int[] { 20, 11, 30 });

            // Act
            var value = tree.GetAncestor(20);

            // Assert
            value.Should().BeNull();
        }
    }
}
