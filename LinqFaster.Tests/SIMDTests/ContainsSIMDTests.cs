using System.Linq;
using JM.LinqFaster.SIMD;
using NUnit.Framework;

namespace LinqFaster.Tests.SIMDTests
{
    [TestFixture]
    class ContainsSIMDTests
    {

        [Test]
        public void ContainsSIMDYes()
        {
            var a = Test.intArray.Contains(0);
            var b = Test.intArray.ContainsS(0);

            Assert.That(a, Is.EqualTo(b));
        }

        [Test]
        public void ContainsSIMDNo()
        {
            var a = Test.longArray.Contains(9999999);
            var b = Test.longArray.ContainsS(9999999);

            Assert.That(a, Is.EqualTo(b));
        }
        
    }
}