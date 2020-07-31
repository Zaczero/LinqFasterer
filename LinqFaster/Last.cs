using System;
using System.Collections.Generic;

namespace JM.LinqFaster
{
    public static partial class LinqFaster
    {
        /// <summary>Returns the last element of a sequence.</summary>
        /// <returns>The last element in the specified sequence.</returns>
        /// <param name="source">The <see cref="T:System.Collections.Generic.IEnumerable`1" /> to return the last element of.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <exception cref="T:System.ArgumentNullException">
        ///   <paramref name="source" /> is null.</exception>
        /// <exception cref="T:System.InvalidOperationException">The source sequence is empty.</exception>
        public static TSource LastF<TSource>(this IReadOnlyList<TSource> source)
        {
            if (source == null)
                throw Error.ArgumentNull(nameof(source));

            if (source.Count == 0)
                throw Error.NoElements();

            return source[source.Count - 1];
        }

        /// <summary>Returns the last element in a sequence that satisfies a specified condition.</summary>
        /// <returns>The last element in the sequence that passes the test in the specified predicate function.</returns>
        /// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to return an element from.</param>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <exception cref="T:System.ArgumentNullException">
        ///   <paramref name="source" /> or <paramref name="predicate" /> is null.</exception>
        /// <exception cref="T:System.InvalidOperationException">No element satisfies the condition in <paramref name="predicate" />.-or-The source sequence is empty.</exception>
        public static TSource LastF<TSource>(this IReadOnlyList<TSource> source, Func<TSource, bool> predicate)
        {
            if (source == null)
                throw Error.ArgumentNull(nameof(source));

            if (predicate == null)
                throw Error.ArgumentNull(nameof(predicate));

            for (var i = source.Count - 1; i >= 0; i--)
                if (predicate(source[i]))
                    return source[i];

            throw Error.NoMatch();
        }
        
        /// <summary>Returns the last element of a sequence, or a default value if the sequence contains no elements.</summary>
        /// <returns>The last element in the specified sequence.</returns>
        /// <param name="source">The <see cref="T:System.Collections.Generic.IEnumerable`1" /> to return the last element of.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <exception cref="T:System.ArgumentNullException">
        ///   <paramref name="source" /> is null.</exception>
        /// <exception cref="T:System.InvalidOperationException">The source sequence is empty.</exception>
        public static TSource LastOrDefaultF<TSource>(this IReadOnlyList<TSource> source)
        {
            if (source == null)
                throw Error.ArgumentNull(nameof(source));

            if (source.Count == 0)
                return default;
                
            return source[source.Count - 1];
        }

        /// <summary>Returns the last element of a sequence, or a default value if the sequence contains no elements.</summary>
        /// <returns>The last element in the sequence that passes the test in the specified predicate function.</returns>
        /// <param name="source">An <see cref="T:System.Collections.Generic.IEnumerable`1" /> to return an element from.</param>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <exception cref="T:System.ArgumentNullException">
        ///   <paramref name="source" /> or <paramref name="predicate" /> is null.</exception>
        /// <exception cref="T:System.InvalidOperationException">No element satisfies the condition in <paramref name="predicate" />.-or-The source sequence is empty.</exception>
        public static TSource LastOrDefaultF<TSource>(this IReadOnlyList<TSource> source, Func<TSource, bool> predicate)
        {
            if (source == null)
                throw Error.ArgumentNull(nameof(source));

            if (predicate == null)
                throw Error.ArgumentNull(nameof(predicate));
                
            for (var i = source.Count - 1; i >= 0; i--)
                if (predicate(source[i]))
                    return source[i];

            return default;
        }
    }
}
