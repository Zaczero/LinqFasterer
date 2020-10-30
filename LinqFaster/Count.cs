using System;
using System.Collections.Generic;
using LinqFasterer.Utils;

namespace LinqFasterer
{
	public static partial class LinqFasterer
	{
		/// <summary>Returns a number that represents how many elements in the specified sequence satisfy a condition.</summary>
		/// <returns>A number that represents how many elements in the sequence satisfy the condition in the predicate function.</returns>
		/// <param name="source">A sequence that contains elements to be tested and counted.</param>
		/// <param name="predicate">A function to test each element for a condition.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		public static int CountF<TSource>(this IList<TSource> source, Func<TSource, bool> predicate = null)
		{
			if (source == null)
				throw Error.ArgumentNull(nameof(source));

			if (predicate == null)
				return source.Count;

			var count = 0;

			for (var i = 0; i < source.Count; i++)
				if (predicate(source[i]))
					count++;

			return count;
		}
	}
}
