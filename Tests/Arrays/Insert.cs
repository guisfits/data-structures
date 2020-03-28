using DataStructures;
using FluentAssertions;
using Xunit;

namespace DataStructures.Tests.Arrays
{
    public class Insert
    {
        [Fact]
        public void GivenAValue_WhenMyArrayListIsInitialized_ShouldInsertIntoInternalList()
        {
            var array = new MyArrayList(1);
            array.Insert(1);
            array.ToArray().Should().ContainSingle().And.ContainEquivalentOf(1);
        }
    }
}
