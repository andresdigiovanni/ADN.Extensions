using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ADN.Extensions.Tests
{
    public class IntegerExtensionsTest
    {
        [Theory]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(3, 4)]
        [InlineData(4, 4)]
        [InlineData(5, 8)]
        [InlineData(6, 8)]
        [InlineData(7, 8)]
        [InlineData(8, 8)]
        [InlineData(9, 16)]
        [InlineData(15, 16)]
        [InlineData(16, 16)]
        [InlineData(17, 32)]
        [InlineData(31, 32)]
        [InlineData(32, 32)]
        public void NextPow2(int value, int expected)
        {
            var result = value.NextPow2();

            Assert.Equal(expected, result);
        }
    }
}
