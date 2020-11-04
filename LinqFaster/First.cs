using System;
using System.Collections.Generic;
using LinqFasterer.Utils;

namespace LinqFasterer
{
	public static partial class LinqFasterer
	{
		/// <summary>Returns the first element in a sequence that satisfies a specified condition.</summary>
		/// <returns>The first element in the sequence that passes the test in the specified predicate function.</returns>
		/// <param name="source">A sequence to return an element from.</param>
		/// <param name="predicate">A function to test each element for a condition.</param>
		public static TSource FirstF<TSource>(this IList<TSource> source, Func<TSource, bool>? predicate = null)
		{
			if (predicate == null)
				return source[0];

			var sourceArray = source.ToArrayF();
			var sourceLength = sourceArray.Length;

			for (var i = 0; i < sourceLength; i++)
			{
				var value = sourceArray[i];

				if (predicate(value))
					return value;
			}

			throw Error.NoMatch();
		}

		/// <summary>Returns the first element of a sequence, or a default value if the sequence contains no elements.</summary>
		/// <returns>The first element in the sequence that passes the test in the specified predicate function.</returns>
		/// <param name="source">A sequence to return an element from.</param>
		/// <param name="predicate">A function to test each element for a condition.</param>
		public static TSource FirstOrDefaultF<TSource>(this IList<TSource> source, Func<TSource, bool>? predicate = null)
		{
			if (predicate == null)
				return source.Count == 0 ? default! : source[0];

			var sourceArray = source.ToArrayF();
			var sourceLength = sourceArray.Length;

			for (var i = 0; i < sourceLength; i++)
			{
				var value = sourceArray[i];

				if (predicate(value))
					return value;
			}

			return default!;
		}
	}
}
