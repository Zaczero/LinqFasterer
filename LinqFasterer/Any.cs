using System;
using System.Collections.Generic;

namespace LinqFasterer
{
    public static partial class EnumerableF
    {
        /// <summary>
        /// Determines whether any element of a sequence satisfies a condition.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> whose elements to apply the predicate to.</param>
        /// <param name="predicate">An optional predicate function to test each element for a condition; when set to <see langword="null"/>, the function check whether <paramref name="source"/> is empty or not.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <returns><see langword="true"/> if any element of <paramref name="source"/> passes the test in the specified <paramref name="predicate"/>; otherwise, <see langword="false"/>.</returns>
        public static bool AnyF<TSource>(this IList<TSource> source, Predicate<TSource>? predicate = null)
        {
            if (predicate == null)
                return source.Count != 0;

            var sourceArray = source.ToArrayF();
            var sourceLength = sourceArray.Length;

            for (var i = 0; i < sourceLength; i++)
                if (predicate(sourceArray[i]))
                    return true;

            return false;
        }
    }
}