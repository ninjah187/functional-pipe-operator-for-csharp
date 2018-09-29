using System;
using System.Collections.Generic;
using System.Text;

namespace Functional
{
    public static partial class String
    {
        public static string Replace(string x, string oldValue, string newValue) => x.Replace(oldValue, newValue);
    }
}
