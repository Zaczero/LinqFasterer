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
        public static IList<TSource> OrderF<TSource>(this IList<TSource> source, IComparer<TSource>? comparer = null, bool forceClone = false)
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
        public static IList<TSource> OrderDescendingF<TSource>(this IList<TSource> source, IComparer<TSource>? comparer = null, bool forceClone = false)
        {
            return source.OrderF(comparer, forceClone).ReverseF();
        }
        
        /// <summary>
        /// Sorts the elements of a sequence in ascending order by using a specified comparer.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> of values to order.</param>
        /// <param name="keySelector">A selector function to extract a key from an element.</param>
        /// <param name="comparer">An optional <see cref="IComparer{T}"/> used to compare keys; falls back to <see cref="Comparer{T}.Default"/> when set to <see langword="null"/>.</param>
        /// <param name="forceClone">Force clone of <paramref name="source"/> (disable in-place optimization).</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <typeparam name="TKey">The type of the key returned by <paramref name="keySelector"/>.</typeparam>
        /// <returns>An <see cref="IList{T}"/> whose elements are sorted in ascending order according to a key.</returns>
        public static IList<TSource> OrderByF<TSource, TKey>(this IList<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey>? comparer = null, bool forceClone = false)
        {
            comparer ??= Comparer<TKey>.Default;

            var sourceArray = source.ToArrayF(forceClone);
            var sourceLength = sourceArray.Length;

            var keys = new TKey[sourceLength];

            for (var i = 0; i < sourceLength; i++)
                keys[i] = keySelector(sourceArray[i]);

            Array.Sort(keys, sourceArray, comparer);

            return sourceArray;
        }

        /// <summary>
        /// Sorts the elements of a sequence in descending order by using a specified comparer.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> of values to order.</param>
        /// <param name="keySelector">A selector function to extract a key from an element.</param>
        /// <param name="comparer">An optional <see cref="IComparer{T}"/> used to compare keys; falls back to <see cref="Comparer{T}.Default"/> when set to <see langword="null"/>.</param>
        /// <param name="forceClone">Force clone of <paramref name="source"/> (disable in-place optimization).</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <typeparam name="TKey">The type of the key returned by <paramref name="keySelector"/>.</typeparam>
        /// <returns>An <see cref="IList{T}"/> whose elements are sorted in descending order according to a key.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IList<TSource> OrderByDescendingF<TSource, TKey>(this IList<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey>? comparer = null, bool forceClone = false)
        {
            return source.OrderByF(keySelector, comparer, forceClone).ReverseF();
        }
    }
}