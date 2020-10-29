using System;
using System.Collections.Generic;

namespace JM.LinqFaster
{
	public static partial class LinqFaster
	{
		/// <summary>Returns the minimum value in a generic sequence.</summary>
		/// <returns>The minimum value in the sequence.</returns>
		/// <param name="source">A sequence of values to determine the minimum value of.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		public static TSource MinF<TSource>(this IList<TSource> source)
		{
			if (source == null)
				throw Error.ArgumentNull(nameof(source));

			if (source.Count == 0)
				throw Error.NoElements();

			var comparer = Comparer<TSource>.Default;
			var result = source[0];

			if (default(TSource) == null)
			{
				for (var i = 1; i < source.Count; i++)
					if (source[i] != null && comparer.Compare(source[i], result) < 0)
						result = source[i];
			}
			else
			{
				for (var i = 1; i < source.Count; i++)
					if (comparer.Compare(source[i], result) < 0)
						result = source[i];
			}

			return result;
		}

		/// <summary>Invokes a transform function on each element of a generic sequence and returns the minimum resulting value.</summary>
		/// <returns>The minimum value in the sequence.</returns>
		/// <param name="source">A sequence of values to determine the minimum value of.</param>
		/// <param name="selector">A transform function to apply to each element.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <typeparam name="TResult">The type of the value returned by <paramref name="selector" />.</typeparam>
		public static TResult MinF<TSource, TResult>(this IList<TSource> source, Func<TSource, TResult> selector)
		{
			if (source == null)
				throw Error.ArgumentNull(nameof(source));

			if (selector == null)
				throw Error.ArgumentNull(nameof(selector));

			if (source.Count == 0)
				throw Error.NoElements();

			var comparer = Comparer<TResult>.Default;
			var result = selector(source[0]);

			if (default(TSource) == null)
			{
				for (var i = 1; i < source.Count; i++)
				{
					if (source[i] == null)
						continue;

					var value = selector(source[i]);

					if (comparer.Compare(value, result) < 0)
						result = value;
				}
			}
			else
			{
				for (var i = 1; i < source.Count; i++)
				{
					var value = selector(source[i]);

					if (comparer.Compare(value, result) < 0)
						result = value;
				}
			}

			return result;
		}
	}
}
