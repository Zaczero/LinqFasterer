using System;
using System.Collections.Generic;

namespace LinqFasterer
{
    public static partial class EnumerableF
    {
        /// <summary>
        /// Checks whether elements of a sequence are sorted in ascending order by using a specified comparer.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> of values to check an order of.</param>
        /// <param name="comparer">An optional <see cref="IComparer{T}"/> used to compare elements; falls back to <see cref="Comparer{T}.Default"/> when set to <see langword="null"/>.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <returns>A <see cref="Boolean"/> which indicates whether elements are sorted in ascending order.</returns>
        public static bool IsSortedF<TSource>(this IList<TSource> source, IComparer<TSource>? comparer = null)
        {
            var sourceArray = source.ToArrayF();
            var sourceLength = sourceArray.Length;
            if (sourceLength < 2)
                return true;
                    
            var lastValue = sourceArray[0];

            if (comparer == null)
            {
                for (var i = 1; i < sourceLength; i++)
                {
                    var value = sourceArray[i];

                    if (Comparer<TSource>.Default.Compare(lastValue, value) > 0)
                        return false;
                
                    lastValue = value;
                }
            }
            else
            {
                for (var i = 1; i < sourceLength; i++)
                {
                    var value = sourceArray[i];

                    if (comparer.Compare(lastValue, value) > 0)
                        return false;
                
                    lastValue = value;
                }
            }

            return true;
        }
        
        /// <summary>
        /// Checks whether elements of a sequence are sorted in descending order by using a specified comparer.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> of values to check an order of.</param>
        /// <param name="comparer">An optional <see cref="IComparer{T}"/> used to compare elements; falls back to <see cref="Comparer{T}.Default"/> when set to <see langword="null"/>.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <returns>A <see cref="Boolean"/> which indicates whether elements are sorted in descending order.</returns>
        public static bool IsSortedDescendingF<TSource>(this IList<TSource> source, IComparer<TSource>? comparer = null)
        {
            var sourceArray = source.ToArrayF();
            var sourceLength = sourceArray.Length;
            if (sourceLength < 2)
                return true;
                    
            var lastValue = sourceArray[0];

            if (comparer == null)
            {
                for (var i = 1; i < sourceLength; i++)
                {
                    var value = sourceArray[i];

                    if (Comparer<TSource>.Default.Compare(lastValue, value) < 0)
                        return false;
                
                    lastValue = value;
                }
            }
            else
            {
                for (var i = 1; i < sourceLength; i++)
                {
                    var value = sourceArray[i];

                    if (comparer.Compare(lastValue, value) < 0)
                        return false;
                
                    lastValue = value;
                }
            }

            return true;
        }
    }
}