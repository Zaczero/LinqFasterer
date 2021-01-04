using System.Collections.Generic;
using System.Linq;
using LinqFasterer.Shared;
using Xunit;

namespace LinqFasterer.Tests
{
    public partial class Test
    {
        [Theory]
        [Trait(nameof(EnumerableF.ToArrayF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 5, 0, 100, MemberType = typeof(Utilities))]
        public void ToArrayTest_Int(IList<int> source)
        {
            var expected = source.ToArray();
            var actual = source.ToArrayF();

            Assert.Equal(expected, actual);
        }

        [Theory]
        [Trait(nameof(EnumerableF.ToArrayF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 5, 0, 100, MemberType = typeof(Utilities))]
        public void ToArrayTest_IntForceClone(IList<int> source)
        {
            var expected = source.ToArray();
            var actual = source.ToArrayF(true);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [Trait(nameof(EnumerableF.ToListF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 5, 0, 100, MemberType = typeof(Utilities))]
        public void ToListTest_Int(IList<int> source)
        {
            var expected = source.ToList();
            var actual = source.ToListF();

            Assert.Equal(expected, actual);
        }

        [Theory]
        [Trait(nameof(EnumerableF.ToListF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 5, 0, 100, MemberType = typeof(Utilities))]
        public void ToListTest_IntInPlace(IList<int> source)
        {
            var expected = source.ToList();
            var actual = source.ToList().ToListF();

            Assert.Equal(expected, actual);
        }

        [Theory]
        [Trait(nameof(EnumerableF.ToListF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 5, 0, 100, MemberType = typeof(Utilities))]
        public void ToListTest_IntInPlaceForceClone(IList<int> source)
        {
            var expected = source.ToList();
            var actual = source.ToList().ToListF(true);

            Assert.Equal(expected, actual);
        }
    }
}