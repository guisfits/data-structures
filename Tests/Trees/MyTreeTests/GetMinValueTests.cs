using System;
using System.Linq;
using Bogus;
using DataStructures.Trees;
using FluentAssertions;
using Xunit;

namespace DataStructures.Tests.Trees.MyTreeTests
{
    public class GetMinValueTests
    {
        private static Faker _faker = new Faker();

        [Fact]
        public void GivenATree_WhenHaveSomeItems_ShouldReturnTheMinValue()
        {
            // Arrange
            var tree = new MyTree();
            var values = GetRandomValues(100);
            tree.Insert(values);

            // Act
            var min = tree.GetMinValue();

            // Assert
            min.Should().Be(values.Min());
        }

        [Fact]
        public void GivenATree_WhenIsEmpty_ShouldThrowAnException()
        {
            // Arrange
            var tree = new MyTree();

            // Act // Assert
            Assert.Throws<InvalidOperationException>(() => tree.GetMinValue());
        }

        private int[] GetRandomValues(int qtd)
        {
            var array = new int[qtd];
            for (int i = 0; i < qtd; i++)
                array[i] = _faker.Random.Int(0, qtd * 2);

            return array;
        }
    }
}
