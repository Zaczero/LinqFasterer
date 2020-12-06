using System;
using System.Collections.Generic;

namespace LinqFasterer
{
    public static partial class EnumerableF
    {
        /// <summary>
        /// Produces the set intersection of two sequences.
        /// </summary>
        /// <param name="first">An <see cref="IList{T}"/> whose distinct elements that also appear in <paramref name="second"/> will be returned.</param>
        /// <param name="second">An <see cref="IList{T}"/> whose distinct elements that also appear in <paramref name="first"/> will be returned.</param>
        /// <param name="comparer">An optional <see cref="IEqualityComparer{T}"/> used to compare values; falls back to <see cref="EqualityComparer{T}.Default"/> when set to <see langword="null"/>.</param>
        /// <param name="forceClone">Force clone of <paramref name="first"/> (disable in-place optimization).</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="first"/> and <paramref name="second"/>.</typeparam>
        /// <returns>An <see cref="IList{T}"/> that contains the elements that form the set intersection of the two input sequences.</returns>
        public static IList<TSource> IntersectF<TSource>(this IList<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource>? comparer = null, bool forceClone = false)
        {
            comparer ??= EqualityComparer<TSource>.Default;

            var secondHashSet = new HashSet<TSource>(second, comparer);
            var resultHashSet = new HashSet<TSource>(comparer);
            var resultSize = 0;

            var firstArray = first.ToArrayF(forceClone);
            var firstLength = firstArray.Length;

            for (var i = 0; i < firstLength; i++)
            {
                var value = firstArray[i];

                if (secondHashSet.Contains(value) && !resultHashSet.Contains(value))
                {
                    firstArray[resultSize++] = value;
                    resultHashSet.Add(value);
                }
            }

            Array.Resize(ref firstArray, resultSize);

            return firstArray;
        }
    }
}