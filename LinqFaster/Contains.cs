using System.Collections.Generic;

namespace JM.LinqFaster
{
    public static partial class LinqFaster
    {
        /// <summary>Determines whether a sequence contains a specified element by using the default equality comparer.</summary>
        /// <returns>true if the source sequence contains an element that has the specified value; otherwise, false.</returns>
        /// <param name="source">A sequence in which to locate a value.</param>
        /// <param name="value">The value to locate in the sequence.</param>
        /// <param name="comparer">An equality comparer to compare values.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <exception cref="T:System.ArgumentNullException">
        ///   <paramref name="source" /> is null.</exception>
        public static bool ContainsF<TSource>(this IReadOnlyList<TSource> source, TSource value, IEqualityComparer<TSource> comparer = null)
        {
            if (source == null)
                throw Error.ArgumentNull(nameof(source));

            if (comparer == null)
                comparer = EqualityComparer<TSource>.Default;

            foreach (var v in source)
                if (comparer.Equals(v, value))
                    return true;

            return false;
        }
    }
}
