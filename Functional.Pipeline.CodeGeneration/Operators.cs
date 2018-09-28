using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Functional.Pipeline.CodeGeneration.Utils;

namespace Functional.Pipeline.CodeGeneration
{
    public static class Operators
    {
        public static string Generate(int count)
        {
            var code = Enumerable.Range(2, count)
                .Select(index =>
$@"public static TOut Pipe<TIn, {Sequence(index, i => $"TMid{i}", ", ")}, TOut>(
    TIn value,
    Func<TIn, TMid1> input,
{Sequence(index - 1, i => $"    Func<TMid{i}, TMid{i+1}> mid{i}", ",\n")},
    Func<TMid{index}, TOut> output) => output(Pipe(value, input, {Sequence(index - 1, i => $"mid{i}", ", ")}));")
                .ToArray();
            return string.Join("\n\n", code);
        }
    }
}
