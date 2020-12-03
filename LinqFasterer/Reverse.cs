using System;
using System.Collections.Generic;

namespace LinqFasterer
{
    public static partial class LinqFasterer
    {
        /// <summary>Inverts the order of the elements in a sequence.</summary>
        /// <returns>A sequence whose elements correspond to those of the input sequence in reverse order.</returns>
        /// <param name="source">A sequence of values to reverse.</param>
        /// <param name="forceClone">Force clone of an object (disable in-place optimization).</param>
        public static IList<TSource> ReverseF<TSource>(this IList<TSource> source, bool forceClone = false)
        {
            var sourceArray = source.ToArrayF(forceClone);

            Array.Reverse(sourceArray);

            return sourceArray;
        }
    }
}