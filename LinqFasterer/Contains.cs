using System;
using System.Collections.Generic;

namespace LinqFasterer
{
    public static partial class EnumerableF
    {
        /// <summary>
        /// Determines whether a sequence contains a specified element by using a specified equality comparer.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> in which to locate a value.</param>
        /// <param name="value">A value to locate.</param>
        /// <param name="comparer">An optional <see cref="IEqualityComparer{T}"/> used to compare values; falls back to <see cref="EqualityComparer{T}.Default"/> when set to <see langword="null"/>.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <returns><see langword="true"/> if <paramref name="source"/> contains an element that has the specified <paramref name="value"/>; otherwise, <see langword="false"/>.</returns>
        public static bool ContainsF<TSource>(this IList<TSource> source, TSource value, IEqualityComparer<TSource>? comparer = null)
        {
            var sourceArray = source.ToArrayF();
            
            if (comparer == null)
                return Array.IndexOf(sourceArray, value) > -1;
            
            var sourceLength = sourceArray.Length;
            
            for (var i = 0; i < sourceLength; i++)
                if (comparer.Equals(sourceArray[i], value))
                    return true;

            return false;
        }
    }
}
