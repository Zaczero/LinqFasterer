using System;
using System.Collections.Generic;
using LinqFasterer.Utils;

namespace LinqFasterer
{
	public static partial class LinqFasterer
	{
		/// <summary>Returns the only element of a sequence, and throws an exception if there is not exactly one element in the sequence.</summary>
		/// <returns>The single element of the input sequence.</returns>
		/// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to return the single element of.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		public static TSource SingleF<TSource>(this IList<TSource> source)
		{
			if (source == null)
				throw Error.ArgumentNull(nameof(source));

			if (source.Count == 0)
				throw Error.NoElements();

			if (source.Count > 1)
				throw Error.MoreThanOneElement();

			return source[0];
		}

		/// <summary>Returns the only element of a sequence that satisfies a specified condition, and throws an exception if more than one such element exists.</summary>
		/// <returns>The single element of the input sequence that satisfies a condition.</returns>
		/// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to return a single element from.</param>
		/// <param name="predicate">A function to test an element for a condition.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		public static TSource SingleF<TSource>(this IList<TSource> source, Func<TSource, bool> predicate)
		{
			if (source == null)
				throw Error.ArgumentNull(nameof(source));

			if (predicate == null)
				throw Error.ArgumentNull(nameof(predicate));

			if (source.Count == 0)
				throw Error.NoElements();

			var foundAtIndex = -1;

			for (var i = 0; i < source.Count; i++)
				if (predicate(source[i]))
					if (foundAtIndex == -1)
						foundAtIndex = i;
					else
						throw Error.MoreThanOneElement();

			if (foundAtIndex == -1)
				throw Error.NoElements();

			return source[foundAtIndex];
		}

		/// <summary>Returns the only element of a sequence, or a default value if the sequence is empty; this method throws an exception if there is more than one element in the sequence.</summary>
		/// <returns>The single element of the input sequence, or default(<paramref name="TSource" />) if the sequence contains no elements.</returns>
		/// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to return the single element of.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		public static TSource SingleOrDefaultF<TSource>(this IList<TSource> source)
		{
			if (source == null)
				throw Error.ArgumentNull(nameof(source));

			if (source.Count == 0)
				return default;

			if (source.Count > 1)
				throw Error.MoreThanOneElement();

			return source[0];
		}

		/// <summary>Returns the only element of a sequence that satisfies a specified condition or a default value if no such element exists; this method throws an exception if more than one element satisfies the condition.</summary>
		/// <returns>The single element of the input sequence that satisfies the condition, or default(<paramref name="TSource" />) if no such element is found.</returns>
		/// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to return a single element from.</param>
		/// <param name="predicate">A function to test an element for a condition.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		public static TSource SingleOrDefaultF<TSource>(this IList<TSource> source, Func<TSource, bool> predicate)
		{
			if (source == null)
				throw Error.ArgumentNull(nameof(source));

			if (predicate == null)
				throw Error.ArgumentNull(nameof(predicate));

			if (source.Count == 0)
				return default;

			var foundAtIndex = -1;

			for (var i = 0; i < source.Count; i++)
				if (predicate(source[i]))
					if (foundAtIndex == -1)
						foundAtIndex = i;
					else
						throw Error.MoreThanOneElement();

			if (foundAtIndex == -1)
				return default;

			return source[foundAtIndex];
		}
	}
}