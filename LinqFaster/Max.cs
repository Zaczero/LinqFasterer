using System;
using System.Collections.Generic;
using LinqFasterer.Utils;

namespace LinqFasterer
{
	public static partial class LinqFasterer
	{
		/// <summary>Returns the maximum value in a generic sequence.</summary>
		/// <returns>The maximum value in the sequence.</returns>
		/// <param name="source">A sequence of values to determine the maximum value of.</param>
		public static TSource MaxF<TSource>(this IList<TSource> source)
		{
			var sourceArr = source.ToArrayF();
			var sourceLength = sourceArr.Length;
			if (sourceLength == 0)
				throw Error.NoElements();

			var comparer = Comparer<TSource>.Default;
			var result = sourceArr[0];

			if (default(TSource) == null)
			{
				for (var i = 1; i < sourceLength; i++)
				{
					if (sourceArr[i] == null)
						continue;

					var value = sourceArr[i];

					if (comparer.Compare(value, result) > 0)
						result = value;
				}
			}
			else
			{
				for (var i = 1; i < sourceLength; i++)
				{
					var value = sourceArr[i];

					if (comparer.Compare(value, result) > 0)
						result = value;
				}
			}

			return result;
		}

		/// <summary>Invokes a transform function on each element of a generic sequence and returns the maximum resulting value.</summary>
		/// <returns>The maximum value in the sequence.</returns>
		/// <param name="source">A sequence of values to determine the maximum value of.</param>
		/// <param name="selector">A transform function to apply to each element.</param>
		public static TResult MaxF<TSource, TResult>(this IList<TSource> source, Func<TSource, TResult> selector)
		{
			var sourceArr = source.ToArrayF();
			var sourceLength = sourceArr.Length;
			if (sourceLength == 0)
				throw Error.NoElements();

			var comparer = Comparer<TResult>.Default;
			var result = selector(sourceArr[0]);

			if (default(TSource) == null)
			{
				for (var i = 1; i < sourceLength; i++)
				{
					if (sourceArr[i] == null)
						continue;

					var value = selector(sourceArr[i]);

					if (comparer.Compare(value, result) > 0)
						result = value;
				}
			}
			else
			{
				for (var i = 1; i < sourceLength; i++)
				{
					var value = selector(sourceArr[i]);

					if (comparer.Compare(value, result) > 0)
						result = value;
				}
			}

			return result;
		}
	}
}
