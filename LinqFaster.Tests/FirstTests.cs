using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace LinqFasterer.Tests
{
	public partial class Test
	{
		[Theory]
		[Trait(nameof(LinqFasterer.FirstF), null)]
		[MemberData(nameof(TestArray), typeof(int), 5, 0, 100)]
		public void FirstTest_Int(IList<int> source)
		{
			var expected = source.First();
			var actual = source.FirstF();

			Assert.Equal(expected, actual);
		}
	}
}