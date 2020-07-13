using System;
using System.Linq;
using JM.LinqFaster.Parallel;
using NUnit.Framework;
using static LinqFaster.Tests.Test;

namespace LinqFaster.Tests.ParallelTests
{
    [TestFixture]
    class SumParallel
    {
        [Test]
        public void ParallelSumArray()
        {
            var a = intArray.SumP();
            var b = intArray.Sum();

            Assert.That(a, Is.EqualTo(b));

            var c = floatArray.SumP();
            var d = floatArray.Sum();

            var diff = Math.Abs(c - d);
            Assert.That(diff, Is.LessThan(0.1));

            var e = decimalArray.SumP();
            var f = decimalArray.Sum();

            var diff2 = Math.Abs(e-f);
            Assert.That(diff2, Is.LessThan(0.1));

            
        }

        [Test]
        public void ParallelSumArraySelector()
        {
            var a = intArray.SumP(x => x + 1);
            var b = intArray.Sum(x => x + 1);

            Assert.That(a, Is.EqualTo(b));

            var c = floatArray.SumP(squaredFloats);
            var d = floatArray.Sum(squaredFloats);

            var diff = Math.Abs(c - d);
            Assert.That(diff, Is.LessThan(0.1));
            
        }

        [Test]
        public void ParallelSumList()
        {
            var a = intList.SumP();
            var b = intList.Sum();

            Assert.That(a, Is.EqualTo(b));

            var c = floatList.SumP();
            var d = floatList.Sum();

            var diff = Math.Abs(c - d);
            Assert.That(diff, Is.LessThan(0.1));

            var e = decimalList.SumP();
            var f = decimalList.Sum();

            var diff2 = Math.Abs(e - f);
            Assert.That(diff2, Is.LessThan(0.1));
        }

        [Test]
        public void ParallelSumListSelector()
        {
            var a = intList.SumP(x => x + 1);
            var b = intList.Sum(x => x + 1);

            Assert.That(a, Is.EqualTo(b));

            var c = floatList.SumP(squaredFloats);
            var d = floatList.Sum(squaredFloats);

            var diff = Math.Abs(c - d);
            Assert.That(diff, Is.LessThan(0.1));
            
        }

    }
}
