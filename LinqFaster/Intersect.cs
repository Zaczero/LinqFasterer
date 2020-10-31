using System;
using System.Collections.Generic;
using LinqFasterer.Utils;

namespace LinqFasterer
{
	public static partial class LinqFasterer
	{
		/// <summary>Produces the set intersection of two sequences by using the default equality comparer to compare values.</summary>
		/// <returns>A sequence that contains the elements that form the set intersection of two sequences.</returns>
		/// <param name="first">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> whose distinct elements that also appear in <paramref name="second" /> will be returned.</param>
		/// <param name="second">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> whose distinct elements that also appear in the first sequence will be returned.</param>
		/// <typeparam name="TSource">The type of the elements of the input sequences.</typeparam>
		public static IList<TSource> IntersectF<TSource>(this IList<TSource> first, IList<TSource> second, IEqualityComparer<TSource> comparer = null)
		{
			if (first == null)
				throw Error.ArgumentNull(nameof(first));

			if (second == null)
				throw Error.ArgumentNull(nameof(second));

			if (comparer == null)
				comparer = EqualityComparer<TSource>.Default;

			var secondHashSet = new HashSet<TSource>(second, comparer);
			var resultHashSet = new HashSet<TSource>(comparer);
			var result = new TSource[first.Count];
			var resultSize = 0;

			for (var i = 0; i < first.Count; i++)
			{
				var value = first[i];

				if (secondHashSet.Contains(value) && !resultHashSet.Contains(value))
				{
					result[resultSize++] = value;
					resultHashSet.Add(value);
				}
			}

			Array.Resize(ref result, resultSize);

			return result;
		}
	}
}