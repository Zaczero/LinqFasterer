using System.Collections.Generic;
using Xunit;

namespace LinqFasterer.Tests
{
    public partial class Test
    {
        [Theory]
        [Trait(nameof(EnumerableF.BinarySearchF), null)]
        [InlineData(1, new [] {5,6,7,8,9}, 6)]
        [InlineData(2, new [] {5,6,7,8,9}, 7)]
        [InlineData(~0, new [] {5,6,7,8,9}, 0)]
        [InlineData(~0, new [] {5,6,7,8,9}, 4)]
        [InlineData(~5, new [] {5,6,7,8,9}, 10)]
        [InlineData(~2, new [] {5,6,8,9}, 7)]
        public void BinarySearchTest_Int(int expected, int[] source, int value)
        {
            var actual = source.BinarySearchF(value, Comparer<int>.Default);

            Assert.Equal(expected, actual);
        }
        
        [Theory]
        [Trait(nameof(EnumerableF.BinarySearchF), null)]
        [InlineData(1, new [] {5,6,7,8,9}, 0, 2, 6)]
        [InlineData(1, new [] {5,6,7,8,9}, 1, 1, 6)]
        [InlineData(~1, new [] {5,6,7,8,9}, 1, 0, 6)]
        [InlineData(~2, new [] {5,6,7,8,9}, 0, 2, 7)]
        public void BinarySearchTest_IntIndexed(int expected, int[] source, int index, int length, int value)
        {
            var actual = source.BinarySearchF(index, length, value, Comparer<int>.Default);

            Assert.Equal(expected, actual);
        }
    }
}