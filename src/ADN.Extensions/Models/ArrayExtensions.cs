﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ADN.Extensions
{
    /// <summary>
    /// A static class of extension methods for <see cref="Array"/>.
    /// </summary>
    public static class ArrayExtensions
    {
        /// <summary>
        /// Checks if the Arrays are equal.
        /// </summary>
        /// <typeparam name="T">Array type.</typeparam>
        /// <param name="first">The <see cref="Array"/> that contains data to compare with.</param>
        /// <param name="second">The <see cref="Array"/> that contains data to compare to.</param>
        /// <returns>Returns <c>true</c> if all element match and <c>false</c> otherwise.</returns>
        /// <example>
        /// <code lang="csharp">
        /// var first= new double[] { 0, 0, 0, 0, 0 };
        /// var second = new double[] { 0, 0, 0, 0, 0 };
        /// var result = first.ArrayEqual(second);
        ///
        /// /*
        /// result is true
        /// */
        /// </code>
        /// </example>
        public static bool ArrayEqual<T>(this T[] first, T[] second) where T : IEquatable<T>
        {
            if (ReferenceEquals(first, second))
            {
                return true;
            }

            if (first is null || second is null)
            {
                return false;
            }

            if (first.Length != second.Length)
            {
                return false;
            }

            for (int i = 0; i < first.Length; i++)
            {
                if (!first[i].Equals(second[i]))
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Combine the Arrays.
        /// </summary>
        /// <typeparam name="T">Array type.</typeparam>
        /// <param name="first">First element to combine.</param>
        /// <param name="second">Second element to combine.</param>
        /// <returns>T[].</returns>
        /// <example>
        /// <code lang="csharp">
        /// var first= new double[] { 0, 1, 2 };
        /// var second = new double[] { 3, 4, 5 };
        /// var result = first.Combine(second);
        ///
        /// /*
        /// result contains the values { 0, 1, 2, 3, 4, 5 }
        /// */
        /// </code>
        /// </example>
        public static T[] Combine<T>(this T[] first, T[] second)
        {
            T[] result = new T[first.Length + second.Length];
            Array.Copy(first, 0, result, 0, first.Length);
            Array.Copy(second, 0, result, first.Length, second.Length);
            return result;
        }

        /// <summary>
        /// Inserts an element into the <see cref="Array"/> at the specified index.
        /// </summary>
        /// <typeparam name="T">Array type.</typeparam>
        /// <param name="array">The one-dimensional, zero-based array.</param>
        /// <param name="index">The zero-based index at which item should be inserted.</param>
        /// <param name="item">The object to insert. The value can be null for reference types.</param>
        /// <returns>A reference to the changed array.</returns>
        /// <example>
        /// <code lang="csharp">
        /// var array = new double[] { 1, 2, 3, 4, 5 };
        /// var result = array.InsertIntoArray(2, 0);
        ///
        /// /*
        /// result contains the values { 1, 2, 0, 3, 4, 5 }
        /// */
        /// </code>
        /// </example>
        public static T[] InsertIntoArray<T>(this T[] array, int index, T item)
        {
            var result = new T[array.Length + 1];

            for (int i = 0; i < index; i++)
            {
                result[i] = array[i];
            }

            result[index] = item;

            for (int i = index + 1; i < result.Length; i++)
            {
                result[i] = array[i - 1];
            }

            return result;
        }

        /// <summary>
        /// Sets all values.
        /// </summary>
        /// <typeparam name="T">The type of the elements of the array that will be modified.</typeparam>
        /// <param name="array">The one-dimensional, zero-based array.</param>
        /// <param name="value">The value.</param>
        /// <returns>A reference to the changed array.</returns>
        /// <example>
        /// <code lang="csharp">
        /// var array = new double[] { 0, 0, 0, 0, 0 };
        /// var result = array.SetAllValues(1);
        ///
        /// /*
        /// result contains the values { 1, 1, 1, 1, 1 }
        /// */
        /// </code>
        /// </example>
        public static T[] SetAllValues<T>(this T[] array, T value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = value;
            }

            return array;
        }

        /// <summary>
        /// Split an array into subarrays by specifying the number of divisions.
        /// </summary>
        /// <typeparam name="T">The type of the elements of the array that will be split.</typeparam>
        /// <param name="array">Array to split.</param>
        /// <param name="numberOfDivisions">Number of divisions.</param>
        /// <returns>Subarrays.</returns>
        /// <exception cref="DivideByZeroException">Number of divisions is zero.</exception>
        /// <example>
        /// <code lang="csharp">
        /// var array = new double[] { 0, 1, 2 };
        /// var numberOfDivisions = 2;
        /// var result = array.SplitByNumberOfDivisions(numberOfDivisions);
        ///
        /// /*
        /// result contains the values { { 0, 1 }, { 2 } }
        /// */
        /// </code>
        /// </example>
        public static IEnumerable<T[]> SplitByNumberOfDivisions<T>(this T[] array, int numberOfDivisions)
        {
            if (numberOfDivisions < 1)
            {
                throw (new DivideByZeroException("numberDivisions"));
            }

            IEnumerable<T[]> result;
            int elementsInDivision = (int)Math.Ceiling(array.Length / (double)numberOfDivisions);

            if (elementsInDivision > 0)
            {
                result = array.SplitByNumberOfElementsInDivision(elementsInDivision);
            }
            else
            {
                result = new List<T[]>();
            }

            return result;
        }

        /// <summary>
        /// Split an array into subarrays by specifying the number of elements in each division.
        /// </summary>
        /// <typeparam name="T">The type of the elements of the array that will be split.</typeparam>
        /// <param name="array">Array to split.</param>
        /// <param name="elementsInDivision">Elements in each division.</param>
        /// <returns>Subarrays.</returns>
        /// <exception cref="DivideByZeroException">Number of elements in division is zero.</exception>
        /// <example>
        /// <code lang="csharp">
        /// var array = new double[] { 0, 1, 2 };
        /// var elementsInDivision = 2;
        /// var result = array.SplitByNumberOfElementsInDivision(elementsInDivision);
        ///
        /// /*
        /// result contains the values { { 0, 1 }, { 2 } }
        /// */
        /// </code>
        /// </example>
        public static IEnumerable<T[]> SplitByNumberOfElementsInDivision<T>(this T[] array, int elementsInDivision)
        {
            if (elementsInDivision < 1)
            {
                throw (new DivideByZeroException("elementsInDivision"));
            }

            var result = new List<T[]>();

            for (int index = 0; index < array.Length; index += elementsInDivision)
            {
                var length = index + elementsInDivision < array.Length ? elementsInDivision : array.Length - index;
                var temp = new T[length];
                Array.Copy(array, index, temp, 0, length);
                result.Add(temp);
            }

            return result;
        }

        /// <summary>
        /// Subs the array.
        /// </summary>
        /// <typeparam name="T">The type of the elements of the array that will be modified.</typeparam>
        /// <param name="array">The data.</param>
        /// <param name="index">The index.</param>
        /// <param name="length">The length.</param>
        /// <returns>T[].</returns>
        /// <example>
        /// <code lang="csharp">
        /// var array = new double[] { 0, 1, 2, 3, 4, 5 };
        /// var index = 1;
        /// var length = 4;
        /// var result = array.SubArray(index, length);
        ///
        /// /*
        /// result contains the values { 1, 2, 3, 4 }
        /// */
        /// </code>
        /// </example>
        public static T[] SubArray<T>(this T[] array, int index, int length)
        {
            T[] result = new T[length];
            Array.Copy(array, index, result, 0, length);
            return result;
        }

        /// <summary>
        /// Sum the corresponding elements of the Arrays.
        /// </summary>
        /// <param name="first">First array.</param>
        /// <param name="second">Second array.</param>
        /// <returns>T[].</returns>
        /// <example>
        /// <code lang="csharp">
        /// var first= new double[] { 0, 1, 2 };
        /// var second = new double[] { 3, 4, 5 };
        /// var result = first.SumCorrespondingElements(second);
        ///
        /// /*
        /// result contains the values { 3, 5, 7 }
        /// */
        /// </code>
        /// </example>
        public static double[] SumCorrespondingElements(this double[] first, double[] second)
        {
            int length = Math.Max(first.Length, second.Length);
            var result = new double[length];

            for (int i = 0; i < length; i++)
            {
                double f = i < first.Length ? first[i] : 0;
                double s = i < second.Length ? second[i] : 0;

                result[i] = f + s;
            }

            return result;
        }
    }
}
