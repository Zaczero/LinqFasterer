using System.Collections.Generic;
using LinqFasterer.Shared;
using Xunit;

namespace LinqFasterer.Tests
{
    public partial class Test
    {
        [Theory]
        [Trait(nameof(EnumerableF.AllNullF), null)]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 5, 0, 100, MemberType = typeof(Utilities))]
        [MemberData(nameof(Utilities.TestArray), typeof(int), 10, 0, 2, MemberType = typeof(Utilities))]
        public void AllNullTest_IntFalse(IList<int> source)
        {
            Assert.False(source.AllNullF());
        }
        
        [Theory]
        [Trait(nameof(EnumerableF.AllNullF), null)]
        [InlineData(new object[] {new object[] {null,null,null,null,5}})]
        public void AllNullTest_ObjectFalse(IList<object> source)
        {
            Assert.False(source.AllNullF());
        }
        
        [Theory]
        [Trait(nameof(EnumerableF.AllNullF), null)]
        [InlineData(new object[] {new object[] {null,null,null,null,null}})]
        public void AllNullTest_ObjectTrue(IList<object> source)
        {
            Assert.True(source.AllNullF());
        }
    }
}