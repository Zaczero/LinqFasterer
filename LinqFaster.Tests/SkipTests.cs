using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace LinqFasterer.Tests
{
	public partial class Test
	{
		[Theory]
		[Trait(nameof(LinqFasterer.SkipF), null)]
		[MemberData(nameof(TestArray), typeof(int), 15, 0, 5)]
		[MemberData(nameof(TestArray), typeof(int), 15, 0, 100)]
		[MemberData(nameof(TestArray), typeof(int), 15, -5, -1)]
		[MemberData(nameof(TestArray), typeof(int), 15, 50, 100)]
		public void SkipTest_Int(IList<int> source)
		{
			foreach (var i in source)
			{
				var expected = source.Skip(i).ToArray();
				var actual = source.SkipF(i, true).ToArrayF();

				Assert.Equal(expected, actual);
			}
		}

		[Theory]
		[Trait(nameof(LinqFasterer.SkipLastF), null)]
		[MemberData(nameof(TestArray), typeof(int), 15, 0, 5)]
		[MemberData(nameof(TestArray), typeof(int), 15, 0, 100)]
		[MemberData(nameof(TestArray), typeof(int), 15, -5, -1)]
		[MemberData(nameof(TestArray), typeof(int), 15, 50, 100)]
		public void SkipLastTest_Int(IList<int> source)
		{
			foreach (var i in source)
			{
				var expected = source.SkipLast(i).ToArray();
				var actual = source.SkipLastF(i, true).ToArrayF();

				Assert.Equal(expected, actual);
			}
		}

		[Theory]
		[Trait(nameof(LinqFasterer.SkipWhileF), null)]
		[MemberData(nameof(TestArray), typeof(int), 15, 0, 5)]
		[MemberData(nameof(TestArray), typeof(int), 15, 0, 100)]
		[MemberData(nameof(TestArray), typeof(int), 15, -5, -1)]
		[MemberData(nameof(TestArray), typeof(int), 15, 50, 100)]
		public void SkipWhileTest_Int(IList<int> source)
		{
			var expected = source.SkipWhile(v => v > 2).ToArray();
			var actual = source.SkipWhileF(v => v > 2, true).ToArrayF();
			var actualIndexed = source.SkipWhileF((v, i) => v > 2, true).ToArrayF();

			Assert.Equal(expected, actual);
			Assert.Equal(expected, actualIndexed);
		}
	}
}