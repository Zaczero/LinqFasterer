using System;
using System.Collections.Generic;
using System.Linq;
using LinqFasterer.Shared;
using Xunit;

namespace LinqFasterer.Tests
{
    public partial class Test
    {
        [Theory]
        [Trait(nameof(EnumerableF.SequenceEqualF), null)]
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
        [Trait(nameof(EnumerableF.SequenceEqualF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 0, 0, 100, MemberType = typeof(Utilities))]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 4, 0, 100, MemberType = typeof(Utilities))]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 5, 0, 100, MemberType = typeof(Utilities))]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 15, 1, 2, MemberType = typeof(Utilities))]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 16, 1, 2, MemberType = typeof(Utilities))]
        public void SequenceEqualComparerTest_Int(IList<int> source)
        {
            var (first, second) = Utilities.SplitArray(source, source.Count / 2);

            var expected = first.SequenceEqual(second, EqualityComparer<int>.Default);
            var actual = first.SequenceEqualF(second, EqualityComparer<int>.Default);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [Trait(nameof(EnumerableF.SequenceCompareF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 5, 0, 100, MemberType = typeof(Utilities))]
        public void SequenceCompareTest_Int(IList<int> source)
        {
            var clone = new List<int>(source);
            var cloneModified = new List<int>(source) {[0] = -1};

            var expected = new int[source.Count];
            var actual = source.SequenceCompareF(clone);
            var actualSelf = source.SequenceCompareF(source);
            var actualModified = source.SequenceCompareF(cloneModified);

            Assert.Equal(expected, actual);
            Assert.Equal(expected, actualSelf);
            Assert.NotEqual(expected, actualModified);
        }

        [Theory]
        [Trait(nameof(EnumerableF.SequenceCompareF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 5, 0, 100, MemberType = typeof(Utilities))]
        public void SequenceCompareTest_IntFail(IList<int> source)
        {
            Assert.Throws<NotSupportedException>(() => source.SequenceCompareF(EnumerableF.EmptyF<int>()));
        }

        [Theory]
        [Trait(nameof(EnumerableF.SequenceCompareF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 5, 0, 100, MemberType = typeof(Utilities))]
        public void SequenceCompareComparerTest_Int(IList<int> source)
        {
            var clone = new List<int>(source);
            var cloneModified = new List<int>(source) {[0] = -1};

            var expected = new int[source.Count];
            var actual = source.SequenceCompareF(clone, Comparer<int>.Default);
            var actualModified = source.SequenceCompareF(cloneModified, Comparer<int>.Default);

            Assert.Equal(expected, actual);
            Assert.NotEqual(expected, actualModified);
        }
    }
}