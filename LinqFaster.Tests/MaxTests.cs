using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace LinqFasterer.Tests
{
	public partial class Test
	{
		[Theory]
		[Trait(nameof(LinqFasterer.MaxF), null)]
		[MemberData(nameof(TestArray), typeof(int), 5, 0, 100)]
		[MemberData(nameof(TestArray), typeof(int), 10, 0, 2)]
		[MemberData(nameof(TestArray), typeof(int), 50, 0, 5)]
		public void MaxTest_Int(IList<int> source)
		{
			var expected = source.Max();
			var actual = source.MaxF();

			Assert.Equal(expected, actual);
		}

		[Theory]
		[Trait(nameof(LinqFasterer.MaxF), null)]
		[MemberData(nameof(TestArray), typeof(int), 5, 0, 100)]
		[MemberData(nameof(TestArray), typeof(int), 10, 0, 2)]
		[MemberData(nameof(TestArray), typeof(int), 50, 0, 5)]
		public void MaxTest_IntSelector(IList<int> source)
		{
			var expected = source.Max(v => -v);
			var actual = source.MaxF(v => -v);

			Assert.Equal(expected, actual);
		}
	}
}