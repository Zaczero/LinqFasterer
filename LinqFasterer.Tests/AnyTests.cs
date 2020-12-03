using System.Collections.Generic;
using System.Linq;
using LinqFasterer.Shared;
using Xunit;

namespace LinqFasterer.Tests
{
    public partial class Test
    {
        [Theory]
        [Trait(nameof(EnumerableF.AnyF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 0, 0, 100, MemberType = typeof(Utilities))]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 5, 0, 100, MemberType = typeof(Utilities))]
        public void AnyTest_Int(IList<int> source)
        {
            var expected = source.Any();
            var actual = source.AnyF();

            Assert.Equal(expected, actual);
        }

        [Theory]
        [Trait(nameof(EnumerableF.AnyF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 5, 0, 100, MemberType = typeof(Utilities))]
        public void AnyTest_IntPredicate(IList<int> source)
        {
            var expected = source.Any(v => v == -1);
            var actual = source.AnyF(v => v == -1);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [Trait(nameof(EnumerableF.AnyF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 5, 0, 100, MemberType = typeof(Utilities))]
        public void AnyTest_IntPredicateMatch(IList<int> source)
        {
            var expected = source.Any(v => v == source[0]);
            var actual = source.AnyF(v => v == source[0]);

            Assert.Equal(expected, actual);
        }
    }
}