using System;
using System.Collections.Generic;
using System.Linq;
using JM.LinqFaster.Parallel;
using NUnit.Framework;
using static LinqFaster.Tests.Test;

namespace LinqFaster.Tests.ParallelTests
{
    [TestFixture]
    class MaxParallel
    {

        public void HelperMax<T>(T[] array)
        {
            var a = array.MaxP();
            var b = array.Max();

            Assert.That(a, Is.EqualTo(b));
        }

        public void HelperMax<T>(List<T> list)
        {
            var a = list.MaxP();
            var b = list.Max();

            Assert.That(a, Is.EqualTo(b));
        }

        public void HelperMax<T, U>(T[] array, Func<T, U> selector)
        {
            var a = array.MaxP(selector);
            var b = array.Max(selector);

            Assert.That(a, Is.EqualTo(b));
        }

        public void HelperMax<T, U>(List<T> list, Func<T, U> selector)
        {
            var a = list.MaxP(selector);
            var b = list.Max(selector);

            Assert.That(a, Is.EqualTo(b));
        }

        [Test]
        public void ParallelMaxArray()
        {
            HelperMax(intArray);
            HelperMax(floatArray);
            HelperMax(intArray, x => x.ToString());
            HelperMax(floatArray, x => x.ToString());
            HelperMax(stringArray);
            HelperMax(stringArray, x => (string)null);
            HelperMax(stringArray, x => int.Parse(x));
        }

        [Test]
        public void ParallelMaxList()
        {
            HelperMax(intList);
            HelperMax(floatList);
            HelperMax(intList, x => x.ToString());
            HelperMax(floatList, x => x.ToString());
            HelperMax(stringList);
            HelperMax(stringList, x => (string)null);
            HelperMax(stringList, x => int.Parse(x));
        }
    }
}

