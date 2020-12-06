using System;
using System.Collections.Generic;

namespace LinqFasterer
{
    public static partial class EnumerableF
    {
        /// <summary>
        /// Bypasses a specified number of elements in a sequence and then returns the remaining elements.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> to return elements from.</param>
        /// <param name="count">A number of elements to skip from <paramref name="source"/>.</param>
        /// <param name="forceClone">Force clone of <paramref name="source"/> (disable in-place optimization).</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <returns>An <see cref="IList{T}"/> that contains the elements that occur after the specified index in <paramref name="source"/>.</returns>
        public static IList<TSource> SkipF<TSource>(this IList<TSource> source, int count, bool forceClone = false)
        {
            var sourceLength = source.Count;
            if (sourceLength <= count)
                return EmptyF<TSource>();

            var sourceArray = source.ToArrayF(forceClone);

            if (count <= 0)
                return sourceArray;

            var resultLength = sourceLength - count;
            Array.Copy(sourceArray, count, sourceArray, 0, resultLength);
            Array.Resize(ref sourceArray, resultLength);

            return sourceArray;
        }

        /// <summary>
        /// Bypasses a specified number of end elements in a sequence and then returns the remaining elements.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> to return elements from.</param>
        /// <param name="count">A number of end elements to skip from <paramref name="source"/>.</param>
        /// <param name="forceClone">Force clone of <paramref name="source"/> (disable in-place optimization).</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <returns>An <see cref="IList{T}"/> that contains the elements that occur before the specified index in <paramref name="source"/>.</returns>
        public static IList<TSource> SkipLastF<TSource>(this IList<TSource> source, int count, bool forceClone = false)
        {
            var sourceLength = source.Count;
            if (sourceLength <= count)
                return EmptyF<TSource>();

            var sourceArray = source.ToArrayF(forceClone);

            if (count <= 0)
                return sourceArray;
            
            var resultLength = sourceLength - count;
            Array.Resize(ref sourceArray, resultLength);

            return sourceArray;
        }

        /// <summary>
        /// Bypasses elements in a sequence as long as a specified condition is true and then returns the remaining elements.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> to return elements from.</param>
        /// <param name="predicate">A predicate function to test each element for a condition.</param>
        /// <param name="forceClone">Force clone of <paramref name="source"/> (disable in-place optimization).</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <returns>An <see cref="IList{T}"/> that contains the elements from <paramref name="source"/> starting at the first element in the linear series that does not pass the test specified by <paramref name="predicate"/>.</returns>
        public static IList<TSource> SkipWhileF<TSource>(this IList<TSource> source, Func<TSource, bool> predicate, bool forceClone = false)
        {
            var sourceArray = source.ToArrayF();
            var sourceLength = sourceArray.Length;
            
            var count = 0;

            for (; count < sourceLength; count++)
                if (!predicate(sourceArray[count]))
                    break;

            return sourceArray.SkipF(count, forceClone);
        }

        /// <summary>
        /// Bypasses elements in a sequence as long as a specified condition is true and then returns the remaining elements.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> to return elements from.</param>
        /// <param name="predicate">A predicate function to test each element for a condition; the second parameter of the function represents the index of <paramref name="source"/> element.</param>
        /// <param name="forceClone">Force clone of <paramref name="source"/> (disable in-place optimization).</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <returns>An <see cref="IList{T}"/> that contains the elements from <paramref name="source"/> starting at the first element in the linear series that does not pass the test specified by <paramref name="predicate"/>.</returns>
        public static IList<TSource> SkipWhileF<TSource>(this IList<TSource> source, Func<TSource, int, bool> predicate, bool forceClone = false)
        {
            var sourceArray = source.ToArrayF();
            var sourceLength = sourceArray.Length;

            var count = 0;

            for (; count < sourceLength; count++)
                if (!predicate(sourceArray[count], count))
                    break;

            return sourceArray.SkipF(count, forceClone);
        }
    }
}
