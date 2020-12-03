using System.Collections.Generic;
using System.Linq;
using LinqFasterer.Shared;
using Xunit;

namespace LinqFasterer.Tests
{
    public partial class Test
    {
        [Theory]
        [Trait(nameof(EnumerableF.OrderByF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 5, 0, 100, MemberType = typeof(Utilities))]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 10, 0, 2, MemberType = typeof(Utilities))]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 50, 0, 5, MemberType = typeof(Utilities))]
        public void OrderByTest_Int(IList<int> source)
        {
            var expected = source.OrderBy(v => v).ToArray();
            var actual = source.OrderByF(v => v).ToArrayF();

            Assert.Equal(expected, actual);
        }

        [Theory]
        [Trait(nameof(EnumerableF.OrderByDescendingF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 5, 0, 100, MemberType = typeof(Utilities))]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 10, 0, 2, MemberType = typeof(Utilities))]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 50, 0, 5, MemberType = typeof(Utilities))]
        public void OrderByDescendingTest_Int(IList<int> source)
        {
            var expected = source.OrderByDescending(v => v).ToArray();
            var actual = source.OrderByDescendingF(v => v).ToArrayF();

            Assert.Equal(expected, actual);
        }
    }
}