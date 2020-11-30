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
			var sourceArray = source.ToArrayF();
			var sourceLength = sourceArray.Length;
			if (sourceLength == 0)
				throw Error.NoElements();

			var result = sourceArray[0];

			if (default(TSource) == null)
			{
				for (var i = 1; i < sourceLength; i++)
				{
					if (sourceArray[i] == null)
						continue;

					var value = sourceArray[i];

					if (Comparer<TSource>.Default.Compare(value, result) > 0)
						result = value;
				}
			}
			else
			{
				for (var i = 1; i < sourceLength; i++)
				{
					var value = sourceArray[i];

					if (Comparer<TSource>.Default.Compare(value, result) > 0)
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
			var sourceArray = source.ToArrayF();
			var sourceLength = sourceArray.Length;
			if (sourceLength == 0)
				throw Error.NoElements();

			var result = selector(sourceArray[0]);

			if (default(TSource) == null)
			{
				for (var i = 1; i < sourceLength; i++)
				{
					if (sourceArray[i] == null)
						continue;

					var value = selector(sourceArray[i]);

					if (Comparer<TResult>.Default.Compare(value, result) > 0)
						result = value;
				}
			}
			else
			{
				for (var i = 1; i < sourceLength; i++)
				{
					var value = selector(sourceArray[i]);

					if (Comparer<TResult>.Default.Compare(value, result) > 0)
						result = value;
				}
			}

			return result;
		}
	}
}
