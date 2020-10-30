using System.Collections.Generic;
using LinqFasterer.Utils;

namespace LinqFasterer
{
	public static partial class LinqFasterer
	{
		/// <summary>Determines whether two sequences are equal by comparing their elements by using a specified <see cref="T:System.Collections.Generic.IEqualityComparer`1" />.</summary>
		/// <returns>true if the two source sequences are of equal length and their corresponding elements compare equal according to <paramref name="comparer" />; otherwise, false.</returns>
		/// <param name="first">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to compare to <paramref name="second" />.</param>
		/// <param name="second">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to compare to the first sequence.</param>
		/// <param name="comparer">An <see cref="T:System.Collections.Generic.IEqualityComparer`1" /> to use to compare elements.</param>
		/// <typeparam name="TSource">The type of the elements of the input sequences.</typeparam>
		public static bool SequenceEqualF<TSource>(this IList<TSource> first, IList<TSource> second, IEqualityComparer<TSource> comparer = null)
		{
			if (first == null)
				throw Error.ArgumentNull(nameof(first));

			if (second == null)
				throw Error.ArgumentNull(nameof(second));

			if (comparer == null)
				comparer = EqualityComparer<TSource>.Default;

			if (first.Count != second.Count)
				return false;

			// ReSharper disable once PossibleUnintendedReferenceComparison
			if (first == second)
				return true;

			for (var i = 0; i < first.Count; i++)
				if (!comparer.Equals(first[i], second[i]))
					return false;

			return true;
		}

		/// <summary>Determines whether two sequences are equal by comparing their elements by using a specified <see cref="T:System.Collections.Generic.IComparer`1" />.</summary>
		/// <returns>An array of integers, where the value corresponds to IComparer.Compare indicating less than, greater than, or equals</returns>
		/// <param name="first">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to compare to <paramref name="second" />.</param>
		/// <param name="second">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to compare to the first sequence.</param>
		/// <param name="comparer">An <see cref="T:System.Collections.Generic.IComparer`1" /> to use to compare elements.</param>
		/// <typeparam name="TSource">The type of the elements of the input sequences.</typeparam>
		public static int[] SequenceCompareF<TSource>(this IList<TSource> first, IList<TSource> second, IComparer<TSource> comparer = null)
		{
			if (first == null)
				throw Error.ArgumentNull(nameof(first));

			if (second == null)
				throw Error.ArgumentNull(nameof(second));

			if (comparer == null)
				comparer = Comparer<TSource>.Default;

			if (first.Count != second.Count)
				throw Error.NotSupported();

			var result = new int[first.Count];

			// ReSharper disable once PossibleUnintendedReferenceComparison
			if (first == second)
				return result;

			for (var i = 0; i < first.Count; i++)
				result[i] = comparer.Compare(first[i], second[i]);

			return result;
		}
	}
}
