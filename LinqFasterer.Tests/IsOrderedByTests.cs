using System.Collections.Generic;
using System.Linq;
using LinqFasterer.Shared;
using Xunit;

namespace LinqFasterer.Tests
{
    public partial class Test
    {[Theory]
        [Trait(nameof(EnumerableF.IsOrderedByF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 5, 0, 100, MemberType = typeof(Utilities))]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 10, 0, 2, MemberType = typeof(Utilities))]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 50, 0, 5, MemberType = typeof(Utilities))]
        public void IsOrderedByTest_Int(IList<int> source)
        {
            Assert.True(source.OrderBy(v => v).ToArray().IsOrderedByF(v => v));
            Assert.True(source.OrderBy(v => v).ToArray().IsOrderedByF(v => v, Comparer<int>.Default));
            Assert.False(source.OrderBy(v => v).ToArray().IsOrderedByF(v => -v));
            Assert.False(source.OrderBy(v => v).ToArray().IsOrderedByF(v => -v, Comparer<int>.Default));
        }
        
        [Theory]
        [Trait(nameof(EnumerableF.IsOrderedByF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 0, 0, 100, MemberType = typeof(Utilities))]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 1, 0, 100, MemberType = typeof(Utilities))]
        public void IsOrderedByTest_IntSmall(IList<int> source)
        {
            Assert.True(source.OrderBy(v => v).ToArray().IsOrderedByF(v => v));
            Assert.True(source.OrderBy(v => v).ToArray().IsOrderedByF(v => v, Comparer<int>.Default));
        }
        
        [Theory]
        [Trait(nameof(EnumerableF.IsOrderedByDescendingF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 5, 0, 100, MemberType = typeof(Utilities))]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 10, 0, 2, MemberType = typeof(Utilities))]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 50, 0, 5, MemberType = typeof(Utilities))]
        public void IsOrderedByDescendingTest_Int(IList<int> source)
        {
            Assert.True(source.OrderByDescending(v => v).ToArray().IsOrderedByDescendingF(v => v));
            Assert.True(source.OrderByDescending(v => v).ToArray().IsOrderedByDescendingF(v => v, Comparer<int>.Default));
            Assert.False(source.OrderByDescending(v => v).ToArray().IsOrderedByDescendingF(v => -v));
            Assert.False(source.OrderByDescending(v => v).ToArray().IsOrderedByDescendingF(v => -v, Comparer<int>.Default));
        }
        
        [Theory]
        [Trait(nameof(EnumerableF.IsOrderedByDescendingF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 0, 0, 100, MemberType = typeof(Utilities))]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 1, 0, 100, MemberType = typeof(Utilities))]
        public void IsOrderedByDescendingTest_IntSmall(IList<int> source)
        {
            Assert.True(source.OrderByDescending(v => v).ToArray().IsOrderedByDescendingF(v => v));
            Assert.True(source.OrderByDescending(v => v).ToArray().IsOrderedByDescendingF(v => v, Comparer<int>.Default));
        }
    }
}