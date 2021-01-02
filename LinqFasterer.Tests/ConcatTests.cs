using System.Collections.Generic;
using System.Linq;
using LinqFasterer.Shared;
using Xunit;

namespace LinqFasterer.Tests
{
    public partial class Test
    {
        [Theory]
        [Trait(nameof(EnumerableF.ConcatF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 5, 0, 100, MemberType = typeof(Utilities))]
        public void ConcatTest_Int(IList<int> source)
        {
            var (first, second) = Utilities.SplitArray(source, source.Count / 2);

            var expected = first.Concat(second).ToArray();
            var actual = first.ConcatF(second).ToArrayF();

            Assert.Equal(expected, actual);
        }
        
        [Theory]
        [Trait(nameof(EnumerableF.ConcatMultipleF), null)]
        [InlineData(new[] {3, 3, 3, 2, 2, 1, 1, 1}, new [] {3, 3, 3}, new [] {2, 2}, new [] {1, 1, 1,})]
        [InlineData(new[] {3, 3, 3, 1, 1, 1}, new [] {3, 3, 3}, new int[0], new [] {1, 1, 1,})]
        [InlineData(new[] {3, 2, 1}, new [] {3}, new [] {2}, new [] {1})]
        [InlineData(new int[0], new int[0], new int[0], new int[0])]
        public void ConcatMultipleTest_Int(int[] expected, int[] left, int[] middle, int[] right)
        {
            var actual = EnumerableF.ConcatMultipleF(left, middle, right);
            
            Assert.Equal(expected, actual);
        }
    }
}