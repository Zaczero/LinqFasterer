using System;
using System.Collections.Generic;
using LinqFasterer.Utils;

namespace LinqFasterer
{
    public static partial class EnumerableF
    {
        /// <summary>
        /// Returns the last element in a sequence that satisfies a specified condition.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> to return an element from.</param>
        /// <param name="predicate">An optional predicate function to test each element for a condition; when set to <see langword="null"/> the function returns the last element in <paramref name="source"/>.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <returns>The last element in <paramref name="source"/> that passes the test specified by <paramref name="predicate"/>.</returns>
        public static TSource LastF<TSource>(this IList<TSource> source, Func<TSource, bool>? predicate = null)
        {
            if (predicate == null)
                // ReSharper disable once UseIndexFromEndExpression
                return source[source.Count - 1];

            var sourceArray = source.ToArrayF();
            var sourceLength = sourceArray.Length;

            for (var i = sourceLength - 1; i >= 0; i--)
            {
                var value = sourceArray[i];

                if (predicate(value))
                    return value;
            }

            throw Error.NoMatch();
        }

        /// <summary>
        /// Returns the last element of a sequence, or a default value if the sequence contains no elements.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> to return an element from.</param>
        /// <param name="predicate">An optional predicate function to test each element for a condition; when set to <see langword="null"/> the function returns the last element in <paramref name="source"/> or <see langword="default"/> when <paramref name="source"/> is empty.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <returns><see langword="default" /> if <paramref name="source" /> is empty or if no element passes the test specified by <paramref name="predicate" />; otherwise, the last element in <paramref name="source" /> that passes the test specified by <paramref name="predicate" />.</returns>
        public static TSource? LastOrDefaultF<TSource>(this IList<TSource> source, Func<TSource, bool>? predicate = null)
        {
            if (predicate == null)
                // ReSharper disable once UseIndexFromEndExpression
                return source.Count == 0 ? default : source[source.Count - 1];

            var sourceArray = source.ToArrayF();
            var sourceLength = sourceArray.Length;

            for (var i = sourceLength - 1; i >= 0; i--)
            {
                var value = sourceArray[i];

                if (predicate(value))
                    return value;
            }

            return default;
        }
    }
}
