using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

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
        public static bool IsOrderedF<TSource>(this IList<TSource> source, IComparer<TSource>? comparer = null)
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
        public static bool IsOrderedDescendingF<TSource>(this IList<TSource> source, IComparer<TSource>? comparer = null)
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
        
        /// <summary>
        /// Checks whether elements of a sequence are sorted in ascending order by using a specified comparer.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> of values to check an order of.</param>
        /// <param name="keySelector">A selector function to extract a key from an element.</param>
        /// <param name="comparer">An optional <see cref="IComparer{T}"/> used to compare keys; falls back to <see cref="Comparer{T}.Default"/> when set to <see langword="null"/>.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <typeparam name="TKey">The type of the key returned by <paramref name="keySelector"/>.</typeparam>
        /// <returns>A <see cref="Boolean"/> which indicates whether elements are sorted in ascending order according to a key.</returns>
        public static bool IsOrderedByF<TSource, TKey>(this IList<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey>? comparer = null)
        {
            var sourceArray = source.ToArrayF();
            var sourceLength = sourceArray.Length;
            if (sourceLength < 2)
                return true;
                    
            var lastKey = keySelector(sourceArray[0]);

            if (comparer == null)
            {
                for (var i = 1; i < sourceLength; i++)
                {
                    var key = keySelector(sourceArray[i]);

                    if (Comparer<TKey>.Default.Compare(lastKey, key) > 0)
                        return false;
                
                    lastKey = key;
                }
            }
            else
            {
                for (var i = 1; i < sourceLength; i++)
                {
                    var key = keySelector(sourceArray[i]);

                    if (comparer.Compare(lastKey, key) > 0)
                        return false;
                
                    lastKey = key;
                }
            }

            return true;
        }
        
        /// <summary>
        /// Checks whether elements of a sequence are sorted in descending order by using a specified comparer.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> of values to check an order of.</param>
        /// <param name="keySelector">A selector function to extract a key from an element.</param>
        /// <param name="comparer">An optional <see cref="IComparer{T}"/> used to compare keys; falls back to <see cref="Comparer{T}.Default"/> when set to <see langword="null"/>.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <typeparam name="TKey">The type of the key returned by <paramref name="keySelector"/>.</typeparam>
        /// <returns>A <see cref="Boolean"/> which indicates whether elements are sorted in descending order according to a key.</returns>
        public static bool IsOrderedByDescendingF<TSource, TKey>(this IList<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey>? comparer = null)
        {
            var sourceArray = source.ToArrayF();
            var sourceLength = sourceArray.Length;
            if (sourceLength < 2)
                return true;
                    
            var lastKey = keySelector(sourceArray[0]);

            if (comparer == null)
            {
                for (var i = 1; i < sourceLength; i++)
                {
                    var key = keySelector(sourceArray[i]);

                    if (Comparer<TKey>.Default.Compare(lastKey, key) < 0)
                        return false;
                
                    lastKey = key;
                }
            }
            else
            {
                for (var i = 1; i < sourceLength; i++)
                {
                    var key = keySelector(sourceArray[i]);

                    if (comparer.Compare(lastKey, key) < 0)
                        return false;
                
                    lastKey = key;
                }
            }

            return true;
        }
    }
}