using Xunit;

namespace LinqFasterer.Tests
{
    public partial class Test
    {
        [Theory]
        [Trait(nameof(EnumerableF.CloneF), null)]
        [InlineData(new [] {0,1,2,3,0}, new [] {0,1,2,3,0})]
        public void CloneTest_Int(int[] expected, int[] source)
        {
            var actual = source.CloneF();

            Assert.Equal(expected, actual);
        }
    }
}
