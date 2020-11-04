using System;
using System.Collections.Generic;

namespace LinqFasterer
{
	public static partial class LinqFasterer
	{
		/// <summary>Produces the set union of two sequences.</summary>
		/// <returns>A sequence that contains the elements from both input sequences, excluding duplicates.</returns>
		/// <param name="first">A sequence whose distinct elements form the first set for the union.</param>
		/// <param name="second">A sequence whose distinct elements form the second set for the union.</param>
		/// <param name="comparer">An optional equality comparer, falls back to default when set to null.</param>
		public static IList<TSource> UnionF<TSource>(this IList<TSource> first, IList<TSource> second, IEqualityComparer<TSource>? comparer = null)
		{
			var firstLength = first.Count;
			var secondLength = second.Count;

			comparer ??= EqualityComparer<TSource>.Default;

			var resultLength = firstLength + secondLength;
			var result = new TSource[resultLength];
			int resultSize;

			first.CopyTo(result, 0);
			second.CopyTo(result, firstLength);

			// The following code runs faster on smaller workloads
			// The magic number is a result of multiple benchmark tests
			if (resultLength < 2500)
			{
				var resultHashSet = new HashSet<TSource>(result, comparer);
				resultSize = resultHashSet.Count;

				resultHashSet.CopyTo(result, 0, resultSize);
			}
			else
			{
				var resultHashSet = new HashSet<TSource>(comparer);
				resultSize = 0;

				for (var i = 0; i < resultLength; i++)
				{
					var value = result[i];

					if (!resultHashSet.Contains(value))
					{
						result[resultSize++] = value;
						resultHashSet.Add(value);
					}
				}
			}

			Array.Resize(ref result, resultSize);

			return result;
		}
	}
}