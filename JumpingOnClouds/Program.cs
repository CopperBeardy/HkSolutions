using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JumpingOnClouds
{
    class Program
    {
        //static int jumpingOnClouds(int[] c)
        static int jumpingOnClouds()
        {
         
            int count = 0;
            var i = 0;
            for (i = 0; i < c.Length -2; i++)
            {
                if (c[i + 2] == 0 || c[i + 1] == 1)
                {
                    count++;
                    i++;
                }
               
                else
                {
                    count++;
                }
            }
       if (i == c.Length - 2)
                {
                    count++;
                }
         
            return count;
        }

        static void Main(string[] args)
        {
           TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

           int n = Convert.ToInt32(Console.ReadLine());

            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp)) ;
            int result = jumpingOnClouds(c);
            int result = jumpingOnClouds();
            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }

}

