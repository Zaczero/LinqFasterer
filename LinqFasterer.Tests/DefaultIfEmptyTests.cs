using System;
using System.Linq;
using Xunit;

namespace LinqFasterer.Tests
{
    public partial class Test
    {
        [Fact]
        [Trait(nameof(LinqFasterer.DefaultIfEmptyF), null)]
        public void DefaultIfEmptyTest_Int()
        {
            var source = Array.Empty<int>();

            var expected = source.DefaultIfEmpty().ToArray();
            var actual = source.DefaultIfEmptyF().ToArrayF();

            Assert.Equal(expected, actual);
        }

        [Fact]
        [Trait(nameof(LinqFasterer.DefaultIfEmptyF), null)]
        public void DefaultIfEmptyTest_IntDefault()
        {
            var source = Array.Empty<int>();

            var expected = source.DefaultIfEmpty(int.MaxValue).ToArray();
            var actual = source.DefaultIfEmptyF(int.MaxValue).ToArrayF();

            Assert.Equal(expected, actual);
        }
    }
}