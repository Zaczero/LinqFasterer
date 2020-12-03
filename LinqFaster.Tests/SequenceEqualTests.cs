using System.Collections.Generic;
using System.Linq;
using LinqFasterer.Shared;
using Xunit;

namespace LinqFasterer.Tests
{
    public partial class Test
    {
        [Theory]
        [Trait(nameof(LinqFasterer.SequenceEqualF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 0, 0, 100, MemberType = typeof(Utilities))]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 4, 0, 100, MemberType = typeof(Utilities))]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 5, 0, 100, MemberType = typeof(Utilities))]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 15, 1, 2, MemberType = typeof(Utilities))]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 16, 1, 2, MemberType = typeof(Utilities))]
        public void SequenceEqualTest_Int(IList<int> source)
        {
            var (first, second) = Utilities.SplitArray(source, source.Count / 2);

            var expected = first.SequenceEqual(second);
            var actual = first.SequenceEqualF(second);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [Trait(nameof(LinqFasterer.SequenceCompareF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 5, 0, 100, MemberType = typeof(Utilities))]
        public void SequenceCompareTest_Int(IList<int> source)
        {
            var clone = new List<int>(source);
            var cloneModified = new List<int>(source) {[0] = -1};

            var expected = new int[source.Count];
            var actual = source.SequenceCompareF(clone);
            var actualModified = source.SequenceCompareF(cloneModified);

            Assert.Equal(expected, actual);
            Assert.NotEqual(expected, actualModified);
        }
    }
}