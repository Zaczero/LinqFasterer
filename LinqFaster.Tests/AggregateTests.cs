using System.Linq;
using JM.LinqFaster;
using NUnit.Framework;
using static LinqFaster.Tests.Test;

namespace LinqFaster.Tests
{
    [TestFixture]
    public class AggregateTests
    {
        [Test]
        public void AggregateArray()
        {
            var a = intArray.AggregateF(addXInts);
            var b = intArray.Aggregate(addXInts);
            Assert.That(a, Is.EqualTo(b));
            
            static string Func(string acc, int x) => acc + x;

            const string seed = "seed";
            var c = intArray.AggregateF(seed, Func);
            var d = intArray.Aggregate(seed, Func);
            Assert.That(c, Is.EqualTo(d));

            var e = intArray.AggregateF(seed, Func, x => "");
            var f = intArray.Aggregate(seed, Func, x => "");
            Assert.That(e, Is.EqualTo(f));
        }

        [Test]
        public void AggregateList()
        {
            var a = intList.AggregateF(addXInts);
            var b = intList.Aggregate(addXInts);
            Assert.That(a, Is.EqualTo(b));

            static string Func(string acc, int x) => acc + x;

            const string seed = "seed";
            var c = intList.AggregateF(seed, Func);
            var d = intList.Aggregate(seed, Func);
            Assert.That(c, Is.EqualTo(d));

            var e = intList.AggregateF(seed, Func, x => "");
            var f = intList.Aggregate(seed, Func, x => "");
            Assert.That(e, Is.EqualTo(f));
        }
    }
}
