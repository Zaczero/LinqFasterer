using System;
using System.Collections.Generic;

namespace LinqFasterer
{
    public static partial class EnumerableF
    {
        /// <summary>
        /// Computes the sum of a sequence. A 16-times unrolled version of <see cref="SumF(System.Collections.Generic.IList{int})"/>.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> of <see cref="int"/> to calculate the sum of.</param>
        /// <returns>The sum of the values in the sequence.</returns>
        public static int SumF16(this IList<int> source)
        {
            const int unrollMultiplier = 16;
            const int unrollMask = unrollMultiplier - 1;

            var sourceArray = source.ToArrayF();
            var sourceLength = sourceArray.Length;

            var sourceArrayPtr = new Span<int>(sourceArray);
            var unrollLength = sourceLength / unrollMultiplier;
            var residuals = sourceLength & unrollMask;

            var sum0 = 0; var sum1 = 0; var sum2 = 0; var sum3 = 0;
            var sum4 = 0; var sum5 = 0; var sum6 = 0; var sum7 = 0;
            var sum8 = 0; var sum9 = 0; var sumA = 0; var sumB = 0;
            var sumC = 0; var sumD = 0; var sumE = 0; var sumF = 0;

            checked
            {
                for (var i = 0; i < unrollLength; i++)
                {
                    sum0 += sourceArrayPtr[0x0]; sum1 += sourceArrayPtr[0x1]; sum2 += sourceArrayPtr[0x2]; sum3 += sourceArrayPtr[0x3];
                    sum4 += sourceArrayPtr[0x4]; sum5 += sourceArrayPtr[0x5]; sum6 += sourceArrayPtr[0x6]; sum7 += sourceArrayPtr[0x7];
                    sum8 += sourceArrayPtr[0x8]; sum9 += sourceArrayPtr[0x9]; sumA += sourceArrayPtr[0xA]; sumB += sourceArrayPtr[0xB];
                    sumC += sourceArrayPtr[0xC]; sumD += sourceArrayPtr[0xD]; sumE += sourceArrayPtr[0xE]; sumF += sourceArrayPtr[0xF];

                    sourceArrayPtr = sourceArrayPtr.Slice(unrollMultiplier);
                }

                for (var i = 0; i < residuals; i++)
                    sum0 += sourceArrayPtr[i];

                return
                    (
                        ((sum0 + sum1) + (sum2 + sum3)) +
                        ((sum4 + sum5) + (sum6 + sum7))
                    ) +
                    (
                        ((sum8 + sum9) + (sumA + sumB)) +
                        ((sumC + sumD) + (sumE + sumF))
                    );
            }
        }

        /// <summary>
        /// Computes the sum of a sequence. A 16-times unrolled version of <see cref="SumF(System.Collections.Generic.IList{long})"/>.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> of <see cref="long"/> to calculate the sum of.</param>
        /// <returns>The sum of the values in the sequence.</returns>
        public static long SumF16(this IList<long> source)
        {
            const int unrollMultiplier = 16;
            const int unrollMask = unrollMultiplier - 1;

            var sourceArray = source.ToArrayF();
            var sourceLength = sourceArray.Length;

            var sourceArrayPtr = new Span<long>(sourceArray);
            var unrollLength = sourceLength / unrollMultiplier;
            var residuals = sourceLength & unrollMask;

            var sum0 = 0L; var sum1 = 0L; var sum2 = 0L; var sum3 = 0L;
            var sum4 = 0L; var sum5 = 0L; var sum6 = 0L; var sum7 = 0L;
            var sum8 = 0L; var sum9 = 0L; var sumA = 0L; var sumB = 0L;
            var sumC = 0L; var sumD = 0L; var sumE = 0L; var sumF = 0L;

            checked
            {
                for (var i = 0; i < unrollLength; i++)
                {
                    sum0 += sourceArrayPtr[0x0]; sum1 += sourceArrayPtr[0x1]; sum2 += sourceArrayPtr[0x2]; sum3 += sourceArrayPtr[0x3];
                    sum4 += sourceArrayPtr[0x4]; sum5 += sourceArrayPtr[0x5]; sum6 += sourceArrayPtr[0x6]; sum7 += sourceArrayPtr[0x7];
                    sum8 += sourceArrayPtr[0x8]; sum9 += sourceArrayPtr[0x9]; sumA += sourceArrayPtr[0xA]; sumB += sourceArrayPtr[0xB];
                    sumC += sourceArrayPtr[0xC]; sumD += sourceArrayPtr[0xD]; sumE += sourceArrayPtr[0xE]; sumF += sourceArrayPtr[0xF];

                    sourceArrayPtr = sourceArrayPtr.Slice(unrollMultiplier);
                }

                for (var i = 0; i < residuals; i++)
                    sum0 += sourceArrayPtr[i];

                return
                    (
                        ((sum0 + sum1) + (sum2 + sum3)) +
                        ((sum4 + sum5) + (sum6 + sum7))
                    ) +
                    (
                        ((sum8 + sum9) + (sumA + sumB)) +
                        ((sumC + sumD) + (sumE + sumF))
                    );
            }
        }

