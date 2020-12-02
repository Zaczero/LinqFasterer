using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace LinqFasterer.Tests
{
	public partial class Test
	{
		[Theory]
		[Trait(nameof(LinqFasterer.OrderByF), null)]
		[MemberData(nameof(TestArray), typeof(int), 5, 0, 100)]
		[MemberData(nameof(TestArray), typeof(int), 10, 0, 2)]
		[MemberData(nameof(TestArray), typeof(int), 50, 0, 5)]
		public void OrderByTest_Int(IList<int> source)
		{
			var expected = source.OrderBy(v => v).ToArray();
			var actual = source.OrderByF(v => v).ToArrayF();

			Assert.Equal(expected, actual);
		}

		[Theory]
		[Trait(nameof(LinqFasterer.OrderByDescendingF), null)]
		[MemberData(nameof(TestArray), typeof(int), 5, 0, 100)]
		[MemberData(nameof(TestArray), typeof(int), 10, 0, 2)]
		[MemberData(nameof(TestArray), typeof(int), 50, 0, 5)]
		public void OrderByDescendingTest_Int(IList<int> source)
		{
			var expected = source.OrderByDescending(v => v).ToArray();
			var actual = source.OrderByDescendingF(v => v).ToArrayF();

			Assert.Equal(expected, actual);
		}
	}
}