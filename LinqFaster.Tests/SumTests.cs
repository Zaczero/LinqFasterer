using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace LinqFasterer.Tests
{
	public partial class Test
	{
		[Theory]
		[Trait(nameof(LinqFasterer.SumF), null)]
		[MemberData(nameof(TestArray), typeof(int), 5, 0, 100)]
		public void SumTest_Int(IList<int> source)
		{
			var expected = source.Sum();
			var actual = source.SumF();
			var actualSelector = source.SumF(v => v);

			Assert.Equal(expected, actual);
			Assert.Equal(expected, actualSelector);
		}

		[Theory]
		[Trait(nameof(LinqFasterer.SumF), null)]
		[MemberData(nameof(TestArray), typeof(long), 5, 0, 100)]
		public void SumTest_Long(IList<long> source)
		{
			var expected = source.Sum();
			var actual = source.SumF();
			var actualSelector = source.SumF(v => v);

			Assert.Equal(expected, actual);
			Assert.Equal(expected, actualSelector);
		}

		[Theory]
		[Trait(nameof(LinqFasterer.SumF), null)]
		[MemberData(nameof(TestArray), typeof(float), 5, 0, 100)]
		public void SumTest_Float(IList<float> source)
		{
			var expected = source.Sum();
			var actual = source.SumF();
			var actualSelector = source.SumF(v => v);

			Assert.Equal(expected, actual);
			Assert.Equal(expected, actualSelector);
		}

		[Theory]
		[Trait(nameof(LinqFasterer.SumF), null)]
		[MemberData(nameof(TestArray), typeof(double), 5, 0, 100)]
		public void SumTest_Double(IList<double> source)
		{
			var expected = source.Sum();
			var actual = source.SumF();
			var actualSelector = source.SumF(v => v);

			Assert.Equal(expected, actual);
			Assert.Equal(expected, actualSelector);
		}

		[Theory]
		[Trait(nameof(LinqFasterer.SumF), null)]
		[MemberData(nameof(TestArray), typeof(decimal), 5, 0, 100)]
		public void SumTest_Decimal(IList<decimal> source)
		{
			var expected = source.Sum();
			var actual = source.SumF();
			var actualSelector = source.SumF(v => v);

			Assert.Equal(expected, actual);
			Assert.Equal(expected, actualSelector);
		}
	}
}