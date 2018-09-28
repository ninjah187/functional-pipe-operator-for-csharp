using System;
using System.Collections.Generic;
using System.Text;

namespace Functional.Pipeline
{
    public static class Operator
    {
        public static TOut Pipe<TIn, TOut>(TIn value, Func<TIn, TOut> func) => func(value);

        public static TOut Pipe<TIn, TMid, TOut>(
            TIn value,
            Func<TIn, TMid> input,
            Func<TMid, TOut> output) => output(Pipe(value, input));

        public static TOut Pipe<TIn, TMid1, TMid2, TOut>(
            TIn value,
            Func<TIn, TMid1> input,
            Func<TMid1, TMid2> mid,
            Func<TMid2, TOut> output) => output(Pipe(value, input, mid));

        public static TOut Pipe<TIn, TMid1, TMid2, TMid3, TOut>(
            TIn value,
            Func<TIn, TMid1> input,
            Func<TMid1, TMid2> mid1,
            Func<TMid2, TMid3> mid2,
            Func<TMid3, TOut> output) => output(Pipe(value, input, mid1, mid2));

        public static TOut Pipe<TIn, TMid1, TMid2, TMid3, TMid4, TOut>(
            TIn value,
            Func<TIn, TMid1> input,
            Func<TMid1, TMid2> mid1,
            Func<TMid2, TMid3> mid2,
            Func<TMid3, TMid4> mid3,
            Func<TMid4, TOut> output) => output(Pipe(value, input, mid1, mid2, mid3));

        public static TOut Pipe<TIn, TMid1, TMid2, TMid3, TMid4, TMid5, TOut>(
            TIn value,
            Func<TIn, TMid1> input,
            Func<TMid1, TMid2> mid1,
            Func<TMid2, TMid3> mid2,
            Func<TMid3, TMid4> mid3,
            Func<TMid4, TMid5> mid4,
            Func<TMid5, TOut> output) => output(Pipe(value, input, mid1, mid2, mid3, mid4));

        public static TOut Pipe<TIn, TMid1, TMid2, TMid3, TMid4, TMid5, TMid6, TOut>(
            TIn value,
            Func<TIn, TMid1> input,
            Func<TMid1, TMid2> mid1,
            Func<TMid2, TMid3> mid2,
            Func<TMid3, TMid4> mid3,
            Func<TMid4, TMid5> mid4,
            Func<TMid5, TMid6> mid5,
            Func<TMid6, TOut> output) => output(Pipe(value, input, mid1, mid2, mid3, mid4, mid5));

        public static TOut Pipe<TIn, TMid1, TMid2, TMid3, TMid4, TMid5, TMid6, TMid7, TOut>(
            TIn value,
            Func<TIn, TMid1> input,
            Func<TMid1, TMid2> mid1,
            Func<TMid2, TMid3> mid2,
            Func<TMid3, TMid4> mid3,
            Func<TMid4, TMid5> mid4,
            Func<TMid5, TMid6> mid5,
            Func<TMid6, TMid7> mid6,
            Func<TMid7, TOut> output) => output(Pipe(value, input, mid1, mid2, mid3, mid4, mid5, mid6));

        public static TOut Pipe<TIn, TMid1, TMid2, TMid3, TMid4, TMid5, TMid6, TMid7, TMid8, TOut>(
            TIn value,
            Func<TIn, TMid1> input,
            Func<TMid1, TMid2> mid1,
            Func<TMid2, TMid3> mid2,
            Func<TMid3, TMid4> mid3,
            Func<TMid4, TMid5> mid4,
            Func<TMid5, TMid6> mid5,
            Func<TMid6, TMid7> mid6,
            Func<TMid7, TMid8> mid7,
            Func<TMid8, TOut> output) => output(Pipe(value, input, mid1, mid2, mid3, mid4, mid5, mid6, mid7));

        public static TOut Pipe<TIn, TMid1, TMid2, TMid3, TMid4, TMid5, TMid6, TMid7, TMid8, TMid9, TOut>(
            TIn value,
            Func<TIn, TMid1> input,
            Func<TMid1, TMid2> mid1,
            Func<TMid2, TMid3> mid2,
            Func<TMid3, TMid4> mid3,
            Func<TMid4, TMid5> mid4,
            Func<TMid5, TMid6> mid5,
            Func<TMid6, TMid7> mid6,
            Func<TMid7, TMid8> mid7,
            Func<TMid8, TMid9> mid8,
            Func<TMid9, TOut> output) => output(Pipe(value, input, mid1, mid2, mid3, mid4, mid5, mid6, mid7, mid8));

        public static TOut Pipe<TIn, TMid1, TMid2, TMid3, TMid4, TMid5, TMid6, TMid7, TMid8, TMid9, TMid10, TOut>(
            TIn value,
            Func<TIn, TMid1> input,
            Func<TMid1, TMid2> mid1,
            Func<TMid2, TMid3> mid2,
            Func<TMid3, TMid4> mid3,
            Func<TMid4, TMid5> mid4,
            Func<TMid5, TMid6> mid5,
            Func<TMid6, TMid7> mid6,
            Func<TMid7, TMid8> mid7,
            Func<TMid8, TMid9> mid8,
            Func<TMid9, TMid10> mid9,
            Func<TMid10, TOut> output) => output(Pipe(value, input, mid1, mid2, mid3, mid4, mid5, mid6, mid7, mid8, mid9));

