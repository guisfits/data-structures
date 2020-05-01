using DataStructures.Algorithms;
using FluentAssertions;
using Xunit;

namespace Tests.Algorithms.StringManipulationTests
{
    public class IsPalindromeTests
    {
        [Theory]
        [InlineData("QWWQ")]
        [InlineData("asdfdsa")]
        [InlineData("ovo")]
        [InlineData("asa")]
        public void GivenAWord_WhenIsPalindrome_ShouldReturnTrue(string str)
        {
            // Act
            var isPalindrome = StringManipulation.IsPalindrome(str);

            // Assert
            isPalindrome.Should().BeTrue();
        }

        [Theory]
        [InlineData("qwerty")]
        [InlineData("ASDF")]
        [InlineData("AsbcsA")]
        public void GivenAWord_WhenIsNotPalindrome_ShouldReturnFalse(string str)
        {
            // Act
            var isPalindrome = StringManipulation.IsPalindrome(str);

            // Assert
            isPalindrome.Should().BeFalse();
        }

        [Fact]
        public void GivenNull_ShouldReturnFalse()
        {
            // Act
            var isPalindrome = StringManipulation.IsPalindrome(null);

            // Assert
            isPalindrome.Should().BeFalse();
        }

        [Fact]
        public void GivenAWhiteSpace_ShouldReturnFalse()
        {
            // Act
            var isPalindrome = StringManipulation.IsPalindrome("");

            // Assert
            isPalindrome.Should().BeFalse();
        }
    }
}