        /// <summary>
        /// Computes the sum of a sequence. A 16-times unrolled version of <see cref="SumF(System.Collections.Generic.IList{float})"/>.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> of <see cref="float"/> to calculate the sum of.</param>
        /// <returns>The sum of the values in the sequence.</returns>
        public static float SumF16(this IList<float> source)
        {
            const int unrollMultiplier = 16;
            const int unrollMask = unrollMultiplier - 1;

            var sourceArray = source.ToArrayF();
            var sourceLength = sourceArray.Length;

            var sourceArrayPtr = new Span<float>(sourceArray);
            var unrollLength = sourceLength / unrollMultiplier;
            var residuals = sourceLength & unrollMask;

            var sum0 = 0F; var sum1 = 0F; var sum2 = 0F; var sum3 = 0F;
            var sum4 = 0F; var sum5 = 0F; var sum6 = 0F; var sum7 = 0F;
            var sum8 = 0F; var sum9 = 0F; var sumA = 0F; var sumB = 0F;
            var sumC = 0F; var sumD = 0F; var sumE = 0F; var sumF = 0F;

            checked
            {
                for (var i = 0; i < unrollLength; i++)
                {
                    sum0 += sourceArrayPtr[0x0]; sum1 += sourceArrayPtr[0x1]; sum2 += sourceArrayPtr[0x2]; sum3 += sourceArrayPtr[0x3];
                    sum4 += sourceArrayPtr[0x4]; sum5 += sourceArrayPtr[0x5]; sum6 += sourceArrayPtr[0x6]; sum7 += sourceArrayPtr[0x7];
                    sum8 += sourceArrayPtr[0x8]; sum9 += sourceArrayPtr[0x9]; sumA += sourceArrayPtr[0xA]; sumB += sourceArrayPtr[0xB];
                    sumC += sourceArrayPtr[0xC]; sumD += sourceArrayPtr[0xD]; sumE += sourceArrayPtr[0xE]; sumF += sourceArrayPtr[0xF];

                    sourceArrayPtr = sourceArrayPtr.Slice(unrollMultiplier);
                }

                for (var i = 0; i < residuals; i++)
                    sum0 += sourceArrayPtr[i];

                return
                    (
                        ((sum0 + sum1) + (sum2 + sum3)) +
                        ((sum4 + sum5) + (sum6 + sum7))
                    ) +
                    (
                        ((sum8 + sum9) + (sumA + sumB)) +
                        ((sumC + sumD) + (sumE + sumF))
                    );
            }
        }

        /// <summary>
        /// Computes the sum of a sequence. A 16-times unrolled version of <see cref="SumF(System.Collections.Generic.IList{double})"/>.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> of <see cref="double"/> to calculate the sum of.</param>
        /// <returns>The sum of the values in the sequence.</returns>
        public static double SumF16(this IList<double> source)
        {
            const int unrollMultiplier = 16;
            const int unrollMask = unrollMultiplier - 1;

            var sourceArray = source.ToArrayF();
            var sourceLength = sourceArray.Length;

            var sourceArrayPtr = new Span<double>(sourceArray);
            var unrollLength = sourceLength / unrollMultiplier;
            var residuals = sourceLength & unrollMask;

            var sum0 = 0D; var sum1 = 0D; var sum2 = 0D; var sum3 = 0D;
            var sum4 = 0D; var sum5 = 0D; var sum6 = 0D; var sum7 = 0D;
            var sum8 = 0D; var sum9 = 0D; var sumA = 0D; var sumB = 0D;
            var sumC = 0D; var sumD = 0D; var sumE = 0D; var sumF = 0D;

            checked
            {
                for (var i = 0; i < unrollLength; i++)
                {
                    sum0 += sourceArrayPtr[0x0]; sum1 += sourceArrayPtr[0x1]; sum2 += sourceArrayPtr[0x2]; sum3 += sourceArrayPtr[0x3];
                    sum4 += sourceArrayPtr[0x4]; sum5 += sourceArrayPtr[0x5]; sum6 += sourceArrayPtr[0x6]; sum7 += sourceArrayPtr[0x7];
                    sum8 += sourceArrayPtr[0x8]; sum9 += sourceArrayPtr[0x9]; sumA += sourceArrayPtr[0xA]; sumB += sourceArrayPtr[0xB];
                    sumC += sourceArrayPtr[0xC]; sumD += sourceArrayPtr[0xD]; sumE += sourceArrayPtr[0xE]; sumF += sourceArrayPtr[0xF];

                    sourceArrayPtr = sourceArrayPtr.Slice(unrollMultiplier);
                }

                for (var i = 0; i < residuals; i++)
                    sum0 += sourceArrayPtr[i];

                return
                    (
                        ((sum0 + sum1) + (sum2 + sum3)) +
                        ((sum4 + sum5) + (sum6 + sum7))
                    ) +
                    (
                        ((sum8 + sum9) + (sumA + sumB)) +
                        ((sumC + sumD) + (sumE + sumF))
                    );
            }
        }

