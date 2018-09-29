using System;
using System.Collections.Generic;
using System.Text;

namespace Functional
{
    public static partial class String
    {
        public static string SkipLastLetter(string x) => Substring(x, 0, x.Length - 1);
    }
}
