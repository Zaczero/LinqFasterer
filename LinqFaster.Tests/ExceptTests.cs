using System.Collections.Generic;
using System.Linq;
using LinqFasterer.Shared;
using Xunit;

namespace LinqFasterer.Tests
{
	public partial class Test
	{
		[Theory]
		[Trait(nameof(LinqFasterer.ExceptF), null)]
		[MemberData(nameof(Utilities.TestArray), typeof(int), 5, 0, 100, MemberType = typeof(Utilities))]
		[MemberData(nameof(Utilities.TestArray), typeof(int), 10, 0, 2, MemberType = typeof(Utilities))]
		[MemberData(nameof(Utilities.TestArray), typeof(int), 50, 0, 5, MemberType = typeof(Utilities))]
		public void ExceptTest_Int(IList<int> source)
		{
			var (first, second) = Utilities.SplitArray(source, source.Count / 2);

			var expected = first.Except(second).ToArray();
			var actual = first.ExceptF(second).ToArrayF();

			Assert.Equal(expected, actual);
		}
	}
}