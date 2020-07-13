using System;
using System.Collections.Generic;

namespace JM.LinqFaster
{
    /// <summary>
    /// Provides faster array and list specific extension methods with
    /// the same semantics as the Linq extensions methods.
    /// </summary>
    public static partial class LinqFaster
    {
        /// <summary>Applies an accumulator function over a sequence.</summary>
        /// <returns>The final accumulator value.</returns>
        /// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to aggregate over.</param>
        /// <param name="func">An accumulator function to be invoked on each element.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        public static TSource AggregateF<TSource>(this IReadOnlyList<TSource> source, Func<TSource, TSource, TSource> func)
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
        public static TAccumulate AggregateF<TSource, TAccumulate>(this IReadOnlyList<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func)
        {
            if (source == null)
                throw Error.ArgumentNull(nameof(source));

            if (func == null)
                throw Error.ArgumentNull(nameof(func));

            var result = seed;

            foreach (var v in source)
                result = func(result, v);

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
        public static TResult AggregateF<TSource, TAccumulate, TResult>(this IReadOnlyList<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func, Func<TAccumulate, TResult> resultSelector)
        {
            if (source == null)
                throw Error.ArgumentNull(nameof(source));

            if (func == null)
                throw Error.ArgumentNull(nameof(func));

            if (resultSelector == null)
                throw Error.ArgumentNull(nameof(resultSelector));

            var result = seed;

            foreach (var v in source)
                result = func(result, v);

            return resultSelector(result);
        }
    }
}