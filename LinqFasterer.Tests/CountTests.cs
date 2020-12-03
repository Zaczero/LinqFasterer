using System.Collections.Generic;
using System.Linq;
using LinqFasterer.Shared;
using Xunit;

namespace LinqFasterer.Tests
{
    public partial class Test
    {
        [Theory]
        [Trait(nameof(LinqFasterer.CountF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 5, 0, 100, MemberType = typeof(Utilities))]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 50, 0, 2, MemberType = typeof(Utilities))]
        public void CountTest_Int(IList<int> source)
        {
            var (first, second) = Utilities.SplitArray(source, source.Count - 1);

            var expected = first.Count(v => v == second[0]);
            var actual = first.CountF(v => v == second[0]);

            Assert.Equal(expected, actual);
        }
    }
}