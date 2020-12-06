using System;
using System.Collections.Generic;

namespace LinqFasterer
{
    public static partial class EnumerableF
    {
        /// <summary>
        /// Inverts the order of the elements in a sequence.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> of values to reverse.</param>
        /// <param name="forceClone">Force clone of <paramref name="source"/> (disable in-place optimization).</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <returns>An <see cref="IList{T}"/> whose elements correspond to those of <paramref name="source"/> in reverse order.</returns>
        public static IList<TSource> ReverseF<TSource>(this IList<TSource> source, bool forceClone = false)
        {
            var sourceArray = source.ToArrayF(forceClone);

            Array.Reverse(sourceArray);

            return sourceArray;
        }
    }
}