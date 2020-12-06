using System.Collections.Generic;

namespace LinqFasterer
{
    public static partial class EnumerableF
    {
        /// <summary>
        /// Prepends a value to the beginning of the sequence.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> of values.</param>
        /// <param name="element">A value to prepend.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <returns>An <see cref="IList{T}"/> that starts with <paramref name="element"/> and ends with <paramref name="source"/>.</returns>
        public static IList<TSource> PrependF<TSource>(this IList<TSource> source, TSource element)
        {
            var result = new TSource[source.Count + 1];

            result[0] = element;
            source.CopyTo(result, 1);

            return result;
        }
    }
}