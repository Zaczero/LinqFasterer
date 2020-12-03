using System.Collections.Generic;

namespace LinqFasterer
{
    public static partial class EnumerableF
    {
        /// <summary>Creates an array from a sequence.</summary>
        /// <returns>An array that contains the elements from the input sequence.</returns>
        /// <param name="source">A sequence to create an array from.</param>
        /// <param name="forceClone">Force clone of an object (disable in-place optimization).</param>
        public static TSource[] ToArrayF<TSource>(this IList<TSource> source, bool forceClone = false)
        {
            if (!forceClone && source is TSource[] sourceArray)
                return sourceArray;

            var result = new TSource[source.Count];

            source.CopyTo(result, 0);

            return result;
        }

        /// <summary>Creates a list from a sequence.</summary>
        /// <returns>A sequence that contains elements from the input sequence.</returns>
        /// <param name="source">A sequence to create a list from.</param>
        /// <param name="forceClone">Force clone of an object (disable in-place optimization).</param>
        public static List<TSource> ToListF<TSource>(this IList<TSource> source, bool forceClone = false)
        {
            if (!forceClone && source is List<TSource> sourceList)
                return sourceList;

            var result = new List<TSource>(source.Count);

            result.AddRange(source);

            return result;
        }
    }
}