using System;

namespace ADN.Extensions
{
    /// <summary>
    /// A static class of extension methods for <see cref="System.Double"/>.
    /// </summary>
    public static class DoubleExtensions
    {
        /// <summary>
        /// Rounds a value to the nearest integral value with the given step.
        /// </summary>
        /// <param name="value">A double-precision floating-point number to be rounded.</param>
        /// <param name="step">Step number to round.</param>
        /// <returns>The number nearest to value that is multiple of the given step.</returns>
        /// <example>
        /// <code lang="csharp">
        /// double value = 12;
        /// int step = 5;
        /// var result = value.RoundNumber(step);
        /// 
        /// /*
        /// result is 10
        /// */
        /// </code>
        /// </example>
        public static double RoundNumber(this double value, double step)
        {
            return Math.Round(value / step) * step;
        }

        /// <summary>
        /// Rounds a value to the nearest integral value with the given step and within the determined range.
        /// </summary>
        /// <param name="value">A double-precision floating-point number to be rounded.</param>
        /// <param name="step">Step number to round.</param>
        /// <param name="min">Minimum value.</param>
        /// <param name="max">Maximum value.</param>
        /// <returns>The number nearest to value that is multiple of the given step and within the determined range.</returns>
        /// <example>
        /// <code lang="csharp">
        /// double value = 12;
        /// int step = 5;
        /// int min = 0;
        /// int max = 20;
        /// var result = value.RoundNumber(step, min, max);
        /// 
        /// /*
        /// result is 10
        /// */
        /// </code>
        /// </example>
        public static double RoundNumber(this double value, double step, double min, double max)
        {
            value = RoundNumber(value, step);

            if (value < min) return min;
            if (value > max) return max;
            return value;
        }
    }
}
