using System;
using System.Collections.Generic;

namespace JM.LinqFaster
{
    public static partial class LinqFaster
    {
        /// <summary>Computes the average of a sequence of <see cref="T:System.Int32" /> values.</summary>
        /// <returns>The average of the sequence of values.</returns>
        /// <param name="source">A sequence of <see cref="T:System.Int32" /> values to calculate the average of.</param>
        public static double AverageF(this IReadOnlyList<int> source)
        {
            if (source == null)
                throw Error.ArgumentNull(nameof(source));

            if (source.Count == 0)
                throw Error.NoElements();

            return (double) source.SumF() / source.Count;
        }

        /// <summary>Computes the average of a sequence of <see cref="T:System.Int64" /> values.</summary>
        /// <returns>The average of the sequence of values.</returns>
        /// <param name="source">A sequence of <see cref="T:System.Int64" /> values to calculate the average of.</param>
        public static double AverageF(this IReadOnlyList<long> source)
        {
            if (source == null)
                throw Error.ArgumentNull(nameof(source));

            if (source.Count == 0)
                throw Error.NoElements();

            return (double) source.SumF() / source.Count;
        }

        /// <summary>Computes the average of a sequence of <see cref="T:System.Single" /> values.</summary>
        /// <returns>The average of the sequence of values.</returns>
        /// <param name="source">A sequence of <see cref="T:System.Single" /> values to calculate the average of.</param>
        public static float AverageF(this IReadOnlyList<float> source)
        {
            if (source == null)
                throw Error.ArgumentNull(nameof(source));

            if (source.Count == 0)
                throw Error.NoElements();

            var sum = 0.0;

            foreach (var v in source)
                sum += v;

            return (float) (sum / source.Count);
        }

        /// <summary>Computes the average of a sequence of <see cref="T:System.Double" /> values.</summary>
        /// <returns>The average of the sequence of values.</returns>
        /// <param name="source">A sequence of <see cref="T:System.Double" /> values to calculate the average of.</param>
        public static double AverageF(this IReadOnlyList<double> source)
        {
            if (source == null)
                throw Error.ArgumentNull(nameof(source));

            if (source.Count == 0)
                throw Error.NoElements();

            return source.SumF() / source.Count;
        }

        /// <summary>Computes the average of a sequence of <see cref="T:System.Decimal" /> values.</summary>
        /// <returns>The average of the sequence of values.</returns>
        /// <param name="source">A sequence of <see cref="T:System.Decimal" /> values to calculate the average of.</param>
        public static decimal AverageF(this IReadOnlyList<decimal> source)
        {
            if (source == null)
                throw Error.ArgumentNull(nameof(source));

            if (source.Count == 0)
                throw Error.NoElements();

            return source.SumF() / source.Count;
        }

        /// <summary>Computes the average of a sequence of <see cref="T:System.Int32" /> values that are obtained by invoking a transform function on each element of the input sequence.</summary>
        /// <returns>The average of the sequence of values.</returns>
        /// <param name="source">A sequence of values to calculate the average of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        public static double AverageF<TSource>(this IReadOnlyList<TSource> source, Func<TSource, int> selector)
        {
            if (source == null)
                throw Error.ArgumentNull(nameof(source));

            if (source.Count == 0)
                throw Error.NoElements();

            if (selector == null)
                throw Error.ArgumentNull(nameof(selector));

            return (double) source.SumF(selector) / source.Count;
        }

        /// <summary>Computes the average of a sequence of <see cref="T:System.Int64" /> values that are obtained by invoking a transform function on each element of the input sequence.</summary>
        /// <returns>The average of the sequence of values.</returns>
        /// <param name="source">A sequence of values to calculate the average of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        public static double AverageF<TSource>(this IReadOnlyList<TSource> source, Func<TSource, long> selector)
        {
            if (source == null)
                throw Error.ArgumentNull(nameof(source));

            if (source.Count == 0)
                throw Error.NoElements();

            if (selector == null)
                throw Error.ArgumentNull(nameof(selector));

            return (double) source.SumF(selector) / source.Count;
        }

        /// <summary>Computes the average of a sequence of <see cref="T:System.Single" /> values that are obtained by invoking a transform function on each element of the input sequence.</summary>
        /// <returns>The average of the sequence of values.</returns>
        /// <param name="source">A sequence of values to calculate the average of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        public static float AverageF<TSource>(this IReadOnlyList<TSource> source, Func<TSource, float> selector)
        {
            if (source == null)
                throw Error.ArgumentNull(nameof(source));

            if (source.Count == 0)
                throw Error.NoElements();

            if (selector == null)
                throw Error.ArgumentNull(nameof(selector));

            var sum = 0.0;

            foreach (var v in source)
                sum += selector(v);

            return (float) (sum / source.Count);
        }
        /// <summary>Computes the average of a sequence of <see cref="T:System.Double" /> values that are obtained by invoking a transform function on each element of the input sequence.</summary>
        /// <returns>The average of the sequence of values.</returns>
        /// <param name="source">A sequence of values to calculate the average of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        public static double AverageF<TSource>(this IReadOnlyList<TSource> source, Func<TSource, double> selector)
        {
            if (source == null)
                throw Error.ArgumentNull(nameof(source));

            if (source.Count == 0)
                throw Error.NoElements();

            if (selector == null)
                throw Error.ArgumentNull(nameof(selector));

            return source.SumF(selector) / source.Count;
        }
        /// <summary>Computes the average of a sequence of <see cref="T:System.Decimal" /> values that are obtained by invoking a transform function on each element of the input sequence.</summary>
        /// <returns>The average of the sequence of values.</returns>
        /// <param name="source">A sequence of values to calculate the average of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        public static decimal AverageF<TSource>(this IReadOnlyList<TSource> source, Func<TSource, decimal> selector)
        {
            if (source == null)
                throw Error.ArgumentNull(nameof(source));

            if (source.Count == 0)
                throw Error.NoElements();

            if (selector == null)
                throw Error.ArgumentNull(nameof(selector));

            return source.SumF(selector) / source.Count;
        }
    }
}