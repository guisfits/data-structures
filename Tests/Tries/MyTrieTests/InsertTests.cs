using DataStructures.Tries;
using FluentAssertions;
using Xunit;

namespace Tests.Tries.MyTrieTests
{
    public class InsertTests
    {
        [Fact]
        public void GivenAWord_WhenTrieIsEmpty_ShouldCreateANewTree()
        {
            // Arrange
            var word = "test";
            var trie = new MyTrie();

            // Act
            trie.Insert(word);

            // Assert
            trie.HasWord(word).Should().BeTrue();
        }

        [Fact]
        public void GivenTwoWords_WhenTheyCross_ShouldTrieContainBoth()
        {
            // Arrange
            var word1 = "cat";
            var word2 = "can";
            var trie = new MyTrie();

            // Act
            trie.Insert(word1);
            trie.Insert(word2);

            // Assert
            trie.HasWord(word1).Should().BeTrue();
            trie.HasWord(word2).Should().BeTrue();
        }

        [Fact]
        public void GivenTwoWords_WhenTheyAreDistinct_ShouldContainBoth()
        {
            // Arrange
            var word1 = "cat";
            var word2 = "dog";
            var trie = new MyTrie();

            // Act
            trie.Insert(word1);
            trie.Insert(word2);

            // Assert
            trie.HasWord(word1).Should().BeTrue();
            trie.HasWord(word2).Should().BeTrue();
        }

        [Fact]
        public void GivenAWord_WhenTryToAddTwice_ShouldContainOne()
        {
            // Arrange
            var word = "test";
            var trie = new MyTrie();

            // Act
            trie.Insert(word);
            trie.Insert(word);

            // Assert
            trie.HasWord(word).Should().BeTrue();
        }

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
    }
}
