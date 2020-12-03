using System.Linq;
using Xunit;

namespace LinqFasterer.Tests
{
    public partial class Test
    {
        [Fact]
        [Trait(nameof(EnumerableF.EmptyF), null)]
        public void EmptyTest_Int()
        {
            var expected = Enumerable.Empty<int>().ToArray();
            var actual = EnumerableF.EmptyF<int>().ToArrayF();

            Assert.Equal(expected, actual);
        }
    }
}