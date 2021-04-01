using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace LinqFasterer
{
    public static partial class EnumerableF
    {
        /// <summary>
        /// Returns the elements of the specified sequence or the specified value in a singleton collection if the sequence is empty.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> to return the specified value for if it is empty.</param>
        /// <param name="defaultValue">The value to return if <paramref name="source"/> is empty.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <returns>An <see cref="IList{T}"/> that contains <paramref name="defaultValue"/> if <paramref name="source"/> is empty; otherwise, <paramref name="source"/>.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IList<TSource> DefaultIfEmptyF<TSource>(this IList<TSource> source, TSource? defaultValue = default)
        {
            return source.Count == 0 ? new [] {defaultValue}! : source;
        }
    }
}
