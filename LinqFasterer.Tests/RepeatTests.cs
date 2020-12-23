using System.Collections.Generic;
using System.Linq;
using LinqFasterer.Shared;
using Xunit;

namespace LinqFasterer.Tests
{
    public partial class Test
    {
        [Theory]
        [Trait(nameof(EnumerableF.RepeatF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 5, 0, 100, MemberType = typeof(Utilities))]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 10, 0, 2, MemberType = typeof(Utilities))]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 50, 0, 5, MemberType = typeof(Utilities))]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 5000, 0, 100, MemberType = typeof(Utilities))]
        public void RepeatTest_Int(IList<int> source)
        {
            var expected = Enumerable.Repeat(source[0], source.Count).ToArray();
            var actual = EnumerableF.RepeatF(source[0], source.Count).ToArrayF();

            Assert.Equal(expected, actual);
        }
    }
}