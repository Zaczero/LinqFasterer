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
        [Trait(nameof(EnumerableF.ElementAtF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 5, 0, 100, MemberType = typeof(Utilities))]
        public void ElementAtTest_Int(IList<int> source)
        {
            var expected = source.ElementAt(source.Count / 2);
            var actual = source.ElementAtF(source.Count / 2);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [Trait(nameof(EnumerableF.ElementAtF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 5, 0, 100, MemberType = typeof(Utilities))]
        public void ElementAtTest_Except(IList<int> source)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => source.ElementAtF(-1));
            Assert.Throws<ArgumentOutOfRangeException>(() => source.ElementAtF(source.Count));
        }

        [Theory]
        [Trait(nameof(EnumerableF.ElementAtOrDefaultF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 5, 0, 100, MemberType = typeof(Utilities))]
        public void ElementAtOrDefaultTest_Int(IList<int> source)
        {
            var expected = source.ElementAtOrDefault(source.Count / 2);
            var actual = source.ElementAtOrDefaultF(source.Count / 2);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [Trait(nameof(EnumerableF.ElementAtOrDefaultF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 5, 0, 100, MemberType = typeof(Utilities))]
        public void ElementAtOrDefaultTest_Default(IList<int> source)
        {
            Assert.Equal(0, source.ElementAtOrDefaultF(-1));
            Assert.Equal(0, source.ElementAtOrDefaultF(source.Count));
        }
    }
}