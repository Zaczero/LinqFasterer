using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace LinqFasterer.Tests
{
	public partial class Test
	{
		[Theory]
		[Trait(nameof(LinqFasterer.ReverseF), null)]
		[MemberData(nameof(TestArray), typeof(int), 5, 0, 100)]
		public void ReverseTest_Int(IList<int> source)
		{
			var expected = source.Reverse().ToArray();
			var actual = source.ReverseF().ToArrayF();

			Assert.Equal(expected, actual);
		}
	}
}