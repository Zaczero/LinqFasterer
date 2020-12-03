using LinqFasterer.Utils;
using System;
using System.Collections.Generic;

namespace LinqFasterer
{
    public static partial class LinqFasterer
    {
        /// <summary>Returns the minimum value in a generic sequence.</summary>
        /// <returns>The minimum value in the sequence.</returns>
        /// <param name="source">A sequence of values to determine the minimum value of.</param>
        public static TSource MinF<TSource>(this IList<TSource> source)
        {
            var sourceArray = source.ToArrayF();
            var sourceLength = sourceArray.Length;
            if (sourceLength == 0)
                throw Error.NoElements();

            if (default(TSource) == null)
            {
                TSource result = default;
                
                for (var i = 0; i < sourceLength; i++)
                {
                    if (sourceArray[i] == null)
                        continue;

                    var value = sourceArray[i];

                    if (result == null || Comparer<TSource>.Default.Compare(value, result) < 0)
                        result = value;
                }

                return result!;
            }
            else
            {
                var result = sourceArray[0];
                
                for (var i = 1; i < sourceLength; i++)
                {
                    var value = sourceArray[i];

                    if (Comparer<TSource>.Default.Compare(value, result) < 0)
                        result = value;
                }

                return result;
            }
        }

        /// <summary>Invokes a transform function on each element of a generic sequence and returns the minimum resulting value.</summary>
        /// <returns>The minimum value in the sequence.</returns>
        /// <param name="source">A sequence of values to determine the minimum value of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        public static TResult MinF<TSource, TResult>(this IList<TSource> source, Func<TSource, TResult> selector)
        {
            var sourceArray = source.ToArrayF();
            var sourceLength = sourceArray.Length;
            if (sourceLength == 0)
                throw Error.NoElements();

            if (default(TSource) == null)
            {
                TResult result = default;
                
                for (var i = 0; i < sourceLength; i++)
                {
                    if (sourceArray[i] == null)
                        continue;

                    var value = selector(sourceArray[i]);

                    if (result == null || Comparer<TResult>.Default.Compare(value, result) < 0)
                        result = value;
                }

                return result!;
            }
            else
            {
                var result = selector(sourceArray[0]);
                
                for (var i = 1; i < sourceLength; i++)
                {
                    var value = selector(sourceArray[i]);

                    if (Comparer<TResult>.Default.Compare(value, result) < 0)
                        result = value;
                }

                return result;
            }
        }
    }
}
