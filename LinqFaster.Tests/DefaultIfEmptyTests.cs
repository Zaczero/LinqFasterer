using NUnit.Framework;
using JM.LinqFaster;
using System.Linq;
using static Tests.Test;

namespace Tests
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
        public void DefaultIfEmptyList() {
            var a = intList.DefaultIfEmptyF();
            var b = intList.DefaultIfEmpty();

            Assert.That(a, Is.EqualTo(b));
        }
    }
}