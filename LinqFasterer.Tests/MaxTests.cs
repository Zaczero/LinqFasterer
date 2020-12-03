using System.Collections.Generic;
using System.Linq;
using LinqFasterer.Shared;
using Xunit;

namespace LinqFasterer.Tests
{
    public partial class Test
    {
        [Theory]
        [Trait(nameof(EnumerableF.MaxF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 5, 0, 100, MemberType = typeof(Utilities))]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 10, 0, 2, MemberType = typeof(Utilities))]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 50, 0, 5, MemberType = typeof(Utilities))]
        public void MaxTest_Int(IList<int> source)
        {
            var expected = source.Max();
            var actual = source.MaxF();

            Assert.Equal(expected, actual);
        }

        [Theory]
        [Trait(nameof(EnumerableF.MaxF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 5, 0, 100, MemberType = typeof(Utilities))]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 10, 0, 2, MemberType = typeof(Utilities))]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 50, 0, 5, MemberType = typeof(Utilities))]
        public void MaxTest_IntNullable(IList<int> source)
        {
            var expected = source.Cast<int?>().ToArray().Max();
            var actual = source.Cast<int?>().ToArray().MaxF();

            Assert.Equal(expected, actual);
        }

        [Theory]
        [Trait(nameof(EnumerableF.MaxF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 5, 0, 100, MemberType = typeof(Utilities))]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 10, 0, 2, MemberType = typeof(Utilities))]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 50, 0, 5, MemberType = typeof(Utilities))]
        public void MaxTest_IntSelector(IList<int> source)
        {
            var expected = source.Max(v => -v);
            var actual = source.MaxF(v => -v);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [Trait(nameof(EnumerableF.MaxF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 5, 0, 100, MemberType = typeof(Utilities))]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 10, 0, 2, MemberType = typeof(Utilities))]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 50, 0, 5, MemberType = typeof(Utilities))]
        public void MaxTest_IntSelectorNullable(IList<int> source)
        {
            var expected = source.Cast<int?>().ToArray().Max(v => -v);
            var actual = source.Cast<int?>().ToArray().MaxF(v => -v);

            Assert.Equal(expected, actual);
        }
    }
}