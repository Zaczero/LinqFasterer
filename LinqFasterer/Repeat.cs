using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace LinqFasterer
{
    public static partial class EnumerableF
    {
        /// <summary>
        /// Generates a sequence that contains one repeated value.
        /// </summary>
        /// <param name="element">The value to be repeated.</param>
        /// <param name="count">The number of times to repeat the value in the generated sequence.</param>
        /// <typeparam name="TResult">The type of the value to be repeated in the result sequence.</typeparam>
        /// <returns>An <see cref="IList{T}"/> that contains a repeated <paramref name="element"/>.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IList<TResult> RepeatF<TResult>(TResult element, int count)
        {
            return count < 1 ? Array.Empty<TResult>() : new TResult[count].FillF(element, 0, count);
        }
        
        /// <summary>
        /// Generates a sequence that contains one repeated sequence.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> to be repeated.</param>
        /// <param name="count">The number of times to repeat the <paramref name="source"/> in the generated sequence.</param>
        /// <typeparam name="TResult">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <returns>An <see cref="IList{T}"/> that contains a repeated <paramref name="source"/>.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IList<TResult> RepeatF<TResult>(this IList<TResult> source, int count)
        {
            return RepeatSequenceF(source, count);
        }
        
        /// <summary>
        /// Generates a sequence that contains one repeated sequence.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> to be repeated.</param>
        /// <param name="count">The number of times to repeat the <paramref name="source"/> in the generated sequence.</param>
        /// <typeparam name="TResult">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <returns>An <see cref="IList{T}"/> that contains a repeated <paramref name="source"/>.</returns>
        public static IList<TResult> RepeatSequenceF<TResult>(IList<TResult> source, int count)
        {
            if (count < 1)
                return Array.Empty<TResult>();

            var sourceArray = source.ToArrayF();
            var sourceLength = sourceArray.Length;
            
            switch (sourceLength)
            {
                case 0:
                    return Array.Empty<TResult>();
                case 1:
                    return RepeatF(sourceArray[0], count);
            }

            var resultLength = sourceLength * count;
            var result = new TResult[resultLength];
            
            Array.Copy(sourceArray, 0, result, 0, sourceLength);
            var filled = sourceLength;
            
            for (; filled * 2 < resultLength; filled *= 2)
                Array.Copy(result, 0, result, filled, filled);

            Array.Copy(result, 0, result, filled, resultLength - filled);

            return result;
        }
    }
}
