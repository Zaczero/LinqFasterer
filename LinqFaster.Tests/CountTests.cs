using JM.LinqFaster;
using NUnit.Framework;
using System.Linq;
using static LinqFaster.Tests.Test;

namespace LinqFaster.Tests
{
    [TestFixture]
    public class CountTests
    {
        [Test]
        public void CountArray()
        {
            var a = intArray.CountF(onlyEvenInts);
            var b = intArray.Count(onlyEvenInts);
            Assert.That(a, Is.EqualTo(b));
        }

        [Test]
        public void CountList()
        {
            var a = intList.CountF(onlyEvenInts);
            var b = intList.Count(onlyEvenInts);
            Assert.That(a, Is.EqualTo(b));
        }

        [Test]
        public void LongCountArray()
        {
            var a = intArray.LongCountF(onlyEvenInts);
            var b = intArray.LongCount(onlyEvenInts);
            Assert.That(a, Is.EqualTo(b));
        }

        [Test]
        public void LongCountList()
        {
            var a = intList.LongCountF(onlyEvenInts);
            var b = intList.LongCount(onlyEvenInts);
            Assert.That(a, Is.EqualTo(b));
        }
    }
}
