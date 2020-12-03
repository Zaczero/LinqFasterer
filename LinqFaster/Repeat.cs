using System;
using System.Collections.Generic;

namespace LinqFasterer
{
    public static partial class LinqFasterer
    {
        /// <summary>Generates a sequence that contains one repeated value.</summary>
        /// <returns>A sequence that contains a repeated value.</returns>
        /// <param name="element">The value to be repeated.</param>
        /// <param name="count">The number of times to repeat the value in the generated sequence.</param>
        public static IList<TResult> RepeatF<TResult>(TResult element, int count)
        {
            var result = new TResult[count];

            Array.Fill(result, element);

            return result;
        }
    }
}
