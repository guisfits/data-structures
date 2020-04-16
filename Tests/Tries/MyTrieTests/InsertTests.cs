using DataStructures.Tries;
using FluentAssertions;
using Xunit;

namespace Tests.Tries.MyTrieTests
{
    public class InsertTests
    {
        [Fact]
        public void GivenAWord_WhenTrieIsEmpty_ShouldAddIt()
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
        public void GivenTwoWords_WhenTheyCross_ShouldContainsBoth()
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
        public void GivenTwoWords_WhenTheyAreDistinct_ShouldContainsBoth()
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
    }
}
