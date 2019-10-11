using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ADN.Extensions
{
    /// <summary>
    /// A static class of extension methods for <see cref="Array"/>.
    /// </summary>
    public static class MatrixExtensions
    {
        /// <summary>
        /// Get the values of specific column of the matrix.
        /// </summary>
        /// <typeparam name="T">Array type.</typeparam>
        /// <param name="matrix">The <see cref="Array"/> to get the values.</param>
        /// <param name="columnNumber">Column index to get the values.</param>
        /// <returns>Values of specific column of the matrix.</returns>
        /// <example>
        /// <code lang="csharp">
        /// var matrix = new int[,]
        /// {
        ///     { 0, 1, 2 },
        ///     { 3, 4, 5 }
        /// };
        /// var columnNumber = 0;
        /// var result = matrix.GetColumn(columnNumber);
        /// 
        /// /*
        /// result is { 0, 3 }
        /// */
        /// </code>
        /// </example>
        public static T[] GetColumn<T>(this T[,] matrix, int columnNumber)
        {
            return Enumerable
                .Range(0, matrix.GetLength(0))
                .Select(x => matrix[x, columnNumber])
                .ToArray();
        }

        /// <summary>
        /// Get the values of specific row of the matrix.
        /// </summary>
        /// <typeparam name="T">Array type.</typeparam>
        /// <param name="matrix">The <see cref="Array"/> to get the values.</param>
        /// <param name="rowNumber">Row index to get the values.</param>
        /// <returns>Values of specific row of the matrix.</returns>
        /// <example>
        /// <code lang="csharp">
        /// var matrix = new int[,]
        /// {
        ///     { 0, 1, 2 },
        ///     { 3, 4, 5 }
        /// };
        /// var rowNumber = 0;
        /// var result = matrix.GetColumn(rowNumber);
        /// 
        /// /*
        /// result is { 0, 1, 2 }
        /// */
        /// </code>
        /// </example>
        public static T[] GetRow<T>(this T[,] matrix, int rowNumber)
        {
            return Enumerable
                .Range(0, matrix.GetLength(1))
                .Select(x => matrix[rowNumber, x])
                .ToArray();
        }

        /// <summary>
        /// Get a sub-matrix ignoring a specific dimension.
        /// </summary>
        /// <typeparam name="T">Array type.</typeparam>
        /// <param name="matrix">The <see cref="Array"/> to get the values.</param>
        /// <param name="dimension">Specific dimension to ignore the values.</param>
        /// <returns>Values ignoring a specific dimension.</returns>
        /// <example>
        /// <code lang="csharp">
        /// var matrix = new int[,,]
        /// {
        ///     {
        ///         { 0, 1 },
        ///         { 2, 3 }
        ///     },
        ///     {
        ///         { 4, 5 },
        ///         { 6, 7 }
        ///     }
        /// };
        /// var dimension = 0;
        /// var result = matrix.IgnoreDimension(dimension);
        /// 
        /// /*
        /// result is { { 0, 1 }, { 2, 3 } }
        /// */
        /// </code>
        /// </example>
        public static T[,] IgnoreDimension<T>(this T[,,] matrix, int dimension)
        {
            var i = matrix.GetLength(1);
            var j = matrix.GetLength(2);
            T[,] result = new T[i, j];

            for (int x = 0; x < i; ++x)
            {
                for (int y = 0; y < j; ++y)
                {
                    result[x, y] = matrix[dimension, x, y];
                }
            }

            return result;
        }
    }
}
