using System.Linq;
using DataStructures.Graphs;
using FluentAssertions;
using Xunit;

namespace Tests.Graphs.MyGraphTests
{
    public class AddNodeTests
    {
        [Fact]
        public void GivenANewKey_WhenGraphIsEmpty_ThenAddIt()
        {
            //Given
            var graph = new MyGraph<string>();

            //When
            graph.AddNode("one");

            //Then
            var values = graph.GetAll();
            values.Should().HaveCount(1);
            values.ContainsKey("one").Should().BeTrue();
        }

        [Fact]
        public void GivenMoreThanOneKey_WhenGraphIsEmpty_ShouldAddThem()
        {
            // Arrange
            var graph = new MyGraph<string>();

            // Act
            graph.AddNode("one");
            graph.AddNode("two");
            graph.AddNode("three");

            // Assert
            var values = graph.GetAll();
            values.Should().HaveCount(3);
            values.ContainsKey("one").Should().BeTrue();
            values.ContainsKey("two").Should().BeTrue();
            values.ContainsKey("three").Should().BeTrue();
        }

        [Fact]
        public void GivenAKey_WhenGraphAlreadyHaveAnNodeWithSameKey_ShouldNotAddIt()
        {
            // Arrange
            var graph = new MyGraph<string>();
            graph.AddNode("one");

            // Act
            graph.AddNode("one");

            // Assert
            graph.GetAll().Should().HaveCount(1);
        }
    }
}
