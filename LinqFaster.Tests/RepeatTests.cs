using System.Linq;
using Xunit;

namespace LinqFasterer.Tests
{
	public partial class Test
	{
		[Fact]
		[Trait(nameof(LinqFasterer.RepeatF), null)]
		public void RepeatTest_Int()
		{
			var expected = Enumerable.Repeat(5, 100);
			var actual = LinqFasterer.RepeatF(5, 100);

			Assert.Equal(expected, actual);
		}
	}
}