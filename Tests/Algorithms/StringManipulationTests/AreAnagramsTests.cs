using DataStructures.Algorithms;
using FluentAssertions;
using Xunit;

namespace Tests.Algorithms.StringManipulationTests
{
    public class AreAnagramsTests
    {
        [Theory]
        [InlineData("ABCD", "BCDA")]
        [InlineData("0093", "0390")]
        [InlineData("LKLK", "KKLL")]
        public void GivenTwoStrings_WhenTheyAreAnagram_ShouldReturnTrue(string str1, string str2)
        {
            // Act
            var isAnagram = StringManipulation.AreAnagrams(str1, str2);

            // Assert
            isAnagram.Should().BeTrue();
        }

        [Theory]
        [InlineData("asdf", "asd")]
        [InlineData("qwert", "poiuy")]
        [InlineData("POI", "poi")]
        [InlineData("mko", "mkol")]
        public void GivenTwoWords_WhenTheyAreNotAnagrams_ShouldReturnFalse(string a, string b)
        {
            // Act
            var areAnagrams = StringManipulation.AreAnagrams(a, b);

            // Assert
            areAnagrams.Should().BeFalse();
        }

        [Fact]
        public void GivenNull_ShouldReturnFalse()
        {
            // Arrange
            string str1 = "ABC";
            string str2 = null;

            // Act
            var isAnagram = StringManipulation.AreAnagrams(str1, str2);

            // Assert
            isAnagram.Should().BeFalse();
        }

        [Theory]
        [InlineData("", "qwerty")]
        [InlineData("asdf", "")]
        [InlineData("", "")]
        public void GivenWhiteSpace_ShouldReturnNull(string str1, string str2)
        {
            // Act
            var areAnagrams = StringManipulation.AreAnagrams(str1, str2);

            // Assert
            areAnagrams.Should().BeFalse();
        }
    }
}
