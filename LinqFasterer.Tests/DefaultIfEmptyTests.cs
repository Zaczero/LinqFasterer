using System;
using System.Collections.Generic;
using System.Linq;
using LinqFasterer.Shared;
using Xunit;

namespace LinqFasterer.Tests
{
    public partial class Test
    {
        [Theory]
        [Trait(nameof(EnumerableF.DefaultIfEmptyF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 5, 0, 100, MemberType = typeof(Utilities))]
        public void DefaultIfEmptyTest_Int(IList<int> source)
        {
            var expected = source.DefaultIfEmpty().ToArray();
            var actual = source.DefaultIfEmptyF().ToArrayF();

            Assert.Equal(expected, actual);
        }
        
        [Fact]
        [Trait(nameof(EnumerableF.DefaultIfEmptyF), null)]
        public void DefaultIfEmptyTest_IntEmpty()
        {
            var source = Array.Empty<int>();

            var expected = source.DefaultIfEmpty().ToArray();
            var actual = source.DefaultIfEmptyF().ToArrayF();

            Assert.Equal(expected, actual);
        }

        [Fact]
        [Trait(nameof(EnumerableF.DefaultIfEmptyF), null)]
        public void DefaultIfEmptyTest_IntEmptyDefault()
        {
            var source = Array.Empty<int>();

            var expected = source.DefaultIfEmpty(int.MaxValue).ToArray();
            var actual = source.DefaultIfEmptyF(int.MaxValue).ToArrayF();

            Assert.Equal(expected, actual);
        }
    }
}