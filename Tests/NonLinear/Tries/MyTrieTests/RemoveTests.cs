using DataStructures.Tries;
using FluentAssertions;
using Xunit;

namespace Tests.Tries.MyTrieTests
{
    public class RemoveTests
    {
        [Fact]
        public void GivenAWord_WhenTrieHasThisOne_ShouldRemoveIt()
        {
            // Arrange
            var trie = new MyTrie();
            trie.Insert("cat");

            // Act
            trie.Remove("cat");

            // Assert
            trie.HasWord("cat").Should().BeFalse();
        }

        [Fact]
        public void GivenAWord_WhenIsHafOfAnotherWord_ShouldRemoveTheEndOfWordFlag()
        {
            // Arrange
            var trie = new MyTrie();
            trie.Insert("can");
            trie.Insert("cannon");

            // Act
            trie.Remove("can");

            // Assert
            trie.HasWord("can").Should().BeFalse();
            trie.HasWord("cannon").Should().BeTrue();
        }
    }
}
