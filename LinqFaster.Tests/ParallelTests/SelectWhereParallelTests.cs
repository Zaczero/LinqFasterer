using System.Linq;
using JM.LinqFaster.Parallel;
using NUnit.Framework;
using static LinqFaster.Tests.Test;

namespace LinqFaster.Tests.ParallelTests
{
    [TestFixture]
    class SelectWhereParallel
    {

        [Test]
        public void ParallelSelectWhereArray()
        {
            var a = intArray.SelectWhereP(squaredInts, onlyEvenInts);
            var b = intArray.Select(squaredInts).Where(onlyEvenInts);

            Assert.That(a, Is.EqualTo(b));

            a = intArray.SelectWhereP((x, i) => x + i, (x, i) => x % 2 == 0);
            b = intArray.Select((x, i) => x + i).Where(onlyEvenInts);

            Assert.That(a, Is.EqualTo(b));
        }

        [Test]
        public void ParallelSelectWhereList()
        {
            var a = intList.SelectWhereP(squaredInts, onlyEvenInts);
            var b = intList.Select(squaredInts).Where(onlyEvenInts);

            Assert.That(a, Is.EqualTo(b));

            a = intList.SelectWhereP((x, i) => x + i, (x, i) => x % 2 == 0);
            b = intList.Select((x, i) => x + i).Where(onlyEvenInts);

            Assert.That(a, Is.EqualTo(b));
        }
    }
}

