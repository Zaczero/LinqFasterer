using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace LinqFasterer.Tests
{
	public partial class Test
	{
		[Theory]
		[Trait(nameof(LinqFasterer.AnyF), null)]
		[MemberData(nameof(TestArray), typeof(int), 0, 0, 100)]
		[MemberData(nameof(TestArray), typeof(int), 5, 0, 100)]
		public void AnyTest_Int(IList<int> source)
		{
			var expected = source.Any();
			var actual = source.AnyF();

			Assert.Equal(expected, actual);
		}

		[Theory]
		[Trait(nameof(LinqFasterer.AnyF), null)]
		[MemberData(nameof(TestArray), typeof(int), 5, 0, 100)]
		public void AnyTest_IntPredicate(IList<int> source)
		{
			var expected = source.Any(v => v == -1);
			var actual = source.AnyF(v => v == -1);

			Assert.Equal(expected, actual);
		}

		[Theory]
		[Trait(nameof(LinqFasterer.AnyF), null)]
		[MemberData(nameof(TestArray), typeof(int), 5, 0, 100)]
		public void AnyTest_IntPredicateMatch(IList<int> source)
		{
			var expected = source.Any(v => v == source[0]);
			var actual = source.AnyF(v => v == source[0]);

			Assert.Equal(expected, actual);
		}
	}
}