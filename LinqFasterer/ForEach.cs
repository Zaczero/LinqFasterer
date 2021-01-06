using System;
using System.Collections.Generic;

namespace LinqFasterer
{
    public static partial class EnumerableF
    {
        /// <summary>
        /// Performs the specified action on each element of the specified sequence.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> on whose elements the action is to be performed.</param>
        /// <param name="action">An <see cref="Action{T}"/> to perform on each element of <paramref name="source"/>.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <returns>The input <paramref name="source"/> sequence.</returns>
        public static IList<TSource> ForEachF<TSource>(this IList<TSource> source, Action<TSource> action)
        {
            var sourceArray = source.ToArrayF();
            var sourceLength = sourceArray.Length;

            for (var i = 0; i < sourceLength; i++)
                action(sourceArray[i]);

            return sourceArray;
        }
    }
}
