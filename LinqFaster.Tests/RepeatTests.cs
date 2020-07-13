using System.Linq;
using NUnit.Framework;

namespace LinqFaster.Tests
{
    [TestFixture]
    class RepeatTests
    {
        [Test]
        public void RepeatArray() {
            var a = JM.LinqFaster.LinqFaster.RepeatArrayF(2.0f, 10);
            var b = Enumerable.Repeat(2.0f, 10).ToList();

            Assert.That(a, Is.EqualTo(b));
        }

        [Test]
        public void RepeatList()
        {
            var a = JM.LinqFaster.LinqFaster.RepeatListF(2.0f, 10);
            var b = Enumerable.Repeat(2.0f, 10).ToList();

            Assert.That(a, Is.EqualTo(b));
        }
    }
}
