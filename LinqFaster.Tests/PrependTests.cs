using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace LinqFasterer.Tests
{
	public partial class Test
	{
		[Theory]
		[Trait(nameof(LinqFasterer.PrependF), null)]
		[MemberData(nameof(TestArray), typeof(int), 5, 0, 100)]
		public void PrependTest_Int(IList<int> source)
		{
			var (first, second) = SplitArray(source, source.Count - 1);

			var expected = first.Prepend(second[0]);
			var actual = first.PrependF(second[0]);

			Assert.Equal(expected, actual);
		}
	}
}
