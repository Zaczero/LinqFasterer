using System;
using System.Collections.Generic;

namespace LinqFasterer
{
    public static partial class EnumerableF
    {
        /// <summary>
        /// Returns a specified number of contiguous elements from the start of a sequence.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> to return elements from.</param>
        /// <param name="count">A number of elements to return from <paramref name="source"/>.</param>
        /// <param name="forceClone">Force clone of <paramref name="source"/> (disable in-place optimization).</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <returns>An <see cref="IList{T}"/> that contains the specified number of elements from the start of <paramref name="source"/>.</returns>
        public static IList<TSource> TakeF<TSource>(this IList<TSource> source, int count, bool forceClone = false)
        {
            if (count <= 0)
                return EmptyF<TSource>();
            
            var sourceArray = source.ToArrayF(forceClone);
            var sourceLength = source.Count;
            if (sourceLength <= count)
                return sourceArray;

            Array.Resize(ref sourceArray, count);

            return sourceArray;
        }

        /// <summary>
        /// Returns a specified number of contiguous elements from the end of a sequence.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> to return elements from.</param>
        /// <param name="count">A number of end elements to return from <paramref name="source"/>.</param>
        /// <param name="forceClone">Force clone of <paramref name="source"/> (disable in-place optimization).</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <returns>An <see cref="IList{T}"/> that contains the specified number of elements from the end of <paramref name="source"/>.</returns>
        public static IList<TSource> TakeLastF<TSource>(this IList<TSource> source, int count, bool forceClone = false)
        {
            if (count <= 0)
                return EmptyF<TSource>();
            
            var sourceArray = source.ToArrayF(forceClone);
            var sourceLength = source.Count;
            if (sourceLength <= count)
                return sourceArray;

            Array.Copy(sourceArray, sourceLength - count, sourceArray, 0, count);
            Array.Resize(ref sourceArray, count);

            return sourceArray;
        }

        /// <summary>
        /// Returns elements from a sequence as long as a specified condition is true.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> to return elements from.</param>
        /// <param name="predicate">A predicate function to test each element for a condition.</param>
        /// <param name="forceClone">Force clone of <paramref name="source"/> (disable in-place optimization).</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <returns>An <see cref="IList{T}"/> that contains the elements from <paramref name="source"/> that occur before the element at which the test no longer passes.</returns>
        public static IList<TSource> TakeWhileF<TSource>(this IList<TSource> source, Func<TSource, bool> predicate, bool forceClone = false)
        {
            var sourceArray = source.ToArrayF();
            var sourceLength = sourceArray.Length;
            
            var count = 0;

            for (; count < sourceLength; count++)
                if (!predicate(sourceArray[count]))
                    break;

            return sourceArray.TakeF(count, forceClone);
        }

        /// <summary>
        /// Returns elements from a sequence as long as a specified condition is true.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> to return elements from.</param>
        /// <param name="predicate">A predicate function to test each element for a condition; the second parameter of the function represents the index of <paramref name="source"/> element.</param>
        /// <param name="forceClone">Force clone of <paramref name="source"/> (disable in-place optimization).</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <returns>An <see cref="IList{T}"/> that contains the elements from <paramref name="source"/> that occur before the element at which the test no longer passes.</returns>
        public static IList<TSource> TakeWhileF<TSource>(this IList<TSource> source, Func<TSource, int, bool> predicate, bool forceClone = false)
        {
            var sourceArray = source.ToArrayF();
            var sourceLength = sourceArray.Length;
            
            var count = 0;

            for (; count < sourceLength; count++)
                if (!predicate(sourceArray[count], count))
                    break;

            return sourceArray.TakeF(count, forceClone);
        }
    }
}