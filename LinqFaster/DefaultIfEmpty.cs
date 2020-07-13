using System;
using System.Collections.Generic;

namespace JM.LinqFaster
{
    public static partial class LinqFaster
    {

        // --------------------------  Arrays --------------------------------------------

        /// <summary>Returns the elements of the specified sequence or the specified value in a singleton collection if the sequence is empty.</summary>
        /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> that contains <paramref name="defaultValue" /> if <paramref name="source" /> is empty; otherwise, <paramref name="source" />.</returns>
        /// <param name="source">The sequence to return the specified value for if it is empty.</param>
        /// <param name="defaultValue">The value to return if the sequence is empty.</param>
        /// <typeparam name="T">The type of the elements of <paramref name="source" />.</typeparam>
        public static T[] DefaultIfEmptyF<T>(this T[] source, T defaultValue = default)
        {
            return source.AnyF() ? source : new [] {defaultValue};
        }

        // --------------------------  this Spans --------------------------------------------

        /// <summary>Returns the elements of the specified sequence or the specified value in a singleton collection if the sequence is empty.</summary>
        /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> that contains <paramref name="defaultValue" /> if <paramref name="source" /> is empty; otherwise, <paramref name="source" />.</returns>
        /// <param name="source">The sequence to return the specified value for if it is empty.</param>
        /// <param name="defaultValue">The value to return if the sequence is empty.</param>
        /// <typeparam name="T">The type of the elements of <paramref name="source" />.</typeparam>
        public static Span<T> DefaultIfEmptyF<T>(this Span<T> source, T defaultValue = default)
        {
            return source.AnyF() ? source : new Span<T> {[0] = defaultValue};
        }

        // ------------------------------ Lists ---------------------

        /// <summary>Returns the elements of the specified sequence or the specified value in a singleton collection if the sequence is empty.</summary>
        /// <returns>An <see cref="T:System.Collections.Generic.IEnumerable`1" /> that contains <paramref name="defaultValue" /> if <paramref name="source" /> is empty; otherwise, <paramref name="source" />.</returns>
        /// <param name="source">The sequence to return the specified value for if it is empty.</param>
        /// <param name="defaultValue">The value to return if the sequence is empty.</param>
        /// <typeparam name="T">The type of the elements of <paramref name="source" />.</typeparam>
        public static List<T> DefaultIfEmptyF<T>(this List<T> source, T defaultValue = default)
        {
            return source.AnyF() ? source : new List<T> {defaultValue};
        }

    }
}
