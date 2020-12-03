using System;
using System.Collections.Generic;

namespace LinqFasterer
{
    public static partial class LinqFasterer
    {
        /// <summary>Determines whether any element of a sequence satisfies a condition.</summary>
        /// <returns>true if any elements in the source sequence pass the test in the specified predicate; otherwise, false.</returns>
        /// <param name="source">A sequence whose elements to apply the predicate to.</param>
        /// <param name="predicate">A function to test each element for a condition.</param>
        public static bool AnyF<TSource>(this IList<TSource> source, Predicate<TSource>? predicate = null)
        {
            if (predicate == null)
                return source.Count != 0;

            var sourceArray = source.ToArrayF();
            var sourceLength = sourceArray.Length;

            for (var i = 0; i < sourceLength; i++)
                if (predicate(sourceArray[i]))
                    return true;

            return false;
        }
    }
}