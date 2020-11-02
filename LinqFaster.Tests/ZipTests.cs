using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace LinqFasterer.Tests
{
	public partial class Test
	{
		[Theory]
		[Trait(nameof(LinqFasterer.ZipF), null)]
		[MemberData(nameof(TestArray), typeof(int), 5, 0, 100)]
		[MemberData(nameof(TestArray), typeof(int), 10, 0, 2)]
		[MemberData(nameof(TestArray), typeof(int), 50, 0, 5)]
		public void ZipTest_Int(IList<int> source)
		{
			var (first, second) = SplitArray(source, source.Count / 2);

			var expected = first.Zip(second);
			var actual = first.ZipF(second);

			Assert.Equal(expected, actual);
		}

		[Theory]
		[Trait(nameof(LinqFasterer.ZipF), null)]
		[MemberData(nameof(TestArray), typeof(int), 5, 0, 100)]
		[MemberData(nameof(TestArray), typeof(int), 10, 0, 2)]
		[MemberData(nameof(TestArray), typeof(int), 50, 0, 5)]
		public void ZipTest_IntSelector(IList<int> source)
		{
			var (first, second) = SplitArray(source, source.Count / 2);

			var expected = first.Zip(second, (l, r) => l * r);
			var actual = first.ZipF(second, (l, r) => l * r);

			Assert.Equal(expected, actual);
		}
	}
}