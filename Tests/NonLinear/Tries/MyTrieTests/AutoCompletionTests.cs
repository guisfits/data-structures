using DataStructures.Tries;
using FluentAssertions;
using Xunit;

namespace Tests.Tries.MyTrieTests
{
    public class AutoCompletionTests
    {
        [Fact]
        public void GivenANonCompleteWord_WhenHasSomeOtherWordsThatMatchesToBegin_ShouldReturnThoseWords()
        {
            // Arrange
            var trie = new MyTrie();
            trie.Insert("car");
            trie.Insert("card");
            trie.Insert("care");
            trie.Insert("careful");
            trie.Insert("egg");

            // Act
            var words = trie.AutoCompletion("car");

            // Assert
            words.Should().HaveCount(4).And.BeEquivalentTo("car", "card", "care", "careful");
        }
    }
}
