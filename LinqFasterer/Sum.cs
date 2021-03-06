using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace LinqFasterer
{
    public static partial class EnumerableF
    {
        /// <summary>
        /// Computes the sum of a sequence.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> of <see cref="int"/> to calculate the sum of.</param>
        /// <returns>The sum of the values in the sequence.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SumF(this IList<int> source)
        {
            return source.SumF4();
        }

        /// <summary>
        /// Computes the sum of a sequence.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> of <see cref="long"/> to calculate the sum of.</param>
        /// <returns>The sum of the values in the sequence.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long SumF(this IList<long> source)
        {
            return source.SumF4();
        }

        /// <summary>
        /// Computes the sum of a sequence.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> of <see cref="float"/> to calculate the sum of.</param>
        /// <returns>The sum of the values in the sequence.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float SumF(this IList<float> source)
        {
            return source.SumF4();
        }

        /// <summary>
        /// Computes the sum of a sequence.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> of <see cref="double"/> to calculate the sum of.</param>
        /// <returns>The sum of the values in the sequence.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double SumF(this IList<double> source)
        {
            return source.SumF4();
        }

        /// <summary>
        /// Computes the sum of a sequence.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> of <see cref="decimal"/> to calculate the sum of.</param>
        /// <returns>The sum of the values in the sequence.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static decimal SumF(this IList<decimal> source)
        {
            return source.SumF4();
        }

        /// <summary>
        /// Computes the sum of a sequence that is obtained by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> of values that are used to calculate a sum.</param>
        /// <param name="selector">A transform function to apply to each element which returns <see cref="int"/>.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <returns>The sum of the projected values.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int SumF<TSource>(this IList<TSource> source, Func<TSource, int> selector)
        {
            return source.SumF4(selector);
        }

        /// <summary>
        /// Computes the sum of a sequence that is obtained by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> of values that are used to calculate a sum.</param>
        /// <param name="selector">A transform function to apply to each element which returns <see cref="long"/>.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <returns>The sum of the projected values.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long SumF<TSource>(this IList<TSource> source, Func<TSource, long> selector)
        {
            return source.SumF4(selector);
        }

        /// <summary>
        /// Computes the sum of a sequence that is obtained by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> of values that are used to calculate a sum.</param>
        /// <param name="selector">A transform function to apply to each element which returns <see cref="float"/>.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <returns>The sum of the projected values.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float SumF<TSource>(this IList<TSource> source, Func<TSource, float> selector)
        {
            return source.SumF4(selector);
        }

        /// <summary>
        /// Computes the sum of a sequence that is obtained by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> of values that are used to calculate a sum.</param>
        /// <param name="selector">A transform function to apply to each element which returns <see cref="double"/>.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <returns>The sum of the projected values.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double SumF<TSource>(this IList<TSource> source, Func<TSource, double> selector)
        {
            return source.SumF4(selector);
        }

        /// <summary>
        /// Computes the sum of a sequence that is obtained by invoking a transform function on each element of the input sequence.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> of values that are used to calculate a sum.</param>
        /// <param name="selector">A transform function to apply to each element which returns <see cref="decimal"/>.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <returns>The sum of the projected values.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static decimal SumF<TSource>(this IList<TSource> source, Func<TSource, decimal> selector)
        {
            return source.SumF4(selector);
        }
    }
}
