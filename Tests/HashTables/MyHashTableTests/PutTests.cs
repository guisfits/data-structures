using DataStructures.HashTables;
using FluentAssertions;
using Xunit;

namespace DataStructures.Tests.HashTables.MyHashTableTests
{
    public class PutTests
    {
        [Fact]
        public void GivenAnEntry_WhenNotContainAEntryWithSameKey_ShouldAddTheEntryInArray()
        {
            // Arrange
            var table = new MyHashTable<int, string>();

            // Act
            table.Put(1, "Guilherme");

            // Assert
            table.Get(1).Should().Be("Guilherme");
        }

        [Fact]
        public void GivenAnEntry_WhenAlreadyContainAEntryWithSameKey_ShouldUpdateTheValue()
        {
            // Arrange
            var table = new MyHashTable<int, string>();
            table.Put(1, "Juliana");

            // Act
            table.Put(1, "Guilherme");

            // Assert
            table.Get(1).Should().Be("Guilherme");
        }

        [Fact]
        public void GivenTwoEntries_WhenBothHaveSameIndex_ShouldStoreBothInLinkedList()
        {
            // Arrange
            var table = new MyHashTable<int, string>();

            // Act
            table.Put(5, "a");
            table.Put(500, "b");

            // Assert
            table.Get(5).Should().Be("a");
            table.Get(500).Should().Be("b");
        }
    }
}
