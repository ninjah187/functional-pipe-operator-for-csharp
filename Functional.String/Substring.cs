using System;
using System.Collections.Generic;
using System.Text;

namespace Functional
{
    public static partial class String
    {
        public static string Substring(string x, int startIndex, int length) => x.Substring(startIndex, length);
        public static string Substring(string x, int startIndex) => x.Substring(startIndex);
    }
}
