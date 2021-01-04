using Xunit;

namespace LinqFasterer.Tests
{
    public partial class Test
    {
        [Theory]
        [Trait(nameof(EnumerableF.ClearF), null)]
        [InlineData(new [] {0,0,0,0,0}, new [] {1,1,1,1,1})]
        public void ClearTest_Int(int[] expected, int[] source)
        {
            var actual = source.ClearF();

            Assert.Equal(expected, actual);
        }
        
        [Theory]
        [Trait(nameof(EnumerableF.ClearF), null)]
        [InlineData(new [] {1,1,1,1,1}, new [] {1,1,1,1,1}, 1, 0)]
        [InlineData(new [] {1,0,0,0,1}, new [] {1,1,1,1,1}, 1, 3)]
        [InlineData(new [] {0,1,1,1,1}, new [] {1,1,1,1,1}, 0, 1)]
        [InlineData(new [] {0,1,1,1,1}, new [] {1,1,1,1,1}, -1, 2)]
        [InlineData(new [] {1,1,1,1,1}, new [] {1,1,1,1,1}, -2, 2)]
        [InlineData(new [] {1,1,1,1,0}, new [] {1,1,1,1,1}, 4, 2)]
        [InlineData(new [] {1,1,1,1,1}, new [] {1,1,1,1,1}, 5, 2)]
        [InlineData(new [] {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}, new [] {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1}, 0, 40)]
        public void ClearTest_IntIndexed(int[] expected, int[] source, int index, int length)
        {
            var actual = source.ClearF(index, length);

            Assert.Equal(expected, actual);
        }
    }
}