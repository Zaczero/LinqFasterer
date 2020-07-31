using System;
using System.Collections.Generic;

namespace JM.LinqFaster
{
    public static partial class LinqFaster
    {
        /// <summary>Returns a number that represents how many elements in the specified sequence satisfy a condition.</summary>
        /// <returns>A number that represents how many elements in the sequence satisfy the condition in the predicate function.</returns>
        /// <param name="source">A sequence that contains elements to be tested and counted.</param>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <exception cref="T:System.ArgumentNullException">
        ///   <paramref name="source" /> or <paramref name="predicate" /> is null.</exception>
        /// <exception cref="T:System.OverflowException">The number of elements in <paramref name="source" /> is larger than <see cref="F:System.Int32.MaxValue" />.</exception>
        public static int CountF<TSource>(this IReadOnlyList<TSource> source, Func<TSource, bool> predicate)
        {
            if (source == null)
                throw Error.ArgumentNull(nameof(source));

            if (predicate == null)
                throw Error.ArgumentNull(nameof(predicate));

            var count = 0;

            checked
            {
                foreach (var v in source)
                    if (predicate(v))
                        count++;
            }

            return count;
        }

        /// <summary>Returns an <see cref="T:System.Int64" /> that represents the total number of elements in a sequence.</summary>
        /// <returns>The number of elements in the source sequence.</returns>
        /// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> that contains the elements to be counted.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <exception cref="T:System.ArgumentNullException">
        ///   <paramref name="source" /> is null.</exception>
        /// <exception cref="T:System.OverflowException">The number of elements exceeds <see cref="F:System.Int64.MaxValue" />.</exception>
        public static long LongCountF<TSource>(this IReadOnlyList<TSource> source)
        {
            if (source == null)
                throw Error.ArgumentNull(nameof(source));

            var count = 0L;

            checked
            {
                foreach (var _ in source)
                    count++;
            }

            return count;
        }

        /// <summary>Returns a number that represents how many elements in the specified sequence satisfy a condition.</summary>
        /// <returns>A number that represents how many elements in the sequence satisfy the condition in the predicate function.</returns>
        /// <param name="source">A sequence that contains elements to be tested and counted.</param>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <exception cref="T:System.ArgumentNullException">
        ///   <paramref name="source" /> or <paramref name="predicate" /> is null.</exception>
        /// <exception cref="T:System.OverflowException">The number of elements in <paramref name="source" /> is larger than <see cref="F:System.Int64.MaxValue" />.</exception>
        public static long LongCountF<TSource>(this IReadOnlyList<TSource> source, Func<TSource, bool> predicate)
        {
            if (source == null)
                throw Error.ArgumentNull(nameof(source));

            if (predicate == null)
                throw Error.ArgumentNull(nameof(predicate));

            var count = 0L;

            checked
            {
                foreach (var v in source)
                    if (predicate(v))
                        count++;
            }

            return count;
        }
    }
}