        /// <summary>
        /// Computes the sum of a sequence. A 16-times unrolled version of <see cref="SumF(System.Collections.Generic.IList{decimal})"/>.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> of <see cref="decimal"/> to calculate the sum of.</param>
        /// <returns>The sum of the values in the sequence.</returns>
        public static decimal SumF16(this IList<decimal> source)
        {
            const int unrollMultiplier = 16;
            const int unrollMask = unrollMultiplier - 1;

            var sourceArray = source.ToArrayF();
            var sourceLength = sourceArray.Length;

            var sourceArrayPtr = new Span<decimal>(sourceArray);
            var unrollLength = sourceLength / unrollMultiplier;
            var residuals = sourceLength & unrollMask;

            var sum0 = 0M; var sum1 = 0M; var sum2 = 0M; var sum3 = 0M;
            var sum4 = 0M; var sum5 = 0M; var sum6 = 0M; var sum7 = 0M;
            var sum8 = 0M; var sum9 = 0M; var sumA = 0M; var sumB = 0M;
            var sumC = 0M; var sumD = 0M; var sumE = 0M; var sumF = 0M;

            checked
            {
                for (var i = 0; i < unrollLength; i++)
                {
                    sum0 += sourceArrayPtr[0x0]; sum1 += sourceArrayPtr[0x1]; sum2 += sourceArrayPtr[0x2]; sum3 += sourceArrayPtr[0x3];
                    sum4 += sourceArrayPtr[0x4]; sum5 += sourceArrayPtr[0x5]; sum6 += sourceArrayPtr[0x6]; sum7 += sourceArrayPtr[0x7];
                    sum8 += sourceArrayPtr[0x8]; sum9 += sourceArrayPtr[0x9]; sumA += sourceArrayPtr[0xA]; sumB += sourceArrayPtr[0xB];
                    sumC += sourceArrayPtr[0xC]; sumD += sourceArrayPtr[0xD]; sumE += sourceArrayPtr[0xE]; sumF += sourceArrayPtr[0xF];

                    sourceArrayPtr = sourceArrayPtr.Slice(unrollMultiplier);
                }

                for (var i = 0; i < residuals; i++)
                    sum0 += sourceArrayPtr[i];

                return
                    (
                        ((sum0 + sum1) + (sum2 + sum3)) +
                        ((sum4 + sum5) + (sum6 + sum7))
                    ) +
                    (
                        ((sum8 + sum9) + (sumA + sumB)) +
                        ((sumC + sumD) + (sumE + sumF))
                    );
            }
        }

