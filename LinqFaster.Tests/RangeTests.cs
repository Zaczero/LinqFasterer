using System.Linq;
using Xunit;

namespace LinqFasterer.Tests
{
	public partial class Test
	{
		[Fact]
		[Trait(nameof(LinqFasterer.RangeF), null)]
		public void RangeTest_Int()
		{
			var expected = Enumerable.Range(5, 100);
			var actual = LinqFasterer.RangeF(5, 100);

			Assert.Equal(expected, actual);
		}

		[Theory]
		[Trait(nameof(LinqFasterer.RangeF), null)]
		[InlineData(new [] {1,0,-1,-2,-3}, 1, 5, -1)]
		[InlineData(new [] {1,1,1,1,1}, 1, 5, 0)]
		[InlineData(new [] {1,3,5,7,9}, 1, 5, 2)]
		public void RangeTest_IntChange(int[] expected, int start, int count, int change)
		{
			Assert.Equal(expected, LinqFasterer.RangeF(start, count, change));
		}
	}
}