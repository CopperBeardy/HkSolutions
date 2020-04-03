using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CompareTriplets
{
    class Program
    {
        static List<int> compareTriplets(List<int> a, List<int> b)
        {

            int alice = 0;
            int bob = 0;

            for (var i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                {

                    alice++;
                }
                else if (a[i] < b[i])
                {
                    bob++;
                }
            }



            return new List<int> { alice, bob };
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            List<int> result = compareTriplets(a, b);

            textWriter.WriteLine(String.Join(" ", result));

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
