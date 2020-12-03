using System.Linq;
using Xunit;

namespace LinqFasterer.Tests
{
    public partial class Test
    {
        [Fact]
        [Trait(nameof(LinqFasterer.RangeF), null)]
        public void RangeTest_Int()
        {
            var expected = Enumerable.Range(5, 100).ToArray();
            var actual = LinqFasterer.RangeF(5, 100).ToArrayF();

            Assert.Equal(expected, actual);
        }

        [Theory]
        [Trait(nameof(LinqFasterer.RangeF), null)]
        [InlineData(new[] {1, 0, -1, -2, -3}, 1, 5, -1)]
        [InlineData(new[] {1, 1, 1, 1, 1}, 1, 5, 0)]
        [InlineData(new[] {1, 3, 5, 7, 9}, 1, 5, 2)]
        public void RangeTest_IntChange(int[] expected, int start, int count, int change)
        {
            Assert.Equal(expected, LinqFasterer.RangeF(start, count, change));
        }

        [Theory]
        [Trait(nameof(LinqFasterer.RangeF), null)]
        [InlineData(new long[] {1, 0, -1, -2, -3}, 1, 5, -1)]
        [InlineData(new long[] {1, 1, 1, 1, 1}, 1, 5, 0)]
        [InlineData(new long[] {1, 3, 5, 7, 9}, 1, 5, 2)]
        public void RangeTest_LongChange(long[] expected, long start, int count, long change)
        {
            Assert.Equal(expected, LinqFasterer.RangeF(start, count, change));
        }

        [Theory]
        [Trait(nameof(LinqFasterer.RangeF), null)]
        [InlineData(new float[] {1, 0, -1, -2, -3}, 1, 5, -1)]
        [InlineData(new float[] {1, 1, 1, 1, 1}, 1, 5, 0)]
        [InlineData(new float[] {1, 2.5f, 4, 5.5f, 7}, 1, 5, 1.5)]
        public void RangeTest_FloatChange(float[] expected, float start, int count, float change)
        {
            Assert.Equal(expected, LinqFasterer.RangeF(start, count, change));
        }

        [Theory]
        [Trait(nameof(LinqFasterer.RangeF), null)]
        [InlineData(new double[] {1, 0, -1, -2, -3}, 1, 5, -1)]
        [InlineData(new double[] {1, 1, 1, 1, 1}, 1, 5, 0)]
        [InlineData(new double[] {1, 2.5, 4, 5.5, 7}, 1, 5, 1.5)]
        public void RangeTest_DoubleChange(double[] expected, double start, int count, double change)
        {
            Assert.Equal(expected, LinqFasterer.RangeF(start, count, change));
        }

        [Theory]
        [Trait(nameof(LinqFasterer.RangeF), null)]
        [InlineData(new double[] {1, 0, -1, -2, -3}, 1, 5, -1)]
        [InlineData(new double[] {1, 1, 1, 1, 1}, 1, 5, 0)]
        [InlineData(new double[] {1, 2.5, 4, 5.5, 7}, 1, 5, 1.5)]
        public void RangeTest_DecimalChange(double[] expected, decimal start, int count, decimal change)
        {
            Assert.Equal(expected, LinqFasterer.RangeF(start, count, change).SelectF(v => (double) v));
        }
    }
}