        public static TOut Pipe<TIn, TMid1, TMid2, TMid3, TMid4, TMid5, TMid6, TMid7, TMid8, TMid9, TMid10, TMid11, TOut>(
            TIn value,
            Func<TIn, TMid1> input,
            Func<TMid1, TMid2> mid1,
            Func<TMid2, TMid3> mid2,
            Func<TMid3, TMid4> mid3,
            Func<TMid4, TMid5> mid4,
            Func<TMid5, TMid6> mid5,
            Func<TMid6, TMid7> mid6,
            Func<TMid7, TMid8> mid7,
            Func<TMid8, TMid9> mid8,
            Func<TMid9, TMid10> mid9,
            Func<TMid10, TMid11> mid10,
            Func<TMid11, TOut> output) => output(Pipe(value, input, mid1, mid2, mid3, mid4, mid5, mid6, mid7, mid8, mid9, mid10));

        public static TOut Pipe<TIn, TMid1, TMid2, TMid3, TMid4, TMid5, TMid6, TMid7, TMid8, TMid9, TMid10, TMid11, TMid12, TOut>(
            TIn value,
            Func<TIn, TMid1> input,
            Func<TMid1, TMid2> mid1,
            Func<TMid2, TMid3> mid2,
            Func<TMid3, TMid4> mid3,
            Func<TMid4, TMid5> mid4,
            Func<TMid5, TMid6> mid5,
            Func<TMid6, TMid7> mid6,
            Func<TMid7, TMid8> mid7,
            Func<TMid8, TMid9> mid8,
            Func<TMid9, TMid10> mid9,
            Func<TMid10, TMid11> mid10,
            Func<TMid11, TMid12> mid11,
            Func<TMid12, TOut> output) => output(Pipe(value, input, mid1, mid2, mid3, mid4, mid5, mid6, mid7, mid8, mid9, mid10, mid11));

        public static TOut Pipe<TIn, TMid1, TMid2, TMid3, TMid4, TMid5, TMid6, TMid7, TMid8, TMid9, TMid10, TMid11, TMid12, TMid13, TOut>(
            TIn value,
            Func<TIn, TMid1> input,
            Func<TMid1, TMid2> mid1,
            Func<TMid2, TMid3> mid2,
            Func<TMid3, TMid4> mid3,
            Func<TMid4, TMid5> mid4,
            Func<TMid5, TMid6> mid5,
            Func<TMid6, TMid7> mid6,
            Func<TMid7, TMid8> mid7,
            Func<TMid8, TMid9> mid8,
            Func<TMid9, TMid10> mid9,
            Func<TMid10, TMid11> mid10,
            Func<TMid11, TMid12> mid11,
            Func<TMid12, TMid13> mid12,
            Func<TMid13, TOut> output) => output(Pipe(value, input, mid1, mid2, mid3, mid4, mid5, mid6, mid7, mid8, mid9, mid10, mid11, mid12));

        public static TOut Pipe<TIn, TMid1, TMid2, TMid3, TMid4, TMid5, TMid6, TMid7, TMid8, TMid9, TMid10, TMid11, TMid12, TMid13, TMid14, TOut>(
            TIn value,
            Func<TIn, TMid1> input,
            Func<TMid1, TMid2> mid1,
            Func<TMid2, TMid3> mid2,
            Func<TMid3, TMid4> mid3,
            Func<TMid4, TMid5> mid4,
            Func<TMid5, TMid6> mid5,
            Func<TMid6, TMid7> mid6,
            Func<TMid7, TMid8> mid7,
            Func<TMid8, TMid9> mid8,
            Func<TMid9, TMid10> mid9,
            Func<TMid10, TMid11> mid10,
            Func<TMid11, TMid12> mid11,
            Func<TMid12, TMid13> mid12,
            Func<TMid13, TMid14> mid13,
            Func<TMid14, TOut> output) => output(Pipe(value, input, mid1, mid2, mid3, mid4, mid5, mid6, mid7, mid8, mid9, mid10, mid11, mid12, mid13));

        public static TOut Pipe<TIn, TMid1, TMid2, TMid3, TMid4, TMid5, TMid6, TMid7, TMid8, TMid9, TMid10, TMid11, TMid12, TMid13, TMid14, TMid15, TOut>(
            TIn value,
            Func<TIn, TMid1> input,
            Func<TMid1, TMid2> mid1,
            Func<TMid2, TMid3> mid2,
            Func<TMid3, TMid4> mid3,
            Func<TMid4, TMid5> mid4,
            Func<TMid5, TMid6> mid5,
            Func<TMid6, TMid7> mid6,
            Func<TMid7, TMid8> mid7,
            Func<TMid8, TMid9> mid8,
            Func<TMid9, TMid10> mid9,
            Func<TMid10, TMid11> mid10,
            Func<TMid11, TMid12> mid11,
            Func<TMid12, TMid13> mid12,
            Func<TMid13, TMid14> mid13,
            Func<TMid14, TMid15> mid14,
            Func<TMid15, TOut> output) => output(Pipe(value, input, mid1, mid2, mid3, mid4, mid5, mid6, mid7, mid8, mid9, mid10, mid11, mid12, mid13, mid14));
    }
}
