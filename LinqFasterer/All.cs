using System;
using System.Collections.Generic;

namespace LinqFasterer
{
    public static partial class EnumerableF
    {
        /// <summary>
        /// Determines whether all elements of a sequence satisfy a condition.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> that contains the elements to apply the predicate to.</param>
        /// <param name="predicate">A predicate function to test each element for a condition.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <returns><see langword="true"/> if every element of <paramref name="source"/> passes the test in the specified <paramref name="predicate"/>, or if <paramref name="source"/> is empty; otherwise, <see langword="false"/>.</returns>
        public static bool AllF<TSource>(this IList<TSource> source, Predicate<TSource> predicate)
        {
            var sourceArray = source.ToArrayF();
            var sourceLength = sourceArray.Length;

            for (var i = 0; i < sourceLength; i++)
                if (!predicate(sourceArray[i]))
                    return false;

            return true;
        }
    }
}