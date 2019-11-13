using Xunit;

namespace DotNetCoverletExample.Counter.Tests
{
    public class CounterTests
    {
        [Fact]
        public void CanIncrement()
        {
            // Arrange
            var counter = new Counter();

            // Act
            counter.Increment();

            // Assert
            Assert.Equal(1, counter.Value);
        }
    }
}
