using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ADN.Extensions.Tests
{
    public class MatrixExtensionsTest
    {
        [Theory]
        [ClassData(typeof(GetColumnData))]
        public void GetColumn(int[,] matrix, int columnNumber, int[] expected)
        {
            var result = matrix.GetColumn(columnNumber);

            Assert.Equal(expected, result);
        }

        [Theory]
        [ClassData(typeof(GetRowData))]
        public void GetRow(int[,] matrix, int rowNumber, int[] expected)
        {
            var result = matrix.GetRow(rowNumber);

            Assert.Equal(expected, result);
        }

        [Theory]
        [ClassData(typeof(IgnoreDimensionData))]
        public void IgnoreDimension(int[,,] matrix, int dimension, int[,] expected)
        {
            var result = matrix.IgnoreDimension(dimension);

            Assert.Equal(expected, result);
        }

        public class GetColumnData : IEnumerable<object[]>
        {
            public IEnumerator<object[]> GetEnumerator()
            {
                yield return new object[] { new int[,] { { 0, 1, 2 }, { 3, 4, 5 } }, 0, new int[] { 0, 3 } };
                yield return new object[] { new int[,] { { 0, 1, 2 }, { 3, 4, 5 } }, 1, new int[] { 1, 4 } };
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }

        public class GetRowData : IEnumerable<object[]>
        {
            public IEnumerator<object[]> GetEnumerator()
            {
                yield return new object[] { new int[,] { { 0, 1, 2 }, { 3, 4, 5 } }, 0, new int[] { 0, 1, 2 } };
                yield return new object[] { new int[,] { { 0, 1, 2 }, { 3, 4, 5 } }, 1, new int[] { 3, 4, 5 } };
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }

        public class IgnoreDimensionData : IEnumerable<object[]>
        {
            public IEnumerator<object[]> GetEnumerator()
            {
                yield return new object[] { new int[,,] { { { 0, 1 }, { 2, 3 } }, { { 4, 5 }, { 6, 7 } } }, 0, new int[,] { { 0, 1 }, { 2, 3 } } };
                yield return new object[] { new int[,,] { { { 0, 1 }, { 2, 3 } }, { { 4, 5 }, { 6, 7 } } }, 1, new int[,] { { 4, 5 }, { 6, 7 } } };
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }
    }
}
