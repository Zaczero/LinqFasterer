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
            var result = new TResult[count];

            Array.Fill(result, element);

            return result;
        }
    }
}
