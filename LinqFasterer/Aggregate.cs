using LinqFasterer.Utils;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace LinqFasterer
{
    public static partial class EnumerableF
    {
        /// <summary>
        /// Applies an accumulator function over a sequence.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> to aggregate over.</param>
        /// <param name="func">An accumulator function to be invoked on each element.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <returns>The final accumulator value.</returns>
        public static TSource AggregateF<TSource>(this IList<TSource> source, Func<TSource, TSource, TSource> func)
        {
            var sourceArray = source.ToArrayF();
            var sourceLength = sourceArray.Length;
            if (sourceLength == 0)
                throw Error.NoElements();

            var result = sourceArray[0];

            for (var i = 1; i < sourceLength; i++)
                result = func(result, sourceArray[i]);

            return result;
        }

        /// <summary>
        /// Applies an accumulator function over a sequence. The specified seed value is used as the initial accumulator value.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> to aggregate over.</param>
        /// <param name="seed">An initial accumulator value.</param>
        /// <param name="func">An accumulator function to be invoked on each element.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <typeparam name="TAccumulate">The type of the accumulator value.</typeparam>
        /// <returns>The final accumulator value.</returns>
        public static TAccumulate AggregateF<TSource, TAccumulate>(this IList<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func)
        {
            var sourceArray = source.ToArrayF();
            var sourceLength = sourceArray.Length;

            var result = seed;

            for (var i = 0; i < sourceLength; i++)
                result = func(result, sourceArray[i]);

            return result;
        }

        /// <summary>
        /// Applies an accumulator function over a sequence. The specified seed value is used as the initial accumulator value, and the specified function is used to select the result value.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> to aggregate over.</param>
        /// <param name="seed">An initial accumulator value.</param>
        /// <param name="func">An accumulator function to be invoked on each element.</param>
        /// <param name="resultSelector">A selector function to transform the final accumulator value into the result value.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <typeparam name="TAccumulate">The type of the accumulator value.</typeparam>
        /// <typeparam name="TResult">The type of the resulting value.</typeparam>
        /// <returns>The transformed final accumulator value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static TResult AggregateF<TSource, TAccumulate, TResult>(this IList<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> func, Func<TAccumulate, TResult> resultSelector)
        {
            return resultSelector(AggregateF(source, seed, func));
        }
    }
}