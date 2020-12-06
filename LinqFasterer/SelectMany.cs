using System;
using System.Collections.Generic;

namespace LinqFasterer
{
    public static partial class EnumerableF
    {
        /// <summary>
        /// Projects each element of sequence to a sequence and flattens the resulting sequences into one sequence.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> of values to project.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <typeparam name="TResult">The type of the value returned by <paramref name="selector"/>.</typeparam>
        /// <returns>An <see cref="IList{T}"/> whose elements are the result of invoking the one-to-many <paramref name="selector"/> on each element of <paramref name="source"/>.</returns>
        public static IList<TResult> SelectManyF<TSource, TResult>(this IList<TSource> source, Func<TSource, IList<TResult>> selector)
        {
            var sourceArray = source.ToArrayF();
            var sourceLength = sourceArray.Length;
            
            var result = new List<TResult>();

            for (var i = 0; i < sourceLength; i++)
            {
                var valueArray = selector(source[i]).ToArrayF();
                var valueLength = valueArray.Length;

                for (var j = 0; j < valueLength; j++)
                    result.Add(valueArray[j]);
            }

            return result;
        }

        /// <summary>
        /// Projects each element of sequence to a sequence and flattens the resulting sequences into one sequence.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> of values to project.</param>
        /// <param name="selector">A transform function to apply to each element; the second parameter of the function represents the index of <paramref name="source"/> element.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <typeparam name="TResult">The type of the value returned by <paramref name="selector"/>.</typeparam>
        /// <returns>An <see cref="IList{T}"/> whose elements are the result of invoking the one-to-many <paramref name="selector"/> on each element of <paramref name="source"/>.</returns>
        public static IList<TResult> SelectManyF<TSource, TResult>(this IList<TSource> source, Func<TSource, int, IList<TResult>> selector)
        {
            var sourceArray = source.ToArrayF();
            var sourceLength = sourceArray.Length;
            
            var result = new List<TResult>();

            for (var i = 0; i < sourceLength; i++)
            {
                var valueArray = selector(source[i], i).ToArrayF();
                var valueLength = valueArray.Length;

                for (var j = 0; j < valueLength; j++)
                    result.Add(valueArray[j]);
            }

            return result;
        }
    }
}
