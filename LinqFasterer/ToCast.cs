using System.Collections.Generic;

namespace LinqFasterer
{
    public static partial class EnumerableF
    {
        /// <summary>
        /// Creates a <see cref="System.Array"/> from an <see cref="IList{T}"/>.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> to create a <see cref="System.Array"/> from.</param>
        /// <param name="forceClone">Force clone of <paramref name="source"/> (disable in-place optimization).</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <returns>A <see cref="System.Array"/> that contains the elements from <paramref name="source"/>.</returns>
        public static TSource[] ToArrayF<TSource>(this IList<TSource> source, bool forceClone = false)
        {
            if (!forceClone && source is TSource[] sourceArray)
                return sourceArray;

            var result = new TSource[source.Count];

            source.CopyTo(result, 0);

            return result;
        }

        /// <summary>
        /// Creates a <see cref="List{T}"/> from an <see cref="IList{T}"/>.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> to create a <see cref="List{T}"/> from.</param>
        /// <param name="forceClone">Force clone of <paramref name="source"/> (disable in-place optimization).</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <returns>A <see cref="List{T}"/> that contains elements from <paramref name="source"/>.</returns>
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