using System.Collections.Generic;
using System.Linq;
using LinqFasterer.Shared;
using Xunit;

namespace LinqFasterer.Tests
{
    public partial class Test
    {
        [Theory]
        [Trait(nameof(LinqFasterer.AverageF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 5, 0, 100, MemberType = typeof(Utilities))]
        public void AverageTest_Int(IList<int> source)
        {
            var expected = source.Average();
            var actual = source.AverageF();

            Assert.Equal(expected, actual);
        }

        [Theory]
        [Trait(nameof(LinqFasterer.AverageF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(long), 5, 0, 100, MemberType = typeof(Utilities))]
        public void AverageTest_Long(IList<long> source)
        {
            var expected = source.Average();
            var actual = source.AverageF();

            Assert.Equal(expected, actual);
        }

        [Theory]
        [Trait(nameof(LinqFasterer.AverageF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(float), 5, 0, 100, MemberType = typeof(Utilities))]
        public void AverageTest_Float(IList<float> source)
        {
            var expected = source.Average();
            var actual = source.AverageF();

            Assert.Equal(expected, actual, 3);
        }

        [Theory]
        [Trait(nameof(LinqFasterer.AverageF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(double), 5, 0, 100, MemberType = typeof(Utilities))]
        public void AverageTest_Double(IList<double> source)
        {
            var expected = source.Average();
            var actual = source.AverageF();

            Assert.Equal(expected, actual, 3);
        }

        [Theory]
        [Trait(nameof(LinqFasterer.AverageF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(decimal), 5, 0, 100, MemberType = typeof(Utilities))]
        public void AverageTest_Decimal(IList<decimal> source)
        {
            var expected = source.Average();
            var actual = source.AverageF();

            Assert.Equal(expected, actual, 3);
        }

        [Theory]
        [Trait(nameof(LinqFasterer.AverageF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 5, 0, 100, MemberType = typeof(Utilities))]
        public void AverageTest_IntSelector(IList<int> source)
        {
            var expected = source.Average(v => -v);
            var actual = source.AverageF(v => -v);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [Trait(nameof(LinqFasterer.AverageF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(long), 5, 0, 100, MemberType = typeof(Utilities))]
        public void AverageTest_LongSelector(IList<long> source)
        {
            var expected = source.Average(v => -v);
            var actual = source.AverageF(v => -v);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [Trait(nameof(LinqFasterer.AverageF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(float), 5, 0, 100, MemberType = typeof(Utilities))]
        public void AverageTest_FloatSelector(IList<float> source)
        {
            var expected = source.Average(v => -v);
            var actual = source.AverageF(v => -v);

            Assert.Equal(expected, actual, 3);
        }

        [Theory]
        [Trait(nameof(LinqFasterer.AverageF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(double), 5, 0, 100, MemberType = typeof(Utilities))]
        public void AverageTest_DoubleSelector(IList<double> source)
        {
            var expected = source.Average(v => -v);
            var actual = source.AverageF(v => -v);

            Assert.Equal(expected, actual, 3);
        }

        [Theory]
        [Trait(nameof(LinqFasterer.AverageF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(decimal), 5, 0, 100, MemberType = typeof(Utilities))]
        public void AverageTest_DecimalSelector(IList<decimal> source)
        {
            var expected = source.Average(v => -v);
            var actual = source.AverageF(v => -v);

            Assert.Equal(expected, actual, 3);
        }
    }
}