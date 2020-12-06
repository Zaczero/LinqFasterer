using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace LinqFasterer
{
    public static partial class EnumerableF
    {
        /// <summary>
        /// Returns the element at a specified index in a sequence.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> to return an element from.</param>
        /// <param name="index">The zero-based index of the element to retrieve.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <returns>The element at <paramref name="index"/> in <paramref name="source"/>.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TSource ElementAtF<TSource>(this IList<TSource> source, int index)
        {
            return source[index];
        }

        /// <summary>
        /// Returns the element at a specified index in a sequence or a default value if the index is out of range.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> to return an element from.</param>
        /// <param name="index">The zero-based index of the element to retrieve.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <returns><see langword="default"/> if the index is outside the bounds of <paramref name="source"/>; otherwise, the element at <paramref name="index"/> in <paramref name="source"/>.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TSource ElementAtOrDefaultF<TSource>(this IList<TSource> source, int index)
        {
            if (index < 0 || index >= source.Count)
                return default!;

            return source[index];
        }
    }
}