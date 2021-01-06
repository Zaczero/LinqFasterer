using System.Collections.Generic;
using LinqFasterer.Shared;
using Xunit;

namespace LinqFasterer.Tests
{
    public partial class Test
    {
        [Theory]
        [Trait(nameof(EnumerableF.ForEachF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 5, 0, 100, MemberType = typeof(Utilities))]
        public void ForEachTest_Int(IList<int> source)
        {
            var expected = source.ToArrayF();
            var actual = new List<int>();

            source.ForEachF(i => actual.Add(i));

            Assert.Equal(expected, actual.ToArray());
        }
    }
}