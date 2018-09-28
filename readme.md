# Functional.Pipeline

## C# functional programming forward pipe operator-like functions.

This small feature is meant to fill the gap created by lack of forward pipe operator in C#.
Forward pipe operator allows one to increase readability of functional code.

## Usage:

### Installation:

All released Functional.Pipeline versions can be obtained via NuGet Package Manager.

| Package              | Version | Build                                                                                                               |
| -------------------- | ------- | ------------------------------------------------------------------------------------------------------------------- |
| Functional.Pipeline  | 1.0.0   | [![Build Status](https://travis-ci.org/ninjah187/functional-pipe-operator-for-csharp.svg?branch=release)](https://travis-ci.org/ninjah187/functional-pipe-operator-for-csharp) |

### Extension:

```cs
using Functional.Pipeline;
using static Functional.String; // string manipulation helper functions

namespace Examples
{
    static void Piped()
    {
        var greetings = "hell".Pipe(
            x => Append(x, "o"),      // hello
            x => Triple(x, ", "),     // hello, hello, hello
            FirstLetterToUpper,       // Hello, hello, hello
            Exclaim);                 // Hello, hello, hello!
    }
}
```

### Static function:

```cs
using static Functional.Pipeline.Operator;
using static Functional.String;

namespace Examples
{
    static void Piped()
    {
        var greetings = Pipe("hell",
            x => Append(x, "o"),
            x => Triple(x, ", "),
            FirstLetterToUpper,
            Exclaim);
    }
}
```