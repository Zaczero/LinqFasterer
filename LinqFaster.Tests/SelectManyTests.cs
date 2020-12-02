using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace LinqFasterer.Tests
{
	public partial class Test
	{
		[Theory]
		[Trait(nameof(LinqFasterer.SelectManyF), null)]
		[MemberData(nameof(TestArray), typeof(int), 5, 0, 100)]
		public void SelectManyTest_Int(IList<int> source)
		{
			var expected = source.SelectMany(v => new [] {v, v, v}).ToArray();
			var actual = source.SelectManyF(v => new[] {v, v, v}).ToArrayF();
			var actualIndexed = source.SelectManyF((v, i) => new[] {v, v, v}).ToArrayF();

			Assert.Equal(expected, actual);
			Assert.Equal(expected, actualIndexed);
		}
	}
}