        /// <summary>
        /// Computes the sum of a sequence that is obtained by invoking a transform function on each element of the input sequence.
        /// A 16-times unrolled version of <see cref="SumF(System.Collections.Generic.IList{int})"/>.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> of values that are used to calculate a sum.</param>
        /// <param name="selector">A transform function to apply to each element which returns <see cref="int"/>.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <returns>The sum of the projected values.</returns>
        public static int SumF16<TSource>(this IList<TSource> source, Func<TSource, int> selector)
        {
            const int unrollMultiplier = 16;
            const int unrollMask = unrollMultiplier - 1;

            var sourceArray = source.ToArrayF();
            var sourceLength = sourceArray.Length;

            var sourceArrayPtr = new Span<TSource>(sourceArray);
            var unrollLength = sourceLength / unrollMultiplier;
            var residuals = sourceLength & unrollMask;

            var sum0 = 0; var sum1 = 0; var sum2 = 0; var sum3 = 0;
            var sum4 = 0; var sum5 = 0; var sum6 = 0; var sum7 = 0;
            var sum8 = 0; var sum9 = 0; var sumA = 0; var sumB = 0;
            var sumC = 0; var sumD = 0; var sumE = 0; var sumF = 0;

            checked
            {
                for (var i = 0; i < unrollLength; i++)
                {
                    sum0 += selector(sourceArrayPtr[0x0]); sum1 += selector(sourceArrayPtr[0x1]); sum2 += selector(sourceArrayPtr[0x2]); sum3 += selector(sourceArrayPtr[0x3]);
                    sum4 += selector(sourceArrayPtr[0x4]); sum5 += selector(sourceArrayPtr[0x5]); sum6 += selector(sourceArrayPtr[0x6]); sum7 += selector(sourceArrayPtr[0x7]);
                    sum8 += selector(sourceArrayPtr[0x8]); sum9 += selector(sourceArrayPtr[0x9]); sumA += selector(sourceArrayPtr[0xA]); sumB += selector(sourceArrayPtr[0xB]);
                    sumC += selector(sourceArrayPtr[0xC]); sumD += selector(sourceArrayPtr[0xD]); sumE += selector(sourceArrayPtr[0xE]); sumF += selector(sourceArrayPtr[0xF]);

                    sourceArrayPtr = sourceArrayPtr.Slice(unrollMultiplier);
                }

                for (var i = 0; i < residuals; i++)
                    sum0 += selector(sourceArrayPtr[i]);

                return
                    (
                        ((sum0 + sum1) + (sum2 + sum3)) +
                        ((sum4 + sum5) + (sum6 + sum7))
                    ) +
                    (
                        ((sum8 + sum9) + (sumA + sumB)) +
                        ((sumC + sumD) + (sumE + sumF))
                    );
            }
        }

        /// <summary>
        /// Computes the sum of a sequence that is obtained by invoking a transform function on each element of the input sequence.
        /// A 16-times unrolled version of <see cref="SumF(System.Collections.Generic.IList{int})"/>.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> of values that are used to calculate a sum.</param>
        /// <param name="selector">A transform function to apply to each element which returns <see cref="long"/>.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <returns>The sum of the projected values.</returns>
        public static long SumF16<TSource>(this IList<TSource> source, Func<TSource, long> selector)
        {
            const int unrollMultiplier = 16;
            const int unrollMask = unrollMultiplier - 1;

            var sourceArray = source.ToArrayF();
            var sourceLength = sourceArray.Length;

            var sourceArrayPtr = new Span<TSource>(sourceArray);
            var unrollLength = sourceLength / unrollMultiplier;
            var residuals = sourceLength & unrollMask;

            var sum0 = 0L; var sum1 = 0L; var sum2 = 0L; var sum3 = 0L;
            var sum4 = 0L; var sum5 = 0L; var sum6 = 0L; var sum7 = 0L;
            var sum8 = 0L; var sum9 = 0L; var sumA = 0L; var sumB = 0L;
            var sumC = 0L; var sumD = 0L; var sumE = 0L; var sumF = 0L;

            checked
            {
                for (var i = 0; i < unrollLength; i++)
                {
                    sum0 += selector(sourceArrayPtr[0x0]); sum1 += selector(sourceArrayPtr[0x1]); sum2 += selector(sourceArrayPtr[0x2]); sum3 += selector(sourceArrayPtr[0x3]);
                    sum4 += selector(sourceArrayPtr[0x4]); sum5 += selector(sourceArrayPtr[0x5]); sum6 += selector(sourceArrayPtr[0x6]); sum7 += selector(sourceArrayPtr[0x7]);
                    sum8 += selector(sourceArrayPtr[0x8]); sum9 += selector(sourceArrayPtr[0x9]); sumA += selector(sourceArrayPtr[0xA]); sumB += selector(sourceArrayPtr[0xB]);
                    sumC += selector(sourceArrayPtr[0xC]); sumD += selector(sourceArrayPtr[0xD]); sumE += selector(sourceArrayPtr[0xE]); sumF += selector(sourceArrayPtr[0xF]);

                    sourceArrayPtr = sourceArrayPtr.Slice(unrollMultiplier);
                }

                for (var i = 0; i < residuals; i++)
                    sum0 += selector(sourceArrayPtr[i]);

                return
                    (
                        ((sum0 + sum1) + (sum2 + sum3)) +
                        ((sum4 + sum5) + (sum6 + sum7))
                    ) +
                    (
                        ((sum8 + sum9) + (sumA + sumB)) +
                        ((sumC + sumD) + (sumE + sumF))
                    );
            }
        }

