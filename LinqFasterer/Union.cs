using System;
using System.Collections.Generic;

namespace LinqFasterer
{
    public static partial class EnumerableF
    {
        /// <summary>
        /// Produces the set union of two sequences.
        /// </summary>
        /// <param name="first">An <see cref="IList{T}"/> whose distinct elements form the first set for the union.</param>
        /// <param name="second">An <see cref="IList{T}"/> whose distinct elements form the second set for the union.</param>
        /// <param name="comparer">An optional <see cref="IEqualityComparer{T}"/> used to compare values; falls back to <see cref="EqualityComparer{T}.Default"/> when set to <see langword="null"/>.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="first"/> and <paramref name="second"/>.</typeparam>
        /// <returns>An <see cref="IList{T}"/> that contains the elements from both input sequences, excluding duplicates.</returns>
        public static IList<TSource> UnionF<TSource>(this IList<TSource> first, IList<TSource> second, IEqualityComparer<TSource>? comparer = null)
        {
            comparer ??= EqualityComparer<TSource>.Default;
            
            var firstLength = first.Count;
            var secondLength = second.Count;

            var resultLength = firstLength + secondLength;
            var result = new TSource[resultLength];
            int resultSize;

            first.CopyTo(result, 0);
            second.CopyTo(result, firstLength);

            // The following code runs faster on smaller workloads.
            // The magic number is a result of multiple benchmark tests.
            if (resultLength < 2500)
            {
                var resultHashSet = new HashSet<TSource>(result, comparer);
                resultSize = resultHashSet.Count;

                resultHashSet.CopyTo(result, 0, resultSize);
            }
            else
            {
                var resultHashSet = new HashSet<TSource>(comparer);
                resultSize = 0;

                for (var i = 0; i < resultLength; i++)
                {
                    var value = result[i];

                    if (!resultHashSet.Contains(value))
                    {
                        result[resultSize++] = value;
                        resultHashSet.Add(value);
                    }
                }
            }

            Array.Resize(ref result, resultSize);

            return result;
        }
    }
}