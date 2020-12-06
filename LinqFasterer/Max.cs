using System;
using System.Collections.Generic;
using LinqFasterer.Utils;

namespace LinqFasterer
{
    public static partial class EnumerableF
    {
        /// <summary>
        /// Returns the maximum value in a sequence.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> of values to determine the maximum value of.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <returns>The maximum value in <paramref name="source"/>.</returns>
        public static TSource MaxF<TSource>(this IList<TSource> source)
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
                    var value = sourceArray[i];
                    if (value == null)
                        continue;

                    if (result == null || Comparer<TSource>.Default.Compare(value, result) > 0)
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

                    if (Comparer<TSource>.Default.Compare(value, result) > 0)
                        result = value;
                }

                return result;
            }
        }

        /// <summary>
        /// Invokes a transform function on each element of a sequence and returns the maximum resulting value.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> of values to determine the maximum value of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <typeparam name="TResult">The type of the value returned by <paramref name="selector"/>.</typeparam>
        /// <returns>The maximum value in <paramref name="source"/>.</returns>
        public static TResult MaxF<TSource, TResult>(this IList<TSource> source, Func<TSource, TResult> selector)
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
                    var value = sourceArray[i];
                    if (value == null)
                        continue;

                    var valueSelector = selector(value);

                    if (result == null || Comparer<TResult>.Default.Compare(valueSelector, result) > 0)
                        result = valueSelector;
                }

                return result!;
            }
            else
            {
                var result = selector(sourceArray[0]);
                
                for (var i = 1; i < sourceLength; i++)
                {
                    var value = selector(sourceArray[i]);

                    if (Comparer<TResult>.Default.Compare(value, result) > 0)
                        result = value;
                }

                return result;
            }
        }
    }
}
