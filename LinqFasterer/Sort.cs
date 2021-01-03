using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace LinqFasterer
{
    public static partial class EnumerableF
    {
        /// <summary>
        /// Sorts the elements of a sequence in ascending order by using a specified comparer.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> of values to order.</param>
        /// <param name="comparer">An optional <see cref="IComparer{T}"/> used to compare elements; falls back to <see cref="Comparer{T}.Default"/> when set to <see langword="null"/>.</param>
        /// <param name="forceClone">Force clone of <paramref name="source"/> (disable in-place optimization).</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <returns>An <see cref="IList{T}"/> whose elements are sorted in ascending order.</returns>
        public static IList<TSource> SortF<TSource>(this IList<TSource> source, IComparer<TSource>? comparer = null, bool forceClone = false)
        {
            comparer ??= Comparer<TSource>.Default;

            var sourceArray = source.ToArrayF(forceClone);

            Array.Sort(sourceArray, comparer);

            return sourceArray;
        }
        
        /// <summary>
        /// Sorts the elements of a sequence in descending order by using a specified comparer.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> of values to order.</param>
        /// <param name="comparer">An optional <see cref="IComparer{T}"/> used to compare elements; falls back to <see cref="Comparer{T}.Default"/> when set to <see langword="null"/>.</param>
        /// <param name="forceClone">Force clone of <paramref name="source"/> (disable in-place optimization).</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <returns>An <see cref="IList{T}"/> whose elements are sorted in descending order.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IList<TSource> SortDescendingF<TSource>(this IList<TSource> source, IComparer<TSource>? comparer = null, bool forceClone = false)
        {
            return source.SortF(comparer, forceClone).ReverseF();
        }
    }
}