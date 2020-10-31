using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace LinqFasterer.Tests
{
	public partial class Test
	{
		[Theory]
		[Trait(nameof(LinqFasterer.AllF), null)]
		[MemberData(nameof(TestArray), typeof(int), 0, 0, 100)]
		[MemberData(nameof(TestArray), typeof(int), 5, 0, 100)]
		[MemberData(nameof(TestArray), typeof(int), 5, 0, 1)]
		[MemberData(nameof(TestArray), typeof(int), 5, -1, 0)]
		public void AllTest_Int(IList<int> source)
		{
			var expected = source.All(v => v == -1);
			var actual = source.AllF(v => v == -1);

			Assert.Equal(expected, actual);
		}
	}
}