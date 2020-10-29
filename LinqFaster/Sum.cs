using System;
using System.Collections.Generic;

namespace JM.LinqFaster
{
	public static partial class LinqFaster
	{
		/// <summary>Computes the sum of a sequence of <see cref="T:System.Int32" /> values.</summary>
		/// <returns>The sum of the values in the sequence.</returns>
		/// <param name="source">A sequence of <see cref="T:System.Int32" /> values to calculate the sum of.</param>
		public static int SumF(this IList<int> source)
		{
			if (source == null)
				throw Error.ArgumentNull(nameof(source));

			var sum = 0;

			checked
			{
				for (var i = 0; i < source.Count; i++)
					sum += source[i];
			}

			return sum;
		}

		/// <summary>Computes the sum of a sequence of <see cref="T:System.Int64" /> values.</summary>
		/// <returns>The sum of the values in the sequence.</returns>
		/// <param name="source">A sequence of <see cref="T:System.Int64" /> values to calculate the sum of.</param>
		public static long SumF(this IList<long> source)
		{
			if (source == null)
				throw Error.ArgumentNull(nameof(source));

			var sum = 0L;

			checked
			{
				for (var i = 0; i < source.Count; i++)
					sum += source[i];
			}

			return sum;
		}

		/// <summary>Computes the sum of a sequence of <see cref="T:System.Single" /> values.</summary>
		/// <returns>The sum of the values in the sequence.</returns>
		/// <param name="source">A sequence of <see cref="T:System.Int64" /> values to calculate the sum of.</param>
		public static float SumF(this IList<float> source)
		{
			if (source == null)
				throw Error.ArgumentNull(nameof(source));

			var sum = 0.0;

			for (var i = 0; i < source.Count; i++)
				sum += source[i];

			return (float) sum;
		}

		/// <summary>Computes the sum of a sequence of <see cref="T:System.Double" /> values.</summary>
		/// <returns>The sum of the values in the sequence.</returns>
		/// <param name="source">A sequence of <see cref="T:System.Int64" /> values to calculate the sum of.</param>
		public static double SumF(this IList<double> source)
		{
			if (source == null)
				throw Error.ArgumentNull(nameof(source));

			var sum = 0.0;

			for (var i = 0; i < source.Count; i++)
				sum += source[i];

			return sum;
		}

		/// <summary>Computes the sum of a sequence of <see cref="T:System.Decimal" /> values.</summary>
		/// <returns>The sum of the values in the sequence.</returns>
		/// <param name="source">A sequence of <see cref="T:System.Decimal" /> values to calculate the sum of.</param>
		public static decimal SumF(this IList<decimal> source)
		{
			if (source == null)
				throw Error.ArgumentNull(nameof(source));

			var sum = 0M;

			for (var i = 0; i < source.Count; i++)
				sum += source[i];

			return sum;
		}

		/// <summary>Computes the sum of the sequence of <see cref="T:System.Int32" /> values that are obtained by invoking a transform function on each element of the input sequence.</summary>
		/// <returns>The sum of the projected values.</returns>
		/// <param name="source">A sequence of values that are used to calculate a sum.</param>
		/// <param name="selector">A transform function to apply to each element.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		public static int SumF<TSource>(this IList<TSource> source, Func<TSource, int> selector)
		{
			if (source == null)
				throw Error.ArgumentNull(nameof(source));

			if (selector == null)
				throw Error.ArgumentNull(nameof(selector));

			var sum = 0;

			checked
			{
				for (var i = 0; i < source.Count; i++)
					sum += selector(source[i]);
			}

			return sum;
		}

		/// <summary>Computes the sum of the sequence of <see cref="T:System.Int64" /> values that are obtained by invoking a transform function on each element of the input sequence.</summary>
		/// <returns>The sum of the projected values.</returns>
		/// <param name="source">A sequence of values that are used to calculate a sum.</param>
		/// <param name="selector">A transform function to apply to each element.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		public static long SumF<TSource>(this IList<TSource> source, Func<TSource, long> selector)
		{
			if (source == null)
				throw Error.ArgumentNull(nameof(source));

			if (selector == null)
				throw Error.ArgumentNull(nameof(selector));

			var sum = 0L;

			checked
			{
				for (var i = 0; i < source.Count; i++)
					sum += selector(source[i]);
			}

			return sum;
		}

		/// <summary>Computes the sum of the sequence of <see cref="T:System.Single" /> values that are obtained by invoking a transform function on each element of the input sequence.</summary>
		/// <returns>The sum of the projected values.</returns>
		/// <param name="source">A sequence of values that are used to calculate a sum.</param>
		/// <param name="selector">A transform function to apply to each element.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		public static float SumF<TSource>(this IList<TSource> source, Func<TSource, float> selector)
		{
			if (source == null)
				throw Error.ArgumentNull(nameof(source));

			if (selector == null)
				throw Error.ArgumentNull(nameof(selector));

			var sum = 0.0;

			for (var i = 0; i < source.Count; i++)
				sum += selector(source[i]);

			return (float) sum;
		}

		/// <summary>Computes the sum of the sequence of <see cref="T:System.Double" /> values that are obtained by invoking a transform function on each element of the input sequence.</summary>
		/// <returns>The sum of the projected values.</returns>
		/// <param name="source">A sequence of values that are used to calculate a sum.</param>
		/// <param name="selector">A transform function to apply to each element.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		public static double SumF<TSource>(this IList<TSource> source, Func<TSource, double> selector)
		{
			if (source == null)
				throw Error.ArgumentNull(nameof(source));

			if (selector == null)
				throw Error.ArgumentNull(nameof(selector));

			var sum = 0.0;

			for (var i = 0; i < source.Count; i++)
				sum += selector(source[i]);

			return sum;
		}

		/// <summary>Computes the sum of the sequence of <see cref="T:System.Decimal" /> values that are obtained by invoking a transform function on each element of the input sequence.</summary>
		/// <returns>The sum of the projected values.</returns>
		/// <param name="source">A sequence of values that are used to calculate a sum.</param>
		/// <param name="selector">A transform function to apply to each element.</param>
		/// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
		public static decimal SumF<TSource>(this IList<TSource> source, Func<TSource, decimal> selector)
		{
			if (source == null)
				throw Error.ArgumentNull(nameof(source));

			if (selector == null)
				throw Error.ArgumentNull(nameof(selector));

			var sum = 0M;

			for (var i = 0; i < source.Count; i++)
				sum += selector(source[i]);

			return sum;
		}
	}
}