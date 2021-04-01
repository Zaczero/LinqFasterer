using System.Collections.Generic;
using System.Linq;
using LinqFasterer.Shared;
using Xunit;

namespace LinqFasterer.Tests
{
    public partial class Test
    {
        [Theory]
        [Trait(nameof(EnumerableF.SumF16), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 5, 0, 100, MemberType = typeof(Utilities))]
        public void SumX16Test_Int(IList<int> source)
        {
            var expected = source.Sum();
            var actual = source.SumF16();
            var actualSelector = source.SumF16(v => v);

            Assert.Equal(expected, actual);
            Assert.Equal(expected, actualSelector);
        }

        [Theory]
        [Trait(nameof(EnumerableF.SumF16), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(long), 5, 0, 100, MemberType = typeof(Utilities))]
        public void SumX16Test_Long(IList<long> source)
        {
            var expected = source.Sum();
            var actual = source.SumF16();
            var actualSelector = source.SumF16(v => v);

            Assert.Equal(expected, actual);
            Assert.Equal(expected, actualSelector);
        }

        [Theory]
        [Trait(nameof(EnumerableF.SumF16), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(float), 5, 0, 100, MemberType = typeof(Utilities))]
        public void SumX16Test_Float(IList<float> source)
        {
            var expected = source.Sum();
            var actual = source.SumF16();
            var actualSelector = source.SumF16(v => v);

            Assert.Equal(expected, actual);
            Assert.Equal(expected, actualSelector);
        }

        [Theory]
        [Trait(nameof(EnumerableF.SumF16), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(double), 5, 0, 100, MemberType = typeof(Utilities))]
        public void SumX16Test_Double(IList<double> source)
        {
            var expected = source.Sum();
            var actual = source.SumF16();
            var actualSelector = source.SumF16(v => v);

            Assert.Equal(expected, actual);
            Assert.Equal(expected, actualSelector);
        }

        [Theory]
        [Trait(nameof(EnumerableF.SumF16), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(decimal), 5, 0, 100, MemberType = typeof(Utilities))]
        public void SumX16Test_Decimal(IList<decimal> source)
        {
            var expected = source.Sum();
            var actual = source.SumF16();
            var actualSelector = source.SumF16(v => v);

            Assert.Equal(expected, actual);
            Assert.Equal(expected, actualSelector);
        }
    }
}
