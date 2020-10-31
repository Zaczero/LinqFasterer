using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace LinqFasterer.Tests
{
	public partial class Test
	{
		[Theory]
		[Trait(nameof(LinqFasterer.SelectF), null)]
		[MemberData(nameof(TestArray), typeof(int), 0, 0, 100)]
		[MemberData(nameof(TestArray), typeof(int), 5, 0, 100)]
		public void SelectTest_Int(IList<int> source)
		{
			var expected = source.Select(v => -v).ToArray();
			var actual = source.SelectF(v => -v);
			var actualIndexed = source.SelectF((v, i) => -v);

			Assert.Equal(expected, actual);
			Assert.Equal(expected, actualIndexed);
		}

		[Theory]
		[Trait(nameof(LinqFasterer.SelectInPlaceF), null)]
		[MemberData(nameof(TestArray), typeof(int), 0, 0, 100)]
		[MemberData(nameof(TestArray), typeof(int), 5, 0, 100)]
		public void SelectInPlaceTest_Int(IList<int> source)
		{
			var expected = source.Select(v => -v).ToArray();

			var actual = new List<int>(source);
			actual.SelectInPlaceF(v => -v);

			var actualIndexed = new List<int>(source);
			actualIndexed.SelectInPlaceF((v, i) => -v);

			Assert.Equal(expected, actual);
			Assert.Equal(expected, actualIndexed);
		}
	}
}