using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace LinqFasterer.Tests
{
	public partial class Test
	{
		[Theory]
		[Trait(nameof(LinqFasterer.UnionF), null)]
		[MemberData(nameof(TestArray), typeof(int), 5, 0, 100)]
		[MemberData(nameof(TestArray), typeof(int), 10, 0, 2)]
		[MemberData(nameof(TestArray), typeof(int), 50, 0, 5)]
		[MemberData(nameof(TestArray), typeof(int), 3000, 0, 100)]
		public void UnionTest_Int(IList<int> source)
		{
			var (first, second) = SplitArray(source, source.Count / 2);

			var expected = first.Union(second);
			var actual = first.UnionF(second);

			Assert.Equal(expected, actual);
		}
	}
}