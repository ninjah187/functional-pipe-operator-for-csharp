using System;
using System.Collections.Generic;
using System.Text;

namespace Functional
{
    public static partial class String
    {
        public static string Double(string x, string separator) => $"{x}{separator}{x}";
        public static string Double(string x) => Double(x, " ");
    }
}
