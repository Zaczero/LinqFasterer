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
        [Trait(nameof(LinqFasterer.SingleF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 1, 0, 100, MemberType = typeof(Utilities))]
        public void SingleTest_Int(IList<int> source)
        {
            var expected = source.Single();
            var actual = source.SingleF();

            Assert.Equal(expected, actual);
        }

        [Theory]
        [Trait(nameof(LinqFasterer.SingleF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 0, 0, 100, MemberType = typeof(Utilities))]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 5, 0, 100, MemberType = typeof(Utilities))]
        public void SingleTest_IntFail(IList<int> source)
        {
            Assert.Throws<InvalidOperationException>(() => source.SingleF());
        }

        [Theory]
        [Trait(nameof(LinqFasterer.SingleF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 50, 5, 10, MemberType = typeof(Utilities))]
        public void SingleTest_IntPredicate(IList<int> source)
        {
            source[0] = 0;

            var expected = source.Single(v => v == source[0]);
            var actual = source.SingleF(v => v == source[0]);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [Trait(nameof(LinqFasterer.SingleF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 0, 0, 100, MemberType = typeof(Utilities))]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 5, 0, 100, MemberType = typeof(Utilities))]
        public void SingleTest_IntPredicateFail(IList<int> source)
        {
            Assert.Throws<InvalidOperationException>(() => source.SingleF(v => v == 0));
        }

        [Theory]
        [Trait(nameof(LinqFasterer.SingleOrDefaultF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 1, 0, 100, MemberType = typeof(Utilities))]
        public void SingleOrDefaultTest_Int(IList<int> source)
        {
            var expected = source.SingleOrDefault();
            var actual = source.SingleOrDefaultF();

            Assert.Equal(expected, actual);
        }

        [Theory]
        [Trait(nameof(LinqFasterer.SingleOrDefaultF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 0, 0, 100, MemberType = typeof(Utilities))]
        public void SingleOrDefaultTest_IntDefault(IList<int> source)
        {
            var expected = source.SingleOrDefault();
            var actual = source.SingleOrDefaultF();

            Assert.Equal(expected, actual);
        }

        [Theory]
        [Trait(nameof(LinqFasterer.SingleOrDefaultF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 50, 5, 10, MemberType = typeof(Utilities))]
        public void SingleOrDefaultTest_IntPredicate(IList<int> source)
        {
            source[0] = 0;

            var expected = source.SingleOrDefault(v => v == source[0]);
            var actual = source.SingleOrDefaultF(v => v == source[0]);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [Trait(nameof(LinqFasterer.SingleOrDefaultF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 0, 0, 100, MemberType = typeof(Utilities))]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 5, 0, 100, MemberType = typeof(Utilities))]
        public void SingleOrDefaultTest_IntPredicateDefault(IList<int> source)
        {
            var expected = source.SingleOrDefault(v => v < 0);
            var actual = source.SingleOrDefaultF(v => v < 0);

            Assert.Equal(expected, actual);
        }
    }
}