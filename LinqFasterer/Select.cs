using System;
using System.Collections.Generic;

namespace LinqFasterer
{
    public static partial class EnumerableF
    {
        /// <summary>
        /// Projects each element of a sequence into a new form.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> of values to invoke a transform function on.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <typeparam name="TResult">The type of the value returned by <paramref name="selector"/>.</typeparam>
        /// <returns>An <see cref="IList{T}"/> whose elements are the result of invoking <paramref name="selector"/> on each element of <paramref name="source"/>.</returns>
        public static IList<TResult> SelectF<TSource, TResult>(this IList<TSource> source, Func<TSource, TResult> selector)
        {
            var sourceArray = source.ToArrayF();
            var sourceLength = sourceArray.Length;
            
            var result = new TResult[sourceLength];

            for (var i = 0; i < sourceLength; i++)
                result[i] = selector(sourceArray[i]);

            return result;
        }

        /// <summary>
        /// Projects each element of a sequence into a new form by incorporating the element's index.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> of values to invoke a transform function on.</param>
        /// <param name="selector">A transform function to apply to each source element; the second parameter of the function represents the index of <paramref name="source"/> element.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <typeparam name="TResult">The type of the value returned by <paramref name="selector"/>.</typeparam>
        /// <returns>An <see cref="IList{T}"/> whose elements are the result of invoking <paramref name="selector"/> on each element of <paramref name="source"/>.</returns>
        public static IList<TResult> SelectF<TSource, TResult>(this IList<TSource> source, Func<TSource, int, TResult> selector)
        {
            var sourceArray = source.ToArrayF();
            var sourceLength = sourceArray.Length;

            var result = new TResult[sourceLength];

            for (var i = 0; i < sourceLength; i++)
                result[i] = selector(sourceArray[i], i);

            return result;
        }

        /// <summary>
        /// Projects each element of a sequence into a new form.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> of values to invoke a transform function on.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/> and the value returned by <paramref name="selector"/>.</typeparam>
        /// <returns>An <see cref="IList{T}"/> whose elements are the result of invoking <paramref name="selector"/> on each element of <paramref name="source"/>.</returns>
        public static IList<TSource> SelectInPlaceF<TSource>(this TSource[] source, Func<TSource, TSource> selector)
        {
            var sourceArray = source;
            var sourceLength = sourceArray.Length;
            
            for (var i = 0; i < sourceLength; i++)
                sourceArray[i] = selector(sourceArray[i]);

            return sourceArray;
        }

        /// <summary>
        /// Projects each element of a sequence into a new form by incorporating the element's index.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> of values to invoke a transform function on.</param>
        /// <param name="selector">A transform function to apply to each source element; the second parameter of the function represents the index of <paramref name="source"/> element.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/> and the value returned by <paramref name="selector"/>.</typeparam>
        /// <returns>An <see cref="IList{T}"/> whose elements are the result of invoking <paramref name="selector"/> on each element of <paramref name="source"/>.</returns>
        public static IList<TSource> SelectInPlaceF<TSource>(this TSource[] source, Func<TSource, int, TSource> selector)
        {
            var sourceArray = source;
            var sourceLength = sourceArray.Length;
            
            for (var i = 0; i < sourceLength; i++)
                sourceArray[i] = selector(sourceArray[i], i);

            return sourceArray;
        }
    }
}
