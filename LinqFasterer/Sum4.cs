using System;
using System.Collections.Generic;

namespace LinqFasterer
{
    public static partial class EnumerableF
    {
        /// <summary>
        /// Computes the sum of a sequence. A 4-times unrolled version of <see cref="SumF(System.Collections.Generic.IList{int})"/>.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> of <see cref="int"/> to calculate the sum of.</param>
        /// <returns>The sum of the values in the sequence.</returns>
        public static int SumF4(this IList<int> source)
        {
            const int unrollMultiplier = 4;
            const int unrollMask = unrollMultiplier - 1;

            var sourceArray = source.ToArrayF();
            var sourceLength = sourceArray.Length;

            var sourceArrayPtr = new Span<int>(sourceArray);
            var unrollLength = sourceLength / unrollMultiplier;
            var residuals = sourceLength & unrollMask;

            var sum0 = 0;
            var sum1 = 0;
            var sum2 = 0;
            var sum3 = 0;

            checked
            {
                for (var i = 0; i < unrollLength; i++)
                {
                    sum0 += sourceArrayPtr[0];
                    sum1 += sourceArrayPtr[1];
                    sum2 += sourceArrayPtr[2];
                    sum3 += sourceArrayPtr[3];

                    sourceArrayPtr = sourceArrayPtr.Slice(unrollMultiplier);
                }

                for (var i = 0; i < residuals; i++)
                    sum0 += sourceArrayPtr[i];

                return (sum0 + sum1) +
                       (sum2 + sum3);
            }
        }

        /// <summary>
        /// Computes the sum of a sequence. A 4-times unrolled version of <see cref="SumF(System.Collections.Generic.IList{long})"/>.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> of <see cref="long"/> to calculate the sum of.</param>
        /// <returns>The sum of the values in the sequence.</returns>
        public static long SumF4(this IList<long> source)
        {
            const int unrollMultiplier = 4;
            const int unrollMask = unrollMultiplier - 1;

            var sourceArray = source.ToArrayF();
            var sourceLength = sourceArray.Length;

            var sourceArrayPtr = new Span<long>(sourceArray);
            var unrollLength = sourceLength / unrollMultiplier;
            var residuals = sourceLength & unrollMask;

            var sum0 = 0L;
            var sum1 = 0L;
            var sum2 = 0L;
            var sum3 = 0L;

            checked
            {
                for (var i = 0; i < unrollLength; i++)
                {
                    sum0 += sourceArrayPtr[0];
                    sum1 += sourceArrayPtr[1];
                    sum2 += sourceArrayPtr[2];
                    sum3 += sourceArrayPtr[3];

                    sourceArrayPtr = sourceArrayPtr.Slice(unrollMultiplier);
                }

                for (var i = 0; i < residuals; i++)
                    sum0 += sourceArrayPtr[i];

                return (sum0 + sum1) +
                       (sum2 + sum3);
            }
        }

        /// <summary>
        /// Computes the sum of a sequence. A 4-times unrolled version of <see cref="SumF(System.Collections.Generic.IList{float})"/>.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> of <see cref="float"/> to calculate the sum of.</param>
        /// <returns>The sum of the values in the sequence.</returns>
        public static float SumF4(this IList<float> source)
        {
            const int unrollMultiplier = 4;
            const int unrollMask = unrollMultiplier - 1;

            var sourceArray = source.ToArrayF();
            var sourceLength = sourceArray.Length;

            var sourceArrayPtr = new Span<float>(sourceArray);
            var unrollLength = sourceLength / unrollMultiplier;
            var residuals = sourceLength & unrollMask;

            var sum0 = 0.0;
            var sum1 = 0.0;
            var sum2 = 0.0;
            var sum3 = 0.0;

            checked
            {
                for (var i = 0; i < unrollLength; i++)
                {
                    sum0 += sourceArrayPtr[0];
                    sum1 += sourceArrayPtr[1];
                    sum2 += sourceArrayPtr[2];
                    sum3 += sourceArrayPtr[3];

                    sourceArrayPtr = sourceArrayPtr.Slice(unrollMultiplier);
                }

                for (var i = 0; i < residuals; i++)
                    sum0 += sourceArrayPtr[i];

                return (float)
                (
                    (sum0 + sum1) +
                    (sum2 + sum3)
                );
            }
        }

        /// <summary>
        /// Computes the sum of a sequence. A 4-times unrolled version of <see cref="SumF(System.Collections.Generic.IList{double})"/>.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> of <see cref="double"/> to calculate the sum of.</param>
        /// <returns>The sum of the values in the sequence.</returns>
        public static double SumF4(this IList<double> source)
        {
            const int unrollMultiplier = 4;
            const int unrollMask = unrollMultiplier - 1;

            var sourceArray = source.ToArrayF();
            var sourceLength = sourceArray.Length;

            var sourceArrayPtr = new Span<double>(sourceArray);
            var unrollLength = sourceLength / unrollMultiplier;
            var residuals = sourceLength & unrollMask;

            var sum0 = 0.0;
            var sum1 = 0.0;
            var sum2 = 0.0;
            var sum3 = 0.0;

            checked
            {
                for (var i = 0; i < unrollLength; i++)
                {
                    sum0 += sourceArrayPtr[0];
                    sum1 += sourceArrayPtr[1];
                    sum2 += sourceArrayPtr[2];
                    sum3 += sourceArrayPtr[3];

                    sourceArrayPtr = sourceArrayPtr.Slice(unrollMultiplier);
                }

                for (var i = 0; i < residuals; i++)
                    sum0 += sourceArrayPtr[i];

                return (sum0 + sum1) +
                       (sum2 + sum3);
            }
        }

