using System;
using System.Collections.Generic;

namespace LinqFasterer
{
	public static partial class LinqFasterer
	{
		/// <summary>Returns distinct elements from a sequence by using a specified equality comparer to compare values.</summary>
		/// <returns>A sequence that contains distinct elements from the source sequence.</returns>
		/// <param name="source">The sequence to remove duplicate elements from.</param>
		/// <param name="comparer">An equality comparer to compare values.</param>
		public static IList<TSource> DistinctF<TSource>(this IList<TSource> source, IEqualityComparer<TSource>? comparer = null)
		{
			var sourceArray = source.ToArrayF();
			var sourceLength = sourceArray.Length;

			comparer ??= EqualityComparer<TSource>.Default;

			TSource[] result;

			// The following code runs faster on smaller workloads
			// The magic number is a result of multiple benchmark tests
			if (sourceLength < 2500)
			{
				var resultHashSet = new HashSet<TSource>(sourceArray, comparer);
				var resultSize = resultHashSet.Count;

				result = new TSource[resultSize];
				resultHashSet.CopyTo(result, 0, resultSize);
			}
			else
			{
				var resultHashSet = new HashSet<TSource>(comparer);
				var resultSize = 0;

				result = new TSource[sourceLength];

				for (var i = 0; i < sourceLength; i++)
				{
					var value = sourceArray[i];

					if (!resultHashSet.Contains(value))
					{
						resultHashSet.Add(value);
						result[resultSize++] = value;
					}
				}

				Array.Resize(ref result, resultSize);
			}

			return result;
		}
	}
}