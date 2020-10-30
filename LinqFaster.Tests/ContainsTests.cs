using System.Collections.Generic;
using Xunit;

namespace LinqFasterer.Tests
{
	public partial class Test
	{
		[Theory]
		[Trait(nameof(LinqFasterer.ContainsF), null)]
		[MemberData(nameof(TestArray), typeof(int), 5, 0, 100)]
		[MemberData(nameof(TestArray), typeof(int), 10, 0, 2)]
		public void ContainsTest_Int(IList<int> source)
		{
			var (first, second) = SplitArray(source, source.Count - 1);

			var expected = first.Contains(second[0]);
			var actual = first.ContainsF(second[0]);

			Assert.Equal(expected, actual);
		}
	}
}