        /// <summary>
        /// Computes the sum of a sequence. A 4-times unrolled version of <see cref="SumF(System.Collections.Generic.IList{decimal})"/>.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> of <see cref="decimal"/> to calculate the sum of.</param>
        /// <returns>The sum of the values in the sequence.</returns>
        public static decimal SumF4(this IList<decimal> source)
        {
            const int unrollMultiplier = 4;
            const int unrollMask = unrollMultiplier - 1;

            var sourceArray = source.ToArrayF();
            var sourceLength = sourceArray.Length;

            var sourceArrayPtr = new Span<decimal>(sourceArray);
            var unrollLength = sourceLength / unrollMultiplier;
            var residuals = sourceLength & unrollMask;

            var sum0 = 0M;
            var sum1 = 0M;
            var sum2 = 0M;
            var sum3 = 0M;

            checked
            {
                for (var i = 0; i < unrollLength; i++)
                {
                    sum0 += sourceArrayPtr[0];
                    sum1 += sourceArrayPtr[1];
                    sum2 += sourceArrayPtr[2];
                    sum3 += sourceArrayPtr[3];

                    sourceArrayPtr = sourceArrayPtr.Slice(unrollMultiplier);
                }

                for (var i = 0; i < residuals; i++)
                    sum0 += sourceArrayPtr[i];

                return (sum0 + sum1) +
                       (sum2 + sum3);
            }
        }

        /// <summary>
        /// Computes the sum of a sequence that is obtained by invoking a transform function on each element of the input sequence.
        /// A 4-times unrolled version of <see cref="SumF(System.Collections.Generic.IList{int})"/>.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> of values that are used to calculate a sum.</param>
        /// <param name="selector">A transform function to apply to each element which returns <see cref="int"/>.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <returns>The sum of the projected values.</returns>
        public static int SumF4<TSource>(this IList<TSource> source, Func<TSource, int> selector)
        {
            const int unrollMultiplier = 4;
            const int unrollMask = unrollMultiplier - 1;

            var sourceArray = source.ToArrayF();
            var sourceLength = sourceArray.Length;

            var sourceArrayPtr = new Span<TSource>(sourceArray);
            var unrollLength = sourceLength / unrollMultiplier;
            var residuals = sourceLength & unrollMask;

            var sum0 = 0;
            var sum1 = 0;
            var sum2 = 0;
            var sum3 = 0;

            checked
            {
                for (var i = 0; i < unrollLength; i++)
                {
                    sum0 += selector(sourceArrayPtr[0]);
                    sum1 += selector(sourceArrayPtr[1]);
                    sum2 += selector(sourceArrayPtr[2]);
                    sum3 += selector(sourceArrayPtr[3]);

                    sourceArrayPtr = sourceArrayPtr.Slice(unrollMultiplier);
                }

                for (var i = 0; i < residuals; i++)
                    sum0 += selector(sourceArrayPtr[i]);

                return (sum0 + sum1) +
                       (sum2 + sum3);
            }
        }

        /// <summary>
        /// Computes the sum of a sequence that is obtained by invoking a transform function on each element of the input sequence.
        /// A 4-times unrolled version of <see cref="SumF(System.Collections.Generic.IList{long})"/>.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> of values that are used to calculate a sum.</param>
        /// <param name="selector">A transform function to apply to each element which returns <see cref="long"/>.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <returns>The sum of the projected values.</returns>
        public static long SumF4<TSource>(this IList<TSource> source, Func<TSource, long> selector)
        {
            const int unrollMultiplier = 4;
            const int unrollMask = unrollMultiplier - 1;

            var sourceArray = source.ToArrayF();
            var sourceLength = sourceArray.Length;

            var sourceArrayPtr = new Span<TSource>(sourceArray);
            var unrollLength = sourceLength / unrollMultiplier;
            var residuals = sourceLength & unrollMask;

            var sum0 = 0L;
            var sum1 = 0L;
            var sum2 = 0L;
            var sum3 = 0L;

            checked
            {
                for (var i = 0; i < unrollLength; i++)
                {
                    sum0 += selector(sourceArrayPtr[0]);
                    sum1 += selector(sourceArrayPtr[1]);
                    sum2 += selector(sourceArrayPtr[2]);
                    sum3 += selector(sourceArrayPtr[3]);

                    sourceArrayPtr = sourceArrayPtr.Slice(unrollMultiplier);
                }

                for (var i = 0; i < residuals; i++)
                    sum0 += selector(sourceArrayPtr[i]);

                return (sum0 + sum1) +
                       (sum2 + sum3);
            }
        }

