using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using Xunit;

namespace ADN.Extensions.Tests
{
    public class ComplexExtensionsTest
    {
        [Theory]
        [ClassData(typeof(ToIntegerData))]
        public void ToInteger(Complex[,] comp, int[,] expected)
        {
            var result = comp.ToInteger();

            Assert.Equal(expected, result);
        }

        public class ToIntegerData : IEnumerable<object[]>
        {
            public IEnumerator<object[]> GetEnumerator()
            {
                yield return new object[]
                {
                    new Complex[,]
                    {
                        {
                            new Complex(4, 0),
                            new Complex(0, 4)
                        },
                        {
                            new Complex(3, 4),
                            new Complex(8, 6)
                        },
                    },
                    new int[,]
                    {
                        { 4, 4 },
                        { 5, 10 }
                    }
                };
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }
    }
}
