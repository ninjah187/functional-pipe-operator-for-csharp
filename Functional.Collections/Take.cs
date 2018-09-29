using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Functional
{
    public static partial class Collections
    {
        public static IEnumerable<TItem> Take<TItem>(IEnumerable<TItem> items, int count) => items.Take(count);
    }
}
