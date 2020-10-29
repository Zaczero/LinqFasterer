using System;
using System.Collections.Generic;

namespace JM.LinqFaster
{
	public static partial class LinqFaster
	{
		/// <summary>Sorts the elements of a sequence in ascending order by using a specified comparer.</summary>
		/// <returns>An <see cref="T:System.Linq.IOrderedEnumerable`1" /> whose elements are sorted according to a key.</returns>
		/// <param name="source">A sequence of values to order.</param>
		/// <param name="keySelector">A function to extract a key from an element.</param>
		/// <param name="comparer">An <see cref="T:System.Collections.Generic.IComparer`1" /> to compare keys.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <typeparam name="TKey">The type of the key returned by <paramref name="keySelector" />.</typeparam>
		public static IList<TSource> OrderByF<TSource, TKey>(this IList<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey> comparer = null)
		{
			if (source == null)
				throw Error.ArgumentNull(nameof(source));

			if (keySelector == null)
				throw Error.ArgumentNull(nameof(keySelector));

			if (comparer == null)
				comparer = Comparer<TKey>.Default;

			var keys = new TKey[source.Count];
			var result = new TSource[source.Count];

			for (var i = 0; i < source.Count; i++)
			{
				keys[i] = keySelector(source[i]);
				result[i] = source[i];
			}

			Array.Sort(keys, result, comparer);

			return result;
		}

		/// <summary>Sorts the elements of a sequence in descending order by using a specified comparer.</summary>
		/// <returns>An <see cref="T:System.Linq.IOrderedEnumerable`1" /> whose elements are sorted in descending order according to a key.</returns>
		/// <param name="source">A sequence of values to order.</param>
		/// <param name="keySelector">A function to extract a key from an element.</param>
		/// <param name="comparer">An <see cref="T:System.Collections.Generic.IComparer`1" /> to compare keys.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <typeparam name="TKey">The type of the key returned by <paramref name="keySelector" />.</typeparam>
		public static IList<TSource> OrderByDescendingF<TSource, TKey>(this IList<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey> comparer = null)
		{
			return source.OrderByF(keySelector, comparer).ReverseInPlaceF();
		}
	}
}