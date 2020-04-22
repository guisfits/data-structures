using DataStructures.Graphs;
using FluentAssertions;
using Xunit;

namespace Tests.Graphs.MyGraphTests
{
    public class HasCycleTests
    {
        [Fact]
        public void GivenAGraph_WhenNodesHaveCycle_ShouldReturnTrue()
        {
            // Arrange
            var graph = new MyGraph<string>();
            graph.AddNode("A");
            graph.AddNode("B");
            graph.AddNode("C");

            graph.AddEdge("A", "B");
            graph.AddEdge("B", "C");
            graph.AddEdge("C", "A");

            // Act
            var hasCycle = graph.HasCycle();

            // Assert
            hasCycle.Should().BeTrue();
        }
    }
}
