using System;
using System.Collections.Generic;

namespace LinqFasterer
{
    public static partial class EnumerableF
    {
        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> to filter.</param>
        /// <param name="predicate">A predicate function to test each element for a condition.</param>
        /// <param name="forceClone">Force clone of <paramref name="source"/> (disable in-place optimization).</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <returns>An <see cref="IList{T}"/> that contains elements from <paramref name="source"/> that satisfy the condition.</returns>
        public static IList<TSource> WhereF<TSource>(this IList<TSource> source, Func<TSource, bool> predicate, bool forceClone = false)
        {
            var sourceArray = source.ToArrayF(forceClone);
            var sourceLength = sourceArray.Length;
            var resultSize = 0;

            for (var i = 0; i < sourceLength; i++)
            {
                var value = sourceArray[i];

                if (predicate(value))
                    sourceArray[resultSize++] = value;
            }

            Array.Resize(ref sourceArray, resultSize);

            return sourceArray;
        }

        /// <summary>
        /// Filters a sequence of values based on a predicate.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> to filter.</param>
        /// <param name="predicate">A predicate function to test each source element for a condition; the second parameter of the function represents the index of <paramref name="source"/> element.</param>
        /// <param name="forceClone">Force clone of <paramref name="source"/> (disable in-place optimization).</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <returns>An <see cref="IList{T}"/> that contains elements from <paramref name="source"/> that satisfy the condition.</returns>
        public static IList<TSource> WhereF<TSource>(this IList<TSource> source, Func<TSource, int, bool> predicate, bool forceClone = false)
        {
            var sourceArray = source.ToArrayF(forceClone);
            var sourceLength = sourceArray.Length;
            var resultSize = 0;

            for (var i = 0; i < sourceLength; i++)
            {
                var value = sourceArray[i];

                if (predicate(value, i))
                    sourceArray[resultSize++] = value;
            }

            Array.Resize(ref sourceArray, resultSize);

            return sourceArray;
        }
    }
}
