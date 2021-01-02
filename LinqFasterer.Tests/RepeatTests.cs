using System.Collections.Generic;
using System.Linq;
using LinqFasterer.Shared;
using Xunit;

namespace LinqFasterer.Tests
{
    public partial class Test
    {
        [Theory]
        [Trait(nameof(EnumerableF.RepeatF), null)]
        [InlineData(new int[0])]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 5, 0, 100, MemberType = typeof(Utilities))]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 10, 0, 2, MemberType = typeof(Utilities))]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 50, 0, 5, MemberType = typeof(Utilities))]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 5000, 0, 100, MemberType = typeof(Utilities))]
        public void RepeatTest_Int(IList<int> source)
        {
            var expected = Enumerable.Repeat(source.FirstOrDefault(), source.Count).ToArray();
            var actual = EnumerableF.RepeatF(source.FirstOrDefault(), source.Count).ToArrayF();

            Assert.Equal(expected, actual);
        }
        
        [Theory]
        [Trait(nameof(EnumerableF.RepeatSequenceF), null)]
        [InlineData(new[] {1, 2, 3, 1, 2, 3}, new [] {1, 2, 3}, 2)]
        [InlineData(new[] {1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3}, new [] {1, 2, 3}, 4)]
        [InlineData(new[] {1, 1, 1, 1, 1}, new [] {1}, 5)]
        [InlineData(new int[0], new [] {1}, 0)]
        [InlineData(new int[0], new int[0], 5)]
        [InlineData(new[] {1}, new [] {1}, 1)]
        public void RepeatSequenceTest_Int(int[] expected, int[] source, int count)
        {
            var actual = EnumerableF.RepeatSequenceF(source, count).ToArrayF();

            Assert.Equal(expected, actual);
        }
    }
}