using System;
using System.Collections.Generic;
using System.Text;

namespace ADN.Extensions
{
    /// <summary>
    /// A static class of extension methods for <see cref="Int32"/>.
    /// </summary>
    public static class IntegerExtensions
    {
        /// <summary>
        /// Get the next power 2 value.
        /// </summary>
        /// <param name="x">Value to get the next power 2.</param>
        /// <returns>Power 2 value.</returns>
        /// <example>
        /// <code lang="csharp">
        /// int value = 29;
        /// var nextPow2 = value.NextPow2();
        /// 
        /// /*
        /// result is 32
        /// */
        /// </code>
        /// </example>
        public static int NextPow2(this int x)
        {
            x--;
            x |= (x >> 1);
            x |= (x >> 2);
            x |= (x >> 4);
            x |= (x >> 8);
            x |= (x >> 16);
            return (x + 1);
        }
    }
}
