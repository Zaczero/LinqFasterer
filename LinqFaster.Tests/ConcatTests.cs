using System.Collections.Generic;
using System.Linq;
using LinqFasterer.Shared;
using Xunit;

namespace LinqFasterer.Tests
{
	public partial class Test
	{
		[Theory]
		[Trait(nameof(LinqFasterer.ConcatF), null)]
		[MemberData(nameof(Utilities.TestArray), typeof(int), 5, 0, 100, MemberType = typeof(Utilities))]
		public void ConcatTest_Int(IList<int> source)
		{
			var (first, second) = Utilities.SplitArray(source, source.Count / 2);

			var expected = first.Concat(second).ToArray();
			var actual = first.ConcatF(second).ToArrayF();

			Assert.Equal(expected, actual);
		}
	}
}