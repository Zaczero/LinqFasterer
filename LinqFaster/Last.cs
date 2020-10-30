using System;
using System.Collections.Generic;
using LinqFasterer.Utils;

namespace LinqFasterer
{
	public static partial class LinqFasterer
	{
		/// <summary>Returns the last element in a sequence that satisfies a specified condition.</summary>
		/// <returns>The last element in the sequence that passes the test in the specified predicate function.</returns>
		/// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to return an element from.</param>
		/// <param name="predicate">A function to test each element for a condition.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		public static TSource LastF<TSource>(this IList<TSource> source, Func<TSource, bool> predicate = null)
		{
			if (source == null)
				throw Error.ArgumentNull(nameof(source));

			if (predicate == null)
				return source[source.Count - 1];

			for (var i = source.Count - 1; i >= 0; i--)
				if (predicate(source[i]))
					return source[i];

			throw Error.NoMatch();
		}

		/// <summary>Returns the last element of a sequence, or a default value if the sequence contains no elements.</summary>
		/// <returns>The last element in the sequence that passes the test in the specified predicate function.</returns>
		/// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to return an element from.</param>
		/// <param name="predicate">A function to test each element for a condition.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		public static TSource LastOrDefaultF<TSource>(this IList<TSource> source, Func<TSource, bool> predicate = null)
		{
			if (source == null)
				throw Error.ArgumentNull(nameof(source));

			if (predicate == null)
				return source.Count == 0 ? default : source[source.Count - 1];

			for (var i = source.Count - 1; i >= 0; i--)
				if (predicate(source[i]))
					return source[i];

			return default;
		}
	}
}
