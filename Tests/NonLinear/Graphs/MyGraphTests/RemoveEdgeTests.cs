using DataStructures.Graphs;
using FluentAssertions;
using Xunit;

namespace Tests.Graphs.MyGraphTests
{
    public class RemoveEdgeTests
    {
        [Fact]
        public void GivenTwoKeys_WhenGraphHaveTheseNodesAndTheyHaveRelationship_ShouldRemoveTheRelationship()
        {
            // Arrange
            var graph = new MyGraph<string>();
            graph.AddNode("node1");
            graph.AddNode("node2");
            graph.AddEdge("node1", "node2");

            // Act
            graph.RemoveEdge("node1", "node2");

            // Assert
            foreach(var item in graph.GetAll())
            {
                item.Value.Should().BeEmpty();
            }
        }
    }
}
