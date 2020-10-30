using System;
using System.Collections.Generic;
using LinqFasterer.Utils;

namespace LinqFasterer
{
	/// <summary>
	/// Provides faster array and list specific extension methods with the same semantics as the Linq extensions methods.
	/// </summary>
	public static partial class LinqFasterer
	{
		/// <summary>Applies an accumulator function over a sequence.</summary>
		/// <returns>The final accumulator value.</returns>
		/// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to aggregate over.</param>
		/// <param name="func">An accumulator function to be invoked on each element.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		public static TSource AggregateF<TSource>(this IList<TSource> source, Func<TSource, TSource, TSource> func)
		{
			if (source == null)
				throw Error.ArgumentNull(nameof(source));

			if (func == null)
				throw Error.ArgumentNull(nameof(func));

			if (source.Count == 0)
				throw Error.NoElements();

			var result = source[0];

			for (var i = 1; i < source.Count; i++)
				result = func(result, source[i]);

			return result;
		}

		/// <summary>Applies an accumulator function over a sequence. The specified seed value is used as the initial accumulator value.</summary>
		/// <returns>The final accumulator value.</returns>
		/// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to aggregate over.</param>
		/// <param name="seed">The initial accumulator value.</param>
		/// <param name="func">An accumulator function to be invoked on each element.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <typeparam name="TAccumulate">The type of the accumulator value.</typeparam>
		public static TAccumulate AggregateF<TSource, TAccumulate>(this IList<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func)
		{
			if (source == null)
				throw Error.ArgumentNull(nameof(source));

			if (func == null)
				throw Error.ArgumentNull(nameof(func));

			var result = seed;

			for (var i = 0; i < source.Count; i++)
				result = func(result, source[i]);

			return result;
		}

		/// <summary>Applies an accumulator function over a sequence. The specified seed value is used as the initial accumulator value, and the specified function is used to select the result value.</summary>
		/// <returns>The transformed final accumulator value.</returns>
		/// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to aggregate over.</param>
		/// <param name="seed">The initial accumulator value.</param>
		/// <param name="func">An accumulator function to be invoked on each element.</param>
		/// <param name="resultSelector">A function to transform the final accumulator value into the result value.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		/// <typeparam name="TAccumulate">The type of the accumulator value.</typeparam>
		/// <typeparam name="TResult">The type of the resulting value.</typeparam>
		public static TResult AggregateF<TSource, TAccumulate, TResult>(this IList<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func, Func<TAccumulate, TResult> resultSelector)
		{
			if (resultSelector == null)
				throw Error.ArgumentNull(nameof(resultSelector));

			var result = AggregateF(source, seed, func);

			return resultSelector(result);
		}
	}
}