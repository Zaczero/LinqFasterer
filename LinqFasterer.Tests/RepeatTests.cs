using System.Linq;
using Xunit;

namespace LinqFasterer.Tests
{
    public partial class Test
    {
        [Fact]
        [Trait(nameof(EnumerableF.RepeatF), null)]
        public void RepeatTest_Int()
        {
            var expected = Enumerable.Repeat(5, 100).ToArray();
            var actual = EnumerableF.RepeatF(5, 100).ToArrayF();

            Assert.Equal(expected, actual);
        }
    }
}