using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace LinqFasterer
{
    public static partial class EnumerableF
    {
        /// <summary>Returns the element at a specified index in a sequence.</summary>
        /// <returns>The element at the specified position in the source sequence.</returns>
        /// <param name="source">A sequence to return an element from.</param>
        /// <param name="index">The zero-based index of the element to retrieve.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TSource ElementAtF<TSource>(this IList<TSource> source, int index)
        {
            return source[index];
        }

        /// <summary>Returns the element at a specified index in a sequence.</summary>
        /// <returns>The element at the specified position in the source sequence.</returns>
        /// <param name="source">A sequence to return an element from.</param>
        /// <param name="index">The zero-based index of the element to retrieve.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TSource ElementAtOrDefaultF<TSource>(this IList<TSource> source, int index)
        {
            if (index < 0 || index >= source.Count)
                return default!;

            return source[index];
        }
    }
}