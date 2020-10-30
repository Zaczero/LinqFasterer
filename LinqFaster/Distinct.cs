using System;
using System.Collections.Generic;
using LinqFasterer.Utils;

namespace LinqFasterer
{
	public static partial class LinqFasterer
	{
		/// <summary>Returns distinct elements from a sequence by using a specified <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> to compare values.</summary>
		/// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> that contains distinct elements from the source sequence.</returns>
		/// <param name="source">The sequence to remove duplicate elements from.</param>
		/// <param name="comparer">An <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> to compare values.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		public static IList<TSource> DistinctF<TSource>(this IList<TSource> source, IEqualityComparer<TSource> comparer = null)
		{
			if (source == null)
				throw Error.ArgumentNull(nameof(source));

			if (comparer == null)
				comparer = EqualityComparer<TSource>.Default;

			var resultHashSet = new HashSet<TSource>(comparer);
			var result = new TSource[source.Count];
			var resultSize = 0;

			for (var i = 0; i < source.Count; i++)
				if (!resultHashSet.Contains(source[i]))
				{
					resultHashSet.Add(source[i]);
					result[resultSize++] = source[i];
				}


			Array.Resize(ref result, resultSize);

			return result;
		}
	}
}