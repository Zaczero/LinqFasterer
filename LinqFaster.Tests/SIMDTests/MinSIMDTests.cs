using System.Linq;
using JM.LinqFaster.SIMD;
using NUnit.Framework;

namespace LinqFaster.Tests.SIMDTests
{
    [TestFixture]
    class MinSIMDTests
    {

        [Test]
        public void MinSIMDLongs()
        { 
            var a = Test.longArray.MinS();
            var b = Test.longArray.Min();

            Assert.That(a, Is.EqualTo(b));
        }

        [Test]
        public void MinSIMDFloats()
        {
            var a = Test.floatArray.MinS();
            var b = Test.floatArray.Min();

            Assert.That(a, Is.EqualTo(b));
        }
    }
}