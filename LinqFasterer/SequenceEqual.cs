using System.Collections.Generic;
using LinqFasterer.Utils;

namespace LinqFasterer
{
    public static partial class EnumerableF
    {
        /// <summary>Determines whether two sequences are equal by comparing their elements by using a specified equality comparer.</summary>
        /// <returns>true if the two source sequences are of equal length and their corresponding elements compare equal according to comparer; otherwise, false.</returns>
        /// <param name="first">A sequence to compare to second.</param>
        /// <param name="second">A sequence to compare to the first sequence.</param>
        /// <param name="comparer">An equality comparer to use to compare elements.</param>
        public static bool SequenceEqualF<TSource>(this IList<TSource> first, IList<TSource> second, IEqualityComparer<TSource>? comparer = null)
        {
            var firstLength = first.Count;
            var secondLength = second.Count;
            
            if (firstLength != secondLength)
                return false;

            // ReSharper disable once PossibleUnintendedReferenceComparison
            if (first == second)
                return true;
            
            var firstArray = first.ToArrayF();
            var secondArray = second.ToArrayF();

            if (comparer == null)
            {
                for (var i = 0; i < firstLength; i++)
                    if (!EqualityComparer<TSource>.Default.Equals(firstArray[i], secondArray[i]))
                        return false;
            }
            else
            {
                for (var i = 0; i < firstLength; i++)
                    if (!comparer.Equals(firstArray[i], secondArray[i]))
                        return false;
            }

            return true;
        }

        /// <summary>Determines whether two sequences are equal by comparing their elements by using a specified comparer.</summary>
        /// <returns>An array of integers, where the value corresponds to IComparer.Compare indicating less than, greater than, or equals.</returns>
        /// <param name="first">A sequence to compare to second.</param>
        /// <param name="second">A sequence to compare to the first sequence.</param>
        /// <param name="comparer">A comparer to use to compare elements.</param>
        public static int[] SequenceCompareF<TSource>(this IList<TSource> first, IList<TSource> second, IComparer<TSource>? comparer = null)
        {
            var firstLength = first.Count;
            var secondLength = second.Count;
            
            if (firstLength != secondLength)
                throw Error.NotSupported();
            
            var result = new int[firstLength];
            
            // ReSharper disable once PossibleUnintendedReferenceComparison
            if (first == second)
                return result;
            
            var firstArray = first.ToArrayF();
            var secondArray = second.ToArrayF();

            if (comparer == null)
            {
                for (var i = 0; i < firstLength; i++)
                    result[i] = Comparer<TSource>.Default.Compare(firstArray[i], secondArray[i]);
            }
            else
            {
                for (var i = 0; i < firstLength; i++)
                    result[i] = comparer.Compare(firstArray[i], secondArray[i]);
            }
            
            return result;
        }
    }
}
