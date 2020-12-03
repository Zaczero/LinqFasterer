using System.Collections.Generic;
using System.Linq;
using LinqFasterer.Shared;
using Xunit;

namespace LinqFasterer.Tests
{
    public partial class Test
    {
        [Theory]
        [Trait(nameof(EnumerableF.ZipF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 5, 0, 100, MemberType = typeof(Utilities))]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 10, 0, 2, MemberType = typeof(Utilities))]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 50, 0, 5, MemberType = typeof(Utilities))]
        public void ZipTest_Int(IList<int> source)
        {
            var (first, second) = Utilities.SplitArray(source, source.Count / 2);

            var expected = first.Zip(second).ToArray();
            var actual = first.ZipF(second).ToArrayF();

            Assert.Equal(expected, actual);
        }

        [Theory]
        [Trait(nameof(EnumerableF.ZipF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 5, 0, 100, MemberType = typeof(Utilities))]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 10, 0, 2, MemberType = typeof(Utilities))]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 50, 0, 5, MemberType = typeof(Utilities))]
        public void ZipTest_IntSelector(IList<int> source)
        {
            var (first, second) = Utilities.SplitArray(source, source.Count / 2);

            var expected = first.Zip(second, (l, r) => l * r).ToArray();
            var actual = first.ZipF(second, (l, r) => l * r).ToArrayF();

            Assert.Equal(expected, actual);
        }
    }
}