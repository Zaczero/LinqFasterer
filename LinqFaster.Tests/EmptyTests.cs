using System.Linq;
using Xunit;

namespace LinqFasterer.Tests
{
	public partial class Test
	{
		[Fact]
		[Trait(nameof(LinqFasterer.EmptyF), null)]
		public void EmptyTest_Int()
		{
			var expected = Enumerable.Empty<int>();
			var actual = LinqFasterer.EmptyF<int>();

			Assert.Equal(expected, actual);
		}
	}
}