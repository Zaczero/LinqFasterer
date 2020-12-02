using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace LinqFasterer.Tests
{
	public partial class Test
	{
		[Theory]
		[Trait(nameof(LinqFasterer.WhereF), null)]
		[MemberData(nameof(TestArray), typeof(int), 5, 0, 100)]
		[MemberData(nameof(TestArray), typeof(int), 10, 0, 2)]
		[MemberData(nameof(TestArray), typeof(int), 50, 0, 5)]
		public void WhereTest_Int(IList<int> source)
		{
			var expected = source.Where(v => v % 2 == 0).ToArray();
			var actual = source.WhereF(v => v % 2 == 0, true).ToArrayF();
			var actualIndexed = source.WhereF((v, i) => v % 2 == 0, true).ToArrayF();

			Assert.Equal(expected, actual);
			Assert.Equal(expected, actualIndexed);
		}
	}
}