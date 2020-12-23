using System.Collections.Generic;
using LinqFasterer.Shared;
using Xunit;

namespace LinqFasterer.Tests
{
    public partial class Test
    {
        [Theory]
        [Trait(nameof(EnumerableF.ContainsF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 5, 0, 100, MemberType = typeof(Utilities))]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 10, 0, 2, MemberType = typeof(Utilities))]
        public void ContainsTest_Int(IList<int> source)
        {
            var (first, second) = Utilities.SplitArray(source, source.Count - 1);

            var expected = first.Contains(second[0]);
            var actual = first.ContainsF(second[0]);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [Trait(nameof(EnumerableF.ContainsF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 5, 0, 100, MemberType = typeof(Utilities))]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 10, 0, 2, MemberType = typeof(Utilities))]
        public void ContainsComparerTest_Int(IList<int> source)
        {
            var (first, second) = Utilities.SplitArray(source, source.Count - 1);

            var expected = first.Contains(second[0]);
            var actual = first.ContainsF(second[0], EqualityComparer<int>.Default);

            Assert.Equal(expected, actual);
        }
    }
}