using System.Collections.Generic;

namespace LinqFasterer
{
    public static partial class LinqFasterer
    {
        /// <summary>Determines whether a sequence contains a specified element by using a specified equality comparer.</summary>
        /// <returns>true if the source sequence contains an element that has the specified value; otherwise, false.</returns>
        /// <param name="source">A sequence in which to locate a value.</param>
        /// <param name="value">The value to locate in the sequence.</param>
        /// <param name="comparer">An equality comparer to compare values.</param>]
        public static bool ContainsF<TSource>(this IList<TSource> source, TSource value, IEqualityComparer<TSource>? comparer = null)
        {
            var sourceArray = source.ToArrayF();
            var sourceLength = sourceArray.Length;

            if (comparer == null)
            {
                // TODO: comparer == null case performs 3x slower than Linq's implementation

                for (var i = 0; i < sourceLength; i++)
                    // this is faster than assigning .Default to a variable (comparer)
                    if (EqualityComparer<TSource>.Default.Equals(sourceArray[i], value))
                        return true;
            }
            else
            {
                for (var i = 0; i < sourceLength; i++)
                    if (comparer.Equals(sourceArray[i], value))
                        return true;
            }

            return false;
        }
    }
}
