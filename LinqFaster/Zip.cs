using System;
using System.Collections.Generic;

namespace LinqFasterer
{
	public static partial class LinqFasterer
	{
		/// <summary>Produces a sequence of tuples with elements from the two specified sequences.</summary>
		/// <returns>A sequence of tuples with elements taken from the first and second sequences, in that order.</returns>
		/// <param name="first">The first sequence to merge.</param>
		/// <param name="second">The second sequence to merge.</param>
		public static IList<ValueTuple<TFirst,TSecond>> ZipF<TFirst, TSecond>(this IList<TFirst> first, IList<TSecond> second)
		{
			var result = new ValueTuple<TFirst,TSecond>[Math.Min(first.Count, second.Count)];

			for (var i = 0; i < result.Length; i++)
				result[i] = new ValueTuple<TFirst,TSecond>(first[i], second[i]);

			return result;
		}

		/// <summary>Applies a specified function to the corresponding elements of two sequences, producing a sequence of the results.</summary>
		/// <returns>A sequence that contains merged elements of two input sequences.</returns>
		/// <param name="first">The first sequence to merge.</param>
		/// <param name="second">The second sequence to merge.</param>
		/// <param name="resultSelector">A function that specifies how to merge the elements from the two sequences.</param>
		public static IList<TResult> ZipF<TFirst, TSecond, TResult>(this IList<TFirst> first, IList<TSecond> second, Func<TFirst, TSecond, TResult> resultSelector)
		{
			var result = new TResult[Math.Min(first.Count, second.Count)];

			for (var i = 0; i < result.Length; i++)
				result[i] = resultSelector(first[i], second[i]);

			return result;
		}
	}
}
