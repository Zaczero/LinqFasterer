using System;
using System.Collections.Generic;

namespace LinqFasterer
{
    public static partial class LinqFasterer
    {
        /// <summary>Produces the set intersection of two sequences by using the default equality comparer to compare values.</summary>
        /// <returns>A sequence that contains the elements that form the set intersection of two sequences.</returns>
        /// <param name="first">A sequence whose distinct elements that also appear in the second sequence will be returned.</param>
        /// <param name="second">A sequence whose distinct elements that also appear in the first sequence will be returned.</param>
        /// <param name="comparer">An equality comparer to compare values.</param>
        /// <param name="forceClone">Force clone of an object (disable in-place optimization).</param>
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