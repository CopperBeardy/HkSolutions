using System;
using System.IO;

namespace CountingValleys
{
    class Program
    {
      

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            string s = Console.ReadLine();


            int result = countingValleys(n, s);


            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }

        static int countingValleys(int n, string s)
        {
            int stepsUp = 0;
            int stepsDown = 0;
            int valleys = 0;


            foreach (char c in s)
            {
                string temp = c.ToString();

                if (temp.Equals("D")) {
                    stepsDown++;
                }
                else {
                    stepsUp++;
                }

                if (stepsUp.Equals(stepsDown) &&temp.Equals("U") ) {
                    valleys++;

                }
            }     

            return valleys;

        }
    }
}
