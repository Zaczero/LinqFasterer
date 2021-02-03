using System;
using System.Collections.Generic;

namespace LinqFasterer
{
    public partial class EnumerableF
    {
        /// <summary>
        /// Determines whether all elements of a sequence are null.
        /// </summary>
        /// <param name="source">An <see cref="IList{T}"/> in which to check whether every element is <see langword="null"/>.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source"/>.</typeparam>
        /// <returns><see langword="true"/> if every element of <paramref name="source"/> is <see langword="null"/>, or if <paramref name="source"/> is empty; otherwise, <see langword="false"/>.</returns>
        public static bool AllNullF<TSource>(this IList<TSource> source)
        {
            if (default(TSource) != null)
                return false;
            
            var sourceArray = source.ToArrayF();
            var sourceLength = sourceArray.Length;
            
            for (var i = 0; i < sourceLength; i++)
                if (sourceArray[i] != null)
                    return false;

            return true;
        }
    }
}