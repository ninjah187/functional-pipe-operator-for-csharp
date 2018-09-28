using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Functional.Pipeline.CodeGeneration
{
    public class Utils
    {
        public static string Sequence(int count, Func<int, string> value, string separator = " ")
        {
            var values = Enumerable.Range(1, count).Select(index => value(index));
            return string.Join(separator, values);
        }
    }
}
