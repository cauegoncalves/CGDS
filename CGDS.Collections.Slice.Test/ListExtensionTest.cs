using System.Linq;
using Xunit;

namespace CGDS.Collections.Slice.Test
{
    public class ListExtensionTest
    {

        [Theory]
        [InlineData(60, 6, 10)]
        [InlineData(10_000, 9999, 2)]
        [InlineData(526, 526, 1)]
        [InlineData(1, 999, 1)]
        [InlineData(55, 56, 1)]
        [InlineData(500_000, 5000, 100)]
        [InlineData(1_000_000, 1, 1_000_000)]
        [InlineData(1_000_000, 1_000_000, 1)]
        public void Extension_Should_Slice_Successfully(int listSize, int sliceSize, int expectedSlices)
        {
            var list = Enumerable.Range(1, listSize).ToList();
            var result = list.Slice(sliceSize);
            Assert.Equal(expectedSlices, result.Count());
            Assert.Equal(listSize, result.Sum(r => r.Count));
        }

    }
}