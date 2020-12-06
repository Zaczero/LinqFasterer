using System;
using System.Collections.Generic;

namespace LinqFasterer
{
    public static partial class EnumerableF
    {
        /// <summary>
        /// Returns a number that represents how many elements in the specified sequence satisfy a condition.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> that contains elements to be tested and counted.</param>
        /// <param name="predicate">An optional predicate function to test each element for a condition; when set to <see langword="null"/>, the function returns the current size of <paramref name="source"/>.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <returns>A number that represents how many elements in <paramref name="source"/> satisfy the condition specified by <paramref name="predicate"/>.</returns>
        public static int CountF<TSource>(this IList<TSource> source, Func<TSource, bool>? predicate = null)
        {
            var sourceLength = source.Count;

            if (predicate == null)
                return sourceLength;

            var sourceArray = source.ToArrayF();
            var count = 0;

            for (var i = 0; i < sourceLength; i++)
                if (predicate(sourceArray[i]))
                    count++;

            return count;
        }
    }
}
