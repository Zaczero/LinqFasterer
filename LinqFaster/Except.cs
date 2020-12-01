using System;
using System.Collections.Generic;

namespace LinqFasterer
{
	public static partial class LinqFasterer
	{
		// TODO: benchmark

		/// <summary>Produces the set difference of two sequences by using the specified equality comparer to compare values.</summary>
		/// <returns>A sequence that contains the set difference of the elements of two sequences.</returns>
		/// <param name="first">A sequence whose elements that are not also in second will be returned.</param>
		/// <param name="second">A sequence whose elements that also occur in the first sequence will cause those elements to be removed from the returned sequence.</param>
		/// <param name="comparer">An equality comparer to compare values.</param>
		/// <param name="forceClone">Force clone of an object (disable in-place optimization).</param>
		public static IList<TSource> ExceptF<TSource>(this IList<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource>? comparer = null, bool forceClone = false)
		{
			var firstArray = first.ToArrayF(forceClone);
			var firstLength = firstArray.Length;

			comparer ??= EqualityComparer<TSource>.Default;

			var secondHashSet = new HashSet<TSource>(second, comparer);
			var resultSize = 0;

			for (var i = 0; i < firstLength; i++)
			{
				var value = firstArray[i];

				if (!secondHashSet.Contains(value))
					firstArray[resultSize++] = value;
			}

			Array.Resize(ref firstArray, resultSize);

			return firstArray;
		}
	}
}