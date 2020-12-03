using System.Collections.Generic;

namespace LinqFasterer
{
    public static partial class EnumerableF
    {
        /// <summary>Appends a value to the end of the sequence.</summary>
        /// <returns>A new sequence that ends with element.</returns>
        /// <param name="source">A sequence of values.</param>
        /// <param name="element">The value to append to a sequence.</param>
        public static IList<TSource> AppendF<TSource>(this IList<TSource> source, TSource element)
        {
            var sourceLength = source.Count;

            var result = new TSource[sourceLength + 1];

            source.CopyTo(result, 0);
            result[sourceLength] = element;

            return result;
        }
    }
}