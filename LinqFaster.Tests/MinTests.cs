using System.Collections.Generic;
using System.Linq;
using LinqFasterer.Shared;
using Xunit;

namespace LinqFasterer.Tests
{
	public partial class Test
	{
		[Theory]
		[Trait(nameof(LinqFasterer.MinF), null)]
		[MemberData(nameof(Utilities.TestArray), typeof(int), 5, 0, 100, MemberType = typeof(Utilities))]
		[MemberData(nameof(Utilities.TestArray), typeof(int), 10, 0, 2, MemberType = typeof(Utilities))]
		[MemberData(nameof(Utilities.TestArray), typeof(int), 50, 0, 5, MemberType = typeof(Utilities))]
		public void MinTest_Int(IList<int> source)
		{
			var expected = source.Min();
			var actual = source.MinF();

			Assert.Equal(expected, actual);
		}

		[Theory]
		[Trait(nameof(LinqFasterer.MinF), null)]
		[MemberData(nameof(Utilities.TestArray), typeof(int), 5, 0, 100, MemberType = typeof(Utilities))]
		[MemberData(nameof(Utilities.TestArray), typeof(int), 10, 0, 2, MemberType = typeof(Utilities))]
		[MemberData(nameof(Utilities.TestArray), typeof(int), 50, 0, 5, MemberType = typeof(Utilities))]
		public void MinTest_IntNullable(IList<int> source)
		{
			var expected = source.Cast<int?>().ToArray().Min();
			var actual = source.Cast<int?>().ToArray().MinF();

			Assert.Equal(expected, actual);
		}

		[Theory]
		[Trait(nameof(LinqFasterer.MinF), null)]
		[MemberData(nameof(Utilities.TestArray), typeof(int), 5, 0, 100, MemberType = typeof(Utilities))]
		[MemberData(nameof(Utilities.TestArray), typeof(int), 10, 0, 2, MemberType = typeof(Utilities))]
		[MemberData(nameof(Utilities.TestArray), typeof(int), 50, 0, 5, MemberType = typeof(Utilities))]
		public void MinTest_IntSelector(IList<int> source)
		{
			var expected = source.Min(v => -v);
			var actual = source.MinF(v => -v);

			Assert.Equal(expected, actual);
		}

		[Theory]
		[Trait(nameof(LinqFasterer.MinF), null)]
		[MemberData(nameof(Utilities.TestArray), typeof(int), 5, 0, 100, MemberType = typeof(Utilities))]
		[MemberData(nameof(Utilities.TestArray), typeof(int), 10, 0, 2, MemberType = typeof(Utilities))]
		[MemberData(nameof(Utilities.TestArray), typeof(int), 50, 0, 5, MemberType = typeof(Utilities))]
		public void MinTest_IntSelectorNullable(IList<int> source)
		{
			var expected = source.Cast<int?>().ToArray().Min(v => -v);
			var actual = source.Cast<int?>().ToArray().MinF(v => -v);

			Assert.Equal(expected, actual);
		}
	}
}