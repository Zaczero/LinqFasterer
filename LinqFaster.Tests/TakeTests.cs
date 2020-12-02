using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace LinqFasterer.Tests
{
	public partial class Test
	{
		[Theory]
		[Trait(nameof(LinqFasterer.TakeF), null)]
		[MemberData(nameof(TestArray), typeof(int), 15, 0, 5)]
		[MemberData(nameof(TestArray), typeof(int), 15, 0, 100)]
		[MemberData(nameof(TestArray), typeof(int), 15, -5, -1)]
		[MemberData(nameof(TestArray), typeof(int), 15, 50, 100)]
		public void TakeTest_Int(IList<int> source)
		{
			foreach (var i in source)
			{
				var expected = source.Take(i).ToArray();
				var actual = source.TakeF(i, true).ToArrayF();

				Assert.Equal(expected, actual);
			}
		}

		[Theory]
		[Trait(nameof(LinqFasterer.TakeLastF), null)]
		[MemberData(nameof(TestArray), typeof(int), 15, 0, 5)]
		[MemberData(nameof(TestArray), typeof(int), 15, 0, 100)]
		[MemberData(nameof(TestArray), typeof(int), 15, -5, -1)]
		[MemberData(nameof(TestArray), typeof(int), 15, 50, 100)]
		public void TakeLastTest_Int(IList<int> source)
		{
			foreach (var i in source)
			{
				var expected = source.TakeLast(i).ToArray();
				var actual = source.TakeLastF(i, true).ToArrayF();

				Assert.Equal(expected, actual);
			}
		}

		[Theory]
		[Trait(nameof(LinqFasterer.TakeWhileF), null)]
		[MemberData(nameof(TestArray), typeof(int), 15, 0, 5)]
		[MemberData(nameof(TestArray), typeof(int), 15, 0, 100)]
		[MemberData(nameof(TestArray), typeof(int), 15, -5, -1)]
		[MemberData(nameof(TestArray), typeof(int), 15, 50, 100)]
		public void TakeWhileTest_Int(IList<int> source)
		{
			var expected = source.TakeWhile(v => v > 2).ToArray();
			var actual = source.TakeWhileF(v => v > 2, true).ToArrayF();
			var actualIndexed = source.TakeWhileF((v, i) => v > 2, true).ToArrayF();

			Assert.Equal(expected, actual);
			Assert.Equal(expected, actualIndexed);
		}
	}
}