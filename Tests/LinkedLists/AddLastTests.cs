using DataStructure.Tests.LinkedLists;
using FluentAssertions;
using Xunit;

namespace DataStructures.Tests.LinkedLists
{
    public class AddLastTests : Base
    {
        [Fact]
        public void GivenAValue_WhenTheListIsEmpty_ShouldFirstAndLastHaveTheSameValue()
        {
            // Arrange
            var list = CreateSequentialIntList(1);

            // Assert
            list.GetFirst().Should().NotBeNull().And.Be(1);
            list.GetLast().Should().NotBeNull().And.Be(1);
        }

        [Fact]
        public void GivenSomeValues_WhenListContainMoreThanOneItem_ShouldHaveAExpecificValueOnTheBegining()
        {
            // Arrange
            var list = CreateSequentialIntList(3);

            // Assert
            list.GetFirst().Should().Be(1);
            list.GetLast().Should().NotBe(1);
        }
    }
}
