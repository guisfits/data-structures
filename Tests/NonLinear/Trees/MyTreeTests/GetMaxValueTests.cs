using DataStructures.Trees;
using FluentAssertions;
using Xunit;

namespace DataStructures.Tests.Trees.MyTreeTests
{
    public class GetMaxValueTests
    {
        [Fact]
        public void GivenATree_WhenHaveSomeItems_ShouldReturnMaxValue()
        {
            // Arrange
            var tree = new MyTree();
            tree.Insert(new int[] { 20, 10, 30, 6, 14, 24, 3, 8, 26 });

            // Act
            var max = tree.GetMaxValue();

            // Assert
            max.Should().Be(30);
        }
    }
}
