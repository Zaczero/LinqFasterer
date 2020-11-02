using System;
using System.Collections.Generic;

namespace LinqFasterer
{
	public static partial class LinqFasterer
	{
		/// <summary>Produces the set union of two sequences.</summary>
		/// <returns>A sequence that contains the elements from both input sequences, excluding duplicates.</returns>
		/// <param name="first">The first set for the union.</param>
		/// <param name="second">The second set for the union.</param>
		/// <param name="comparer">Optional equality comparer, falls back to default when set to null.</param>
		public static IList<TSource> UnionF<TSource>(this IList<TSource> first, IList<TSource> second, IEqualityComparer<TSource>? comparer = null)
		{
			comparer ??= EqualityComparer<TSource>.Default;

			var result = new TSource[first.Count + second.Count];
			int resultSize;

			first.CopyTo(result, 0);
			second.CopyTo(result, first.Count);

			// The following code runs faster on smaller workloads
			// The magic number is a result of multiple benchmark tests
			if (result.Length < 2000)
			{
				var resultHashSet = new HashSet<TSource>(result, comparer);
				resultSize = resultHashSet.Count;

				resultHashSet.CopyTo(result, 0, resultSize);
			}
			else
			{
				var resultHashSet = new HashSet<TSource>(comparer);
				resultSize = 0;

				for (var i = 0; i<result.Length; i++)
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