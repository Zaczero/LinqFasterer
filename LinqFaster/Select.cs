using System;
using System.Collections.Generic;

namespace JM.LinqFaster
{
	public static partial class LinqFaster
	{
		/// <summary>Projects each element of a sequence into a new form.</summary>
		/// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> whose elements are the result of invoking the transform function on each element of <paramref name="source" />.</returns>
		/// <param name="source">A sequence of values to invoke a transform function on.</param>
		/// <param name="selector">A transform function to apply to each element.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <typeparam name="TResult">The type of the value returned by <paramref name="selector" />.</typeparam>
		public static IList<TResult> SelectF<TSource, TResult>(this IList<TSource> source, Func<TSource, TResult> selector)
		{
			if (source == null)
				throw Error.ArgumentNull(nameof(source));

			if (selector == null)
				throw Error.ArgumentNull(nameof(selector));

			var result = new TResult[source.Count];

			for (var i = 0; i < source.Count; i++)
				result[i] = selector(source[i]);

			return result;
		}

		/// <summary>Projects each element of a sequence into a new form by incorporating the element's index.</summary>
		/// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> whose elements are the result of invoking the transform function on each element of <paramref name="source" />.</returns>
		/// <param name="source">A sequence of values to invoke a transform function on.</param>
		/// <param name="selector">A transform function to apply to each source element; the second parameter of the function represents the index of the source element.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <typeparam name="TResult">The type of the value returned by <paramref name="selector" />.</typeparam>
		public static IList<TResult> SelectF<TSource, TResult>(this IList<TSource> source, Func<TSource, int, TResult> selector)
		{
			if (source == null)
				throw Error.ArgumentNull(nameof(source));

			if (selector == null)
				throw Error.ArgumentNull(nameof(selector));

			var result = new TResult[source.Count];

			for (var i = 0; i < source.Count; i++)
				result[i] = selector(source[i], i);

			return result;
		}

		/// <summary>Projects each element of a sequence into a new form.</summary>
		/// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> whose elements are the result of invoking the transform function on each element of <paramref name="source" />.</returns>
		/// <param name="source">A sequence of values to invoke a transform function on.</param>
		/// <param name="selector">A transform function to apply to each element.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		public static IList<TSource> SelectInPlaceF<TSource>(this IList<TSource> source, Func<TSource, TSource> selector)
		{
			if (source == null)
				throw Error.ArgumentNull(nameof(source));

			if (selector == null)
				throw Error.ArgumentNull(nameof(selector));

			for (var i = 0; i < source.Count; i++)
				source[i] = selector(source[i]);

			return source;
		}

		/// <summary>Projects each element of a sequence into a new form by incorporating the element's index.</summary>
		/// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> whose elements are the result of invoking the transform function on each element of <paramref name="source" />.</returns>
		/// <param name="source">A sequence of values to invoke a transform function on.</param>
		/// <param name="selector">A transform function to apply to each source element; the second parameter of the function represents the index of the source element.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		public static IList<TSource> SelectInPlaceF<TSource>(this IList<TSource> source, Func<TSource, int, TSource> selector)
		{
			if (source == null)
				throw Error.ArgumentNull(nameof(source));

			if (selector == null)
				throw Error.ArgumentNull(nameof(selector));

			for (var i = 0; i < source.Count; i++)
				source[i] = selector(source[i], i);

			return source;
		}
	}
}
