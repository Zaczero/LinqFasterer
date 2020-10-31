using System;
using System.Collections.Generic;
using LinqFasterer.Utils;

namespace LinqFasterer
{
	public static partial class LinqFasterer
	{
		/// <summary>Bypasses a specified number of elements in a sequence and then returns the remaining elements.</summary>
		/// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> that contains the elements that occur after the specified index in the input sequence.</returns>
		/// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to return elements from.</param>
		/// <param name="count">The number of elements to skip before returning the remaining elements.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		public static IList<TSource> SkipF<TSource>(this IList<TSource> source, int count)
		{
			if (source == null)
				throw Error.ArgumentNull(nameof(source));

			if (count > source.Count)
				return EmptyF<TSource>();

			if (count < 0)
				count = 0;

			var result = new TSource[source.Count - count];

			for (var i = count; i < source.Count; i++)
				result[i - count] = source[i];

			return result;
		}

		/// <summary>Bypasses a specified number of last elements in a sequence and then returns the remaining elements.</summary>
		/// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> that contains the elements that occur before the specified index in the input sequence.</returns>
		/// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to return elements from.</param>
		/// <param name="count">The number of elements to skip before returning the remaining elements.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		public static IList<TSource> SkipLastF<TSource>(this IList<TSource> source, int count)
		{
			if (source == null)
				throw Error.ArgumentNull(nameof(source));

			if (count > source.Count)
				return EmptyF<TSource>();

			if (count < 0)
				count = 0;

			var resultLenght = source.Count - count;
			var result = new TSource[resultLenght];

			for (var i = 0; i < resultLenght; i++)
				result[i] = source[i];

			return result;
		}

		/// <summary>Bypasses elements in a sequence as long as a specified condition is true and then returns the remaining elements.</summary>
		/// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> that contains the elements from the input sequence starting at the first element in the linear series that does not pass the test specified by <paramref name="predicate" />.</returns>
		/// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to return elements from.</param>
		/// <param name="predicate">A function to test each element for a condition.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		public static IList<TSource> SkipWhileF<TSource>(this IList<TSource> source, Func<TSource, bool> predicate)
		{
			if (source == null)
				throw Error.ArgumentNull(nameof(source));

			if (predicate == null)
				throw Error.ArgumentNull(nameof(predicate));

			var count = 0;

			for (; count < source.Count; count++)
				if (!predicate(source[count]))
					break;

			return source.SkipF(count);
		}

		/// <summary>Bypasses elements in a sequence as long as a specified condition is true and then returns the remaining elements.</summary>
		/// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> that contains the elements from the input sequence starting at the first element in the linear series that does not pass the test specified by <paramref name="predicate" />.</returns>
		/// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to return elements from.</param>
		/// <param name="predicate">A function to test each element for a condition.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		public static IList<TSource> SkipWhileF<TSource>(this IList<TSource> source, Func<TSource, int, bool> predicate)
		{
			if (source == null)
				throw Error.ArgumentNull(nameof(source));

			if (predicate == null)
				throw Error.ArgumentNull(nameof(predicate));

			var count = 0;

			for (; count < source.Count; count++)
				if (!predicate(source[count], count))
					break;

			return source.SkipF(count);
		}
	}
}
