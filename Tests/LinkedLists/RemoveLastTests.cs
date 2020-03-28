using System;
using DataStructures.Tests.LinkedLists;
using FluentAssertions;
using Xunit;

namespace DataStructures.Tests.LinkedLists
{
    public class RemoveLastTests : Base
    {
        [Fact]
        public void GivenAEmptyList_ShouldThrowAnException()
        {
            // Arrange
            var list = CreateSequentialIntList();

            // Act / Assert
            Assert.Throws<InvalidOperationException>(() => list.RemoveFirst());
        }

        [Fact]
        public void GivenAListWithOneItem_ShouldBeCleanTheList()
        {
            // Arrange
            var list = CreateSequentialIntList(1);

            // Act
            list.RemoveFirst();

            // Assert
            list.GetFirst().Should().BeNull();
            list.GetLast().Should().BeNull();
        }

        [Fact]
        public void GivenAListWithSomeItems_ShouldRemoveLastItem()
        {
            // Arrange
            var list = CreateSequentialIntList(4);

            // Act
            list.RemoveLast();

            // Arrange
            list.GetFirst().Should().Be(1);
            list.GetLast().Should().Be(3);
        }
    }
}
