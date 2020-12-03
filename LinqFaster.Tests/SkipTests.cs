using System.Collections.Generic;
using System.Linq;
using LinqFasterer.Shared;
using Xunit;

namespace LinqFasterer.Tests
{
    public partial class Test
    {
        [Theory]
        [Trait(nameof(LinqFasterer.SkipF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 15, 0, 5, MemberType = typeof(Utilities))]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 15, 0, 100, MemberType = typeof(Utilities))]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 15, -5, -1, MemberType = typeof(Utilities))]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 15, 50, 100, MemberType = typeof(Utilities))]
        public void SkipTest_Int(IList<int> source)
        {
            foreach (var i in source)
            {
                var expected = source.Skip(i).ToArray();
                var actual = source.SkipF(i, true).ToArrayF();

                Assert.Equal(expected, actual);
            }
        }

        [Theory]
        [Trait(nameof(LinqFasterer.SkipLastF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 15, 0, 5, MemberType = typeof(Utilities))]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 15, 0, 100, MemberType = typeof(Utilities))]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 15, -5, -1, MemberType = typeof(Utilities))]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 15, 50, 100, MemberType = typeof(Utilities))]
        public void SkipLastTest_Int(IList<int> source)
        {
            foreach (var i in source)
            {
                var expected = source.SkipLast(i).ToArray();
                var actual = source.SkipLastF(i, true).ToArrayF();

                Assert.Equal(expected, actual);
            }
        }

        [Theory]
        [Trait(nameof(LinqFasterer.SkipWhileF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 15, 0, 5, MemberType = typeof(Utilities))]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 15, 0, 100, MemberType = typeof(Utilities))]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 15, -5, -1, MemberType = typeof(Utilities))]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 15, 50, 100, MemberType = typeof(Utilities))]
        public void SkipWhileTest_Int(IList<int> source)
        {
            var expected = source.SkipWhile(v => v > 2).ToArray();
            var actual = source.SkipWhileF(v => v > 2, true).ToArrayF();
            var actualIndexed = source.SkipWhileF((v, i) => v > 2, true).ToArrayF();

            Assert.Equal(expected, actual);
            Assert.Equal(expected, actualIndexed);
        }
    }
}