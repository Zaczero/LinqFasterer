using JM.LinqFaster;
using NUnit.Framework;
using System.Linq;
using static LinqFaster.Tests.Test;

namespace LinqFaster.Tests
{
	[TestFixture]
	public class ElementAtTests
	{
		[Test]
		public void ElementAtArray()
		{
			for (var i = 0; i < intArray.Length; i++)
			{
				var a = intArray.ElementAtF(i);
				var b = intArray.ElementAt(i);
				Assert.That(a, Is.EqualTo(b));
			}
		}

		[Test]
		public void ElementAtList()
		{
			for (var i = 0; i < intList.Count; i++)
			{
				var a = intList.ElementAtF(i);
				var b = intList.ElementAt(i);
				Assert.That(a, Is.EqualTo(b));
			}
		}
	}
}