using System.Collections.Generic;

namespace LinqFasterer
{
	public static partial class LinqFasterer
	{
		/// <summary>Generates a sequence of numbers within a specified range.</summary>
		/// <returns>A sequence that contains a range of sequential numbers.</returns>
		/// <param name="start">The value of the first number in the sequence.</param>
		/// <param name="count">The number of sequential numbers to generate.</param>
		/// <param name="change">The value change between individual elements of a sequence.</param>
		public static IList<int> RangeF(int start, int count, int change = 1)
		{
			if (change == 0)
				return RepeatF(start, count);
			
			var result = new int[count];
			var lastValue = 0;
			
			if (count != 0)
				lastValue = result[0] = start;

			checked
			{
				for (var i = 1; i < count; i++)
					lastValue = result[i] = lastValue + change;
			}

			return result;
		}

		/// <summary>Generates a sequence of numbers within a specified range.</summary>
		/// <returns>A sequence that contains a range of sequential numbers.</returns>
		/// <param name="start">The value of the first number in the sequence.</param>
		/// <param name="count">The number of sequential numbers to generate.</param>
		/// <param name="change">The value change between individual elements of a sequence.</param>
		public static IList<long> RangeF(long start, int count, long change = 1)
		{
			if (change == 0)
				return RepeatF(start, count);

			var result = new long[count];
			var lastValue = 0L;
			
			if (count != 0)
				lastValue = result[0] = start;

			checked
			{
				for (var i = 1; i < count; i++)
					lastValue = result[i] = lastValue + change;
			}

			return result;
		}

		/// <summary>Generates a sequence of numbers within a specified range.</summary>
		/// <returns>A sequence that contains a range of sequential numbers.</returns>
		/// <param name="start">The value of the first number in the sequence.</param>
		/// <param name="count">The number of sequential numbers to generate.</param>
		/// <param name="change">The value change between individual elements of a sequence.</param>
		public static IList<float> RangeF(float start, int count, float change = 1)
		{
			if (change == 0)
				return RepeatF(start, count);

			var result = new float[count];
			var lastValue = 0f;
			
			if (count != 0)
				lastValue = result[0] = start;

			for (var i = 1; i < count; i++)
				lastValue = result[i] = lastValue + change;

			return result;
		}

		/// <summary>Generates a sequence of numbers within a specified range.</summary>
		/// <returns>A sequence that contains a range of sequential numbers.</returns>
		/// <param name="start">The value of the first number in the sequence.</param>
		/// <param name="count">The number of sequential numbers to generate.</param>
		/// <param name="change">The value change between individual elements of a sequence.</param>
		public static IList<double> RangeF(double start, int count, double change = 1)
		{
			if (change == 0)
				return RepeatF(start, count);

			var result = new double[count];
			var lastValue = 0D;
			
			if (count != 0)
				lastValue = result[0] = start;

			for (var i = 1; i < count; i++)
				lastValue = result[i] = lastValue + change;

			return result;
		}

		/// <summary>Generates a sequence of numbers within a specified range.</summary>
		/// <returns>A sequence that contains a range of sequential numbers.</returns>
		/// <param name="start">The value of the first number in the sequence.</param>
		/// <param name="count">The number of sequential numbers to generate.</param>
		/// <param name="change">The value change between individual elements of a sequence.</param>
		public static IList<decimal> RangeF(decimal start, int count, decimal change = 1)
		{
			if (change == 0)
				return RepeatF(start, count);

			var result = new decimal[count];
			var lastValue = 0M;
			
			if (count != 0)
				lastValue = result[0] = start;

			for (var i = 1; i < count; i++)
				lastValue = result[i] = lastValue + change;

			return result;
		}
	}
}