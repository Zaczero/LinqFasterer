using JM.LinqFaster;
using NUnit.Framework;
using System.Linq;
using static LinqFaster.Tests.Test;

namespace LinqFaster.Tests
{
    [TestFixture]
    public class AverageTests
    {
        [Test]
        public void AverageArrayInt()
        {
            var a = intArray.AverageF();
            var b = intArray.Average();
            Assert.That(a, Is.EqualTo(b));
        }

        [Test]
        public void AverageArrayLong()
        {
            var a = longArray.AverageF();
            var b = longArray.Average();
            Assert.That(a, Is.EqualTo(b));
        }

        [Test]
        public void AverageArrayFloat()
        {
            var x = floatArray;
            var a = floatArray.AverageF();
            var b = floatArray.Average();
            Assert.That(a, Is.EqualTo(b));
        }

        [Test]
        public void AverageArrayDouble()
        {
            var a = doubleArray.AverageF();
            var b = doubleArray.Average();
            Assert.That(a, Is.EqualTo(b));
        }

        [Test]
        public void AverageArrayDecimal()
        {
            var a = decimalArray.AverageF();
            var b = decimalArray.Average();
            Assert.That(a, Is.EqualTo(b));
        }

        [Test]
        public void AverageArrayString()
        {
            static float Func(string x) => int.Parse(x);

            var a = stringArray.AverageF(Func);
            var b = stringArray.Average(Func);
            Assert.That(a, Is.EqualTo(b));
        }

        [Test]
        public void AverageListInt()
        {
            var a = intList.AverageF();
            var b = intList.Average();
            Assert.That(a, Is.EqualTo(b));
        }

        [Test]
        public void AverageListLong()
        {
            var a = longList.AverageF();
            var b = longList.Average();
            Assert.That(a, Is.EqualTo(b));
        }

        [Test]
        public void AverageListFloat()
        {
            var a = floatList.AverageF();
            var b = floatList.Average();
            Assert.That(a, Is.EqualTo(b));
        }

        [Test]
        public void AverageListDouble()
        {
            var a = doubleList.AverageF();
            var b = doubleList.Average();
            Assert.That(a, Is.EqualTo(b));
        }

        [Test]
        public void AverageListDecimal()
        {
            var a = decimalList.AverageF();
            var b = decimalList.Average();
            Assert.That(a, Is.EqualTo(b));
        }

        [Test]
        public void AverageListString()
        {
            static float Func(string x) => int.Parse(x);

            var a = stringList.AverageF(Func);
            var b = stringList.Average(Func);
            Assert.That(a, Is.EqualTo(b));
        }
    }
}