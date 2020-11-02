using System;
using System.Collections.Generic;

namespace LinqFasterer
{
	public static partial class LinqFasterer
	{
		/// <summary>Filters a sequence of values based on a predicate.</summary>
		/// <returns>A sequence that contains elements from the input sequence that satisfy the condition.</returns>
		/// <param name="source">A sequence to filter.</param>
		/// <param name="predicate">A function to test each element for a condition.</param>
		[Obsolete("This method is twice as slow as Linq's implementation. It should not be used in its current state.")]
		public static IList<TSource> WhereF<TSource>(this IList<TSource> source, Func<TSource, bool> predicate)
		{
			var result = new TSource[source.Count];
			var resultSize = 0;

			for (var i = 0; i < source.Count; i++)
			{
				var value = source[i];

				if (predicate(value))
					result[resultSize++] = value;
			}

			Array.Resize(ref result, resultSize);

			return result;
		}

		/// <summary>Filters a sequence of values based on a predicate. Each element's index is used in the logic of the predicate function.</summary>
		/// <returns>A sequence that contains elements from the input sequence that satisfy the condition.</returns>
		/// <param name="source">A sequence to filter.</param>
		/// <param name="predicate">A function to test each source element for a condition; the second parameter of the function represents the index of the source element.</param>
		public static IList<TSource> WhereF<TSource>(this IList<TSource> source, Func<TSource, int, bool> predicate)
		{
			var result = new TSource[source.Count];
			var resultSize = 0;

			for (var i = 0; i < source.Count; i++)
			{
				var value = source[i];

				if (predicate(value, i))
					result[resultSize++] = value;
			}

			Array.Resize(ref result, resultSize);

			return result;
		}
	}
}
