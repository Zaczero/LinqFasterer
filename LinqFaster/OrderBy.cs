using System;
using System.Collections.Generic;

namespace LinqFasterer
{
	public static partial class LinqFasterer
	{
		/// <summary>Sorts the elements of a sequence in ascending order by using a specified comparer.</summary>
		/// <returns>A sequence whose elements are sorted according to a key.</returns>
		/// <param name="source">A sequence of values to order.</param>
		/// <param name="keySelector">A function to extract a key from an element.</param>
		/// <param name="comparer">A comparer to compare keys.</param>
		public static IList<TSource> OrderByF<TSource, TKey>(this IList<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey>? comparer = null)
		{
			comparer ??= Comparer<TKey>.Default;

			var sourceArray = source.ToArrayF(true);
			var sourceLength = sourceArray.Length;

			var keys = new TKey[sourceLength];

			for (var i = 0; i < sourceLength; i++)
				keys[i] = keySelector(sourceArray[i]);

			Array.Sort(keys, sourceArray, comparer);

			return sourceArray;
		}

		/// <summary>Sorts the elements of a sequence in descending order by using a specified comparer.</summary>
		/// <returns>A sequence whose elements are sorted in descending order according to a key.</returns>
		/// <param name="source">A sequence of values to order.</param>
		/// <param name="keySelector">A function to extract a key from an element.</param>
		/// <param name="comparer">A comparer to compare keys.</param>
		public static IList<TSource> OrderByDescendingF<TSource, TKey>(this IList<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey>? comparer = null)
		{
			return source.OrderByF(keySelector, comparer).ReverseF();
		}
	}
}