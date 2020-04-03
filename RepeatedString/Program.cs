using System;
using System.IO;

namespace RepeatedString
{
    public class RepeatedString
    {

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string s = Console.ReadLine();

            long n = Convert.ToInt64(Console.ReadLine());

            long result = repeatedString(s, n);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }

        public static long repeatedString(string s, long n)
        {

           

            //find how long the string passed in is
            long stringLength = s.Length;

            //find out how many times the string needs to be repeated
            long timesToRepeat = n/stringLength ;

            //find out how long any substring is going to be
            long lengthRemaining = n % stringLength;

            long aOccuranceCount = 0;

            //count the number of time 'a' occurs in the string
            var value = Counter(s);
            aOccuranceCount += value * timesToRepeat;
            aOccuranceCount += Counter(s.Substring(0, (int)lengthRemaining)); 


            
            return aOccuranceCount;
        }

        private static long Counter(string s)
        {
            long count = 0;
            foreach (var val in s)
            {
                string temp = val.ToString();
                if (temp.Equals("a"))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
