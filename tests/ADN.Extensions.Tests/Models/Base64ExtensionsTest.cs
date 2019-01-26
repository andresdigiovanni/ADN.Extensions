using ADN.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ADN.Extensions.Tests
{
    public class Base64ExtensionsTest
    {
        [Theory]
        [InlineData("0123456789", "MDEyMzQ1Njc4OQ==")]
        [InlineData("This is a test", "VGhpcyBpcyBhIHRlc3Q=")]
        public void Base64Encode(string value, string expected)
        {
            var result = value.Base64Encode();
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("MDEyMzQ1Njc4OQ==", "0123456789")]
        [InlineData("VGhpcyBpcyBhIHRlc3Q=", "This is a test")]
        public void Base64Decode(string value, string expected)
        {
            var result = value.Base64Decode();
            Assert.Equal(expected, result);
        }
    }
}
