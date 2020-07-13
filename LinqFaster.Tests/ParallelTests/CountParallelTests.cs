using System.Linq;
using JM.LinqFaster.Parallel;
using NUnit.Framework;
using static LinqFaster.Tests.Test;

namespace LinqFaster.Tests.ParallelTests
{
    [TestFixture]
    class CountParallel
    {
        [Test]
        public void ParallelCountArray()
        {
            var a = intArray.CountP(onlyEvenInts);
            var b = intArray.Count(onlyEvenInts);

            Assert.That(a, Is.EqualTo(b));
        }


        [Test]
        public void ParallelCountList()
        {
            var a = intList.CountP(onlyEvenInts);
            var b = intList.Count(onlyEvenInts);

            Assert.That(a, Is.EqualTo(b));
        }
    }
}
