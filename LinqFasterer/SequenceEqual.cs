using System.Collections.Generic;
using LinqFasterer.Utils;

namespace LinqFasterer
{
    public static partial class EnumerableF
    {
        /// <summary>
        /// Determines whether two sequences are equal by comparing their elements by using a specified equality comparer.
        /// </summary>
        /// <param name="first">An <see cref="IList{T}"/> to compare to <paramref name="second"/>.</param>
        /// <param name="second">An <see cref="IList{T}"/> to compare to <paramref name="first"/>.</param>
        /// <param name="comparer">An optional <see cref="IEqualityComparer{T}"/> used to compare values; falls back to <see cref="EqualityComparer{T}.Default"/> when set to <see langword="null"/>.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="first"/> and <paramref name="second"/>.</typeparam>
        /// <returns><see langword="true"/> if the two input sequences are of equal length and their corresponding elements compare equal according to <paramref name="comparer"/>; otherwise, <see langword="false"/>.</returns>
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
        
        /// <summary>
        /// Determines whether two sequences are equal by comparing their elements by using a specified comparer.
        /// </summary>
        /// <param name="first">An <see cref="IList{T}"/> to compare to <paramref name="second"/>.</param>
        /// <param name="second">An <see cref="IList{T}"/> to compare to <paramref name="first"/>.</param>
        /// <param name="comparer">An optional <see cref="IComparer{T}"/> used to compare values; falls back to <see cref="Comparer{T}.Default"/> when set to <see langword="null"/>.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="first"/> and <paramref name="second"/>.</typeparam>
        /// <returns>An array of <see cref="int"/>, where the value corresponds to <see cref="IComparer{T}.Compare"/> indicating less than, greater than, or equals.</returns>
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
