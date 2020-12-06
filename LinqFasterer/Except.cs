using System;
using System.Collections.Generic;

namespace LinqFasterer
{
    public static partial class EnumerableF
    {
        // TODO: benchmark

        /// <summary>
        /// Produces the set difference of two sequences by using the specified equality comparer to compare values.
        /// </summary>
        /// <param name="first">An <see cref="IList{T}"/> whose elements that are not also in <paramref name="second"/> will be returned.</param>
        /// <param name="second">An <see cref="IList{T}"/> whose elements that also occur in <paramref name="first"/> will cause those elements to be removed from the returned sequence.</param>
        /// <param name="comparer">An optional <see cref="IEqualityComparer{T}"/> used to compare values; falls back to <see cref="EqualityComparer{T}.Default"/> when set to <see langword="null"/>.</param>
        /// <param name="forceClone">Force clone of <paramref name="first"/> (disable in-place optimization).</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="first"/> and <paramref name="second"/>.</typeparam>
        /// <returns>An <see cref="IList{T}"/> that contains the set difference of the elements of the two input sequences.</returns>
        public static IList<TSource> ExceptF<TSource>(this IList<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource>? comparer = null, bool forceClone = false)
        {
            var firstArray = first.ToArrayF(forceClone);
            var firstLength = firstArray.Length;

            comparer ??= EqualityComparer<TSource>.Default;

            var secondHashSet = new HashSet<TSource>(second, comparer);
            var resultSize = 0;

            for (var i = 0; i < firstLength; i++)
            {
                var value = firstArray[i];

                if (!secondHashSet.Contains(value))
                    firstArray[resultSize++] = value;
            }

            Array.Resize(ref firstArray, resultSize);

            return firstArray;
        }
    }
}