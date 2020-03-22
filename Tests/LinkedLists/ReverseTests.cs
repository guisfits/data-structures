using System;
using FluentAssertions;
using Xunit;

namespace DataStructure.Tests.LinkedLists
{
    public class ReverseTests : Base
    {
        [Fact]
        public void GivenAnEmptyList_ShouldThrowAnException()
        {
            // Arrange
            var list = CreateSequentialIntList();

            // Assert
            Assert.ThrowsAny<InvalidOperationException>(() => list.Reverse());
        }

        [Fact]
        public void GivenAListWithOneItem_ShouldDoesNothing()
        {
            // Arrange
            var list = CreateSequentialIntList(1);

            // Assert
            list.Reverse();

            // Arrange
            list.GetFirst().Should().Be(1);
            list.GetLast().Should().Be(1);
        }

        [Fact]
        public void GivenAListWithSomeItems_ShouldReverseTheOrderOfTheItems()
        {
            // Arrange
            var list = CreateSequentialIntList(3);

            // Act
            list.Reverse();

            //Assert
            list.GetFirst().Should().Be(3);
            list.GetLast().Should().Be(1);
        }
    }
}
