using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace LinqFasterer.Tests
{
	public partial class Test
	{
		[Theory]
		[Trait(nameof(LinqFasterer.ToArrayF), null)]
		[MemberData(nameof(TestArray), typeof(int), 5, 0, 100)]
		public void ToArrayTest_Int(IList<int> source)
		{
			var expected = source.ToArray();
			var actual = source.ToArrayF();

			Assert.Equal(expected, actual);
		}

		[Theory]
		[Trait(nameof(LinqFasterer.ToListF), null)]
		[MemberData(nameof(TestArray), typeof(int), 5, 0, 100)]
		public void ToListTest_Int(IList<int> source)
		{
			var expected = source.ToList();
			var actual = source.ToListF();

			Assert.Equal(expected, actual);
		}
	}
}