using DataStructures.Trees;
using FluentAssertions;
using Xunit;

namespace DataStructures.Tests.Trees.MyTreeTests
{
    public class GetValuesAtDistanceTests
    {
        [Theory]
        [InlineData(0, new int[] { 20 })]
        [InlineData(1, new int[] { 10, 30 })]
        [InlineData(2, new int[] { 6, 14, 24})]
        public void GivenATree_WhenHaveSomeItems_ShouldReturnListOfIntInTheDistanceLevel(int distance, int[] expectedValues)
        {
            // Arrange
            var tree = new MyTree();
            tree.Insert(new int[] { 20, 10, 30, 6, 14, 24, 3, 8, 26 });

            // Act
            var values = tree.GetValuesAtDistance(distance);

            // Assert
            values.Should().BeEquivalentTo(expectedValues);
        }
    }
}
