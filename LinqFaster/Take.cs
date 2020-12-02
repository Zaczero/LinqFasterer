using System;
using System.Collections.Generic;
using System.Linq;
using LinqFasterer.Utils;

namespace LinqFasterer
{
	public static partial class LinqFasterer
	{
		/// <summary>Returns a specified number of contiguous elements from the start of a sequence.</summary>
		/// <returns>A sequence that contains the specified number of elements from the start of the input sequence.</returns>
		/// <param name="source">The sequence to return elements from.</param>
		/// <param name="count">The number of elements to return.</param>
		/// <param name="forceClone">Force clone of an object (disable in-place optimization).</param>
		public static IList<TSource> TakeF<TSource>(this IList<TSource> source, int count, bool forceClone = false)
		{
			if (count <= 0)
				return EmptyF<TSource>();
			
			var sourceArray = source.ToArrayF(forceClone);
			var sourceLength = source.Count;
			if (sourceLength <= count)
				return sourceArray;

			Array.Resize(ref sourceArray, count);

			return sourceArray;
		}

		/// <summary>Returns a specified number of contiguous elements from the end of a sequence.</summary>
		/// <returns>A sequence that contains the specified number of elements from the end of the input sequence.</returns>
		/// <param name="source">The sequence to return elements from.</param>
		/// <param name="count">The number of elements to return.</param>
		/// <param name="forceClone">Force clone of an object (disable in-place optimization).</param>
		public static IList<TSource> TakeLastF<TSource>(this IList<TSource> source, int count, bool forceClone = false)
		{
			if (count <= 0)
				return EmptyF<TSource>();
			
			var sourceArray = source.ToArrayF(forceClone);
			var sourceLength = source.Count;
			if (sourceLength <= count)
				return sourceArray;

			Array.Copy(sourceArray, sourceLength - count, sourceArray, 0, count);
			Array.Resize(ref sourceArray, count);

			return sourceArray;
		}

		/// <summary>Returns elements from a sequence as long as a specified condition is true.</summary>
		/// <returns>A sequence that contains the elements from the input sequence that occur before the element at which the test no longer passes.</returns>
		/// <param name="source">A sequence to return elements from.</param>
		/// <param name="predicate">A function to test each element for a condition.</param>
		/// <param name="forceClone">Force clone of an object (disable in-place optimization).</param>
		public static IList<TSource> TakeWhileF<TSource>(this IList<TSource> source, Func<TSource, bool> predicate, bool forceClone = false)
		{
			var sourceArray = source.ToArrayF();
			var sourceLength = sourceArray.Length;
			
			var count = 0;

			for (; count < sourceLength; count++)
				if (!predicate(sourceArray[count]))
					break;

			return sourceArray.TakeF(count, forceClone);
		}

		/// <summary>Returns elements from a sequence as long as a specified condition is true.</summary>
		/// <returns>A sequence that contains the elements from the input sequence that occur before the element at which the test no longer passes.</returns>
		/// <param name="source">A sequence to return elements from.</param>
		/// <param name="predicate">A function to test each element for a condition.</param>
		/// <param name="forceClone">Force clone of an object (disable in-place optimization).</param>
		public static IList<TSource> TakeWhileF<TSource>(this IList<TSource> source, Func<TSource, int, bool> predicate, bool forceClone = false)
		{
			var sourceArray = source.ToArrayF();
			var sourceLength = sourceArray.Length;
			
			var count = 0;

			for (; count < sourceLength; count++)
				if (!predicate(sourceArray[count], count))
					break;

			return sourceArray.TakeF(count, forceClone);
		}
	}
}