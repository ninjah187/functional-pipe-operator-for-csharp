using System;
using System.Collections.Generic;
using System.Text;

namespace Functional
{
    public static partial class String
    {
        public static string Join(IEnumerable<string> value, string separator) => string.Join(separator, value);
        public static string Join(IEnumerable<string> value) => Join(value, "");
    }
}
