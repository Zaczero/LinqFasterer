using System;
using System.Collections.Generic;

namespace LinqFasterer
{
    public static partial class EnumerableF
    {
        /// <summary>
        /// Computes the sum of a sequence.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> of <see cref="int"/> to calculate the sum of.</param>
        /// <returns>The sum of the values in the sequence.</returns>
        public static int SumF1(this IList<int> source)
        {
            var sourceArray = source.ToArrayF();
            var sourceLength = sourceArray.Length;

            var sum = 0;

            checked
            {
                for (var i = 0; i < sourceLength; i++)
                    sum += sourceArray[i];
            }

            return sum;
        }

        /// <summary>
        /// Computes the sum of a sequence.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> of <see cref="long"/> to calculate the sum of.</param>
        /// <returns>The sum of the values in the sequence.</returns>
        public static long SumF1(this IList<long> source)
        {
            var sourceArray = source.ToArrayF();
            var sourceLength = sourceArray.Length;

            var sum = 0L;

            checked
            {
                for (var i = 0; i < sourceLength; i++)
                    sum += sourceArray[i];
            }

            return sum;
        }

        /// <summary>
        /// Computes the sum of a sequence.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> of <see cref="float"/> to calculate the sum of.</param>
        /// <returns>The sum of the values in the sequence.</returns>
        public static float SumF1(this IList<float> source)
        {
            var sourceArray = source.ToArrayF();
            var sourceLength = sourceArray.Length;

            var sum = 0F;

            for (var i = 0; i < sourceLength; i++)
                sum += sourceArray[i];

            return sum;
        }

        /// <summary>
        /// Computes the sum of a sequence.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> of <see cref="double"/> to calculate the sum of.</param>
        /// <returns>The sum of the values in the sequence.</returns>
        public static double SumF1(this IList<double> source)
        {
            var sourceArray = source.ToArrayF();
            var sourceLength = sourceArray.Length;

            var sum = 0D;

            for (var i = 0; i < sourceLength; i++)
                sum += sourceArray[i];

            return sum;
        }

        /// <summary>
        /// Computes the sum of a sequence.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> of <see cref="decimal"/> to calculate the sum of.</param>
        /// <returns>The sum of the values in the sequence.</returns>
        public static decimal SumF1(this IList<decimal> source)
        {
            var sourceArray = source.ToArrayF();
            var sourceLength = sourceArray.Length;

            var sum = 0M;

            for (var i = 0; i < sourceLength; i++)
                sum += sourceArray[i];

            return sum;
        }

        /// <summary>
        /// Computes the sum of a sequence that is obtained by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> of values that are used to calculate a sum.</param>
        /// <param name="selector">A transform function to apply to each element which returns <see cref="int"/>.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <returns>The sum of the projected values.</returns>
        public static int SumF1<TSource>(this IList<TSource> source, Func<TSource, int> selector)
        {
            var sourceArray = source.ToArrayF();
            var sourceLength = sourceArray.Length;

            var sum = 0;

            checked
            {
                for (var i = 0; i < sourceLength; i++)
                    sum += selector(sourceArray[i]);
            }

            return sum;
        }

        /// <summary>
        /// Computes the sum of a sequence that is obtained by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> of values that are used to calculate a sum.</param>
        /// <param name="selector">A transform function to apply to each element which returns <see cref="long"/>.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <returns>The sum of the projected values.</returns>
        public static long SumF1<TSource>(this IList<TSource> source, Func<TSource, long> selector)
        {
            var sourceArray = source.ToArrayF();
            var sourceLength = sourceArray.Length;

            var sum = 0L;

            checked
            {
                for (var i = 0; i < sourceLength; i++)
                    sum += selector(sourceArray[i]);
            }

            return sum;
        }

        /// <summary>
        /// Computes the sum of a sequence that is obtained by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> of values that are used to calculate a sum.</param>
        /// <param name="selector">A transform function to apply to each element which returns <see cref="float"/>.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <returns>The sum of the projected values.</returns>
        public static float SumF1<TSource>(this IList<TSource> source, Func<TSource, float> selector)
        {
            var sourceArray = source.ToArrayF();
            var sourceLength = sourceArray.Length;

            var sum = 0F;

            for (var i = 0; i < sourceLength; i++)
                sum += selector(sourceArray[i]);

            return sum;
        }

        /// <summary>
        /// Computes the sum of a sequence that is obtained by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> of values that are used to calculate a sum.</param>
        /// <param name="selector">A transform function to apply to each element which returns <see cref="double"/>.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <returns>The sum of the projected values.</returns>
        public static double SumF1<TSource>(this IList<TSource> source, Func<TSource, double> selector)
        {
            var sourceArray = source.ToArrayF();
            var sourceLength = sourceArray.Length;

            var sum = 0D;

            for (var i = 0; i < sourceLength; i++)
                sum += selector(sourceArray[i]);

            return sum;
        }

        /// <summary>
        /// Computes the sum of a sequence that is obtained by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> of values that are used to calculate a sum.</param>
        /// <param name="selector">A transform function to apply to each element which returns <see cref="decimal"/>.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <returns>The sum of the projected values.</returns>
        public static decimal SumF1<TSource>(this IList<TSource> source, Func<TSource, decimal> selector)
        {
            var sourceArray = source.ToArrayF();
            var sourceLength = sourceArray.Length;

            var sum = 0M;

            for (var i = 0; i < sourceLength; i++)
                sum += selector(sourceArray[i]);

            return sum;
        }
    }
}
