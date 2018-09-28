using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Functional
{
    public static partial class String
    {
        public static string Reverse(string x) => string.Concat(x.Reverse());
    }
}
