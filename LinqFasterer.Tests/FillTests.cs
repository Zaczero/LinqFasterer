using Xunit;

namespace LinqFasterer.Tests
{
    public partial class Test
    {
        [Theory]
        [Trait(nameof(EnumerableF.FillF), null)]
        [InlineData(new [] {0,0,0,0,0}, new [] {1,1,1,1,1}, 0)]
        public void FillTest_Int(int[] expected, int[] source, int value)
        {
            var actual = source.FillF(value);

            Assert.Equal(expected, actual);
        }
        
        [Theory]
        [Trait(nameof(EnumerableF.FillF), null)]
        [InlineData(new [] {1,1,1,1,1}, new [] {1,1,1,1,1}, 0, 1, 0)]
        [InlineData(new [] {1,0,0,0,1}, new [] {1,1,1,1,1}, 0, 1, 3)]
        [InlineData(new [] {0,1,1,1,1}, new [] {1,1,1,1,1}, 0, 0, 1)]
        [InlineData(new [] {0,1,1,1,1}, new [] {1,1,1,1,1}, 0, -1, 2)]
        [InlineData(new [] {1,1,1,1,1}, new [] {1,1,1,1,1}, 0, -2, 2)]
        [InlineData(new [] {1,1,1,1,0}, new [] {1,1,1,1,1}, 0, 4, 2)]
        [InlineData(new [] {1,1,1,1,1}, new [] {1,1,1,1,1}, 0, 5, 2)]
        [InlineData(new [] {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}, new [] {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1}, 0, 0, 40)]
        public void FillTest_IntIndexed(int[] expected, int[] source, int value, int index, int length)
        {
            var actual = source.FillF(value, index, length);

            Assert.Equal(expected, actual);
        }
    }
}