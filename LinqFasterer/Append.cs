using System.Collections.Generic;

namespace LinqFasterer
{
    public static partial class EnumerableF
    {
        /// <summary>
        /// Appends a value to the end of the sequence.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> of values.</param>
        /// <param name="element">A value to append.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <returns>An <see cref="IList{T}"/> that starts with <paramref name="source"/> and ends with <paramref name="element"/>.</returns>
        public static IList<TSource> AppendF<TSource>(this IList<TSource> source, TSource element)
        {
            var sourceLength = source.Count;

            // TODO: benchmark with Array.Resize()
            var result = new TSource[sourceLength + 1];

            source.CopyTo(result, 0);
            result[sourceLength] = element;

            return result;
        }
    }
}