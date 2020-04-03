using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SockMerchant
{
    class Program
    {
        static int sockMerchant(int n, int[] ar)
        {
            int count = 0;

            List<int> list = ar.ToList();
            list.Sort();

            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i].Equals(list[i + 1]))
                {
                    count += 1;
                    i++;
                }

            }
            return count;

        }

       
        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
            ;
            int result = sockMerchant(n, ar);


            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
