using System.Linq;
using JM.LinqFaster.SIMD.Parallel;
using NUnit.Framework;
using static LinqFaster.Tests.Test;

namespace LinqFaster.Tests.ParallelSIMDTests {
    [TestFixture]
    class SequenceEqualsSIMDParallelTests {

        [Test]
        public void SequenceEqualArray()
        {
            var intArray2 = (int[])intArray.Clone();
            var a = LinqFasterSIMDParallel.SequenceEqualSP(intArray, intArray2);
            var b = Enumerable.SequenceEqual(intArray, intArray2);

            Assert.That(a, Is.EqualTo(b));
        }

        [Test]
        public void SequenceNotEqualArray()
        {
            var intArray2 = (int[])intArray.Clone();
            intArray2[3] = -10;
            var a = LinqFasterSIMDParallel.SequenceEqualSP(intArray, intArray2);
            var b = Enumerable.SequenceEqual(intArray, intArray2);

            Assert.That(a, Is.EqualTo(b));
        }    

    }
}
