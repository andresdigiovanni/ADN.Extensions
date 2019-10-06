using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace ADN.Extensions
{
    /// <summary>
    /// A static class of extension methods for <see cref="System.Numerics.Complex"/>.
    /// </summary>
    public static class ComplexExtensions
    {
        /// <summary>
        /// Multilply two matrix of <see cref="System.Numerics.Complex"/>.
        /// </summary>
        /// <param name="comp1">Matrix 1 to multiply.</param>
        /// <param name="comp2">Matrix 2 to multiply.</param>
        /// <returns>Result of multiply the two matrix.</returns>
        /// <example>
        /// <code lang="csharp">
        /// Complex[,] comp1;
        /// Complex[,] comp2;
        /// Complex[,] result = comp1.Multiply(comp2);
        /// </code>
        /// </example>
        public static Complex[,] Multiply(this Complex[,] comp1, Complex[,] comp2)
        {
            int width = comp1.GetLength(0);
            int height = comp1.GetLength(1);

            Complex[,] output = new Complex[width, height];

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    output[i, j] = comp1[i, j] * comp2[i, j];
                }
            }

            return output;
        }

        /// <summary>
        /// Convert a <see cref="System.Numerics.Complex"/> matrix to a <see cref="Int32"/> matrix.
        /// </summary>
        /// <param name="comp"><see cref="System.Numerics.Complex"/> matrix to convert.</param>
        /// <returns><see cref="Int32"/> matrix.</returns>
        /// <example>
        /// <code lang="csharp">
        /// Complex[,] comp;
        /// int[,] result = comp1.ToInteger();
        /// </code>
        /// </example>
        public static int[,] ToInteger(this Complex[,] comp)
        {
            int width = comp.GetLength(0);
            int height = comp.GetLength(1);

            int[,] output = new int[width, height];

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    output[x, y] = (int)comp[x, y].Magnitude;
                }
            }

            return output;
        }
    }
}
