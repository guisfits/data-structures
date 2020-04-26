using DataStructures;
using FluentAssertions;
using Xunit;
using System.Collections.Generic;

namespace Tests.WeightedGraphTests
{
    public class AddEdgesTests
    {
        [Fact]
        public void GivenTwoKeys_WhenBothExists_ShouldAddRelationship()
        {
            // Arrange
            var graph = new WeightedGraph<string>();
            graph.AddNode("test1");
            graph.AddNode("test2");
            graph.AddEdge("test1", "test2", 10);

            // Act
            var values = graph.GetAll();

            // Assert
            values.Should().NotBeNull().And.HaveCount(2);
            values.GetValueOrDefault("test1").Should().ContainSingle("test2");
            values.GetValueOrDefault("test2").Should().ContainSingle("test1");
        }
    }
}
