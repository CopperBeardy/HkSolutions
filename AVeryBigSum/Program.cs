using System;
using System.IO;

namespace AVeryBigSum
{
    class Program
    {
        static long aVeryBigSum(long[] ar)
        {
            long sum = 0;
            foreach (var l in ar)
            {
                sum += l;
            }

            return sum;
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int arCount = Convert.ToInt32(Console.ReadLine());

            long[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt64(arTemp))            ;
            long result = aVeryBigSum(ar);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
