using DataStructures.Stacks;
using FluentAssertions;
using Xunit;

namespace DataStructures.Tests.Stacks.ExercisesTests
{
    public class IsExpressionIsBalancedTests
    {
        [Theory]
        [InlineData("1 + 2")]
        [InlineData("(1 + 2)")]
        [InlineData("[a / b]")]
        [InlineData("{!a * p}")]
        [InlineData("<0 - 0>")]
        [InlineData("((0 - 0))")]
        [InlineData("{(0 - 0)}")]
        [InlineData("<{(0 - 0)}[a]>")]
        public void GivenAValidExpression_ShouldReturnTrue(string expression)
        {
            // Act
            var result = Exercises.IsExpressionIsBalanced(expression);

            // Assert
            result.Should().BeTrue();
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData("(1 + 2")]
        [InlineData("(1 + 2]")]
        [InlineData("<<1 + 2>")]
        [InlineData("(1 + 2(")]
        [InlineData("]1 + 2]")]
        [InlineData(">1 + 2<")]
        public void GivenAnInvalidExpression_ShouldReturnFalse(string expression)
        {
            // Act
            var result = Exercises.IsExpressionIsBalanced(expression);

            // Assert
            result.Should().BeFalse();
        }
    }
}
