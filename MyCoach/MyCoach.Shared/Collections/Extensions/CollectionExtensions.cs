using System;
using System.Collections.Generic;

namespace MyCoach.Shared.Collections.Extensions
{
    public static class CollectionExtensions
    {
        public static void AddRange<T>(this ICollection<T> collection, params T[] items)
        {
            if (collection == null) throw new ArgumentNullException("collection");

            foreach (var item in items)
            {
                collection.Add(item);
            }
        }
    }
}
