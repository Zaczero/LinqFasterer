using System.Collections.Generic;
using System.Linq;
using JM.LinqFaster.Parallel;
using NUnit.Framework;
using static LinqFaster.Tests.Test;

namespace LinqFaster.Tests.ParallelTests
{
    [TestFixture]
    class ContainsParallel
    {
        [Test]
        public void ParallelContainsStringArrayTrue()
        {
            var a = stringArray.ContainsP("0", EqualityComparer<string>.Default);
            var b = stringArray.Contains("0", EqualityComparer<string>.Default);

            Assert.That(a, Is.EqualTo(b));
        }

        [Test]
        public void ParallelContainsStringArrayFalse()
        {
            var a = stringArray.ContainsP("No Match", EqualityComparer<string>.Default);
            var b = stringArray.Contains("No Match", EqualityComparer<string>.Default);

            Assert.That(a, Is.EqualTo(b));
        }

        [Test]
        public void ParallelContainsStringListTrue()
        {
            var a = stringList.ContainsP("0", EqualityComparer<string>.Default);
            var b = stringList.Contains("0", EqualityComparer<string>.Default);

            Assert.That(a, Is.EqualTo(b));
        }

        [Test]
        public void ParallelContainsStringListFalse()
        {
            var a = stringList.ContainsP("no match", EqualityComparer<string>.Default);
            var b = stringList.Contains("no match", EqualityComparer<string>.Default);

            Assert.That(a, Is.EqualTo(b));
        }
    }
}
