using System.Collections.Generic;
using System.Linq;
using LinqFasterer.Shared;
using Xunit;

namespace LinqFasterer.Tests
{
    public partial class Test
    {
        [Theory]
        [Trait(nameof(EnumerableF.SortF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 5, 0, 100, MemberType = typeof(Utilities))]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 10, 0, 2, MemberType = typeof(Utilities))]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 50, 0, 5, MemberType = typeof(Utilities))]
        public void SortTest_Int(IList<int> source)
        {
            var expected = source.OrderBy(v => v).ToArray();
            var actual = source.SortF().ToArrayF();

            Assert.Equal(expected, actual);
        }

        [Theory]
        [Trait(nameof(EnumerableF.SortDescendingF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 5, 0, 100, MemberType = typeof(Utilities))]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 10, 0, 2, MemberType = typeof(Utilities))]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 50, 0, 5, MemberType = typeof(Utilities))]
        public void SortDescendingTest_Int(IList<int> source)
        {
            var expected = source.OrderByDescending(v => v).ToArray();
            var actual = source.SortDescendingF().ToArrayF();

            Assert.Equal(expected, actual);
        }
    }
}