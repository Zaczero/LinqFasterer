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
        [Trait(nameof(LinqFasterer.LastF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 5, 0, 100, MemberType = typeof(Utilities))]
        public void LastTest_Int(IList<int> source)
        {
            var expected = source.Last();
            var actual = source.LastF();

            Assert.Equal(expected, actual);
        }

        [Theory]
        [Trait(nameof(LinqFasterer.LastF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 50, 0, 10, MemberType = typeof(Utilities))]
        public void LastTest_IntPredicate(IList<int> source)
        {
            var expected = source.Last(v => v == source[0]);
            var actual = source.LastF(v => v == source[0]);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [Trait(nameof(LinqFasterer.LastF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 5, 0, 10, MemberType = typeof(Utilities))]
        public void LastTest_IntPredicateFail(IList<int> source)
        {
            Assert.Throws<InvalidOperationException>(() => source.LastF(v => v == -1));
        }

        [Theory]
        [Trait(nameof(LinqFasterer.LastOrDefaultF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 5, 0, 100, MemberType = typeof(Utilities))]
        public void LastOrDefaultTest_Int(IList<int> source)
        {
            var expected = source.LastOrDefault();
            var actual = source.LastOrDefaultF();

            Assert.Equal(expected, actual);
        }

        [Theory]
        [Trait(nameof(LinqFasterer.LastOrDefaultF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 50, 0, 10, MemberType = typeof(Utilities))]
        public void LastOrDefaultTest_IntPredicate(IList<int> source)
        {
            var expected = source.LastOrDefault(v => v == source[0]);
            var actual = source.LastOrDefaultF(v => v == source[0]);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [Trait(nameof(LinqFasterer.LastOrDefaultF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 5, 0, 10, MemberType = typeof(Utilities))]
        public void LastOrDefaultTest_IntPredicateDefault(IList<int> source)
        {
            var expected = source.LastOrDefault(v => v == -1);
            var actual = source.LastOrDefaultF(v => v == -1);

            Assert.Equal(expected, actual);
        }
    }
}