# Extensions Library for .NET

ADN.Extensions is a cross-platform open-source library which provides extensions methods to .NET developers.

[![Build Status](https://travis-ci.org/andresdigiovanni/ADN.Extensions.svg?branch=master)](https://travis-ci.org/andresdigiovanni/ADN.Extensions)
[![NuGet](https://img.shields.io/nuget/v/ADN.Extensions.svg)](https://www.nuget.org/packages/ADN.Extensions/)
[![BCH compliance](https://bettercodehub.com/edge/badge/andresdigiovanni/ADN.Extensions?branch=master)](https://bettercodehub.com/)
[![Maintainability Rating](https://sonarcloud.io/api/project_badges/measure?project=andresdigiovanni_ADN.Extensions&metric=sqale_rating)](https://sonarcloud.io/dashboard?id=andresdigiovanni_ADN.Extensions)
[![Quality](https://sonarcloud.io/api/project_badges/measure?project=andresdigiovanni_ADN.Extensions&metric=alert_status)](https://sonarcloud.io/dashboard?id=andresdigiovanni_ADN.Extensions)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

## Basic usage

Example Dictionary extensions:

```csharp
var dictionary = new Dictionary<string, int>
{
    { "Luke", 1 },
    { "Skywalker", 2 }
};
dictionary.RemoveAll(value => value == 2);

/*
 dictionary contains the values [ {"Luke", 1} ]
 */
```

## Installation

ADN.Extensions runs on Windows, Linux, and macOS.

Once you have an app, you can install the ADN.Extensions NuGet package from the NuGet package manager:

```
Install-Package ADN.Extensions
```

Or alternatively you can add the ADN.Extensions package from within Visual Studio's NuGet package manager.

## Examples

Please find examples and the documentation at the [wiki](https://github.com/andresdigiovanni/ADN.Extensions/wiki) of this repository.

## Contributing

We welcome contributions! Please review our [contribution guide](CONTRIBUTING.md).

## License

ADN.Extensions is licensed under the [MIT license](LICENSE).
