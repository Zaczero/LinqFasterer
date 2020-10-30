using System;
using System.Collections.Generic;
using LinqFasterer.Utils;

namespace LinqFasterer
{
	public static partial class LinqFasterer
	{
		/// <summary>Produces the set union of two sequences by using a specified <see cref="T:System.Collections.Generic.IEqualityComparer`1" />.</summary>
		/// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> that contains the elements from both input sequences, excluding duplicates.</returns>
		/// <param name="first">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> whose distinct elements form the first set for the union.</param>
		/// <param name="second">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> whose distinct elements form the second set for the union.</param>
		/// <param name="comparer">The <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> to compare values.</param>
		/// <typeparam name="TSource">The type of the elements of the input sequences.</typeparam>
		public static IList<TSource> UnionF<TSource>(this IList<TSource> first, IList<TSource> second, IEqualityComparer<TSource> comparer = null)
		{
			if (first == null)
				throw Error.ArgumentNull(nameof(first));

			if (second == null)
				throw Error.ArgumentNull(nameof(second));

			if (comparer == null)
				comparer = EqualityComparer<TSource>.Default;

			// TODO: benchmark both versions
			if (first.Count > second.Count)
			{
				var tmp = first;

				first = second;
				second = tmp;
			}

			var firstHashSet = new HashSet<TSource>(first, comparer);
			var result = new TSource[first.Count + second.Count];
			var resultSize = first.Count;

			first.CopyTo(result, 0);

			for (var i = 0; i < second.Count; i++)
				if (!firstHashSet.Contains(second[i]))
					result[resultSize++] = second[i];


			Array.Resize(ref result, resultSize);

			return result;
		}
	}
}