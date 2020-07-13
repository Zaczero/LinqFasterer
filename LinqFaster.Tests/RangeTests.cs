using System.Linq;
using NUnit.Framework;

namespace LinqFaster.Tests
{
    [TestFixture]
    class RangeTests
    {
        [Test]
        public void RangeArray()
        {
            var a = JM.LinqFaster.LinqFaster.RangeArrayF(-100, 200);
            var b = Enumerable.Range(-100, 200).ToArray();

            Assert.That(a, Is.EqualTo(b));
        }

        [Test]
        public void RangeList()
        {
            var a = JM.LinqFaster.LinqFaster.RangeListF(-100, 200);
            var b = Enumerable.Range(-100, 200).ToList();

            Assert.That(a, Is.EqualTo(b));
        }

    }
}
