using System;
using System.Collections.Generic;

namespace LinqFasterer
{
    public static partial class LinqFasterer
    {
        /// <summary>Projects each element of a sequence to a sequence and flattens the resulting sequences into one sequence.</summary>
        /// <returns>A sequence whose elements are the result of invoking the one-to-many transform function on each element of the input sequence.</returns>
        /// <param name="source">A sequence of values to project.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
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

        /// <summary>Projects each element of a sequence to A sequence and flattens the resulting sequences into one sequence.</summary>
        /// <returns>A sequence whose elements are the result of invoking the one-to-many transform function on each element of the input sequence.</returns>
        /// <param name="source">A sequence of values to project.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
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
