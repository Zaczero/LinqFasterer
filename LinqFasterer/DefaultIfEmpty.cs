using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace LinqFasterer
{
    public static partial class LinqFasterer
    {
        /// <summary>Returns the elements of the specified sequence or the specified value in a singleton collection if the sequence is empty.</summary>
        /// <returns>A sequence that contains defaultValue if source is empty; otherwise, source.</returns>
        /// <param name="source">The sequence to return the specified value for if it is empty.</param>
        /// <param name="defaultValue">The value to return if the sequence is empty.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IList<TSource> DefaultIfEmptyF<TSource>(this IList<TSource> source, TSource defaultValue = default)
        {
            return source.Count == 0 ? new [] {defaultValue}! : source;
        }
    }
}
