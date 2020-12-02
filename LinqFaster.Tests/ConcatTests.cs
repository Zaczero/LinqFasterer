using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace LinqFasterer.Tests
{
	public partial class Test
	{
		[Theory]
		[Trait(nameof(LinqFasterer.ConcatF), null)]
		[MemberData(nameof(TestArray), typeof(int), 5, 0, 100)]
		public void ConcatTest_Int(IList<int> source)
		{
			var (first, second) = SplitArray(source, source.Count / 2);

			var expected = first.Concat(second).ToArray();
			var actual = first.ConcatF(second).ToArrayF();

			Assert.Equal(expected, actual);
		}
	}
}