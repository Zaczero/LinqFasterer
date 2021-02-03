using System;
using System.Collections.Generic;

namespace LinqFasterer
{
    public partial class EnumerableF
    {
        /// <summary>
        /// Determines whether a sequence contains a null element.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> in which to check for a null.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <returns><see langword="true"/> if <paramref name="source"/> contains a null element; otherwise, <see langword="false"/>.</returns>
        public static bool ContainsNullF<TSource>(this IList<TSource> source)
        {
            if (default(TSource) != null)
                return false;
            
            var sourceArray = source.ToArrayF();
            var sourceLength = sourceArray.Length;
            
            for (var i = 0; i < sourceLength; i++)
                if (sourceArray[i] == null)
                    return true;

            return false;
        }
    }
}