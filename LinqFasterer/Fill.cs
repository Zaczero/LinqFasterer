using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace LinqFasterer
{
    public static partial class EnumerableF
    {
        /// <summary>
        /// Sets elements in a sequence to the chosen value.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> whose elements need to be filled.</param>
        /// <param name="value">A value to set elements to.</param>
        /// <param name="forceClone">Force clone of <paramref name="source"/> (disable in-place optimization).</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <returns>An <see cref="IList{T}"/> with elements set to the chosen value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IList<TSource> FillF<TSource>(this IList<TSource> source, TSource value, bool forceClone = false)
        {
            return source.FillF(value, 0, int.MaxValue, forceClone);
        }
        
        /// <summary>
        /// Sets elements in a sequence to the chosen value.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> whose elements need to be filled.</param>
        /// <param name="value">A value to set elements to.</param>
        /// <param name="index">The starting index of the range to fill.</param>
        /// <param name="length">The length of the range to fill.</param>
        /// <param name="forceClone">Force clone of <paramref name="source"/> (disable in-place optimization).</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <returns>An <see cref="IList{T}"/> with elements set to the chosen value.</returns>
        public static IList<TSource> FillF<TSource>(this IList<TSource> source, TSource value, int index, int length, bool forceClone = false)
        {
            var sourceArray = source.ToArrayF(forceClone);
            var sourceLength = sourceArray.Length;

            if (index < 0)
            {
                length += index;
                index = 0;
            }
            
            length = Math.Min(length, sourceLength - index);

            if (index >= sourceLength || length < 1)
                return sourceArray;
            
            var filled = Math.Min(length, 16);
            
            // It's more efficient to fill some initial data by index instead of calling Array.Copy straightaway
            // The magic number is a result of multiple benchmark tests
            var iMax = index + filled;
            for (var i = index; i < iMax; i++)
                sourceArray[i] = value;

            // ReSharper disable once InvertIf
            if (filled < length)
            {
                for (; filled * 2 < length; filled *= 2)
                    Array.Copy(sourceArray, index, sourceArray, index + filled, filled);

                Array.Copy(sourceArray, index, sourceArray, index + filled, length - filled);
            }

            return sourceArray;
        }
    }
}