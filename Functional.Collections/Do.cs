using System;
using System.Collections.Generic;

namespace Functional
{
    public static partial class Collections
    {
        public static IEnumerable<TItem> Do<TItem>(IEnumerable<TItem> items, Action<TItem> action)
        {
            foreach (var item in items)
            {
                action(item);
            }
            return items;
        }
    }
}
