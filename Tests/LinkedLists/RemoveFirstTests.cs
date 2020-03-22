using System;
using DataStructure.Tests.LinkedLists;
using FluentAssertions;
using Xunit;

namespace Tests.LinkedLists
{
    public class RemoveFirstTests : Base
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
        public void GivenAListWithSomeItems_ShouldRemoveTheFirstItem()
        {
            // Arrange
            var list = CreateSequentialIntList(4);

            // Act
            list.RemoveFirst();

            // Assert
            list.GetFirst().Should().Be(2);
            list.GetLast().Should().Be(4);
        }
    }
}
