using System.Collections.Generic;
using System.Linq;
using LinqFasterer.Shared;
using Xunit;

namespace LinqFasterer.Tests
{
	public partial class Test
	{
		[Theory]
		[Trait(nameof(LinqFasterer.WhereF), null)]
		[MemberData(nameof(Utilities.TestArray), typeof(int), 5, 0, 100, MemberType = typeof(Utilities))]
		[MemberData(nameof(Utilities.TestArray), typeof(int), 10, 0, 2, MemberType = typeof(Utilities))]
		[MemberData(nameof(Utilities.TestArray), typeof(int), 50, 0, 5, MemberType = typeof(Utilities))]
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