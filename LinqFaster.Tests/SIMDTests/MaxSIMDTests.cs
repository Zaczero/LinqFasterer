using System.Linq;
using JM.LinqFaster.SIMD;
using NUnit.Framework;

namespace LinqFaster.Tests.SIMDTests
{
    [TestFixture]
    class MaxSIMDTests
    {

        [Test]
        public void MaxSIMDInts()
        {
            var a = Test.intArray.MaxS();
            var b = Test.intArray.Max();

            Assert.That(a, Is.EqualTo(b));
        }

        [Test]
        public void MaxSIMDLongs()
        {
            var a = Test.longArray.MaxS();
            var b = Test.longArray.Max();

            Assert.That(a, Is.EqualTo(b));
        }

        [Test]
        public void MaxSIMDDoubles()
        {
            var a = Test.doubleArray.MaxS();
            var b = Test.doubleArray.Max();

            Assert.That(a, Is.EqualTo(b));
        }
    }
}