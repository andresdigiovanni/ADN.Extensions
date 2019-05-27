using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ADN.Extensions.Tests
{
    public class NumberExtensionsTest
    {
        [Theory]
        [InlineData((sbyte)10)]
        [InlineData((byte)10)]
        [InlineData((short)10)]
        [InlineData((ushort)10)]
        [InlineData((int)10)]
        [InlineData((uint)10)]
        [InlineData((long)10)]
        [InlineData((ulong)10)]
        [InlineData((float)10f)]
        [InlineData((double)10.1)]
        public void IsNumber(object value)
        {
            var result = value.IsNumber();

            Assert.True(result);
        }

        [Theory]
        [InlineData("10")]
        [InlineData(null)]
        public void IsNumber_Invalid(object value)
        {
            var result = value.IsNumber();

            Assert.False(result);
        }
    }
}
