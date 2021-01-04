using System;
using System.Collections.Generic;

namespace LinqFasterer
{
    public static partial class EnumerableF
    {
        /// <summary>
        /// Searches an entire one-dimensional sorted sequence for a value.
        /// </summary>
        /// <param name="source">The sorted one-dimensional, zero-based <see cref="IList{T}"/> to search.</param>
        /// <param name="value">The object to search for.</param>
        /// <param name="comparer">An optional <see cref="IComparer{T}"/> used to compare values; falls back to <see cref="Comparer{T}.Default"/> when set to <see langword="null"/>.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <returns>
        /// The index of the specified <paramref name="value"/> in the specified <paramref name="source"/>, if <paramref name="value"/> is found; otherwise, a negative number.
        /// If <paramref name="value"/> is not found and <paramref name="value"/> is less than one or more elements in <paramref name="source"/>, the negative number returned is the bitwise complement of the index of the first element that is larger than <paramref name="value"/>.
        /// If <paramref name="value"/> is not found and <paramref name="value"/> is greater than all elements in <paramref name="source"/>, the negative number returned is the bitwise complement of (the index of the last element plus 1).
        /// If this method is called with a non-sorted <paramref name="source"/>, the return value can be incorrect and a negative number could be returned, even if <paramref name="value"/> is present in <paramref name="source"/>.
        /// </returns>
        public static int BinarySearchF<TSource>(this IList<TSource> source, TSource value, IComparer<TSource>? comparer = null)
        {
            comparer ??= Comparer<TSource>.Default;

            var sourceArray = source.ToArrayF();

            return Array.BinarySearch(sourceArray, value, comparer);
        }
        
        /// <summary>
        /// Searches an entire one-dimensional sorted sequence for a value.
        /// </summary>
        /// <param name="source">The sorted one-dimensional, zero-based <see cref="IList{T}"/> to search.</param>
        /// <param name="index">The starting index of the range to search.</param>
        /// <param name="length">The length of the range to search.</param>
        /// <param name="value">The object to search for.</param>
        /// <param name="comparer">An optional <see cref="IComparer{T}"/> used to compare values; falls back to <see cref="Comparer{T}.Default"/> when set to <see langword="null"/>.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <returns>
        /// The index of the specified <paramref name="value"/> in the specified <paramref name="source"/>, if <paramref name="value"/> is found; otherwise, a negative number.
        /// If <paramref name="value"/> is not found and <paramref name="value"/> is less than one or more elements in <paramref name="source"/>, the negative number returned is the bitwise complement of the index of the first element that is larger than <paramref name="value"/>.
        /// If <paramref name="value"/> is not found and <paramref name="value"/> is greater than all elements in <paramref name="source"/>, the negative number returned is the bitwise complement of (the index of the last element plus 1).
        /// If this method is called with a non-sorted <paramref name="source"/>, the return value can be incorrect and a negative number could be returned, even if <paramref name="value"/> is present in <paramref name="source"/>.
        /// </returns>
        public static int BinarySearchF<TSource>(this IList<TSource> source, int index, int length, TSource value, IComparer<TSource>? comparer = null)
        {
            comparer ??= Comparer<TSource>.Default;

            var sourceArray = source.ToArrayF();

            return Array.BinarySearch(sourceArray, index, length, value, comparer);
        }
    }
}