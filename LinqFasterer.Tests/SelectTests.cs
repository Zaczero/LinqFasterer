using System.Collections.Generic;
using System.Linq;
using LinqFasterer.Shared;
using Xunit;

namespace LinqFasterer.Tests
{
    public partial class Test
    {
        [Theory]
        [Trait(nameof(EnumerableF.SelectF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 0, 0, 100, MemberType = typeof(Utilities))]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 5, 0, 100, MemberType = typeof(Utilities))]
        public void SelectTest_Int(IList<int> source)
        {
            var expected = source.Select(v => -v).ToArray();
            var actual = source.SelectF(v => -v).ToArrayF();
            var actualIndexed = source.SelectF((v, i) => -v).ToArrayF();

            Assert.Equal(expected, actual);
            Assert.Equal(expected, actualIndexed);
        }

        [Theory]
        [Trait(nameof(EnumerableF.SelectInPlaceF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 0, 0, 100, MemberType = typeof(Utilities))]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 5, 0, 100, MemberType = typeof(Utilities))]
        public void SelectInPlaceTest_Int(IList<int> source)
        {
            var expected = source.Select(v => -v).ToArray();
            var actual = source.ToArrayF(true).SelectInPlaceF(v => -v).ToArrayF();
            var actualIndexed = source.ToArrayF(true).SelectInPlaceF((v, i) => -v).ToArrayF();

            Assert.Equal(expected, actual);
            Assert.Equal(expected, actualIndexed);
        }
    }
}