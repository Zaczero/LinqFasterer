using System.Collections.Generic;
using System.Linq;
using LinqFasterer.Shared;
using Xunit;

namespace LinqFasterer.Tests
{
    public partial class Test
    {
        [Theory]
        [Trait(nameof(LinqFasterer.ReverseF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 5, 0, 100, MemberType = typeof(Utilities))]
        public void ReverseTest_Int(IList<int> source)
        {
            var expected = source.Reverse().ToArray();
            var actual = source.ReverseF().ToArrayF();

            Assert.Equal(expected, actual);
        }
    }
}