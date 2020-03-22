using DataStructure.Tests.LinkedLists;
using DataStructures.LinkedLists;
using FluentAssertions;
using Xunit;

namespace DataStructures.Tests.LinkedLists
{
    public class AddFirstTests : Base
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
        public void GivenSomeValues_WhenListContainMoreThanOneItem_ShouldHaveAExpecificValueOnTheEnd()
        {
            // Arrange
            var list = CreateSequentialIntList(3);

            // Assert
            list.GetLast().Should().Be(3);
            list.GetFirst().Should().NotBe(3);
        }

    }
}
