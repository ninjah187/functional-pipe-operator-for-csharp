using System;
using System.Collections.Generic;
using System.Text;

namespace Functional
{
    public static partial class String
    {
        public static string FirstLetterToUpper(string x) => $"{x.Substring(0, 1).ToUpper()}{x.Substring(1, x.Length - 1)}";
    }
}
