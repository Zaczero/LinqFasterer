using System.Collections.Generic;
using System.Linq;
using LinqFasterer.Shared;
using Xunit;

namespace LinqFasterer.Tests
{
    public partial class Test
    {
        [Theory]
        [Trait(nameof(EnumerableF.IsSortedF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 5, 0, 100, MemberType = typeof(Utilities))]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 10, 0, 2, MemberType = typeof(Utilities))]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 50, 0, 5, MemberType = typeof(Utilities))]
        public void IsSortedTest_Int(IList<int> source)
        {
            Assert.True(source.OrderBy(v => v).ToArray().IsSortedF());
            Assert.True(source.OrderBy(v => v).ToArray().IsSortedF(Comparer<int>.Default));
            Assert.False(source.OrderBy(v => v).ToArray().IsSortedDescendingF());
            Assert.False(source.OrderBy(v => v).ToArray().IsSortedDescendingF(Comparer<int>.Default));
        }
        
        [Theory]
        [Trait(nameof(EnumerableF.IsSortedF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 0, 0, 100, MemberType = typeof(Utilities))]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 1, 0, 100, MemberType = typeof(Utilities))]
        public void IsSortedTest_IntSmall(IList<int> source)
        {
            Assert.True(source.OrderBy(v => v).ToArray().IsSortedF());
            Assert.True(source.OrderBy(v => v).ToArray().IsSortedF(Comparer<int>.Default));
        }
        
        [Theory]
        [Trait(nameof(EnumerableF.IsSortedDescendingF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 5, 0, 100, MemberType = typeof(Utilities))]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 10, 0, 2, MemberType = typeof(Utilities))]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 50, 0, 5, MemberType = typeof(Utilities))]
        public void IsSortedDescendingTest_Int(IList<int> source)
        {
            Assert.True(source.OrderByDescending(v => v).ToArray().IsSortedDescendingF());
            Assert.True(source.OrderByDescending(v => v).ToArray().IsSortedDescendingF(Comparer<int>.Default));
            Assert.False(source.OrderByDescending(v => v).ToArray().IsSortedF());
            Assert.False(source.OrderByDescending(v => v).ToArray().IsSortedF(Comparer<int>.Default));
        }
        
        [Theory]
        [Trait(nameof(EnumerableF.IsSortedDescendingF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 0, 0, 100, MemberType = typeof(Utilities))]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 1, 0, 100, MemberType = typeof(Utilities))]
        public void IsSortedDescendingTest_IntSmall(IList<int> source)
        {
            Assert.True(source.OrderByDescending(v => v).ToArray().IsSortedDescendingF());
            Assert.True(source.OrderByDescending(v => v).ToArray().IsSortedDescendingF(Comparer<int>.Default));
        }
    }
}