        /// <summary>
        /// Computes the sum of a sequence that is obtained by invoking a transform function on each element of the input sequence.
        /// A 16-times unrolled version of <see cref="SumF(System.Collections.Generic.IList{float})"/>.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> of values that are used to calculate a sum.</param>
        /// <param name="selector">A transform function to apply to each element which returns <see cref="float"/>.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <returns>The sum of the projected values.</returns>
        public static float SumF16<TSource>(this IList<TSource> source, Func<TSource, float> selector)
        {
            const int unrollMultiplier = 16;
            const int unrollMask = unrollMultiplier - 1;

            var sourceArray = source.ToArrayF();
            var sourceLength = sourceArray.Length;

            var sourceArrayPtr = new Span<TSource>(sourceArray);
            var unrollLength = sourceLength / unrollMultiplier;
            var residuals = sourceLength & unrollMask;

            var sum0 = 0F; var sum1 = 0F; var sum2 = 0F; var sum3 = 0F;
            var sum4 = 0F; var sum5 = 0F; var sum6 = 0F; var sum7 = 0F;
            var sum8 = 0F; var sum9 = 0F; var sumA = 0F; var sumB = 0F;
            var sumC = 0F; var sumD = 0F; var sumE = 0F; var sumF = 0F;

            checked
            {
                for (var i = 0; i < unrollLength; i++)
                {
                    sum0 += selector(sourceArrayPtr[0x0]); sum1 += selector(sourceArrayPtr[0x1]); sum2 += selector(sourceArrayPtr[0x2]); sum3 += selector(sourceArrayPtr[0x3]);
                    sum4 += selector(sourceArrayPtr[0x4]); sum5 += selector(sourceArrayPtr[0x5]); sum6 += selector(sourceArrayPtr[0x6]); sum7 += selector(sourceArrayPtr[0x7]);
                    sum8 += selector(sourceArrayPtr[0x8]); sum9 += selector(sourceArrayPtr[0x9]); sumA += selector(sourceArrayPtr[0xA]); sumB += selector(sourceArrayPtr[0xB]);
                    sumC += selector(sourceArrayPtr[0xC]); sumD += selector(sourceArrayPtr[0xD]); sumE += selector(sourceArrayPtr[0xE]); sumF += selector(sourceArrayPtr[0xF]);

                    sourceArrayPtr = sourceArrayPtr.Slice(unrollMultiplier);
                }

                for (var i = 0; i < residuals; i++)
                    sum0 += selector(sourceArrayPtr[i]);

                return
                    (
                        ((sum0 + sum1) + (sum2 + sum3)) +
                        ((sum4 + sum5) + (sum6 + sum7))
                    ) +
                    (
                        ((sum8 + sum9) + (sumA + sumB)) +
                        ((sumC + sumD) + (sumE + sumF))
                    );
            }
        }

