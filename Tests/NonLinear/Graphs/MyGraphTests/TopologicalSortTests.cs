using DataStructures.Graphs;
using FluentAssertions;
using Xunit;

namespace Tests.Graphs.MyGraphTests
{
    public class TopologicalSortTests
    {
        [Fact]
        public void GivenAGraphWithNode_WhenTheyHaveDependencyFromEachOther_ShouldTopologicalSortComThoseDependencies()
        {
            // Arrange
            var graph = new MyGraph<string>();
            graph.AddNode("P");
            graph.AddNode("A");
            graph.AddNode("B");
            graph.AddNode("X");
            graph.AddEdge("X", "B");
            graph.AddEdge("X", "A");
            graph.AddEdge("A", "P");
            graph.AddEdge("B", "P");

            // Act
            var sort = graph.TopologicalSort();

            // Assert
            sort.Should().BeEquivalentTo("X", "B", "A", "P");
        }
    }
}
