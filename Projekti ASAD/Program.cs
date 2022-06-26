using System;
using System.Collections.Generic;
using System.Linq;

public class Test
{
	public static void Main()
	{
		var dictionaryOfMatches = new Dictionary<int, int>{
			{0,6},{1,2},{2,5},{3,5},{4,4},{5,5},{6,6},{7,3},{8,7},{9,6}
		};
		Console.Write("Write the number of test cases:");
		int testCases = Convert.ToInt32(Console.ReadLine());

		for (int i = 0; i < testCases; i++)
		{
			string sum;
			int temp, totalSum = 0;
			Console.Write("Write the result:");
			int[] arrOfElements = Array.ConvertAll(Console.ReadLine().Split(), Convert.ToInt32);
			sum = Convert.ToString(arrOfElements.Sum());
			char[] sumInChar = sum.ToCharArray();
			for (int j = 0; j < sumInChar.Length; j++)
			{
				temp = sumInChar[j] - '0';
				totalSum += dictionaryOfMatches[temp];
			}
			Console.Write("Number of matches needed to write the result:");
			Console.Write(totalSum);
			Console.WriteLine();
		}
		Console.ReadKey();
	}
}
