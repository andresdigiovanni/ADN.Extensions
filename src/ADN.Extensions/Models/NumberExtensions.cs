using System;

namespace ADN.Extensions
{
    /// <summary>
    /// A static class of extension methods for numbers.
    /// </summary>
    public static class NumberExtensions
    {
        /// <summary>
        /// Checks if an object is a number type.
        /// </summary>
        /// <param name="value"></param>
        /// <returns>True if the object is a number type.</returns>
        /// <example>
        /// <code lang="csharp">
        /// double value = 42;
        /// var result = value.IsNumber();
        /// 
        /// /*
        /// result is True
        /// */
        /// </code>
        /// </example>
        public static bool IsNumber(this object value)
        {
            return value is sbyte
                || value is byte
                || value is short
                || value is ushort
                || value is int
                || value is uint
                || value is long
                || value is ulong
                || value is float
                || value is double
                || value is decimal;
        }
    }
}
