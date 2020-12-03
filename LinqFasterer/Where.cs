using System;
using System.Collections.Generic;

namespace LinqFasterer
{
    public static partial class EnumerableF
    {
        /// <summary>Filters a sequence of values based on a predicate.</summary>
        /// <returns>A sequence that contains elements from the input sequence that satisfy the condition.</returns>
        /// <param name="source">A sequence to filter.</param>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <param name="forceClone">Force clone of an object (disable in-place optimization).</param>
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

        /// <summary>Filters a sequence of values based on a predicate. Each element's index is used in the logic of the predicate function.</summary>
        /// <returns>A sequence that contains elements from the input sequence that satisfy the condition.</returns>
        /// <param name="source">A sequence to filter.</param>
        /// <param name="predicate">A function to test each source element for a condition; the second parameter of the function represents the index of the source element.</param>
        /// <param name="forceClone">Force clone of an object (disable in-place optimization).</param>
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
