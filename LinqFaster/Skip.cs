using System;
using System.Collections.Generic;

namespace LinqFasterer
{
    public static partial class LinqFasterer
    {
        /// <summary>Bypasses a specified number of elements in a sequence and then returns the remaining elements.</summary>
        /// <returns>A sequence that contains the elements that occur after the specified index in the input sequence.</returns>
        /// <param name="source">A sequence to return elements from.</param>
        /// <param name="count">The number of elements to skip before returning the remaining elements.</param>
        /// <param name="forceClone">Force clone of an object (disable in-place optimization).</param>
        public static IList<TSource> SkipF<TSource>(this IList<TSource> source, int count, bool forceClone = false)
        {
            var sourceLength = source.Count;
            if (sourceLength <= count)
                return EmptyF<TSource>();

            var sourceArray = source.ToArrayF(forceClone);

            if (count <= 0)
                return sourceArray;

            var resultLength = sourceLength - count;
            Array.Copy(sourceArray, count, sourceArray, 0, resultLength);
            Array.Resize(ref sourceArray, resultLength);

            return sourceArray;
        }

        /// <summary>Bypasses a specified number of last elements in a sequence and then returns the remaining elements.</summary>
        /// <returns>A sequence that contains the elements that occur before the specified index in the input sequence.</returns>
        /// <param name="source">A sequence to return elements from.</param>
        /// <param name="count">The number of elements to skip before returning the remaining elements.</param>
        /// <param name="forceClone">Force clone of an object (disable in-place optimization).</param>
        public static IList<TSource> SkipLastF<TSource>(this IList<TSource> source, int count, bool forceClone = false)
        {
            var sourceLength = source.Count;
            if (sourceLength <= count)
                return EmptyF<TSource>();

            var sourceArray = source.ToArrayF(forceClone);

            if (count <= 0)
                return sourceArray;
            
            var resultLength = sourceLength - count;
            Array.Resize(ref sourceArray, resultLength);

            return sourceArray;
        }

        /// <summary>Bypasses elements in a sequence as long as a specified condition is true and then returns the remaining elements.</summary>
        /// <returns>A sequence that contains the elements from the input sequence starting at the first element in the linear series that does not pass the test specified by predicate.</returns>
        /// <param name="source">A sequence to return elements from.</param>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <param name="forceClone">Force clone of an object (disable in-place optimization).</param>
        public static IList<TSource> SkipWhileF<TSource>(this IList<TSource> source, Func<TSource, bool> predicate, bool forceClone = false)
        {
            var sourceArray = source.ToArrayF();
            var sourceLength = sourceArray.Length;
            
            var count = 0;

            for (; count < sourceLength; count++)
                if (!predicate(sourceArray[count]))
                    break;

            return sourceArray.SkipF(count, forceClone);
        }

        /// <summary>Bypasses elements in a sequence as long as a specified condition is true and then returns the remaining elements.</summary>
        /// <returns>A sequence that contains the elements from the input sequence starting at the first element in the linear series that does not pass the test specified by predicate.</returns>
        /// <param name="source">A sequence to return elements from.</param>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <param name="forceClone">Force clone of an object (disable in-place optimization).</param>
        public static IList<TSource> SkipWhileF<TSource>(this IList<TSource> source, Func<TSource, int, bool> predicate, bool forceClone = false)
        {
            var sourceArray = source.ToArrayF();
            var sourceLength = sourceArray.Length;

            var count = 0;

            for (; count < sourceLength; count++)
                if (!predicate(sourceArray[count], count))
                    break;

            return sourceArray.SkipF(count, forceClone);
        }
    }
}
