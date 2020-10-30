using System;
using System.Collections.Generic;

namespace JM.LinqFaster
{
	public static partial class LinqFaster
	{
		/// <summary>Filters a sequence of values based on a predicate.</summary>
		/// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> that contains elements from the input sequence that satisfy the condition.</returns>
		/// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to filter.</param>
		/// <param name="predicate">A function to test each element for a condition.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		public static IList<TSource> WhereF<TSource>(this IList<TSource> source, Func<TSource, bool> predicate)
		{
			if (source == null)
				throw Error.ArgumentNull(nameof(source));

			if (predicate == null)
				throw Error.ArgumentNull(nameof(predicate));

			var result = new TSource[source.Count];
			var resultSize = 0;

			for (var i = 0; i < source.Count; i++)
				if (predicate(source[i]))
					result[resultSize++] = source[i];

			Array.Resize(ref result, resultSize);

			return result;
		}

		/// <summary>Filters a sequence of values based on a predicate. Each element's index is used in the logic of the predicate function.</summary>
		/// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> that contains elements from the input sequence that satisfy the condition.</returns>
		/// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to filter.</param>
		/// <param name="predicate">A function to test each source element for a condition; the second parameter of the function represents the index of the source element.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		public static IList<TSource> WhereF<TSource>(this IList<TSource> source, Func<TSource, int, bool> predicate)
		{
			if (source == null)
				throw Error.ArgumentNull(nameof(source));

			if (predicate == null)
				throw Error.ArgumentNull(nameof(predicate));

			var result = new TSource[source.Count];
			var resultSize = 0;

			for (var i = 0; i < source.Count; i++)
				if (predicate(source[i], i))
					result[resultSize++] = source[i];

			Array.Resize(ref result, resultSize);

			return result;
		}
	}
}
