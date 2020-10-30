using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace LinqFasterer.Tests
{
	public partial class Test
	{
		[Theory]
		[Trait(nameof(LinqFasterer.ElementAtF), null)]
		[MemberData(nameof(TestArray), typeof(int), 5, 0, 100)]
		public void ElementAtTest_Int(IList<int> source)
		{
			var expected = source.ElementAt(source.Count / 2);
			var actual = source.ElementAtF(source.Count / 2);

			Assert.Equal(expected, actual);
		}

		[Theory]
		[Trait(nameof(LinqFasterer.ElementAtF), null)]
		[MemberData(nameof(TestArray), typeof(int), 5, 0, 100)]
		public void ElementAtTest_Except(IList<int> source)
		{
			Assert.Throws<ArgumentOutOfRangeException>(() => source.ElementAtF(-1));
			Assert.Throws<ArgumentOutOfRangeException>(() => source.ElementAtF(source.Count));
		}

		[Theory]
		[Trait(nameof(LinqFasterer.ElementAtOrDefaultF), null)]
		[MemberData(nameof(TestArray), typeof(int), 5, 0, 100)]
		public void ElementAtOrDefaultTest_Int(IList<int> source)
		{
			var expected = source.ElementAtOrDefault(source.Count / 2);
			var actual = source.ElementAtOrDefaultF(source.Count / 2);

			Assert.Equal(expected, actual);
		}

		[Theory]
		[Trait(nameof(LinqFasterer.ElementAtOrDefaultF), null)]
		[MemberData(nameof(TestArray), typeof(int), 5, 0, 100)]
		public void ElementAtOrDefaultTest_Default(IList<int> source)
		{
			Assert.Equal(0, source.ElementAtOrDefaultF(-1));
			Assert.Equal(0, source.ElementAtOrDefaultF(source.Count));
		}
	}
}