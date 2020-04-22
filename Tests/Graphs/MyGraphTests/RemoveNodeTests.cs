using DataStructures.Graphs;
using FluentAssertions;
using Xunit;

namespace Tests.Graphs.MyGraphTests
{
    public class RemoveNodeTests
    {
        [Fact]
        public void GivenAKey_WhenGraphHaveThisKey_ShouldRemoveIt()
        {
            // Arrange
            var graph = new MyGraph<string>();
            graph.AddNode("one");

            // Act
            graph.RemoveNode("one");

            // Assert
            graph.GetAll().Should().BeEmpty();
        }

        [Fact]
        public void GivenAKey_WhenGraphDoesntHaveIt_ShouldDoNothing()
        {
            // Arrange
            var graph = new MyGraph<string>();
            graph.AddNode("one");

            // Act
            graph.RemoveNode("two");

            // Assert
            var values = graph.GetAll();
            values.Should().HaveCount(1);
            values.ContainsKey("one").Should().BeTrue();
        }
    }
}
