using System.Collections.Generic;
using System.Linq;
using LinqFasterer.Shared;
using Xunit;

namespace LinqFasterer.Tests
{
    public partial class Test
    {
        [Theory]
        [Trait(nameof(LinqFasterer.AllF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 0, 0, 100, MemberType = typeof(Utilities))]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 5, 0, 100, MemberType = typeof(Utilities))]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 5, 0, 1, MemberType = typeof(Utilities))]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 5, -1, 0, MemberType = typeof(Utilities))]
        public void AllTest_Int(IList<int> source)
        {
            var expected = source.All(v => v == -1);
            var actual = source.AllF(v => v == -1);

            Assert.Equal(expected, actual);
        }
    }
}