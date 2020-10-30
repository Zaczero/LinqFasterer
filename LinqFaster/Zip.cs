using System;
using System.Collections.Generic;

namespace JM.LinqFaster
{
	public static partial class LinqFaster
	{
		/// <summary>Applies a specified function to the corresponding elements of two sequences, producing a sequence of the results.</summary>
		/// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> that contains merged elements of two input sequences.</returns>
		/// <param name="first">The first sequence to merge.</param>
		/// <param name="second">The second sequence to merge.</param>
		/// <param name="resultSelector">A function that specifies how to merge the elements from the two sequences.</param>
		/// <typeparam name="TFirst">The type of the elements of the first input sequence.</typeparam>
		/// <typeparam name="TSecond">The type of the elements of the second input sequence.</typeparam>
		/// <typeparam name="TResult">The type of the elements of the result sequence.</typeparam>
		public static IList<TResult> ZipF<TFirst, TSecond, TResult>(this IList<TFirst> first, IList<TSecond> second, Func<TFirst, TSecond, TResult> resultSelector)
		{
			if (first == null)
				throw Error.ArgumentNull(nameof(first));

			if (second == null)
				throw Error.ArgumentNull(nameof(second));

			if (resultSelector == null)
				throw Error.ArgumentNull(nameof(resultSelector));

			var resultSize = Math.Min(first.Count, second.Count);
			var result = new TResult[resultSize];

			for (var i = 0; i < resultSize; i++)
				result[i] = resultSelector(first[i], second[i]);

			return result;
		}
	}
}
