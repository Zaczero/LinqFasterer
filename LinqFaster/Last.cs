using System;
using System.Collections.Generic;
using LinqFasterer.Utils;

namespace LinqFasterer
{
	public static partial class LinqFasterer
	{
		/// <summary>Returns the last element in a sequence that satisfies a specified condition.</summary>
		/// <returns>The last element in the sequence that passes the test in the specified predicate function.</returns>
		/// <param name="source">A sequence to return an element from.</param>
		/// <param name="predicate">A function to test each element for a condition.</param>
		public static TSource LastF<TSource>(this IList<TSource> source, Func<TSource, bool>? predicate = null)
		{
			if (predicate == null)
				return source[source.Count - 1];

			var sourceArray = source.ToArrayF();
			var sourceLength = sourceArray.Length;

			for (var i = sourceLength - 1; i >= 0; i--)
			{
				var value = sourceArray[i];

				if (predicate(value))
					return value;
			}

			throw Error.NoMatch();
		}

		/// <summary>Returns the last element of a sequence, or a default value if the sequence contains no elements.</summary>
		/// <returns>The last element in the sequence that passes the test in the specified predicate function.</returns>
		/// <param name="source">A sequence to return an element from.</param>
		/// <param name="predicate">A function to test each element for a condition.</param>
		public static TSource LastOrDefaultF<TSource>(this IList<TSource> source, Func<TSource, bool>? predicate = null)
		{
			if (predicate == null)
				return source.Count == 0 ? default! : source[source.Count - 1];

			var sourceArray = source.ToArrayF();
			var sourceLength = sourceArray.Length;

			for (var i = sourceLength - 1; i >= 0; i--)
			{
				var value = sourceArray[i];

				if (predicate(value))
					return value;
			}

			return default!;
		}
	}
}
