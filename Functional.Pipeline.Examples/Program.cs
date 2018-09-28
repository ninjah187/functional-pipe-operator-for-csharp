using System;
using System.Diagnostics;
using System.Threading.Tasks;
using static Functional.String;
using static Functional.Collections;
using static Functional.Pipeline.Operator;

namespace Functional.Pipeline.Examples
{
    class Program
    {
        static TimeSpan Benchmark(int repeats, Action action)
        {
            var sw = Stopwatch.StartNew();
            for (int i = 0; i < repeats; i++)
            {
                action();
            }
            sw.Stop();
            return sw.Elapsed;
        }

        static string NotPiped()
        {
            return Exclaim(FirstLetterToUpper(Triple(Append("hell", "o"), ", ")));
        }

        static string NotPipedReasonable()
        {
            var appended = Append("hell", "o");
            var tripled = Triple(appended, ", ");
            var uppered = FirstLetterToUpper(tripled);
            var exclaimed = Exclaim(uppered);
            return exclaimed;
        }

        static string PipedExtension()
        {
            return "hell".Pipe(
                x => $"{x}o",           // hello
                x => Triple(x, ", "),   // hello, hello, hello
                FirstLetterToUpper,     // Hello, hello, hello
                Exclaim);               // Hello, hello, hello!
        }

        static string PipedOperator()
        {
            return Pipe("hell",
                x => $"{x}o",
                x => Triple(x, ", "),
                FirstLetterToUpper,
                Exclaim);
        }

        static void WarmUp()
        {
            var repeats = 10_000;
            Benchmark(repeats, () => NotPiped());
            Benchmark(repeats, () => NotPipedReasonable());
            Benchmark(repeats, () => PipedExtension());
        }

        static (string, TimeSpan) Test(string name, Func<TimeSpan> benchmark)
        {
            var elapsed = benchmark();
            return (name, elapsed);
        }

        static void WriteResult((string, TimeSpan) result)
        {
            var (name, elapsed) = result;
            Console.WriteLine($"{name} > {elapsed}");
        }

        static async Task Main(string[] args)
        {
            WarmUp();

            var repeats = 1_000_0000;

            var elapsed = await Task.WhenAll(
                Task.Run(() => Test($"{nameof(NotPiped)} x {repeats}",
                                    () => Benchmark(repeats, () => NotPiped()))),
                Task.Run(() => Test($"{nameof(NotPipedReasonable)} x {repeats}",
                                    () => Benchmark(repeats, () => NotPipedReasonable()))),
                Task.Run(() => Test($"{nameof(PipedExtension)} x {repeats}",
                                    () => Benchmark(repeats, () => PipedExtension()))),
                Task.Run(() => Test($"{nameof(PipedOperator)} x {repeats}",
                                    () => Benchmark(repeats, () => PipedOperator()))));

            elapsed.Pipe(x => Do(x, result => WriteResult(result)));

            Console.ReadKey();
        }
    }
}
