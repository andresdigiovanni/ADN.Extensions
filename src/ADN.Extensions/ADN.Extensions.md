# ADN.Extensions

# Content

- [ArrayExtensions](#T:ADN.Extensions.ArrayExtensions)

  - [ArrayEqual`<T>(first, second)](#ArrayExtensions.ArrayEqual`<T>(first,second))

  - [Combine`<T>(first, second)](#ArrayExtensions.Combine`<T>(first,second))

  - [InsertIntoArray`<T>(array, index, item)](#ArrayExtensions.InsertIntoArray`<T>(array,index,item))

  - [SetAllValues`<T>(array, value)](#ArrayExtensions.SetAllValues`<T>(array,value))

  - [SplitByNumberOfDivisions`<T>(array, numberOfDivisions)](#ArrayExtensions.SplitByNumberOfDivisions`<T>(array,numberOfDivisions))

  - [SplitByNumberOfElementsInDivision`<T>(array, elementsInDivision)](#ArrayExtensions.SplitByNumberOfElementsInDivision`<T>(array,elementsInDivision))

  - [SubArray`<T>(array, index, length)](#ArrayExtensions.SubArray`<T>(array,index,length))

- [Base64Extensions](#T:ADN.Extensions.Base64Extensions)

  - [Base64Decode(base64EncodedData)](#Base64Extensions.Base64Decode(base64EncodedData))

  - [Base64Encode(plainText)](#Base64Extensions.Base64Encode(plainText))

- [ByteExtensions](#T:ADN.Extensions.ByteExtensions)

  - [BytesToHexa(bytes, separator)](#ByteExtensions.BytesToHexa(bytes,separator))

  - [BytesToString(bytes)](#ByteExtensions.BytesToString(bytes))

  - [HexaToBytes(value, separator)](#ByteExtensions.HexaToBytes(value,separator))

  - [StringToBytes(value)](#ByteExtensions.StringToBytes(value))

- [DataTableExtensions](#T:ADN.Extensions.DataTableExtensions)

- [DataTableExtensions.TableCssClasses](#T:ADN.Extensions.DataTableExtensions.TableCssClasses)

  - [DataTableExtensions.ToHtmlTable(dataTable, tableCssClasses)](#DataTableExtensions.ToHtmlTable(dataTable,tableCssClasses))

- [DateTimeExtensions](#T:ADN.Extensions.DateTimeExtensions)

  - [DateTimeToUnixTimeStamp(dateTime)](#DateTimeExtensions.DateTimeToUnixTimeStamp(dateTime))

  - [TrimMilliseconds(dateTime)](#DateTimeExtensions.TrimMilliseconds(dateTime))

  - [TrimSecondsAndMilliseconds(dateTime)](#DateTimeExtensions.TrimSecondsAndMilliseconds(dateTime))

  - [TrimTicks(dateTime)](#DateTimeExtensions.TrimTicks(dateTime))

  - [UnixTimeStampToDateTime(unixTimestamp)](#DateTimeExtensions.UnixTimeStampToDateTime(unixTimestamp))

- [DictionaryExtensions](#T:ADN.Extensions.DictionaryExtensions)

  - [RemoveAll``2(System.Collections.Generic.IDictionary{``0,`<T>},System.Func{`<T>,System.Boolean})](#DictionaryExtensions.RemoveAll``2(System.Collections.Generic.IDictionary{``0,`<T>},System.Func{`<T>,System.Boolean}))

- [IntegerExtensions](#T:ADN.Extensions.IntegerExtensions)

  - [RoundNumber(value, step)](#IntegerExtensions.RoundNumber(value,step))

  - [RoundNumber(value, step, min, max)](#IntegerExtensions.RoundNumber(value,step,min,max))

- [ListExtensions](#T:ADN.Extensions.ListExtensions)

  - [IndexOfMax`<T>(values)](#ListExtensions.IndexOfMax`<T>(values))

  - [IndexOfMin`<T>(values)](#ListExtensions.IndexOfMin`<T>(values))

  - [IsSame`<T>(first, second)](#ListExtensions.IsSame`<T>(first,second))

  - [Mean(values)](#ListExtensions.Mean(values))

  - [Mean(values, start, end)](#ListExtensions.Mean(values,start,end))

  - [Median(values)](#ListExtensions.Median(values))

  - [Median(values, start, end)](#ListExtensions.Median(values,start,end))

  - [Shuffle`<T>(values)](#ListExtensions.Shuffle`<T>(values))

  - [StandardDeviation(values)](#ListExtensions.StandardDeviation(values))

  - [StandardDeviation(values, start, end)](#ListExtensions.StandardDeviation(values,start,end))

  - [Variance(values)](#ListExtensions.Variance(values))

  - [Variance(values, mean)](#ListExtensions.Variance(values,mean))

  - [Variance(values, mean, start, end)](#ListExtensions.Variance(values,mean,start,end))

- [NumberExtensions](#T:ADN.Extensions.NumberExtensions)

  - [IsNumber(value)](#NumberExtensions.IsNumber(value))

- [ObjectExtensions](#T:ADN.Extensions.ObjectExtensions)

  - [DeepClone`<T>(source)](#ObjectExtensions.DeepClone`<T>(source))

- [StringExtensions](#T:ADN.Extensions.StringExtensions)

  - [FromHex(str)](#StringExtensions.FromHex(str))

  - [IsAlphaNumeric(str)](#StringExtensions.IsAlphaNumeric(str))

  - [IsValidEmailAddress(str)](#StringExtensions.IsValidEmailAddress(str))

  - [Left(str, length)](#StringExtensions.Left(str,length))

  - [Mid(str, startIndex, length)](#StringExtensions.Mid(str,startIndex,length))

  - [Right(str, length)](#StringExtensions.Right(str,length))

  - [ToHex(str)](#StringExtensions.ToHex(str))

  - [TrimNonPrintableAscii(str)](#StringExtensions.TrimNonPrintableAscii(str))

<a name='T:ADN.Extensions.ArrayExtensions'></a>


## ArrayExtensions

A static class of extension methods for .

<a name='ArrayExtensions.ArrayEqual`<T>(first,second)'></a>


### ArrayEqual`<T>(first, second)

Checks if the Arrays are equal.


#### Parameters

| Name | Description |
| ---- | ----------- |
| first | *``0[]*<br>The that contains data to compare with. |

#### Parameters

| second | *``0[]*<br>The that contains data to compare to. |


#### Returns

Returns true if all element match and false otherwise.


#### Example

```csharp
var first= new double[] { 0, 0, 0, 0, 0 };
var second = new double[] { 0, 0, 0, 0, 0 };
var result = first.ArrayEqual(second);

/*
result is true
*/
```

<a name='ArrayExtensions.Combine`<T>(first,second)'></a>


### Combine`<T>(first, second)

Combine the Arrays.


#### Parameters

| Name | Description |
| ---- | ----------- |
| first | *``0[]*<br>First element to combine. |

#### Parameters

| second | *``0[]*<br>Second element to combine. |


#### Returns

T[].


#### Example

```csharp
var first= new double[] { 0, 1, 2 };
var second = new double[] { 3, 4, 5 };
var result = first.Combine(second);

/*
result contains the values { 0, 1, 2, 3, 4, 5 }
*/
```

<a name='ArrayExtensions.InsertIntoArray`<T>(array,index,item)'></a>


### InsertIntoArray`<T>(array, index, item)

Inserts an element into the at the specified index.


#### Parameters

| Name | Description |
| ---- | ----------- |
| array | *``0[]*<br>The one-dimensional, zero-based array. |

#### Parameters

| index | *System.Int32*<br>The zero-based index at which item should be inserted. |

#### Parameters

| item | *``0*<br>The object to insert. The value can be null for reference types. |


#### Returns

A reference to the changed array.


#### Example

```csharp
var array = new double[] { 1, 2, 3, 4, 5 };
var result = array.InsertIntoArray(2, 0);

/*
result contains the values { 1, 2, 0, 3, 4, 5 }
*/
```

<a name='ArrayExtensions.SetAllValues`<T>(array,value)'></a>


### SetAllValues`<T>(array, value)

Sets all values.


#### Parameters

| Name | Description |
| ---- | ----------- |
| array | *``0[]*<br>The one-dimensional, zero-based array. |

#### Parameters

| value | *``0*<br>The value. |


#### Returns

A reference to the changed array.


#### Example

```csharp
var array = new double[] { 0, 0, 0, 0, 0 };
var result = array.SetAllValues(1);

/*
result contains the values { 1, 1, 1, 1, 1 }
*/
```

<a name='ArrayExtensions.SplitByNumberOfDivisions`<T>(array,numberOfDivisions)'></a>


### SplitByNumberOfDivisions`<T>(array, numberOfDivisions)

Split an array into subarrays by specifying the number of divisions.


#### Parameters

| Name | Description |
| ---- | ----------- |
| array | *``0[]*<br>Array to split. |

#### Parameters

| numberOfDivisions | *System.Int32*<br>Number of divisions. |


#### Returns

Subarrays.

*System.DivideByZeroException:* Number of divisions is zero.


#### Example

```csharp
var array = new double[] { 0, 1, 2 };
var numberOfDivisions = 2;
var result = array.SplitByNumberOfDivisions(numberOfDivisions);

/*
result contains the values { { 0, 1 }, { 2 } }
*/
```

<a name='ArrayExtensions.SplitByNumberOfElementsInDivision`<T>(array,elementsInDivision)'></a>


### SplitByNumberOfElementsInDivision`<T>(array, elementsInDivision)

Split an array into subarrays by specifying the number of elements in each division.


#### Parameters

| Name | Description |
| ---- | ----------- |
| array | *``0[]*<br>Array to split. |

#### Parameters

| elementsInDivision | *System.Int32*<br>Elements in each division. |


#### Returns

Subarrays.

*System.DivideByZeroException:* Number of elements in division is zero.


#### Example

```csharp
var array = new double[] { 0, 1, 2 };
var elementsInDivision = 2;
var result = array.SplitByNumberOfElementsInDivision(elementsInDivision);

/*
result contains the values { { 0, 1 }, { 2 } }
*/
```

<a name='ArrayExtensions.SubArray`<T>(array,index,length)'></a>


### SubArray`<T>(array, index, length)

Subs the array.


#### Parameters

| Name | Description |
| ---- | ----------- |
| array | *``0[]*<br>The data. |

#### Parameters

| index | *System.Int32*<br>The index. |

#### Parameters

| length | *System.Int32*<br>The length. |


#### Returns

T[].


#### Example

```csharp
var array = new double[] { 0, 1, 2, 3, 4, 5 };
var index = 1;
var length = 4;
var result = array.SubArray(index, length);

/*
result contains the values { 1, 2, 3, 4 }
*/
```

<a name='T:ADN.Extensions.Base64Extensions'></a>


## Base64Extensions

A static class of methods for Base64 strings.

<a name='Base64Extensions.Base64Decode(base64EncodedData)'></a>


### Base64Decode(base64EncodedData)

Converts the specified string, which encodes binary data as base-64 digits, to an equivalent plain text string.


#### Parameters

| Name | Description |
| ---- | ----------- |
| base64EncodedData | *System.String*<br>String encoded with base-64 digits. |


#### Returns

Plain text string.


#### Example

```csharp
var value = "MDEyMzQ1Njc4OQ==";
var result = value.Base64Decode();

/*
result is "0123456789"
*/
```

<a name='Base64Extensions.Base64Encode(plainText)'></a>


### Base64Encode(plainText)

Converts the value of a plain text string to its equivalent string representation that is encoded with base-64 digits.


#### Parameters

| Name | Description |
| ---- | ----------- |
| plainText | *System.String*<br>Plain text string. |


#### Returns

String encoded with base-64 digits.


#### Example

```csharp
var value = "0123456789";
var result = value.Base64Encode();

/*
result is "MDEyMzQ1Njc4OQ=="
*/
```

<a name='T:ADN.Extensions.ByteExtensions'></a>


## ByteExtensions

A static class of extension methods for .

<a name='ByteExtensions.BytesToHexa(bytes,separator)'></a>


### BytesToHexa(bytes, separator)

Converts the numeric value of a byte array to its equivalent hexadecimal string.


#### Parameters

| Name | Description |
| ---- | ----------- |
| bytes | *System.Byte[]*<br>The value. |

#### Parameters

| separator | *System.String*<br>Hexadecimal values separator. |


#### Returns

Hexadecimal string.


#### Example

```csharp
var array = new byte[] { 48, 49, 50, 51, 52 };
var separator = "-";
var result = array.BytesToHexa(separator);

/*
result is "30-31-32-33-34"
*/
```

<a name='ByteExtensions.BytesToString(bytes)'></a>


### BytesToString(bytes)

Decodes a sequence of bytes from the specified byte array into a string.


#### Parameters

| Name | Description |
| ---- | ----------- |
| bytes | *System.Byte[]*<br>The byte array containing the sequence of bytes to decode. |


#### Returns

A string that contains the results of decoding the specified sequence of bytes.


#### Remarks

Equivalent to System.Text.Encoding.UTF8.GetString().


#### Example

```csharp
var array = new byte[] { 48, 49, 50, 51, 52 };
var result = array.BytesToString();

/*
result is "01234"
*/
```

<a name='ByteExtensions.HexaToBytes(value,separator)'></a>


### HexaToBytes(value, separator)

Converts the hexadecimal string to its quivalent numeric value byte array.


#### Parameters

| Name | Description |
| ---- | ----------- |
| value | *System.String*<br>The value. |

#### Parameters

| separator | *System.String*<br>Hexadecimal values separator. |


#### Returns

Byte array.


#### Example

```csharp
var value = "30-31-32-33-34";
var separator = "-";
var result = value.HexaToBytes(separator);

/*
result contains the values { 48, 49, 50, 51, 52 }
*/
```

<a name='ByteExtensions.StringToBytes(value)'></a>


### StringToBytes(value)

Encodes a set of characters into a sequence of bytes.


#### Parameters

| Name | Description |
| ---- | ----------- |
| value | *System.String*<br>The character array containing the characters to encode. |


#### Returns

A byte array containing the results of encoding the specified set of characters.


#### Remarks

Equivalent to System.Text.Encoding.UTF8.GetBytes().


#### Example

```csharp
var value = "01234";
var result = value.StringToBytes();

/*
result contains the values { 48, 49, 50, 51, 52 }
*/
```

<a name='T:ADN.Extensions.DataTableExtensions'></a>


## DataTableExtensions

A static class of extension methods for .

<a name='T:ADN.Extensions.DataTableExtensions.TableCssClasses'></a>


## DataTableExtensions.TableCssClasses

CSS classes.

<a name='DataTableExtensions.ToHtmlTable(dataTable,tableCssClasses)'></a>


### DataTableExtensions.ToHtmlTable(dataTable, tableCssClasses)

Convert a DataTable to the equivalent HTML table.


#### Parameters

| Name | Description |
| ---- | ----------- |
| dataTable | *System.Data.DataTable*<br>DataTable to convert. |

#### Parameters

| tableCssClasses | *ADN.Extensions.DataTableExtensions.TableCssClasses*<br>Optional parameter. CSS classes. |


#### Returns

HTML table.


#### Example

```csharp
DataTable table = new DataTable(new DataTableExtensions.TableCssClasses()
{
Table = "class-table",
Tr = "class-tr-1 class-tr-2",
Th = "class-th",
Td = "class-td",
});
// populate table
var result = table.ToHtmlTable();
```

<a name='T:ADN.Extensions.DateTimeExtensions'></a>


## DateTimeExtensions

A static class of extension methods for .

<a name='DateTimeExtensions.DateTimeToUnixTimeStamp(dateTime)'></a>


### DateTimeToUnixTimeStamp(dateTime)

Converts DateTime to unix time stamp.


#### Parameters

| Name | Description |
| ---- | ----------- |
| dateTime | *System.DateTime*<br>The DateTime. |


#### Returns

The unix time stamp.


#### Example

```csharp
var dateTime = DateTime.Parse("02/16/2008 12:15:12", new CultureInfo("en-US"));
var result = date.DateTimeToUnixTimeStamp();

/*
result is 1203164112
*/
```

<a name='DateTimeExtensions.TrimMilliseconds(dateTime)'></a>


### TrimMilliseconds(dateTime)

Returns the DateTime with the milliseconds trimmed.


#### Parameters

| Name | Description |
| ---- | ----------- |
| dateTime | *System.DateTime*<br>The DateTime. |


#### Returns

A DateTime with the milliseconds trimmed.


#### Example

```csharp
var dateTime = DateTime.Now.TrimMilliseconds();
```

<a name='DateTimeExtensions.TrimSecondsAndMilliseconds(dateTime)'></a>


### TrimSecondsAndMilliseconds(dateTime)

Returns a Datetime with the seconds trimmed.


#### Parameters

| Name | Description |
| ---- | ----------- |
| dateTime | *System.DateTime*<br>The DateTime. |


#### Returns

A DateTime with the seconds trimmed.


#### Example

```csharp
var dateTime = DateTime.Now.TrimSecondsAndMilliseconds();
```

<a name='DateTimeExtensions.TrimTicks(dateTime)'></a>


### TrimTicks(dateTime)

Returns the DateTime with the ticks trimmed.


#### Parameters

| Name | Description |
| ---- | ----------- |
| dateTime | *System.DateTime*<br>The DateTime. |


#### Returns

A DateTime with the ticks trimmed.


#### Example

```csharp
var dateTime = DateTime.Now.TrimTicks();
```

<a name='DateTimeExtensions.UnixTimeStampToDateTime(unixTimestamp)'></a>


### UnixTimeStampToDateTime(unixTimestamp)

Converts unix time stamp to DateTime.


#### Parameters

| Name | Description |
| ---- | ----------- |
| unixTimestamp | *System.Int64*<br>The unix time stamp. |


#### Returns

The DateTime.


#### Example

```csharp
long unixTimestamp = 1203164112;
var result = unixTimestamp.UnixTimeStampToDateTime().ToString("MM/dd/yyyy HH:mm:ss");

/*
result is 02/16/2008 12:15:12
*/
```

<a name='T:ADN.Extensions.DictionaryExtensions'></a>


## DictionaryExtensions

A static class of extension methods for .

<a name='DictionaryExtensions.RemoveAll``2(System.Collections.Generic.IDictionary{``0,`<T>},System.Func{`<T>,System.Boolean})'></a>


### RemoveAll``2(System.Collections.Generic.IDictionary{``0,`<T>},System.Func{`<T>,System.Boolean})

Remove all elements in the dictionary that match the predicate.


#### Parameters

| Name | Description |
| ---- | ----------- |
| dict | *Unknown type*<br>The dictionary to modify. |

#### Parameters

| predicate | *Unknown type*<br>The predicate to make the match. |


#### Example

```csharpvar dictionary = new Dictionary<string, int>
{
{ "Luke", 1 },
{ "Skywalker", 2 }
};
dictionary.RemoveAll(value => value == 2);

/*
dictionary contains the values [ {"Luke", 1} ]
*/
```

<a name='T:ADN.Extensions.IntegerExtensions'></a>


## IntegerExtensions

A static class of extension methods for .

<a name='IntegerExtensions.RoundNumber(value,step)'></a>


### RoundNumber(value, step)

Rounds a value to the nearest integer with the given step.


#### Parameters

| Name | Description |
| ---- | ----------- |
| value | *System.Double*<br>A double-precision floating-point number to be rounded. |

#### Parameters

| step | *System.Int32*<br>Step number to round. |


#### Returns

The number nearest to value that is multiple of the given step.


#### Example

```csharp
double value = 12;
int step = 5;
var result = value.RoundNumber(step);

/*
result is 10
*/
```

<a name='IntegerExtensions.RoundNumber(value,step,min,max)'></a>


### RoundNumber(value, step, min, max)

Rounds a value to the nearest integer with the given step and within the determined range.


#### Parameters

| Name | Description |
| ---- | ----------- |
| value | *System.Double*<br>A double-precision floating-point number to be rounded. |

#### Parameters

| step | *System.Int32*<br>Step number to round. |

#### Parameters

| min | *System.Int32*<br>Minimum value. |

#### Parameters

| max | *System.Int32*<br>Maximum value. |


#### Returns

The number nearest to value that is multiple of the given step and within the determined range.


#### Example

```csharp
double value = 12;
int step = 5;
int min = 0;
int max = 20;
var result = value.RoundNumber(step, min, max);

/*
result is 10
*/
```

<a name='T:ADN.Extensions.ListExtensions'></a>


## ListExtensions

A static class of extension methods for .

<a name='ListExtensions.IndexOfMax`<T>(values)'></a>


### IndexOfMax`<T>(values)

Find the index of the maximum value of the list.


#### Parameters

| Name | Description |
| ---- | ----------- |
| values | *System.Collections.Generic.IList{``0}*<br>The list of elements. |


#### Returns

Index of the maximum value of the list.


#### Example

```csharp
var values = new double[] { 10, 11, 12, 13, 12, 11, 10 };
var result = values.IndexOfMax();

/*
result is 3
*/
```

<a name='ListExtensions.IndexOfMin`<T>(values)'></a>


### IndexOfMin`<T>(values)

Find the index of the minimum value of the list.


#### Parameters

| Name | Description |
| ---- | ----------- |
| values | *System.Collections.Generic.IList{``0}*<br>The list of elements. |


#### Returns

Index of the minimum value of the list.


#### Example

```csharp
var values = new double[] { 13, 12, 11, 10, 11, 12, 13 };
var result = values.IndexOfMin();

/*
result is 3
*/
```

<a name='ListExtensions.IsSame`<T>(first,second)'></a>


### IsSame`<T>(first, second)

Determine if two sequences contains exactly the same elements.


#### Parameters

| Name | Description |
| ---- | ----------- |
| first | *System.Collections.Generic.IList{``0}*<br>The first list of elements. |

#### Parameters

| second | *System.Collections.Generic.IList{``0}*<br>The second list of elements. |


#### Returns

True if two sequences contains exactly the same elements, false otherwise.


#### Example

```csharp
var first = new double[] { 0, 1 };
var second = new double[] { 1, 0 };
var result = first.IsSame(second);

/*
result is true
*/
```

<a name='ListExtensions.Mean(values)'></a>


### Mean(values)

Gets the mean of the values of the list.


#### Parameters

| Name | Description |
| ---- | ----------- |
| values | *System.Collections.Generic.List{System.Double}*<br>The list of elements. |


#### Returns

Mean of the values.


#### Example

```csharpvar values = new List<double>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
var result = values.Mean();

/*
result is 4.5
*/
```

<a name='ListExtensions.Mean(values,start,end)'></a>


### Mean(values, start, end)

Gets the mean of the values of the list of a given range.


#### Parameters

| Name | Description |
| ---- | ----------- |
| values | *System.Collections.Generic.List{System.Double}*<br>The list of elements. |

#### Parameters

| start | *System.Int32*<br>Start index. |

#### Parameters

| end | *System.Int32*<br>End index. |


#### Returns

Mean of the values.

*System.ArgumentOutOfRangeException:* Start or end out of range.


#### Example

```csharp
int start = 0;
int end = 5;
var values = new List<double>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
var result = values.Mean(start, end);

/*
result is 2.5
*/
```

<a name='ListExtensions.Median(values)'></a>


### Median(values)

Gets the value of the middle element of the list after sorted.


#### Parameters

| Name | Description |
| ---- | ----------- |
| values | *System.Collections.Generic.List{System.Double}*<br>The list of elements. |


#### Returns

Index of the middle element.


#### Example

```csharp
var values = new double[] { 2, 3, 5, 1, 4 };
var result = values.Median();

/*
result is 3
*/
```

<a name='ListExtensions.Median(values,start,end)'></a>


### Median(values, start, end)

Gets the value of the middle element of the list after sorted of a given range.


#### Parameters

| Name | Description |
| ---- | ----------- |
| values | *System.Collections.Generic.List{System.Double}*<br>The list of elements. |

#### Parameters

| start | *System.Int32*<br>Start index. |

#### Parameters

| end | *System.Int32*<br>End index. |


#### Returns

Index of the middle element.


#### Example

```csharp
int start = 0;
int end = 2;
var values = new double[] { 2, 3, 5, 1, 4 };
var result = values.Median();

/*
result is 2
*/
```

<a name='ListExtensions.Shuffle`<T>(values)'></a>


### Shuffle`<T>(values)

Shuffle the elements of the list.


#### Parameters

| Name | Description |
| ---- | ----------- |
| values | *System.Collections.Generic.IList{``0}*<br>The list of elements. |


#### Example

```csharp
var values = new double[] { 0, 1, 2, 3, 4, 5 };
values.Shuffle();
```

<a name='ListExtensions.StandardDeviation(values)'></a>


### StandardDeviation(values)

Calculate the standard deviation of the values of the list.


#### Parameters

| Name | Description |
| ---- | ----------- |
| values | *System.Collections.Generic.List{System.Double}*<br>The list of elements. |


#### Returns

Standard deviation.


#### Example

```csharpvar values = new List<double>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
var result = values.StandardDeviation();
```

<a name='ListExtensions.StandardDeviation(values,start,end)'></a>


### StandardDeviation(values, start, end)

Calculate the standard deviation of the values of the list of a given range.


#### Parameters

| Name | Description |
| ---- | ----------- |
| values | *System.Collections.Generic.List{System.Double}*<br>The list of elements. |

#### Parameters

| start | *System.Int32*<br>Start index. |

#### Parameters

| end | *System.Int32*<br>End index. |


#### Returns

Standard deviation.


#### Example

```csharp
int start = 0;
int end = 5;
var values = new List<double>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
var result = values.StandardDeviation(start, end);
```

<a name='ListExtensions.Variance(values)'></a>


### Variance(values)

Calculate the variance of the values of the list.


#### Parameters

| Name | Description |
| ---- | ----------- |
| values | *System.Collections.Generic.List{System.Double}*<br>The list of elements. |


#### Returns

Variance of values.


#### Example

```csharpvar values = new List<double>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
var result = values.Variance();
```

<a name='ListExtensions.Variance(values,mean)'></a>


### Variance(values, mean)

Calculate the variance of the values of the list.


#### Parameters

| Name | Description |
| ---- | ----------- |
| values | *System.Collections.Generic.List{System.Double}*<br>The list of elements. |

#### Parameters

| mean | *System.Double*<br>The mean of the values of the list. |


#### Returns

Variance of values.


#### Example

```csharp
double mean = 2.5;
var values = new List<double>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
var result = values.Variance(mean);
```

<a name='ListExtensions.Variance(values,mean,start,end)'></a>


### Variance(values, mean, start, end)

Calculate the variance of the values of the list of a given range.


#### Parameters

| Name | Description |
| ---- | ----------- |
| values | *System.Collections.Generic.List{System.Double}*<br>The list of elements. |

#### Parameters

| mean | *System.Double*<br>The mean of the values of the list. |

#### Parameters

| start | *System.Int32*<br>Start index. |

#### Parameters

| end | *System.Int32*<br>End index. |


#### Returns

Variance of values.


#### Example

```csharp
int start = 0;
int end = 5;
double mean = 2.5;
var values = new List<double>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
var result = values.Variance(mean, start, end);
```

<a name='T:ADN.Extensions.NumberExtensions'></a>


## NumberExtensions

A static class of extension methods for numbers.

<a name='NumberExtensions.IsNumber(value)'></a>


### IsNumber(value)

Checks if an object is a number type.


#### Parameters

| Name | Description |
| ---- | ----------- |
| value | *System.Object*<br> |


#### Returns

True if the object is a number type.


#### Example

```csharp
double value = 42;
var result = value.IsNumber();

/*
result is True
*/
```

<a name='T:ADN.Extensions.ObjectExtensions'></a>


## ObjectExtensions

A static class of extension methods for .

<a name='ObjectExtensions.DeepClone`<T>(source)'></a>


### DeepClone`<T>(source)

Clone a serializable object.


#### Parameters

| Name | Description |
| ---- | ----------- |
| source | *``0*<br>Object to clone. |


#### Returns

A clone of the object.


#### Example

```csharp
var person1 = new Person()
{
FirstName = "Luke",
LastName = "Skywalwer"
};
var person2 = person1.DeepClone();
```

<a name='T:ADN.Extensions.StringExtensions'></a>


## StringExtensions

A static class of extension methods for .

<a name='StringExtensions.FromHex(str)'></a>


### FromHex(str)

Converts a hexadecimal string to unicode string.


#### Parameters

| Name | Description |
| ---- | ----------- |
| str | *System.String*<br>Hexadecimal string. |


#### Returns

Unicode string.


#### Example

```csharp
var value = "4C6F72656D20497073756D";
var result = value.FromHex();

/*
result is "Lorem Ipsum"
*/
```

<a name='StringExtensions.IsAlphaNumeric(str)'></a>


### IsAlphaNumeric(str)

Check if a string is alphanumeric.


#### Parameters

| Name | Description |
| ---- | ----------- |
| str | *System.String*<br>String to check. |


#### Returns

True if the string is alphanumeric, false otherwise.


#### Example

```csharp
var value = "abc1234";
var result = value.IsAlphaNumeric();

/*
result is true
*/
```

<a name='StringExtensions.IsValidEmailAddress(str)'></a>


### IsValidEmailAddress(str)

Check if a string is a valid email.


#### Parameters

| Name | Description |
| ---- | ----------- |
| str | *System.String*<br>String to check. |


#### Returns

True if the string is a valid email, false otherwise.


#### Example

```csharp
var value = "austin.powers@example.com";
var result = value.IsValidEmailAddress();

/*
result is true
*/
```

<a name='StringExtensions.Left(str,length)'></a>


### Left(str, length)

Returns a string containing a specified number of characters from the left side of a string.


#### Parameters

| Name | Description |
| ---- | ----------- |
| str | *System.String*<br>String expression from which the leftmost characters are returned. |

#### Parameters

| length | *System.Int32*<br>Numeric expression indicating how many characters to return. |


#### Returns

Returns a string containing a specified number of characters from the left side of a string.


#### Example

```csharp
var value = "abcdefghij";
var length = 5;
var result = value.Left(length);

/*
result is "abcde"
*/
```

<a name='StringExtensions.Mid(str,startIndex,length)'></a>


### Mid(str, startIndex, length)

Returns a string that contains a specified number of characters starting from a specified position in a string.


#### Parameters

| Name | Description |
| ---- | ----------- |
| str | *System.String*<br>String expression from which characters are returned. |

#### Parameters

| startIndex | *System.Int32*<br>Starting position of the characters to return. |

#### Parameters

| length | *System.Int32*<br>Number of characters to return. |


#### Returns

A string that consists of the specified number of characters starting from the specified position in the string.


#### Example

```csharp
var value = "abcdefghij";
var startIndex = 3;
var length = 5;
var result = value.Mid(startIndex, length);

/*
result is "defgh"
*/
```

<a name='StringExtensions.Right(str,length)'></a>


### Right(str, length)

Returns a string containing a specified number of characters from the right side of a string.


#### Parameters

| Name | Description |
| ---- | ----------- |
| str | *System.String*<br>String expression from which the rightmost characters are returned. |

#### Parameters

| length | *System.Int32*<br>Numeric expression indicating how many characters to return. |


#### Returns

Returns a string containing a specified number of characters from the right side of a string.


#### Example

```csharp
var value = "abcdefghij";
var length = 5;
var result = value.Right(length);

/*
result is "fghij"
*/
```

<a name='StringExtensions.ToHex(str)'></a>


### ToHex(str)

Converts a unicode string to hexadecimal string.


#### Parameters

| Name | Description |
| ---- | ----------- |
| str | *System.String*<br>Unicode string. |


#### Returns

Hexadecimal string.


#### Example

```csharp
var value = "Lorem Ipsum";
var result = value.ToHex();

/*
result is "4C6F72656D20497073756D"
*/
```

<a name='StringExtensions.TrimNonPrintableAscii(str)'></a>


### TrimNonPrintableAscii(str)

Returns a string without the non-printable ASCII characters from a string (characters between space and tilde).


#### Parameters

| Name | Description |
| ---- | ----------- |
| str | *System.String*<br>String to remove the non-printable ASCII characters. |


#### Returns

A string without the non-printable ASCII characters from a string (characters between space and tilde).


#### Example

```csharp
var str = (char)0x12 + " a~";
var result = str.TrimNonPrintableAscii();

/*
result is " a~"
*/
```

