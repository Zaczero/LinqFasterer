using System;
using System.Collections.Generic;

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
        public static IList<TResult> RepeatF<TResult>(TResult element, int count)
        {
            if (count < 1)
                return EmptyF<TResult>();
            
            var result = new TResult[count];
            var filled = Math.Min(count, 16);
            
            // It's more efficient to fill some initial data by index instead of calling Array.Copy straightaway
            // The magic number is a result of multiple benchmark tests
            for (var i = 0; i < filled; i++)
                result[i] = element;

            // ReSharper disable once InvertIf
            if (filled < count)
            {
                for (; filled * 2 < count; filled *= 2)
                    Array.Copy(result, 0, result, filled, filled);

                Array.Copy(result, 0, result, filled, count - filled);
            }

            return result;
        }
    }
}
