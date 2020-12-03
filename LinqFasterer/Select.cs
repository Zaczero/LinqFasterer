using System;
using System.Collections.Generic;

namespace LinqFasterer
{
    public static partial class LinqFasterer
    {
        /// <summary>Projects each element of a sequence into a new form.</summary>
        /// <returns>A sequence whose elements are the result of invoking the transform function on each element of source.</returns>
        /// <param name="source">A sequence of values to invoke a transform function on.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        public static IList<TResult> SelectF<TSource, TResult>(this IList<TSource> source, Func<TSource, TResult> selector)
        {
            var sourceArray = source.ToArrayF();
            var sourceLength = sourceArray.Length;
            
            var result = new TResult[sourceLength];

            for (var i = 0; i < sourceLength; i++)
                result[i] = selector(sourceArray[i]);

            return result;
        }

        /// <summary>Projects each element of a sequence into a new form by incorporating the element's index.</summary>
        /// <returns>A sequence whose elements are the result of invoking the transform function on each element of source.</returns>
        /// <param name="source">A sequence of values to invoke a transform function on.</param>
        /// <param name="selector">A transform function to apply to each source element; the second parameter of the function represents the index of the source element.</param>
        public static IList<TResult> SelectF<TSource, TResult>(this IList<TSource> source, Func<TSource, int, TResult> selector)
        {
            var sourceArray = source.ToArrayF();
            var sourceLength = sourceArray.Length;

            var result = new TResult[sourceLength];

            for (var i = 0; i < sourceLength; i++)
                result[i] = selector(sourceArray[i], i);

            return result;
        }

        /// <summary>Projects each element of a sequence into a new form.</summary>
        /// <returns>A sequence whose elements are the result of invoking the transform function on each element of source.</returns>
        /// <param name="source">A sequence of values to invoke a transform function on.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        public static IList<TSource> SelectInPlaceF<TSource>(this TSource[] source, Func<TSource, TSource> selector)
        {
            var sourceArray = source;
            var sourceLength = sourceArray.Length;
            
            for (var i = 0; i < sourceLength; i++)
                sourceArray[i] = selector(sourceArray[i]);

            return sourceArray;
        }

        /// <summary>Projects each element of a sequence into a new form by incorporating the element's index.</summary>
        /// <returns>A sequence whose elements are the result of invoking the transform function on each element of source.</returns>
        /// <param name="source">A sequence of values to invoke a transform function on.</param>
        /// <param name="selector">A transform function to apply to each source element; the second parameter of the function represents the index of the source element.</param>
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
