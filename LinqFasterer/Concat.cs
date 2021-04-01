using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace LinqFasterer
{
    public static partial class EnumerableF
    {
        /// <summary>
        /// Concatenates two sequences.
        /// </summary>
        /// <param name="first">The first <see cref="IList{T}"/> to concatenate.</param>
        /// <param name="second">The second <see cref="IList{T}"/> to concatenate.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="first"/> and <paramref name="second"/>.</typeparam>
        /// <returns>An <see cref="IList{T}"/> that contains the concatenated elements of the two input sequences.</returns>
        public static IList<TSource> ConcatF<TSource>(this IList<TSource> first, IList<TSource> second)
        {
            var firstLength = first.Count;
            var secondLength = second.Count;

            var resultLength = firstLength + secondLength;
            var result = new TSource[resultLength];

            first.CopyTo(result, 0);
            second.CopyTo(result, firstLength);

            return result;
        }

        /// <summary>
        /// Concatenates multiple sequences.
        /// </summary>
        /// <param name="sources">An <see cref="IList{T}"/> of <see cref="IList{T}"/> to concatenate.</param>
        /// <param name="forceClone">Force clone of <paramref name="sources"/> (disable in-place optimization).</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="sources"/>.</typeparam>
        /// <returns>A <see cref="string"/> that contains the concatenated elements of the input sequences.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IList<TSource> ConcatF<TSource>(this IList<IList<TSource>> sources, bool forceClone = false)
        {
            return ConcatMultipleF(sources.ToArrayF(forceClone));
        }

        /// <summary>
        /// Concatenates multiple strings.
        /// </summary>
        /// <param name="sources">An <see cref="IList{T}"/> of <see cref="string"/> to concatenate.</param>
        /// <param name="forceClone">Force clone of <paramref name="sources"/> (disable in-place optimization).</param>
        /// <returns>A <see cref="string"/> that contains the concatenated elements of the input sequences.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ConcatF(this IList<string> sources, bool forceClone = false)
        {
            return ConcatMultipleF(sources.ToArrayF(forceClone));
        }

        /// <summary>
        /// Concatenates multiple sequences.
        /// </summary>
        /// <param name="sources">An <see cref="Array"/> of <see cref="IList{T}"/> to concatenate.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="sources"/>.</typeparam>
        /// <returns>An <see cref="IList{T}"/> that contains the concatenated elements of the input sequences.</returns>
        public static IList<TSource> ConcatMultipleF<TSource>(params IList<TSource>[] sources)
        {
            var sourcesLength = sources.Length;
            switch (sourcesLength)
            {
                case 0:
                    return Array.Empty<TSource>();
                case 1:
                    // Note: this is unsafe but fast (add support for forceClone?)
                    return sources[0];
            }

            var resultLength = 0;

            for (var i = 0; i < sourcesLength; i++)
                resultLength += sources[i].Count;

            var result = new TSource[resultLength];
            var resultFilled = 0;

            for (var i = 0; i < sourcesLength; i++)
            {
                sources[i].CopyTo(result, resultFilled);
                resultFilled += sources[i].Count;
            }

            return result;
        }

        /// <summary>
        /// Concatenates multiple strings.
        /// </summary>
        /// <param name="sources">An <see cref="Array"/> of <see cref="string"/> to concatenate.</param>
        /// <returns>A <see cref="string"/> that contains the concatenated elements of the input sequences.</returns>
        public static string ConcatMultipleF(params string[] sources)
        {
            var sourcesLength = sources.Length;
            switch (sourcesLength)
            {
                case 0:
                    return string.Empty;
                case 1:
                    // Note: this is unsafe but fast (add support for forceClone?)
                    return sources[0];
                case 2:
                    return string.Concat(sources);
            }

            var resultLength = 0;

            for (var i = 0; i < sourcesLength; i++)
                resultLength += sources[i].Length;

            if (resultLength < 32 && sourcesLength < 8)
                return string.Concat(sources);

            var resultSb = new StringBuilder(sources[0], resultLength);

            for (var i = 1; i < sourcesLength; i++)
                resultSb.Append(sources[i]);

            return resultSb.ToString();
        }
    }
}
