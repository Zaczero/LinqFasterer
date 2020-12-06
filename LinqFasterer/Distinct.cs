using System;
using System.Collections.Generic;

namespace LinqFasterer
{
    public static partial class EnumerableF
    {
        /// <summary>
        /// Returns distinct elements from a sequence by using a specified equality comparer to compare values.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> to remove duplicate elements from.</param>
        /// <param name="comparer">An optional <see cref="IEqualityComparer{T}"/> used to compare values; falls back to <see cref="EqualityComparer{T}.Default"/> when set to <see langword="null"/>.</param>
        /// <param name="forceClone">Force clone of <paramref name="source"/> (disable in-place optimization).</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <returns>An <see cref="IList{T}"/> that contains distinct elements from <paramref name="source"/>.</returns>
        public static IList<TSource> DistinctF<TSource>(this IList<TSource> source, IEqualityComparer<TSource>? comparer = null, bool forceClone = false)
        {
            var sourceArray = source.ToArrayF();
            var sourceLength = sourceArray.Length;

            comparer ??= EqualityComparer<TSource>.Default;

            TSource[] result;

            // The following code runs faster on smaller workloads
            // The magic number is a result of multiple benchmark tests
            if (sourceLength < 2500)
            {
                var resultHashSet = new HashSet<TSource>(sourceArray, comparer);
                var resultSize = resultHashSet.Count;

                result = new TSource[resultSize];
                resultHashSet.CopyTo(result, 0, resultSize);
            }
            else
            {
                var resultHashSet = new HashSet<TSource>(comparer);
                var resultSize = 0;

                result = forceClone ? new TSource[sourceLength] : sourceArray;

                for (var i = 0; i < sourceLength; i++)
                {
                    var value = sourceArray[i];

                    if (!resultHashSet.Contains(value))
                    {
                        resultHashSet.Add(value);
                        result[resultSize++] = value;
                    }
                }

                Array.Resize(ref result, resultSize);
            }

            return result;
        }
    }
}