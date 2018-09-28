using System;
using System.Collections.Generic;
using System.Text;

namespace Functional
{
    public static partial class String
    {
        public static string Triple(string x, string separator) => $"{Double(x, separator)}{separator}{x}";
        public static string Triple(string x) => Triple(x, " ");
    }
}
