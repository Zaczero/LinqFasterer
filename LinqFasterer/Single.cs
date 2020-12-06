using System;
using System.Collections.Generic;
using LinqFasterer.Utils;

namespace LinqFasterer
{
    public static partial class EnumerableF
    {
        /// <summary>
        /// Returns the only element of a sequence, and throws an exception if there is not exactly one element in the sequence.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> to return the single element of.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <returns>The single element of <paramref name="source"/>.</returns>
        public static TSource SingleF<TSource>(this IList<TSource> source)
        {
            var sourceLength = source.Count;
            if (sourceLength == 0)
                throw Error.NoElements();

            if (sourceLength > 1)
                throw Error.MoreThanOneElement();

            return source[0];
        }

        /// <summary>
        /// Returns the only element of a sequence that satisfies a specified condition, and throws an exception if more than one such element exists.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> to return a single element from.</param>
        /// <param name="predicate">A predicate function to test an element for a condition.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <returns>The single element of <paramref name="source"/> that satisfies a condition.</returns>
        public static TSource SingleF<TSource>(this IList<TSource> source, Func<TSource, bool> predicate)
        {
            var sourceLength = source.Count;
            if (sourceLength == 0)
                throw Error.NoElements();

            var sourceArray = source.ToArrayF();
            var foundAtIndex = -1;

            for (var i = 0; i < sourceLength; i++)
                if (predicate(sourceArray[i]))
                    if (foundAtIndex == -1)
                        foundAtIndex = i;
                    else
                        throw Error.MoreThanOneElement();

            if (foundAtIndex == -1)
                throw Error.NoElements();

            return sourceArray[foundAtIndex];
        }

        /// <summary>
        /// Returns the only element of a sequence, or a default value if the sequence is empty; this method throws an exception if there is more than one element in the sequence.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> to return the single element of.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <returns>The single element of <paramref name="source"/>, or <see langword="default"/> if <paramref name="source"/> contains no elements.</returns>
        public static TSource SingleOrDefaultF<TSource>(this IList<TSource> source)
        {
            var sourceLength = source.Count;
            if (sourceLength == 0)
                return default!;

            if (sourceLength > 1)
                throw Error.MoreThanOneElement();

            return source[0];
        }

        /// <summary>
        /// Returns the only element of a sequence that satisfies a specified condition or a default value if no such element exists; this method throws an exception if more than one element satisfies the condition.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> to return a single element from.</param>
        /// <param name="predicate">A predicate function to test an element for a condition.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <returns>The single element of <paramref name="source"/> that satisfies the condition, or <see langword="default"/> if no such element is found.</returns>
        public static TSource SingleOrDefaultF<TSource>(this IList<TSource> source, Func<TSource, bool> predicate)
        {
            var sourceLength = source.Count;
            if (sourceLength == 0)
                return default!;

            var sourceArray = source.ToArrayF();
            var foundAtIndex = -1;

            for (var i = 0; i < sourceLength; i++)
                if (predicate(sourceArray[i]))
                    if (foundAtIndex == -1)
                        foundAtIndex = i;
                    else
                        throw Error.MoreThanOneElement();

            if (foundAtIndex == -1)
                return default!;

            return source[foundAtIndex];
        }
    }
}