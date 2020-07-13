using System;
using System.Collections.Generic;
using System.Linq;
using JM.LinqFaster.Parallel;
using NUnit.Framework;
using static LinqFaster.Tests.Test;

namespace LinqFaster.Tests.ParallelTests
{
    [TestFixture]
    class MinParallel
    {

        public void HelperMin<T>(T[] array)
        {
            var a = array.MinP();
            var b = array.Min();

            Assert.That(a, Is.EqualTo(b));
        }

        public void HelperMin<T>(List<T> list)
        {
            var a = list.MinP();
            var b = list.Min();

            Assert.That(a, Is.EqualTo(b));
        }

        public void HelperMin<T, U>(T[] array, Func<T, U> selector)
        {
            var a = array.MinP(selector);
            var b = array.Min(selector);

            Assert.That(a, Is.EqualTo(b));
        }

        public void HelperMin<T, U>(List<T> list, Func<T, U> selector)
        {
            var a = list.MinP(selector);
            var b = list.Min(selector);

            Assert.That(a, Is.EqualTo(b));
        }

        [Test]
        public void ParallelMinArray()
        {
            HelperMin(intArray);
            HelperMin(floatArray);
            HelperMin(intArray, x => x.ToString());
            HelperMin(floatArray, x => x.ToString());
            HelperMin(stringArray);
            HelperMin(stringArray, x => (string)null);
            HelperMin(stringArray, x => int.Parse(x));
        }

        [Test]
        public void ParallelMinList()
        {
            HelperMin(intList);
            HelperMin(floatList);
            HelperMin(intList, x => x.ToString());
            HelperMin(floatList, x => x.ToString());
            HelperMin(stringList, x => (string)null);
            HelperMin(stringList, x => int.Parse(x));
        }
    }
}

