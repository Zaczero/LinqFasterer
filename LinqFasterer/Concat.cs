using System.Collections.Generic;

namespace LinqFasterer
{
    public static partial class EnumerableF
    {
        /// <summary>Concatenates two sequences.</summary>
        /// <returns>A sequence that contains the concatenated elements of the two input sequences.</returns>
        /// <param name="first">The first sequence to concatenate.</param>
        /// <param name="second">The sequence to concatenate to the first sequence.</param>
        public static IList<TSource> ConcatF<TSource>(this IList<TSource> first, IList<TSource> second)
        {
            var firstLength = first.Count;
            var secondLength = second.Count;

            var resultLength = firstLength + secondLength;
            var result = new TSource[resultLength];

            first.CopyTo(result, 0);
            second.CopyTo(result, firstLength);

            return result;
        }
    }
}