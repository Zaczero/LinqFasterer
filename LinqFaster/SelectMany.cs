using System;
using System.Collections.Generic;

namespace JM.LinqFaster
{
	public static partial class LinqFaster
	{
		/// <summary>Projects each element of a sequence to an <see cref="T:System.Collections.Generic.IEnumerable`1" /> and flattens the resulting sequences into one sequence.</summary>
		/// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> whose elements are the result of invoking the one-to-many transform function on each element of the input sequence.</returns>
		/// <param name="source">A sequence of values to project.</param>
		/// <param name="selector">A transform function to apply to each element.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <typeparam name="TResult">The type of the elements of the sequence returned by <paramref name="selector" />.</typeparam>
		public static IList<TResult> SelectManyF<TSource, TResult>(this IList<TSource> source, Func<TSource, IList<TResult>> selector)
		{
			if (source == null)
				throw Error.ArgumentNull(nameof(source));

			if (selector == null)
				throw Error.ArgumentNull(nameof(selector));

			var result = new List<TResult>();

			for (var i = 0; i < source.Count; i++)
			{
				var valueArray = selector(source[i]);

				for (var j = 0; j < valueArray.Count; j++)
					result.Add(valueArray[j]);
			}

			return result;
		}

		/// <summary>Projects each element of a sequence to an <see cref="T:System.Collections.Generic.IEnumerable`1" /> and flattens the resulting sequences into one sequence.</summary>
		/// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> whose elements are the result of invoking the one-to-many transform function on each element of the input sequence.</returns>
		/// <param name="source">A sequence of values to project.</param>
		/// <param name="selector">A transform function to apply to each element.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <typeparam name="TResult">The type of the elements of the sequence returned by <paramref name="selector" />.</typeparam>
		public static IList<TResult> SelectManyF<TSource, TResult>(this IList<TSource> source, Func<TSource, int, IList<TResult>> selector)
		{
			if (source == null)
				throw Error.ArgumentNull(nameof(source));

			if (selector == null)
				throw Error.ArgumentNull(nameof(selector));

			var result = new List<TResult>();

			for (var i = 0; i < source.Count; i++)
			{
				var valueArray = selector(source[i], i);

				for (var j = 0; j < valueArray.Count; j++)
					result.Add(valueArray[j]);
			}

			return result;
		}
	}
}
