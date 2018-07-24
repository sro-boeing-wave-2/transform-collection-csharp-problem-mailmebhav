using System;
using System.Linq;
using System.Collections.Generic;

namespace Transform
{
    public static class Transform 
    {
        public static IEnumerable<TResult> Map<TSource, TResult>(this IEnumerable<TSource> x, Func<TSource, TResult> transform)
        {
            return x.Select(transform);
        }
    }
}