        /// <summary>
        /// Computes the sum of a sequence that is obtained by invoking a transform function on each element of the input sequence.
        /// A 16-times unrolled version of <see cref="SumF(System.Collections.Generic.IList{double})"/>.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> of values that are used to calculate a sum.</param>
        /// <param name="selector">A transform function to apply to each element which returns <see cref="double"/>.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <returns>The sum of the projected values.</returns>
        public static double SumF16<TSource>(this IList<TSource> source, Func<TSource, double> selector)
        {
            const int unrollMultiplier = 16;
            const int unrollMask = unrollMultiplier - 1;

            var sourceArray = source.ToArrayF();
            var sourceLength = sourceArray.Length;

            var sourceArrayPtr = new Span<TSource>(sourceArray);
            var unrollLength = sourceLength / unrollMultiplier;
            var residuals = sourceLength & unrollMask;

            var sum0 = 0D; var sum1 = 0D; var sum2 = 0D; var sum3 = 0D;
            var sum4 = 0D; var sum5 = 0D; var sum6 = 0D; var sum7 = 0D;
            var sum8 = 0D; var sum9 = 0D; var sumA = 0D; var sumB = 0D;
            var sumC = 0D; var sumD = 0D; var sumE = 0D; var sumF = 0D;

            checked
            {
                for (var i = 0; i < unrollLength; i++)
                {
                    sum0 += selector(sourceArrayPtr[0x0]); sum1 += selector(sourceArrayPtr[0x1]); sum2 += selector(sourceArrayPtr[0x2]); sum3 += selector(sourceArrayPtr[0x3]);
                    sum4 += selector(sourceArrayPtr[0x4]); sum5 += selector(sourceArrayPtr[0x5]); sum6 += selector(sourceArrayPtr[0x6]); sum7 += selector(sourceArrayPtr[0x7]);
                    sum8 += selector(sourceArrayPtr[0x8]); sum9 += selector(sourceArrayPtr[0x9]); sumA += selector(sourceArrayPtr[0xA]); sumB += selector(sourceArrayPtr[0xB]);
                    sumC += selector(sourceArrayPtr[0xC]); sumD += selector(sourceArrayPtr[0xD]); sumE += selector(sourceArrayPtr[0xE]); sumF += selector(sourceArrayPtr[0xF]);

                    sourceArrayPtr = sourceArrayPtr.Slice(unrollMultiplier);
                }

                for (var i = 0; i < residuals; i++)
                    sum0 += selector(sourceArrayPtr[i]);

                return
                    (
                        ((sum0 + sum1) + (sum2 + sum3)) +
                        ((sum4 + sum5) + (sum6 + sum7))
                    ) +
                    (
                        ((sum8 + sum9) + (sumA + sumB)) +
                        ((sumC + sumD) + (sumE + sumF))
                    );
            }
        }

        /// <summary>
        /// Computes the sum of a sequence that is obtained by invoking a transform function on each element of the input sequence.
        /// A 16-times unrolled version of <see cref="SumF(System.Collections.Generic.IList{decimal})"/>.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> of values that are used to calculate a sum.</param>
        /// <param name="selector">A transform function to apply to each element which returns <see cref="decimal"/>.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <returns>The sum of the projected values.</returns>
        public static decimal SumF16<TSource>(this IList<TSource> source, Func<TSource, decimal> selector)
        {
            const int unrollMultiplier = 16;
            const int unrollMask = unrollMultiplier - 1;

            var sourceArray = source.ToArrayF();
            var sourceLength = sourceArray.Length;

            var sourceArrayPtr = new Span<TSource>(sourceArray);
            var unrollLength = sourceLength / unrollMultiplier;
            var residuals = sourceLength & unrollMask;

            var sum0 = 0M; var sum1 = 0M; var sum2 = 0M; var sum3 = 0M;
            var sum4 = 0M; var sum5 = 0M; var sum6 = 0M; var sum7 = 0M;
            var sum8 = 0M; var sum9 = 0M; var sumA = 0M; var sumB = 0M;
            var sumC = 0M; var sumD = 0M; var sumE = 0M; var sumF = 0M;

            checked
            {
                for (var i = 0; i < unrollLength; i++)
                {
                    sum0 += selector(sourceArrayPtr[0x0]); sum1 += selector(sourceArrayPtr[0x1]); sum2 += selector(sourceArrayPtr[0x2]); sum3 += selector(sourceArrayPtr[0x3]);
                    sum4 += selector(sourceArrayPtr[0x4]); sum5 += selector(sourceArrayPtr[0x5]); sum6 += selector(sourceArrayPtr[0x6]); sum7 += selector(sourceArrayPtr[0x7]);
                    sum8 += selector(sourceArrayPtr[0x8]); sum9 += selector(sourceArrayPtr[0x9]); sumA += selector(sourceArrayPtr[0xA]); sumB += selector(sourceArrayPtr[0xB]);
                    sumC += selector(sourceArrayPtr[0xC]); sumD += selector(sourceArrayPtr[0xD]); sumE += selector(sourceArrayPtr[0xE]); sumF += selector(sourceArrayPtr[0xF]);

                    sourceArrayPtr = sourceArrayPtr.Slice(unrollMultiplier);
                }

                for (var i = 0; i < residuals; i++)
                    sum0 += selector(sourceArrayPtr[i]);

                return
                    (
                        ((sum0 + sum1) + (sum2 + sum3)) +
                        ((sum4 + sum5) + (sum6 + sum7))
                    ) +
                    (
                        ((sum8 + sum9) + (sumA + sumB)) +
                        ((sumC + sumD) + (sumE + sumF))
                    );
            }
        }
    }
}
