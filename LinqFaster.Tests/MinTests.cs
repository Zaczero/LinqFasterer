using System;
using System.Collections.Generic;
using System.Linq;
using JM.LinqFaster;
using NUnit.Framework;
using static LinqFaster.Tests.Test;

namespace LinqFaster.Tests
{
    [TestFixture]
    class MinTests
    {
        public void HelperMin<T>(T[] array)
        {
            var a = array.MinF();
            var b = array.Min();

            Assert.That(a, Is.EqualTo(b));
        }

        public void HelperMin<T>(List<T> list)
        {
            var a = list.MinF();
            var b = list.Min();

            Assert.That(a, Is.EqualTo(b));
        }

        public void HelperMin<T, U>(T[] array, Func<T, U> selector)
        {
            var a = array.MinF(selector);
            var b = array.Min(selector);

            Assert.That(a, Is.EqualTo(b));
        }

        public void HelperMin<T, U>(List<T> list, Func<T, U> selector)
        {
            var a = list.MinF(selector);
            var b = list.Min(selector);

            Assert.That(a, Is.EqualTo(b));
        }

        [Test]
        public void MinArray()
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
        public void MinList()
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
