using System;
using System.Collections.Generic;
using System.Text;

namespace Functional
{
    public static partial class String
    {
        public static string[] Split(string x, string separator) => x.Split(new[] { separator }, StringSplitOptions.RemoveEmptyEntries);
        public static string[] Split(string x) => Split(x, " ");
    }
}
