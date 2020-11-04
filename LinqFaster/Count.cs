using System;
using System.Collections.Generic;

namespace LinqFasterer
{
	public static partial class LinqFasterer
	{
		/// <summary>Returns a number that represents how many elements in the specified sequence satisfy a condition.</summary>
		/// <returns>A number that represents how many elements in the sequence satisfy the condition in the predicate function.</returns>
		/// <param name="source">A sequence that contains elements to be tested and counted.</param>
		/// <param name="predicate">A function to test each element for a condition.</param>
		public static int CountF<TSource>(this IList<TSource> source, Func<TSource, bool>? predicate = null)
		{
			var sourceLength = source.Count;

			if (predicate == null)
				return sourceLength;

			var sourceArray = source.ToArrayF();
			var count = 0;

			for (var i = 0; i < sourceLength; i++)
				if (predicate(sourceArray[i]))
					count++;

			return count;
		}
	}
}
