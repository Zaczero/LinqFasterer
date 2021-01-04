using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace LinqFasterer
{
    public static partial class EnumerableF
    {
        /// <summary>
        /// Sets elements in a sequence to the default value of each element type.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> whose elements need to be cleared.</param>
        /// <param name="forceClone">Force clone of <paramref name="source"/> (disable in-place optimization).</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <returns>An <see cref="IList{T}"/> with elements set to <see langword="default"/>.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IList<TSource> ClearF<TSource>(this IList<TSource> source, bool forceClone = false)
        {
            return source.ClearF(0, int.MaxValue, forceClone);
        }
        
        /// <summary>
        /// Sets elements in a sequence to the default value of each element type.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> whose elements need to be cleared.</param>
        /// <param name="index">The starting index of the range to clear.</param>
        /// <param name="length">The length of the range to clear.</param>
        /// <param name="forceClone">Force clone of <paramref name="source"/> (disable in-place optimization).</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <returns>An <see cref="IList{T}"/> with elements set to <see langword="default"/>.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IList<TSource> ClearF<TSource>(this IList<TSource> source, int index, int length, bool forceClone = false)
        {
            return source.FillF(default!, index, length, forceClone);
        }
    }
}