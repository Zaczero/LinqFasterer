using System.Linq;
using JM.LinqFaster.SIMD;
using NUnit.Framework;

namespace LinqFaster.Tests.SIMDTests
{
    [TestFixture]
    class SelectSIMDTests
    {

        [Test]
        public void SelectSIMD()
        {
            var a = Test.intArray.Select(x => x * x).ToArray();
            var b = Test.intArray.SelectS(x => x * x);

            Assert.That(a, Is.EqualTo(b));
        }

        
        
    }
}