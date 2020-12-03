using System;
using System.Collections.Generic;

namespace LinqFasterer
{
    public static partial class EnumerableF
    {
        /// <summary>Produces a sequence of tuples with elements from the two specified sequences.</summary>
        /// <returns>A sequence of tuples with elements taken from the first and second sequences, in that order.</returns>
        /// <param name="first">The first sequence to merge.</param>
        /// <param name="second">The second sequence to merge.</param>
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

        /// <summary>Applies a specified function to the corresponding elements of two sequences, producing a sequence of the results.</summary>
        /// <returns>A sequence that contains merged elements of two input sequences.</returns>
        /// <param name="first">The first sequence to merge.</param>
        /// <param name="second">The second sequence to merge.</param>
        /// <param name="resultSelector">A function that specifies how to merge the elements from the two sequences.</param>
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
