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
		[Trait(nameof(LinqFasterer.FirstF), null)]
		[MemberData(nameof(Utilities.TestArray), typeof(int), 5, 0, 100, MemberType = typeof(Utilities))]
		public void FirstTest_Int(IList<int> source)
		{
			var expected = source.First();
			var actual = source.FirstF();

			Assert.Equal(expected, actual);
		}

		[Theory]
		[Trait(nameof(LinqFasterer.FirstF), null)]
		[MemberData(nameof(Utilities.TestArray), typeof(int), 50, 0, 10, MemberType = typeof(Utilities))]
		public void FirstTest_IntPredicate(IList<int> source)
		{
			var expected = source.First(v => v == source[0]);
			var actual = source.FirstF(v => v == source[0]);

			Assert.Equal(expected, actual);
		}

		[Theory]
		[Trait(nameof(LinqFasterer.FirstF), null)]
		[MemberData(nameof(Utilities.TestArray), typeof(int), 5, 0, 10, MemberType = typeof(Utilities))]
		public void FirstTest_IntPredicateFail(IList<int> source)
		{
			Assert.Throws<InvalidOperationException>(() => source.FirstF(v => v == -1));
		}

		[Theory]
		[Trait(nameof(LinqFasterer.FirstOrDefaultF), null)]
		[MemberData(nameof(Utilities.TestArray), typeof(int), 5, 0, 100, MemberType = typeof(Utilities))]
		public void FirstOrDefaultTest_Int(IList<int> source)
		{
			var expected = source.FirstOrDefault();
			var actual = source.FirstOrDefaultF();

			Assert.Equal(expected, actual);
		}

		[Theory]
		[Trait(nameof(LinqFasterer.FirstOrDefaultF), null)]
		[MemberData(nameof(Utilities.TestArray), typeof(int), 50, 0, 10, MemberType = typeof(Utilities))]
		public void FirstOrDefaultTest_IntPredicate(IList<int> source)
		{
			var expected = source.FirstOrDefault(v => v == source[0]);
			var actual = source.FirstOrDefaultF(v => v == source[0]);

			Assert.Equal(expected, actual);
		}

		[Theory]
		[Trait(nameof(LinqFasterer.FirstOrDefaultF), null)]
		[MemberData(nameof(Utilities.TestArray), typeof(int), 5, 0, 10, MemberType = typeof(Utilities))]
		public void FirstOrDefaultTest_IntPredicateDefault(IList<int> source)
		{
			var expected = source.FirstOrDefault(v => v == -1);
			var actual = source.FirstOrDefaultF(v => v == -1);

			Assert.Equal(expected, actual);
		}
	}
}