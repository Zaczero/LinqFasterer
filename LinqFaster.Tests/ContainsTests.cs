using JM.LinqFaster;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using static LinqFaster.Tests.Test;

namespace LinqFaster.Tests
{
    [TestFixture]
    public class ContainsTests
    {
        [Test]
        public void ContainsStringArrayTrue()
        {
            var a = stringArray.ContainsF("0", EqualityComparer<string>.Default);
            var b = stringArray.Contains("0", EqualityComparer<string>.Default);
            Assert.That(a, Is.EqualTo(b));
        }

        [Test]
        public void ContainsStringArrayFalse()
        {
            var a = stringArray.ContainsF("no Match", EqualityComparer<string>.Default);
            var b = stringArray.Contains("no Match", EqualityComparer<string>.Default);
            Assert.That(a, Is.EqualTo(b));
        }

        [Test]
        public void ContainsStringListTrue()
        {
            var a = stringList.ContainsF("0", EqualityComparer<string>.Default);
            var b = stringList.Contains("0", EqualityComparer<string>.Default);
            Assert.That(a, Is.EqualTo(b));
        }

        [Test]
        public void ContainsStringListFalse()
        {
            var a = stringList.ContainsF("no match", EqualityComparer<string>.Default);
            var b = stringList.Contains("no match", EqualityComparer<string>.Default);
            Assert.That(a, Is.EqualTo(b));
        }
    }
}
