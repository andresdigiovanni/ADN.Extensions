using ADN.Extensions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ADN.Extensions.Tests
{
    public class StringExtensionsTest
    {
        [Theory]
        [InlineData("abc", true)]
        [InlineData("ABC", true)]
        [InlineData("1234", true)]
        [InlineData("abc1234", true)]
        [InlineData(" abc", false)]
        [InlineData(" 1234", false)]
        [InlineData("-abc", false)]
        [InlineData("_abc", false)]
        public void IsAlphaNumeric(string value, bool expected)
        {
            var result = value.IsAlphaNumeric();
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(@"NotAnEmail", false)]
        [InlineData(@"@NotAnEmail", false)]
        [InlineData(@"""test\\blah""@example.com", true)]
        [InlineData(@"""test\blah""@example.com", false)]
        [InlineData("\"test\\\rblah\"@example.com", true)]
        [InlineData("\"test\rblah\"@example.com", false)]
        [InlineData(@"""test\""blah""@example.com", true)]
        [InlineData(@"""test""blah""@example.com", false)]
        [InlineData(@"customer/department@example.com", true)]
        [InlineData(@"$A12345@example.com", true)]
        [InlineData(@"!def!xyz%abc@example.com", true)]
        [InlineData(@"_Yosemite.Sam@example.com", true)]
        [InlineData(@"~@example.com", true)]
        [InlineData(@".wooly@example.com", false)]
        [InlineData(@"wo..oly@example.com", false)]
        [InlineData(@"pootietang.@example.com", false)]
        [InlineData(@".@example.com", false)]
        [InlineData(@"""Austin@Powers""@example.com", true)]
        [InlineData(@"Ima.Fool@example.com", true)]
        [InlineData(@"""Ima.Fool""@example.com", true)]
        [InlineData(@"""Ima Fool""@example.com", true)]
        [InlineData(@"Ima Fool@example.com", false)]
        public void IsValidEmailAddress(string value, bool expected)
        {
            var result = value.IsValidEmailAddress();
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("abcdefghij", 0, "")]
        [InlineData("abcdefghij", 5, "abcde")]
        [InlineData("abcdefghij", 10, "abcdefghij")]
        [InlineData("abcdefghij", 15, "abcdefghij")]
        public void Left(string value, int length, string expected)
        {
            var result = value.Left(length);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("abcdefghij", 0, 0, "")]
        [InlineData("abcdefghij", 0, 5, "abcde")]
        [InlineData("abcdefghij", 5, 10, "fghij")]
        [InlineData("abcdefghij", 5, 15, "fghij")]
        public void Mid(string value, int startIndex, int length, string expected)
        {
            var result = value.Mid(startIndex, length);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("abcdefghij", 0, "")]
        [InlineData("abcdefghij", 5, "fghij")]
        [InlineData("abcdefghij", 10, "abcdefghij")]
        [InlineData("abcdefghij", 15, "abcdefghij")]
        public void Right(string value, int length, string expected)
        {
            var result = value.Right(length);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("abc", 0, "abc")]
        [InlineData("abc", 1, "abc")]
        [InlineData("abc", 2, "abc")]
        [InlineData("abc", 3, "abc")]
        [InlineData("abc", 4, "abc ")]
        [InlineData("abc", 5, " abc ")]
        [InlineData("abc", 6, " abc  ")]
        [InlineData("abc", 7, "  abc  ")]
        public void PadCenter(string value, int maxLength, string expected)
        {
            var result = value.PadCenter(maxLength);
            Assert.Equal(expected, result);
        }

        [Theory]
        [ClassData(typeof(TrimNonPrintableAsciiData))]
        public void TrimNonPrintableAscii(string value, string expected)
        {
            var result = value.TrimNonPrintableAscii();
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("48656C6C6F20776F726C64", "Hello world")]
        [InlineData("4C6F72656D20497073756D", "Lorem Ipsum")]
        public void FromHex(string value, string expected)
        {
            var result = value.FromHex();
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("Hello world", "48656C6C6F20776F726C64")]
        [InlineData("Lorem Ipsum", "4C6F72656D20497073756D")]
        public void ToHex(string value, string expected)
        {
            var result = value.ToHex();
            Assert.Equal(expected, result);
        }

        public class TrimNonPrintableAsciiData : IEnumerable<object[]>
        {
            public IEnumerator<object[]> GetEnumerator()
            {
                yield return new object[] { "", "" };
                yield return new object[] { "abcdefghij", "abcdefghij" };
                yield return new object[] { (char)0x12 + "a" + (char)0x142 + "b" + (char)0x242, "ab" };
                yield return new object[] { " a~", " a~" };
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }
    }
}
