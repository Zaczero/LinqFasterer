using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace LinqFasterer.Tests
{
	public partial class Test
	{
		[Theory]
		[Trait(nameof(LinqFasterer.DistinctF), null)]
		[MemberData(nameof(TestArray), typeof(int), 5, 0, 100)]
		[MemberData(nameof(TestArray), typeof(int), 10, 0, 2)]
		[MemberData(nameof(TestArray), typeof(int), 50, 0, 5)]
		[MemberData(nameof(TestArray), typeof(int), 5000, 0, 100)]
		public void DistinctTest_Int(IList<int> source)
		{
			var expected = source.Distinct().ToArray();
			var actual = source.DistinctF().ToArrayF();

			Assert.Equal(expected, actual);
		}
	}
}