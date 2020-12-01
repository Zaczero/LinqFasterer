using System;
using System.Collections.Generic;
using LinqFasterer.Utils;

namespace LinqFasterer
{
	public static partial class LinqFasterer
	{
		/// <summary>Returns a specified number of contiguous elements from the start of a sequence.</summary>
		/// <returns>A sequence that contains the specified number of elements from the start of the input sequence.</returns>
		/// <param name="source">The sequence to return elements from.</param>
		/// <param name="count">The number of elements to return.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		public static IList<TSource> TakeF<TSource>(this IList<TSource> source, int count)
		{
			if (source == null)
				throw Error.ArgumentNull(nameof(source));

			if (count < 0)
				return EmptyF<TSource>();

			if (count > source.Count)
				count = source.Count;

			var result = new TSource[count];

			for (var i = 0; i < count; i++)
				result[i] = source[i];

			return result;
		}

		/// <summary>Returns a specified number of contiguous elements from the end of a sequence.</summary>
		/// <returns>A sequence that contains the specified number of elements from the end of the input sequence.</returns>
		/// <param name="source">The sequence to return elements from.</param>
		/// <param name="count">The number of elements to return.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		public static IList<TSource> TakeLastF<TSource>(this IList<TSource> source, int count)
		{
			if (source == null)
				throw Error.ArgumentNull(nameof(source));

			if (count < 0)
				return EmptyF<TSource>();

			if (count > source.Count)
				count = source.Count;

			var result = new TSource[count];

			for (var i = 0; i < count; i++)
				result[i] = source[source.Count - count + i];

			return result;
		}

		/// <summary>
		/// Returns elements from a sequence as long as a specified condition is true.
		/// </summary>
		/// <param name="source">A sequence to return elements from.</param>
		/// <param name="predicate">A function to test each element for a condition.</param>
		/// <returns>A sequence that contains the elements from the input sequence that occur before the element at which the test no longer passes.</returns>
		public static IList<TSource> TakeWhileF<TSource>(this IList<TSource> source, Func<TSource, bool> predicate)
		{
			if (source == null)
				throw Error.ArgumentNull(nameof(source));

			if (predicate == null)
				throw Error.ArgumentNull(nameof(predicate));

			var count = 0;

			for (; count < source.Count; count++)
				if (!predicate(source[count]))
					break;

			return source.TakeF(count);
		}

		/// <summary>
		/// Returns elements from a sequence as long as a specified condition is true.
		/// </summary>
		/// <param name="source">A sequence to return elements from.</param>
		/// <param name="predicate">A function to test each element for a condition.</param>
		/// <returns>A sequence that contains the elements from the input sequence that occur before the element at which the test no longer passes.</returns>
		public static IList<TSource> TakeWhileF<TSource>(this IList<TSource> source, Func<TSource, int, bool> predicate)
		{
			if (source == null)
				throw Error.ArgumentNull(nameof(source));

			if (predicate == null)
				throw Error.ArgumentNull(nameof(predicate));

			var count = 0;

			for (; count < source.Count; count++)
				if (!predicate(source[count], count))
					break;

			return source.TakeF(count);
		}
	}
}