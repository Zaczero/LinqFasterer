using System;
using System.Collections.Generic;

namespace LinqFasterer
{
    public static partial class LinqFasterer
    {
        /// <summary>Determines whether all elements of a sequence satisfy a condition.</summary>
        /// <returns>true if every element of the source sequence passes the test in the specified predicate, or if the sequence is empty; otherwise, false.</returns>
        /// <param name="source">An array that contains the elements to apply the predicate to.</param>
        /// <param name="predicate">A function to test each element for a condition.</param>
        public static bool AllF<TSource>(this IList<TSource> source, Predicate<TSource> predicate)
        {
            var sourceArray = source.ToArrayF();
            var sourceLength = sourceArray.Length;

            for (var i = 0; i < sourceLength; i++)
                if (!predicate(sourceArray[i]))
                    return false;

            return true;
        }
    }
}