using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace LinqFasterer.Tests
{
	public partial class Test
	{
		[Fact]
		[Trait(nameof(LinqFasterer.DefaultIfEmptyF), null)]
		public void DefaultIfEmptyTest_Int()
		{
			var source = new int[0];

			var expected = source.DefaultIfEmpty();
			var actual = source.DefaultIfEmptyF();

			Assert.Equal(expected, actual);
		}

		[Fact]
		[Trait(nameof(LinqFasterer.DefaultIfEmptyF), null)]
		public void DefaultIfEmptyTest_IntDefault()
		{
			var source = new int[0];

			var expected = source.DefaultIfEmpty(int.MaxValue);
			var actual = source.DefaultIfEmptyF(int.MaxValue);

			Assert.Equal(expected, actual);
		}
	}
}