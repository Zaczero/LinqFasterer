using System;
using System.Linq;
using JM.LinqFaster;
using NUnit.Framework;
using static LinqFaster.Tests.Test;

namespace LinqFaster.Tests
{
    [TestFixture]
    class DefaultIfEmptyTests {

        [Test]
        public void DefaultIfEmptyArray() {
            var a = intArray.DefaultIfEmptyF();
            var b = intArray.DefaultIfEmpty();

            Assert.That(a, Is.EqualTo(b));
        }

        [Test]
        public void DefaultIfEmptySpan() {
            var a = intArray.AsSpan().DefaultIfEmptyF();
            var b = intArray.DefaultIfEmpty();

            Assert.That(a.ToArray(), Is.EqualTo(b));
        }

        [Test]
        public void DefaultIfEmptyList() {
            var a = intList.DefaultIfEmptyF();
            var b = intList.DefaultIfEmpty();

            Assert.That(a, Is.EqualTo(b));
        }
    }
}