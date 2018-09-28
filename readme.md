# Functional.Pipeline

## C# functional programming forward pipe operator-like functions.

This small feature is meant to fill the gap created by lack of forward pipe operator in C#. These functions allow one to increase readability of functional code.

## Usage:

### Extension:

```cs
using Functional.Pipeline;
using static Functional.String; // string manipulation helper functions

namespace Examples
{
    static void Piped()
    {
        var greetings = "hell".Pipe(
            x => $"{x}o",             // hello
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
            x => $"{x}o",
            x => Triple(x, ", "),
            FirstLetterToUpper,
            Exclaim);
    }
}
```