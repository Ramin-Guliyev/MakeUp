[![Nuget](https://img.shields.io/nuget/v/MakeUp.svg?color=blue&label=MakeUp&style=flat-square)](https://www.nuget.org/packages/MakeUp/)
[![Nuget](https://img.shields.io/nuget/dt/MakeUp.svg?style=flat-square)](https://www.nuget.org/packages/MakeUp/)
# MakeUp
* Make your console app looks much more pretty 😉 


## Introduction
This package is set of extenion methots for making colorful console apps .

## Current Features
* Writes colorful string to one line.
* Writes colorful string to new line.
* Changes string background colors.

## Getting started

Add package to your project from [nuget](https://www.nuget.org/packages/MakeUp/)

    dotnet add package MakeUp --version 2.0.0

```csharp
using MakeUp;

public class Example
{
        public static void Main()
        {
                "Hello World".Write(Color.DarkRed);
                "Hello MakeUp".WriteLine(Color.White);

                "Hello MakeUp".Write(BackgroundColor.Gray);
                "Hello World".WriteLine(BackgroundColor.Green);

                "Hello MakeUp".WriteLine(BackgroundColor.Green,Color.DarkRed)
        }
}
```
* You can use this extension methots for all strings 
* Also this usage is available

```csharp
using MakeUp;

public class Example
{
        public static void Main()
        {
                MakeUp.Write("Hello World",MakeUpColor.DarkRed);
                MakeUp.Write("Hello MakeUp",MakeUpColor.White);
        }
}
```

## Contributing
Want to help develop MakeUp? Check out our [contribution guide](/CONTRIBUTING.md).

