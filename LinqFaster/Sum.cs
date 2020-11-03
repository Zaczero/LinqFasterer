using System;
using System.Collections.Generic;

namespace LinqFasterer
{
	public static partial class LinqFasterer
	{
		/// <summary>Computes the sum of a sequence.</summary>
		/// <returns>The sum of the values in the sequence.</returns>
		/// <param name="source">A sequence to calculate the sum of.</param>
		public static int SumF(this IList<int> source)
		{
			var sourceArr = source.ToArrayF();
			var sourceLength = source.Count;

			var sum = 0;

			checked
			{
				for (var i = 0; i < sourceLength; i++)
					sum += sourceArr[i];
			}

			return sum;
		}

		/// <summary>Computes the sum of a sequence.</summary>
		/// <returns>The sum of the values in the sequence.</returns>
		/// <param name="source">A sequence to calculate the sum of.</param>
		public static long SumF(this IList<long> source)
		{
			var sourceArr = source.ToArrayF();
			var sourceLength = source.Count;

			var sum = 0L;

			checked
			{
				for (var i = 0; i < sourceLength; i++)
					sum += sourceArr[i];
			}

			return sum;
		}

		/// <summary>Computes the sum of a sequence.</summary>
		/// <returns>The sum of the values in the sequence.</returns>
		/// <param name="source">A sequence to calculate the sum of.</param>
		public static float SumF(this IList<float> source)
		{
			var sourceArr = source.ToArrayF();
			var sourceLength = source.Count;

			var sum = 0.0;

			for (var i = 0; i < sourceLength; i++)
				sum += sourceArr[i];

			return (float) sum;
		}

		/// <summary>Computes the sum of a sequence.</summary>
		/// <returns>The sum of the values in the sequence.</returns>
		/// <param name="source">A sequence to calculate the sum of.</param>
		public static double SumF(this IList<double> source)
		{
			var sourceArr = source.ToArrayF();
			var sourceLength = source.Count;

			var sum = 0.0;

			for (var i = 0; i < sourceLength; i++)
				sum += sourceArr[i];

			return sum;
		}

		/// <summary>Computes the sum of a sequence.</summary>
		/// <returns>The sum of the values in the sequence.</returns>
		/// <param name="source">A sequence to calculate the sum of.</param>
		public static decimal SumF(this IList<decimal> source)
		{
			var sourceArr = source.ToArrayF();
			var sourceLength = source.Count;

			var sum = 0M;

			for (var i = 0; i < sourceLength; i++)
				sum += sourceArr[i];

			return sum;
		}

		/// <summary>Computes the sum of a sequence that is obtained by invoking a transform function on each element of the input sequence.</summary>
		/// <returns>The sum of the projected values.</returns>
		/// <param name="source">A sequence of values that are used to calculate a sum.</param>
		/// <param name="selector">A transform function to apply to each element.</param>
		public static int SumF<TSource>(this IList<TSource> source, Func<TSource, int> selector)
		{
			var sourceArr = source.ToArrayF();
			var sourceLength = source.Count;

			var sum = 0;

			checked
			{
				for (var i = 0; i < sourceLength; i++)
					sum += selector(sourceArr[i]);
			}

			return sum;
		}

		/// <summary>Computes the sum of a sequence that is obtained by invoking a transform function on each element of the input sequence.</summary>
		/// <returns>The sum of the projected values.</returns>
		/// <param name="source">A sequence of values that are used to calculate a sum.</param>
		/// <param name="selector">A transform function to apply to each element.</param>
		public static long SumF<TSource>(this IList<TSource> source, Func<TSource, long> selector)
		{
			var sourceArr = source.ToArrayF();
			var sourceLength = source.Count;

			var sum = 0L;

			checked
			{
				for (var i = 0; i < sourceLength; i++)
					sum += selector(sourceArr[i]);
			}

			return sum;
		}

		/// <summary>Computes the sum of a sequence that is obtained by invoking a transform function on each element of the input sequence.</summary>
		/// <returns>The sum of the projected values.</returns>
		/// <param name="source">A sequence of values that are used to calculate a sum.</param>
		/// <param name="selector">A transform function to apply to each element.</param>
		public static float SumF<TSource>(this IList<TSource> source, Func<TSource, float> selector)
		{
			var sourceArr = source.ToArrayF();
			var sourceLength = source.Count;

			var sum = 0.0;

			for (var i = 0; i < sourceLength; i++)
				sum += selector(sourceArr[i]);

			return (float) sum;
		}

		/// <summary>Computes the sum of a sequence that is obtained by invoking a transform function on each element of the input sequence.</summary>
		/// <returns>The sum of the projected values.</returns>
		/// <param name="source">A sequence of values that are used to calculate a sum.</param>
		/// <param name="selector">A transform function to apply to each element.</param>
		public static double SumF<TSource>(this IList<TSource> source, Func<TSource, double> selector)
		{
			var sourceArr = source.ToArrayF();
			var sourceLength = source.Count;

			var sum = 0.0;

			for (var i = 0; i < sourceLength; i++)
				sum += selector(sourceArr[i]);

			return sum;
		}

		/// <summary>Computes the sum of a sequence that is obtained by invoking a transform function on each element of the input sequence.</summary>
		/// <returns>The sum of the projected values.</returns>
		/// <param name="source">A sequence of values that are used to calculate a sum.</param>
		/// <param name="selector">A transform function to apply to each element.</param>
		public static decimal SumF<TSource>(this IList<TSource> source, Func<TSource, decimal> selector)
		{
			var sourceArr = source.ToArrayF();
			var sourceLength = source.Count;

			var sum = 0M;

			for (var i = 0; i < sourceLength; i++)
				sum += selector(sourceArr[i]);

			return sum;
		}
	}
}