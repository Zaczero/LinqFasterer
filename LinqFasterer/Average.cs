using System;
using System.Collections.Generic;
using LinqFasterer.Utils;

namespace LinqFasterer
{
    public static partial class EnumerableF
    {
        /// <summary>Computes the average of a sequence.</summary>
        /// <returns>The average of the sequence of values.</returns>
        /// <param name="source">A sequence to calculate the average of.</param>
        public static double AverageF(this IList<int> source)
        {
            var sourceLength = source.Count;
            if (sourceLength == 0)
                throw Error.NoElements();

            return (double) source.SumF() / sourceLength;
        }

        /// <summary>Computes the average of a sequence.</summary>
        /// <returns>The average of the sequence of values.</returns>
        /// <param name="source">A sequence to calculate the average of.</param>
        public static double AverageF(this IList<long> source)
        {
            var sourceLength = source.Count;
            if (sourceLength == 0)
                throw Error.NoElements();

            return (double) source.SumF() / sourceLength;
        }

        /// <summary>Computes the average of a sequence.</summary>
        /// <returns>The average of the sequence of values.</returns>
        /// <param name="source">A sequence to calculate the average of.</param>
        public static float AverageF(this IList<float> source)
        {
            var sourceLength = source.Count;
            if (sourceLength == 0)
                throw Error.NoElements();

            return source.SumF() / sourceLength;
        }

        /// <summary>Computes the average of a sequence.</summary>
        /// <returns>The average of the sequence of values.</returns>
        /// <param name="source">A sequence to calculate the average of.</param>
        public static double AverageF(this IList<double> source)
        {
            var sourceLength = source.Count;
            if (sourceLength == 0)
                throw Error.NoElements();

            return source.SumF() / sourceLength;
        }

        /// <summary>Computes the average of a sequence.</summary>
        /// <returns>The average of the sequence of values.</returns>
        /// <param name="source">A sequence to calculate the average of.</param>
        public static decimal AverageF(this IList<decimal> source)
        {
            var sourceLength = source.Count;
            if (sourceLength == 0)
                throw Error.NoElements();

            return source.SumF() / sourceLength;
        }

        /// <summary>Computes the average of a sequence that is obtained by invoking a transform function on each element of the input sequence.</summary>
        /// <returns>The average of the sequence of values.</returns>
        /// <param name="source">A sequence of values to calculate the average of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        public static double AverageF<TSource>(this IList<TSource> source, Func<TSource, int> selector)
        {
            var sourceLength = source.Count;
            if (sourceLength == 0)
                throw Error.NoElements();

            return (double) source.SumF(selector) / sourceLength;
        }

        /// <summary>Computes the average of a sequence that is obtained by invoking a transform function on each element of the input sequence.</summary>
        /// <returns>The average of the sequence of values.</returns>
        /// <param name="source">A sequence of values to calculate the average of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        public static double AverageF<TSource>(this IList<TSource> source, Func<TSource, long> selector)
        {
            var sourceLength = source.Count;
            if (sourceLength == 0)
                throw Error.NoElements();

            return (double) source.SumF(selector) / sourceLength;
        }

        /// <summary>Computes the average of a sequence that is obtained by invoking a transform function on each element of the input sequence.</summary>
        /// <returns>The average of the sequence of values.</returns>
        /// <param name="source">A sequence of values to calculate the average of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        public static float AverageF<TSource>(this IList<TSource> source, Func<TSource, float> selector)
        {
            var sourceLength = source.Count;
            if (sourceLength == 0)
                throw Error.NoElements();

            return source.SumF(selector) / sourceLength;
        }

        /// <summary>Computes the average of a sequence that is obtained by invoking a transform function on each element of the input sequence.</summary>
        /// <returns>The average of the sequence of values.</returns>
        /// <param name="source">A sequence of values to calculate the average of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        public static double AverageF<TSource>(this IList<TSource> source, Func<TSource, double> selector)
        {
            var sourceLength = source.Count;
            if (sourceLength == 0)
                throw Error.NoElements();

            return source.SumF(selector) / sourceLength;
        }

        /// <summary>Computes the average of a sequence that is obtained by invoking a transform function on each element of the input sequence.</summary>
        /// <returns>The average of the sequence of values.</returns>
        /// <param name="source">A sequence of values to calculate the average of.</param>
        /// <param name="selector">A transform function to apply to each element.</param>
        public static decimal AverageF<TSource>(this IList<TSource> source, Func<TSource, decimal> selector)
        {
            var sourceLength = source.Count;
            if (sourceLength == 0)
                throw Error.NoElements();

            return source.SumF(selector) / sourceLength;
        }
    }
}