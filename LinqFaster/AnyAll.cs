using System;
using System.Collections.Generic;

namespace JM.LinqFaster
{
    public static partial class LinqFaster
    {
        /// <summary>Determines whether all elements of a sequence satisfy a condition.</summary>
        /// <returns>true if every element of the source sequence passes the test in the specified predicate, or if the sequence is empty; otherwise, false.</returns>
        /// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> that contains the elements to apply the predicate to.</param>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        public static bool AllF<TSource>(this IReadOnlyList<TSource> source, Predicate<TSource> predicate)
        {
            if (source == null)
                throw Error.ArgumentNull(nameof(source));

            if (predicate == null)
                throw Error.ArgumentNull(nameof(predicate));

            foreach (var v in source)
                if (!predicate(v))
                    return false;

            return true;
        }

        /// <summary>Determines whether a sequence contains any elements.</summary>
        /// <returns>true if the source sequence contains any elements; otherwise, false.</returns>
        /// <param name="source">The <see cref="T:System.Collections.Generic.IEnumerable`1" /> to check for emptiness.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        public static bool AnyF<TSource>(this IReadOnlyList<TSource> source)
        {
            if (source == null)
                throw Error.ArgumentNull(nameof(source));

            return source.Count > 0;
        }

        /// <summary>Determines whether any element of a sequence satisfies a condition.</summary>
        /// <returns>true if any elements in the source sequence pass the test in the specified predicate; otherwise, false.</returns>
        /// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> whose elements to apply the predicate to.</param>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        public static bool AnyF<TSource>(this IReadOnlyList<TSource> source, Predicate<TSource> predicate)
        {
            if (source == null)
                throw Error.ArgumentNull(nameof(source));

            if (predicate == null)
                throw Error.ArgumentNull(nameof(predicate));

            foreach (var v in source)
                if (predicate(v))
                    return true;

            return false;
        }
    }
}