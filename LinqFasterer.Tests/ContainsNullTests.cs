using System.Collections.Generic;
using LinqFasterer.Shared;
using Xunit;

namespace LinqFasterer.Tests
{
    public partial class Test
    {
        [Theory]
        [Trait(nameof(EnumerableF.ContainsNullF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 5, 0, 100, MemberType = typeof(Utilities))]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 10, 0, 2, MemberType = typeof(Utilities))]
        public void ContainsNullTest_IntFalse(IList<int> source)
        {
            Assert.False(source.ContainsNullF());
        }
        
        [Theory]
        [Trait(nameof(EnumerableF.ContainsNullF), null)]
        [InlineData(new object[] {new object[] {1,2,3,4,5}})]
        public void ContainsNullTest_ObjectFalse(IList<object> source)
        {
            Assert.False(source.ContainsNullF());
        }
        
        [Theory]
        [Trait(nameof(EnumerableF.ContainsNullF), null)]
        [InlineData(new object[] {new object[] {1,2,3,null,5}})]
        public void ContainsNullTest_ObjectTrue(IList<object> source)
        {
            Assert.True(source.ContainsNullF());
        }
    }
}