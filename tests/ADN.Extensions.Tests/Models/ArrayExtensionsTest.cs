using ADN.Extensions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ADN.Extensions.Tests
{
    public class ArrayExtensionsTest
    {
        [Theory]
        [ClassData(typeof(ArrayEqualData))]
        public void ArrayEqual(double[] first, double[] second, bool expected)
        {
            var result = first.ArrayEqual(second);

            Assert.Equal(expected, result);
        }

        [Theory]
        [ClassData(typeof(CombineData))]
        public void Combine(double[] first, double[] second, double[] expected)
        {
            var result = first.Combine(second);

            Assert.Equal(expected, result);
        }

        [Theory]
        [ClassData(typeof(InsertIntoArrayData))]
        public void InsertIntoArray(double[] value, int index, double item, double[] expected)
        {
            var result = value.InsertIntoArray(index, item);

            Assert.Equal(expected, result);
        }

        [Theory]
        [ClassData(typeof(SetAllValuesData))]
        public void SetAllValues(double[] value, double setter, double[] expected)
        {
            var result = value.SetAllValues(setter);

            Assert.Equal(expected, result);
        }

        [Theory]
        [ClassData(typeof(SplitByNumberOfDivisionsData))]
        public void SplitByNumberOfDivisions(double[] value, int numberOfDivisions, double[][] expected)
        {
            var result = value.SplitByNumberOfDivisions(numberOfDivisions);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void SplitByNumberOfDivisions_Exception_ZeroDivisions()
        {
            Assert.Throws<DivideByZeroException>(() => ArrayExtensions.SplitByNumberOfDivisions(new double[0], 0));
        }

        [Theory]
        [ClassData(typeof(SplitByNumberOfElementsInDivisionData))]
        public void SplitByNumberOfElementsInDivision(double[] value, int elementsInDivision, double[][] expected)
        {
            var result = value.SplitByNumberOfElementsInDivision(elementsInDivision);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void SplitByNumberOfElementsInDivision_Exception_ZeroDivisions()
        {
            Assert.Throws<DivideByZeroException>(() => ArrayExtensions.SplitByNumberOfElementsInDivision(new double[0], 0));
        }

        [Theory]
        [ClassData(typeof(SubArrayData))]
        public void SubArray(double[] value, int index, int length, double[] expected)
        {
            var result = value.SubArray(index, length);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void SubArray_Exception_value_Null()
        {
            double[] list = null;

            Assert.Throws<ArgumentNullException>(() => ArrayExtensions.SubArray(list, 0, 1));
        }

        [Fact]
        public void SubArray_Exception_Array_OutOfRange_Bottom()
        {
            double[] list = new double[] { 0, 1 };
            Assert.Throws<ArgumentOutOfRangeException>(() => ArrayExtensions.SubArray(list, -1, 1));
        }

        public class ArrayEqualData : IEnumerable<object[]>
        {
            public IEnumerator<object[]> GetEnumerator()
            {
                yield return new object[] { new double[] { 0 }, new double[] { 0 }, true };
                yield return new object[] { new double[] { 0, 1 }, new double[] { 0, 1 }, true };
                yield return new object[] { new double[] { 0 }, new double[] { 0, 1 }, false };
                yield return new object[] { new double[] { }, new double[] { }, true };
                yield return new object[] { new double[] { }, new double[] { 0 }, false };
                yield return new object[] { new double[] { 0 }, new double[] { }, false };
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }

        public class CombineData : IEnumerable<object[]>
        {
            public IEnumerator<object[]> GetEnumerator()
            {
                yield return new object[] { new double[] { 0, 1, 2 }, new double[] { 3, 4, 5 }, new double[] { 0, 1, 2, 3, 4, 5 } };
                yield return new object[] { new double[] { 0 }, new double[] { }, new double[] { 0 } };
                yield return new object[] { new double[] { }, new double[] { 0 }, new double[] { 0 } };
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }

        public class InsertIntoArrayData : IEnumerable<object[]>
        {
            public IEnumerator<object[]> GetEnumerator()
            {
                yield return new object[] { new double[] { 1, 2, 3, 4, 5 }, 2, 0, new double[] { 1, 2, 0, 3, 4, 5 } };
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }

        public class SetAllValuesData : IEnumerable<object[]>
        {
            public IEnumerator<object[]> GetEnumerator()
            {
                yield return new object[] { new double[] { }, 1, new double[] { } };
                yield return new object[] { new double[] { 0 }, 1, new double[] { 1 } };
                yield return new object[] { new double[] { 0, 0, 0, 0, 0 }, 1, new double[] { 1, 1, 1, 1, 1 } };
                yield return new object[] { new double[] { 0, 0, 0, 0, 0 }, 1.2, new double[] { 1.2, 1.2, 1.2, 1.2, 1.2 } };
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }

        public class SplitByNumberOfDivisionsData : IEnumerable<object[]>
        {
            public IEnumerator<object[]> GetEnumerator()
            {
                yield return new object[] { new double[] { }, 1,
                    new double[0][]
                };
                yield return new object[] { new double[] { 0 }, 1,
                    new double[][] {
                        new double[] { 0 }
                    }
                };
                yield return new object[] { new double[] { 0 }, 2,
                    new double[][] {
                        new double[] { 0 }
                    }
                };
                yield return new object[] { new double[] { 0, 1 }, 1,
                    new double[][] {
                        new double[] { 0, 1 }
                    }
                };
                yield return new object[] { new double[] { 0, 1 }, 2,
                    new double[][] {
                        new double[] { 0 },
                        new double[] { 1 }
                    }
                };
                yield return new object[] { new double[] { 0, 1, 2 }, 2,
                    new double[][] {
                        new double[] { 0, 1 },
                        new double[] { 2 }
                    }
                };
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }

        public class SplitByNumberOfElementsInDivisionData : IEnumerable<object[]>
        {
            public IEnumerator<object[]> GetEnumerator()
            {
                yield return new object[] { new double[] { }, 1,
                    new double[0][]
                };
                yield return new object[] { new double[] { 0 }, 1,
                    new double[][] {
                        new double[] { 0 }
                    }
                };
                yield return new object[] { new double[] { 0 }, 2,
                    new double[][] {
                        new double[] { 0 }
                    }
                };
                yield return new object[] { new double[] { 0, 1 }, 1,
                    new double[][] {
                        new double[] { 0 },
                        new double[] { 1 }
                    }
                };
                yield return new object[] { new double[] { 0, 1 }, 2,
                    new double[][] {
                        new double[] { 0, 1 }
                    }
                };
                yield return new object[] { new double[] { 0, 1, 2 }, 2,
                    new double[][] {
                        new double[] { 0, 1 },
                        new double[] { 2 }
                    }
                };
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }

        public class SubArrayData : IEnumerable<object[]>
        {
            public IEnumerator<object[]> GetEnumerator()
            {
                yield return new object[] { new double[] { 0, 1, 2, 3, 4, 5 }, 0, 6, new double[] { 0, 1, 2, 3, 4, 5 } };
                yield return new object[] { new double[] { 0, 1, 2, 3, 4, 5 }, 1, 4, new double[] { 1, 2, 3, 4 } };
                yield return new object[] { new double[] { 0, 1, 2, 3, 4, 5 }, 0, 1, new double[] { 0 } };
                yield return new object[] { new double[] { 0, 1, 2, 3, 4, 5 }, 5, 1, new double[] { 5 } };
                yield return new object[] { new double[] { 0, 1, 2, 3, 4, 5 }, 0, 0, new double[] { } };
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }
    }
}
