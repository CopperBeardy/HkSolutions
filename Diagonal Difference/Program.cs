using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Diagonal_Difference
{
    class Program
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = Result.diagonalDifference(arr);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }


    class Result
    {

        /*
         * Complete the 'diagonalDifference' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts 2D_INTEGER_ARRAY arr as parameter.
         */

        public static int diagonalDifference(List<List<int>> arr)
        {
            int leftDiagonalSum = 0;
            int rightDiagonnaleSum = 0;
            int size = arr.Count;

            for (int i = 0; i <= size - 1; i++)
            {

                leftDiagonalSum += arr[i][i];
            }

            for (int j = 0, k = size - 1; j <= size - 1; j++, k--)
            {
                rightDiagonnaleSum += arr[j][k];
            }
            return Math.Abs(leftDiagonalSum - rightDiagonnaleSum);
        }

    }
}
