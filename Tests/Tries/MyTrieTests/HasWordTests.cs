using DataStructures.Tries;
using FluentAssertions;
using Xunit;

namespace Tests.Tries.MyTrieTests
{
    public class HasWordTests
    {
        [Fact]
        public void GivenATrie_WhenTryToFindAInexistentWord_ShouldReturnFalse()
        {
            // Arrange
            var word = "cat";
            var search = "dog";
            var trie = new MyTrie();

            // Act
            trie.Insert(word);

            // Assert
            trie.HasWord(search).Should().BeFalse();
        }

        [Fact]
        public void GivenAEmptyTrie_WhenTryToFindAWord_ShouldReturnFalse()
        {
            // Arrange
            var trie = new MyTrie();

            // Assert
            trie.HasWord("test").Should().BeFalse();
        }

        [Fact]
        public void GivenAWord_WhenIsPartOfAnotherWord_ShouldReturnFalse()
        {
            // Arrange
            var word = "Canada";
            var search = "Can";
            var trie = new MyTrie();

            // Act
            trie.Insert(word);

            // Assert
            trie.HasWord(search).Should().BeFalse();
        }

        [Fact]
        public void GivenNull_WhenTrieIsEmpty_ShouldReturnFalse()
        {
            // Arrange
            var trie = new MyTrie();

            // Assert
            trie.HasWord(null).Should().BeFalse();
        }

        [Fact]
        public void GivenAnEmptyString_WhenTrieIsEmpty_ShouldReturnFalse()
        {
            // Arrange
            var trie = new MyTrie();

            // Assert
            trie.HasWord("").Should().BeFalse();
        }
    }
}
