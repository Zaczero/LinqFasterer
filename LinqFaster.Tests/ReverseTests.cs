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
			var actual = source.ReverseF();

			Assert.Equal(expected, actual);
		}

		[Theory]
		[Trait(nameof(LinqFasterer.ReverseF), null)]
		[MemberData(nameof(TestArray), typeof(int), 5, 0, 100)]
		public void ReverseForceCloneTest_Int(IList<int> source)
		{
			var expected = source.Reverse().ToArray();
			var actual = source.ReverseF(true);

			Assert.Equal(expected, actual);
		}
	}
}