        /// <summary>
        /// Computes the sum of a sequence that is obtained by invoking a transform function on each element of the input sequence.
        /// A 4-times unrolled version of <see cref="SumF(System.Collections.Generic.IList{float})"/>.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> of values that are used to calculate a sum.</param>
        /// <param name="selector">A transform function to apply to each element which returns <see cref="float"/>.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <returns>The sum of the projected values.</returns>
        public static float SumF4<TSource>(this IList<TSource> source, Func<TSource, float> selector)
        {
            const int unrollMultiplier = 4;
            const int unrollMask = unrollMultiplier - 1;

            var sourceArray = source.ToArrayF();
            var sourceLength = sourceArray.Length;

            var sourceArrayPtr = new Span<TSource>(sourceArray);
            var unrollLength = sourceLength / unrollMultiplier;
            var residuals = sourceLength & unrollMask;

            var sum0 = 0.0;
            var sum1 = 0.0;
            var sum2 = 0.0;
            var sum3 = 0.0;

            checked
            {
                for (var i = 0; i < unrollLength; i++)
                {
                    sum0 += selector(sourceArrayPtr[0]);
                    sum1 += selector(sourceArrayPtr[1]);
                    sum2 += selector(sourceArrayPtr[2]);
                    sum3 += selector(sourceArrayPtr[3]);

                    sourceArrayPtr = sourceArrayPtr.Slice(unrollMultiplier);
                }

                for (var i = 0; i < residuals; i++)
                    sum0 += selector(sourceArrayPtr[i]);

                return (float)
                (
                    (sum0 + sum1) +
                    (sum2 + sum3)
                );
            }
        }

        /// <summary>
        /// Computes the sum of a sequence that is obtained by invoking a transform function on each element of the input sequence.
        /// A 4-times unrolled version of <see cref="SumF(System.Collections.Generic.IList{double})"/>.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> of values that are used to calculate a sum.</param>
        /// <param name="selector">A transform function to apply to each element which returns <see cref="double"/>.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <returns>The sum of the projected values.</returns>
        public static double SumF4<TSource>(this IList<TSource> source, Func<TSource, double> selector)
        {
            const int unrollMultiplier = 4;
            const int unrollMask = unrollMultiplier - 1;

            var sourceArray = source.ToArrayF();
            var sourceLength = sourceArray.Length;

            var sourceArrayPtr = new Span<TSource>(sourceArray);
            var unrollLength = sourceLength / unrollMultiplier;
            var residuals = sourceLength & unrollMask;

            var sum0 = 0.0;
            var sum1 = 0.0;
            var sum2 = 0.0;
            var sum3 = 0.0;

            checked
            {
                for (var i = 0; i < unrollLength; i++)
                {
                    sum0 += selector(sourceArrayPtr[0]);
                    sum1 += selector(sourceArrayPtr[1]);
                    sum2 += selector(sourceArrayPtr[2]);
                    sum3 += selector(sourceArrayPtr[3]);

                    sourceArrayPtr = sourceArrayPtr.Slice(unrollMultiplier);
                }

                for (var i = 0; i < residuals; i++)
                    sum0 += selector(sourceArrayPtr[i]);

                return (sum0 + sum1) +
                       (sum2 + sum3);
            }
        }

        /// <summary>
        /// Computes the sum of a sequence that is obtained by invoking a transform function on each element of the input sequence.
        /// A 4-times unrolled version of <see cref="SumF(System.Collections.Generic.IList{decimal})"/>.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> of values that are used to calculate a sum.</param>
        /// <param name="selector">A transform function to apply to each element which returns <see cref="decimal"/>.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <returns>The sum of the projected values.</returns>
        public static decimal SumF4<TSource>(this IList<TSource> source, Func<TSource, decimal> selector)
        {
            const int unrollMultiplier = 4;
            const int unrollMask = unrollMultiplier - 1;

            var sourceArray = source.ToArrayF();
            var sourceLength = sourceArray.Length;

            var sourceArrayPtr = new Span<TSource>(sourceArray);
            var unrollLength = sourceLength / unrollMultiplier;
            var residuals = sourceLength & unrollMask;

            var sum0 = 0M;
            var sum1 = 0M;
            var sum2 = 0M;
            var sum3 = 0M;

            checked
            {
                for (var i = 0; i < unrollLength; i++)
                {
                    sum0 += selector(sourceArrayPtr[0]);
                    sum1 += selector(sourceArrayPtr[1]);
                    sum2 += selector(sourceArrayPtr[2]);
                    sum3 += selector(sourceArrayPtr[3]);

                    sourceArrayPtr = sourceArrayPtr.Slice(unrollMultiplier);
                }

                for (var i = 0; i < residuals; i++)
                    sum0 += selector(sourceArrayPtr[i]);

                return (sum0 + sum1) +
                       (sum2 + sum3);
            }
        }
    }
}
