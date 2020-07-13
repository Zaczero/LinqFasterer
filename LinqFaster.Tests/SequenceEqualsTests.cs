using NUnit.Framework;
using JM.LinqFaster;
using System.Linq;
using static Tests.Test;
using System.Collections.Generic;

namespace Tests {
    [TestFixture]
    class SequenceEqualsTests {

        [Test]
        public void SequenceEqualArray() {
            var intArray2 = (int[])intArray.Clone();
            var a = LinqFaster.SequenceEqualF(intArray, intArray2);
            var b = Enumerable.SequenceEqual(intArray, intArray2);

            Assert.That(a, Is.EqualTo(b));
        }

        [Test]
        public void SequenceNotEqualArray() {
            var intArray2 = (int[])intArray.Clone();
            intArray2[3] = -10;
            var a = LinqFaster.SequenceEqualF(intArray, intArray2);
            var b = Enumerable.SequenceEqual(intArray, intArray2);

            Assert.That(a, Is.EqualTo(b));
        }

        [Test]
        public void SequenceEqualList() {
            var intList2 = intList.ToList();
            var a = LinqFaster.SequenceEqualF(intList, intList2);
            var b = Enumerable.SequenceEqual(intList, intList2);

            Assert.That(a, Is.EqualTo(b));
        }

        [Test]
        public void SequenceNotEqualList() {
            var testList = intList.ToList();
            testList[3] = -10;
            var a = LinqFaster.SequenceEqualF(intList, testList);
            var b = Enumerable.SequenceEqual(intList, testList);

            Assert.That(a, Is.EqualTo(b));
        }

        [Test]
        public void SequenceEqualListAndArray() {
            var a = LinqFaster.SequenceEqualF(intList, intArray);
            var b = Enumerable.SequenceEqual(intList, intArray);

            Assert.That(a, Is.EqualTo(b));
        }

        [Test]
        public void SequenceNotEqualListAndArray() {
            var testList = new List<int>();
            int[] testArray = { 1, 2, 3, 4, };
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);

            var a = LinqFaster.SequenceEqualF(intArray, testList);
            var b = Enumerable.SequenceEqual(intArray, testList);

            Assert.That(a, Is.EqualTo(b));
        }




    }
}
