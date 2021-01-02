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
        [Trait(nameof(EnumerableF.AverageF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 5, 0, 100, MemberType = typeof(Utilities))]
        public void AverageTest_Int(IList<int> source)
        {
            var expected = source.Average();
            var actual = source.AverageF();

            Assert.Equal(expected, actual);
        }
        
        [Theory]
        [Trait(nameof(EnumerableF.AverageF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 0, 0, 0, MemberType = typeof(Utilities))]
        public void AverageTest_IntFail(IList<int> source)
        {
            Assert.Throws<InvalidOperationException>(() => source.AverageF());
        }

        [Theory]
        [Trait(nameof(EnumerableF.AverageF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(long), 5, 0, 100, MemberType = typeof(Utilities))]
        public void AverageTest_Long(IList<long> source)
        {
            var expected = source.Average();
            var actual = source.AverageF();

            Assert.Equal(expected, actual);
        }
        
        [Theory]
        [Trait(nameof(EnumerableF.AverageF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(long), 0, 0, 0, MemberType = typeof(Utilities))]
        public void AverageTest_LongFail(IList<long> source)
        {
            Assert.Throws<InvalidOperationException>(() => source.AverageF());
        }

        [Theory]
        [Trait(nameof(EnumerableF.AverageF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(float), 5, 0, 100, MemberType = typeof(Utilities))]
        public void AverageTest_Float(IList<float> source)
        {
            var expected = source.Average();
            var actual = source.AverageF();

            Assert.Equal(expected, actual, 3);
        }
        
        [Theory]
        [Trait(nameof(EnumerableF.AverageF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(float), 0, 0, 0, MemberType = typeof(Utilities))]
        public void AverageTest_FloatFail(IList<float> source)
        {
            Assert.Throws<InvalidOperationException>(() => source.AverageF());
        }

        [Theory]
        [Trait(nameof(EnumerableF.AverageF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(double), 5, 0, 100, MemberType = typeof(Utilities))]
        public void AverageTest_Double(IList<double> source)
        {
            var expected = source.Average();
            var actual = source.AverageF();

            Assert.Equal(expected, actual, 3);
        }
        
        [Theory]
        [Trait(nameof(EnumerableF.AverageF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(double), 0, 0, 0, MemberType = typeof(Utilities))]
        public void AverageTest_DoubleFail(IList<double> source)
        {
            Assert.Throws<InvalidOperationException>(() => source.AverageF());
        }

        [Theory]
        [Trait(nameof(EnumerableF.AverageF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(decimal), 5, 0, 100, MemberType = typeof(Utilities))]
        public void AverageTest_Decimal(IList<decimal> source)
        {
            var expected = source.Average();
            var actual = source.AverageF();

            Assert.Equal(expected, actual, 3);
        }
        
        [Theory]
        [Trait(nameof(EnumerableF.AverageF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(decimal), 0, 0, 0, MemberType = typeof(Utilities))]
        public void AverageTest_DecimalFail(IList<decimal> source)
        {
            Assert.Throws<InvalidOperationException>(() => source.AverageF());
        }

        [Theory]
        [Trait(nameof(EnumerableF.AverageF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 5, 0, 100, MemberType = typeof(Utilities))]
        public void AverageTest_IntSelector(IList<int> source)
        {
            var expected = source.Average(v => -v);
            var actual = source.AverageF(v => -v);

            Assert.Equal(expected, actual);
        }
        
        [Theory]
        [Trait(nameof(EnumerableF.AverageF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 0, 0, 0, MemberType = typeof(Utilities))]
        public void AverageTest_IntSelectorFail(IList<int> source)
        {
            Assert.Throws<InvalidOperationException>(() => source.AverageF(v => -v));
        }

        [Theory]
        [Trait(nameof(EnumerableF.AverageF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(long), 5, 0, 100, MemberType = typeof(Utilities))]
        public void AverageTest_LongSelector(IList<long> source)
        {
            var expected = source.Average(v => -v);
            var actual = source.AverageF(v => -v);

            Assert.Equal(expected, actual);
        }
        
        [Theory]
        [Trait(nameof(EnumerableF.AverageF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(long), 0, 0, 0, MemberType = typeof(Utilities))]
        public void AverageTest_LongSelectorFail(IList<long> source)
        {
            Assert.Throws<InvalidOperationException>(() => source.AverageF(v => -v));
        }

        [Theory]
        [Trait(nameof(EnumerableF.AverageF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(float), 5, 0, 100, MemberType = typeof(Utilities))]
        public void AverageTest_FloatSelector(IList<float> source)
        {
            var expected = source.Average(v => -v);
            var actual = source.AverageF(v => -v);

            Assert.Equal(expected, actual, 3);
        }
        
        [Theory]
        [Trait(nameof(EnumerableF.AverageF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(float), 0, 0, 0, MemberType = typeof(Utilities))]
        public void AverageTest_FloatSelectorFail(IList<float> source)
        {
            Assert.Throws<InvalidOperationException>(() => source.AverageF(v => -v));
        }

        [Theory]
        [Trait(nameof(EnumerableF.AverageF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(double), 5, 0, 100, MemberType = typeof(Utilities))]
        public void AverageTest_DoubleSelector(IList<double> source)
        {
            var expected = source.Average(v => -v);
            var actual = source.AverageF(v => -v);

            Assert.Equal(expected, actual, 3);
        }
        
        [Theory]
        [Trait(nameof(EnumerableF.AverageF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(double), 0, 0, 0, MemberType = typeof(Utilities))]
        public void AverageTest_DoubleSelectorFail(IList<double> source)
        {
            Assert.Throws<InvalidOperationException>(() => source.AverageF(v => -v));
        }

        [Theory]
        [Trait(nameof(EnumerableF.AverageF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(decimal), 5, 0, 100, MemberType = typeof(Utilities))]
        public void AverageTest_DecimalSelector(IList<decimal> source)
        {
            var expected = source.Average(v => -v);
            var actual = source.AverageF(v => -v);

            Assert.Equal(expected, actual, 3);
        }
        
        [Theory]
        [Trait(nameof(EnumerableF.AverageF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(decimal), 0, 0, 0, MemberType = typeof(Utilities))]
        public void AverageTest_DecimalSelectorFail(IList<decimal> source)
        {
            Assert.Throws<InvalidOperationException>(() => source.AverageF(v => -v));
        }
    }
}