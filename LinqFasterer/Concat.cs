using System.Collections.Generic;

namespace LinqFasterer
{
    public static partial class EnumerableF
    {
        /// <summary>
        /// Concatenates two sequences.
        /// </summary>
        /// <param name="first">The first <see cref="IList{T}"/> to concatenate.</param>
        /// <param name="second">The second <see cref="IList{T}"/> to concatenate.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="first"/> and <paramref name="second"/>.</typeparam>
        /// <returns>An <see cref="IList{T}"/> that contains the concatenated elements of the two input sequences.</returns>
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