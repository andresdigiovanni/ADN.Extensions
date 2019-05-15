using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ADN.Extensions
{
    /// <summary>
    /// A static class of extension methods for <see cref="string"/>.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Check if a string is alphanumeric.
        /// </summary>
        /// <param name="str">String to check.</param>
        /// <returns>True if the string is alphanumeric, false otherwise.</returns>
        /// <example>
        /// <code lang="csharp">
        /// var value = "abc1234";
        /// var result = value.IsAlphaNumeric();
        /// 
        /// /*
        /// result is true
        /// */
        /// </code>
        /// </example>
        public static bool IsAlphaNumeric(this string str)
        {
            return !(new Regex("[^a-zA-Z0-9]")).IsMatch(str);
        }

        /// <summary>
        /// Check if a string is a valid email.
        /// </summary>
        /// <param name="str">String to check.</param>
        /// <returns>True if the string is a valid email, false otherwise.</returns>
        /// <example>
        /// <code lang="csharp">
        /// var value = "austin.powers@example.com";
        /// var result = value.IsValidEmailAddress();
        /// 
        /// /*
        /// result is true
        /// */
        /// </code>
        /// </example>
        public static bool IsValidEmailAddress(this string str)
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|" +
                @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)" +
                @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            var regex = new Regex(pattern, RegexOptions.IgnoreCase);
            return regex.IsMatch(str);
        }

        /// <summary>
        /// Returns a string containing a specified number of characters from the left side of a string.
        /// </summary>
        /// <param name="str">String expression from which the leftmost characters are returned.</param>
        /// <param name="length">Numeric expression indicating how many characters to return.</param>
        /// <returns>Returns a string containing a specified number of characters from the left side of a string.</returns>
        /// <example>
        /// <code lang="csharp">
        /// var value = "abcdefghij";
        /// var length = 5;
        /// var result = value.Left(length);
        /// 
        /// /*
        /// result is "abcde"
        /// */
        /// </code>
        /// </example>
        public static string Left(this string str, int length)
        {
            return (str.Length <= length) ? str : str.Substring(0, length);
        }

        /// <summary>
        /// Returns a string that contains a specified number of characters starting from a specified position in a string.
        /// </summary>
        /// <param name="str">String expression from which characters are returned.</param>
        /// <param name="startIndex">Starting position of the characters to return.</param>
        /// <param name="length">Number of characters to return.</param>
        /// <returns>A string that consists of the specified number of characters starting from the specified position in the string.</returns>
        /// <example>
        /// <code lang="csharp">
        /// var value = "abcdefghij";
        /// var startIndex = 3;
        /// var length = 5;
        /// var result = value.Mid(startIndex, length);
        /// 
        /// /*
        /// result is "defgh"
        /// */
        /// </code>
        /// </example>
        public static string Mid(this string str, int startIndex, int length)
        {
            if (str.Length < startIndex) return "";

            return (str.Length < startIndex + length) ? str.Substring(startIndex, str.Length - startIndex)
                                                      : str.Substring(startIndex, length);
        }

        /// <summary>
        /// Returns a string containing a specified number of characters from the right side of a string.
        /// </summary>
        /// <param name="str">String expression from which the rightmost characters are returned.</param>
        /// <param name="length">Numeric expression indicating how many characters to return.</param>
        /// <returns>Returns a string containing a specified number of characters from the right side of a string.</returns>
        /// <example>
        /// <code lang="csharp">
        /// var value = "abcdefghij";
        /// var length = 5;
        /// var result = value.Right(length);
        /// 
        /// /*
        /// result is "fghij"
        /// */
        /// </code>
        /// </example>
        public static string Right(this string str, int length)
        {
            return (str.Length <= length) ? str : str.Substring(str.Length - length, length);
        }

        /// <summary>
        /// Returns a string without the non-printable ASCII characters from a string (characters between space and tilde).
        /// </summary>
        /// <param name="str">String to remove the non-printable ASCII characters.</param>
        /// <returns>A string without the non-printable ASCII characters from a string (characters between space and tilde).</returns>
        /// <example>
        /// <code lang="csharp">
        /// var str = (char)0x12 + " a~";
        /// var result = str.TrimNonPrintableAscii();
        /// 
        /// /*
        /// result is " a~"
        /// */
        /// </code>
        /// </example>
        public static string TrimNonPrintableAscii(this string str)
        {
            string pattern = "[^ -~]+";
            Regex regex = new Regex(pattern);
            return regex.Replace(str, "");
        }

        /// <summary>
        /// Converts a hexadecimal string to unicode string.
        /// </summary>
        /// <param name="str">Hexadecimal string.</param>
        /// <returns>Unicode string.</returns>
        /// <example>
        /// <code lang="csharp">
        /// var value = "4C6F72656D20497073756D";
        /// var result = value.FromHex();
        /// 
        /// /*
        /// result is "Lorem Ipsum"
        /// */
        /// </code>
        /// </example>
        public static string FromHex(this string str)
        {
            var sb = new StringBuilder();

            for (var i = 0; i < str.Length; i+=2)
            {
                sb.Append(Convert.ToChar(Convert.ToUInt32(str.Substring(i, 2), 16)));
            }
            return sb.ToString();
        }

        /// <summary>
        /// Converts a unicode string to hexadecimal string.
        /// </summary>
        /// <param name="str">Unicode string.</param>
        /// <returns>Hexadecimal string.</returns>
        /// <example>
        /// <code lang="csharp">
        /// var value = "Lorem Ipsum";
        /// var result = value.ToHex();
        /// 
        /// /*
        /// result is "4C6F72656D20497073756D"
        /// */
        /// </code>
        /// </example>
        public static string ToHex(this string str)
        {
            var sb = new StringBuilder();

            foreach (char c in str)
            {
                sb.Append(string.Format("{0:X2}", Convert.ToInt32(c)));
            }

            return sb.ToString();
        }
    }
}
