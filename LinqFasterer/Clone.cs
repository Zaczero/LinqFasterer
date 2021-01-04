using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace LinqFasterer
{
    public static partial class EnumerableF
    {
        /// <summary>
        /// Creates a copy of the input sequence.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> to be cloned.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <returns>An <see cref="IList{T}"/> which is a copy of the input sequence.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IList<TSource> CloneF<TSource>(this IList<TSource> source)
        {
            return source.ToArrayF(true);
        }
    }
}