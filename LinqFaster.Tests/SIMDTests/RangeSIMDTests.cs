using System.Linq;
using JM.LinqFaster.SIMD;
using NUnit.Framework;

namespace LinqFaster.Tests.SIMDTests
{
    [TestFixture]
    class RangeSIMDTests
    {

        [Test]
        public void RangeSIMD()
        {
            var a = LinqFasterSIMD.RangeS(-100, 100);
            var b = Enumerable.Range(-100, 100);

            Assert.That(a, Is.EqualTo(b));
        }

      
    }
}