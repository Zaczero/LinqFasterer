using System;
using System.Collections.Generic;
using System.Linq;
using JM.LinqFaster;
using NUnit.Framework;
using static LinqFaster.Tests.Test;

namespace LinqFaster.Tests
{
    [TestFixture]
    class MaxTests
    {        
        public void HelperMax<T>(T[] array)
        {
            var a = array.MaxF();
            var b = array.Max();

            Assert.That(a, Is.EqualTo(b));            
        }

        public void HelperMax<T>(List<T> list)
        {
            var a = list.MaxF();
            var b = list.Max();

            Assert.That(a, Is.EqualTo(b));
        }

        public void HelperMax<T,U>(T[] array, Func<T, U> selector)
        {
            var a = array.MaxF(selector);
            var b = array.Max(selector);

            Assert.That(a, Is.EqualTo(b));
        }

        public void HelperMax<T,U>(List<T> list, Func<T,U> selector)
        {
            var a = list.MaxF(selector);
            var b = list.Max(selector);

            Assert.That(a, Is.EqualTo(b));
        }

        [Test]
        public void MaxArray()
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
        public void MaxList()
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
