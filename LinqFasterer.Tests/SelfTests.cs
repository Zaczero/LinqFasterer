using LinqFasterer.Shared;
using Xunit;

namespace LinqFasterer.Tests
{
    public partial class Test
    {
        [Theory]
        [Trait(nameof(Utilities.SplitArray), "Internal")]
        [InlineData(new [] {1,2,3,4,5}, -1, new int[0], new [] {1,2,3,4,5})]
        [InlineData(new [] {1,2,3,4,5}, 0, new int[0], new [] {1,2,3,4,5})]
        [InlineData(new [] {1,2,3,4,5}, 2, new [] {1,2}, new [] {3,4,5})]
        [InlineData(new [] {1,2,3,4,5}, 3, new [] {1,2,3}, new [] {4,5})]
        [InlineData(new [] {1,2,3,4,5}, 99, new []{ 1,2,3,4,5}, new int[0])]
        public void SplitArrayTest(int[] source, int splitSize, int[] firstExpected, int[] secondExpected)
        {
            var (first, second) = Utilities.SplitArray(source, splitSize);

            Assert.Equal(first, firstExpected);
            Assert.Equal(second, secondExpected);
        }
    }
}