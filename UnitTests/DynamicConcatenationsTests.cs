using Benchmarking;
using Xunit;

namespace UnitTests
{
    public class DynamicConcatenationsTests
    {
        [Fact]
        public void Creation()
        {
            Assert.NotNull(new DynamicConcatenations());
        }

        [Fact]
        public void Check()
        {
            var concat = new DynamicConcatenations();

            concat.Count = 10;

            Assert.Equal(concat.PlusEquals(), concat.Builder());
        }
    }
}