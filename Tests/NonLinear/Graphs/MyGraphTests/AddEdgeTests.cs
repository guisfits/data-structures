using System.Collections.Generic;
using DataStructures.Graphs;
using FluentAssertions;
using Xunit;

namespace Tests.Graphs.MyGraphTests
{
    public class AddEdgeTests
    {
        [Fact]
        public void GivenTwoKeys_WhenGraphHaveThisNodesAndTheyDoNotHaveRelationship_ShouldConnectThisTwoNodes()
        {
            // Arrange
            var graph = new MyGraph<string>();
            graph.AddNode("one");
            graph.AddNode("two");

            // Act
            graph.AddEdge("one", "two");

            // Assert
            var values = graph.GetAll();
            values.GetValue("one").Should().ContainSingle("two");
        }
    }
}
