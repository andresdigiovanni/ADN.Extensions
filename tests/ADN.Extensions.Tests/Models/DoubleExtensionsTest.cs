using ADN.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ADN.Extensions.Tests
{
    public class DoubleExtensionsTest
    {
        [Theory]
        [InlineData(10, 2, 10)]
        [InlineData(11, 2, 12)]
        [InlineData(12, 2, 12)]
        [InlineData(10, 5, 10)]
        [InlineData(11, 5, 10)]
        [InlineData(12, 5, 10)]
        [InlineData(13, 5, 15)]
        [InlineData(14, 5, 15)]
        [InlineData(15, 5, 15)]
        [InlineData(-10, 5, -10)]
        [InlineData(-11, 5, -10)]
        [InlineData(-12, 5, -10)]
        [InlineData(-13, 5, -15)]
        [InlineData(-14, 5, -15)]
        [InlineData(-15, 5, -15)]
        [InlineData(0, 5, 0)]
        [InlineData(1.0, 0.5, 1.0)]
        [InlineData(1.1, 0.5, 1.0)]
        [InlineData(1.2, 0.5, 1.0)]
        [InlineData(1.3, 0.5, 1.5)]
        [InlineData(1.4, 0.5, 1.5)]
        [InlineData(1.5, 0.5, 1.5)]
        public void RoundNumber_Valid(double value, double step, double expected)
        {
            var result = value.RoundNumber(step);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(10, 2, 0, 8, 8)]
        [InlineData(10, 2, 0, 12, 10)]
        [InlineData(11, 2, 0, 8, 8)]
        [InlineData(11, 2, 0, 12, 12)]
        [InlineData(12, 2, 0, 8, 8)]
        [InlineData(12, 2, 0, 12, 12)]
        [InlineData(10, 2, 8, 20, 10)]
        [InlineData(10, 2, 12, 20, 12)]
        [InlineData(11, 2, 8, 20, 12)]
        [InlineData(11, 2, 12, 20, 12)]
        [InlineData(12, 2, 8, 20, 12)]
        [InlineData(12, 2, 12, 20, 12)]
        public void RoundNumber_WithStep_Valid(double value, double step, double min, double max, double expected)
        {
            var result = value.RoundNumber(step, min, max);

            Assert.Equal(expected, result);
        }
    }
}
