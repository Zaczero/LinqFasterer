using System;
using System.Collections.Generic;

namespace LinqFasterer
{
    public static partial class EnumerableF
    {
        /// <summary>
        /// Produces a sequence of tuples with elements from the two specified sequences.
        /// </summary>
        /// <param name="first">The first <see cref="IList{T}"/> to merge.</param>
        /// <param name="second">The second <see cref="IList{T}"/> to merge.</param>
        /// <typeparam name="TFirst">The type of the elements of <paramref name="first"/>.</typeparam>
        /// <typeparam name="TSecond">The type of the elements of <paramref name="second"/>.</typeparam>
        /// <returns>An <see cref="IList{T}"/> of tuples with elements taken from <paramref name="first"/> and <paramref name="second"/>, in that order.</returns>
        public static IList<ValueTuple<TFirst,TSecond>> ZipF<TFirst, TSecond>(this IList<TFirst> first, IList<TSecond> second)
        {
            var firstArray = first.ToArrayF();
            var secondArray = second.ToArrayF();

            var resultLength = Math.Min(firstArray.Length, secondArray.Length);
            var result = new ValueTuple<TFirst,TSecond>[resultLength];

            for (var i = 0; i < resultLength; i++)
                result[i] = new ValueTuple<TFirst,TSecond>(firstArray[i], secondArray[i]);

            return result;
        }

        /// <summary>
        /// Applies a specified function to the corresponding elements of two sequences, producing a sequence of the results.
        /// </summary>
        /// <param name="first">The first <see cref="IList{T}"/> to merge.</param>
        /// <param name="second">The second <see cref="IList{T}"/> to merge.</param>
        /// <param name="resultSelector">A selector function that specifies how to merge the elements from the two input sequences.</param>
        /// <typeparam name="TFirst">The type of the elements of <paramref name="first"/>.</typeparam>
        /// <typeparam name="TSecond">The type of the elements of <paramref name="second"/>.</typeparam>
        /// <typeparam name="TResult">The type returned by <paramref name="resultSelector"/>.</typeparam>
        /// <returns>An <see cref="IList{T}"/> that contains merged elements of the two input sequences using <paramref name="resultSelector"/>.</returns>
        public static IList<TResult> ZipF<TFirst, TSecond, TResult>(this IList<TFirst> first, IList<TSecond> second, Func<TFirst, TSecond, TResult> resultSelector)
        {
            var firstArray = first.ToArrayF();
            var secondArray = second.ToArrayF();

            var resultLength = Math.Min(firstArray.Length, secondArray.Length);
            var result = new TResult[resultLength];

            for (var i = 0; i < resultLength; i++)
                result[i] = resultSelector(firstArray[i], secondArray[i]);

            return result;
        }
    }
}
